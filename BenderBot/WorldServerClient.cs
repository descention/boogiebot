//#define LOG

using System;
using System.Collections;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Xml;
using System.Timers;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using System.Resources;
using System.Collections.Generic;
using System.Diagnostics;

using Foole.Crypt;
using Foole.Utils;
using Foole.WoW;
using WCell.Constants.GameObjects;
using WCell.RealmServer;


namespace BenderBot.Common
{

    public partial class BenderCore
    {
        #region Member variables
        private UInt32 LastUpdateTime = 0;

        public Thread WorldThread = null;
        public Thread UpdateThread = null;

        private bool isRunning;

        private string mUsername;

        protected PacketCrypt packetCrypt;
        private int mSendCryptSize;
        private int mRecvCryptSize;
        private byte[] Key;

        private UInt32 ServerSeed;
        private UInt32 ClientSeed;
        private Random random = new Random();
        private Socket mSocket;

#if WARDEN
        private Socket mWardenSocket;
        private static string WardenHost = "127.0.01";
        private static int WardenPort = 4141;
#endif
        System.Timers.Timer PingTimer = new System.Timers.Timer();
        System.Timers.Timer MoveUpdateTimer = new System.Timers.Timer();

        // Ping stuffs
        private UInt32 Ping_Seq;
        private UInt32 Ping_Req_Time;
        private UInt32 Ping_Res_Time;

        public UInt32 Latency;

        private ArrayList Objects = new ArrayList();
        private Dictionary<uint, Entry> EntryList = new Dictionary<uint, Entry>();
        private Hashtable EntryQueue = new Hashtable();

#if (LOG)
         private TextWriter tw;
#endif

        public List<Character> Characters { get; set; }

        #endregion

        public void Connect(IPEndPoint ep, string username, byte[] key)
        {
#if LOG
            try
            {
                tw = File.CreateText(string.Format("packets-{0}.txt", Process.GetCurrentProcess().Id) );
            }
            catch (Exception) { }
#endif
            
            isRunning = false;

            Mover = new Mover(this);

            mSendCryptSize = 6;
            mRecvCryptSize = 2;

            mUsername = username;
            Key = key;

            try
            {
                mSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                mSocket.BeginConnect(ep, new AsyncCallback(ConnectCallback), mSocket);
            }
            catch(SocketException ex)
            {
                Log(LogType.Error,0, "Failed to connect to realm: {0}", ex.Message);
                return;
            }
#if WARDEN
            try
            {
                mWardenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                mWardenSocket.BeginConnect(WardenHost, WardenPort, new AsyncCallback(ConnectCallback), mWardenSocket);
            }
            catch (SocketException ex)
            {
                Log(LogType.Error, 1, "Failed to connect to WardenServer: {0}", ex.Message);
                return;
            }
#endif 

        }

        private void NetworkStart()
        {
            // Setup ping timer/initial values
            PingTimer.Elapsed += new ElapsedEventHandler(Ping);
            PingTimer.Interval = 60000;
            PingTimer.Enabled = false;

            Ping_Seq = 1;
            Latency = 0;

            NetworkLoop();

        }

        object readLocker = new object();

        // Primary network loop
        private void NetworkLoop()
        {
            byte[] data;
            int dataSize = 0;
            WoWWriter tmpa = new WoWWriter();
            byte[] tmp;
            bool isFuckingGiganticPacket = false;
            do
            {
                try
                {
                    dataSize = 0;
                    tmp = OnReceive(2);
                    if (packetCrypt != null)
                    {
                        packetCrypt.Decrypt(tmp, 0, 2);
                        isFuckingGiganticPacket = (tmp[0] & 0x80) != 0;
                        if (isFuckingGiganticPacket)
                        {
                            // Then get the size of the fucking gigantic packet.
                            dataSize = (tmp[0] & 0x7F) << 16;
                            dataSize |= tmp[1] << 8;
                            dataSize |= DecryptByte(OnReceive(1));
                        }
                        else
                        {
                            dataSize |= tmp[0] << 8;
                            dataSize |= tmp[1];
                        }
                    }
                    else
                    {
                        dataSize |= tmp[0] << 8;
                        dataSize |= tmp[1];
                    }
                    data = OnReceive(dataSize);

                    decryptData(data);
                    processData(data);

#if WARDEN
                    Receive(mWardenSocket);
#endif

                    Thread.Sleep(10);

                }
                catch (Exception ex)    // Server dc'd us most likely
                {
                    Log(LogType.Error,0, "Caught Exception while reading off the network: {0}", ex.Message);
                    Log(LogType.Error,1, "{0}", ex.StackTrace);
                    isRunning = false;
                }
            }
            while (isRunning);

            isRunning = false;

            if ( mSocket.Connected)
            {
                try
                {
                    mSocket.Disconnect(false);
                }
                catch (Exception ex)
                {
                    Log(LogType.Error, 0, "Unable to disconnect socket: {0}", ex.Message);
                }
            }
#if WARDEN
            if (mWardenSocket.Connected)
                try
                {
                    mWardenSocket.Disconnect(false);
                }
                catch (Exception) { }
#endif
            Log(LogType.System,1, "WS: Thread Stopping: {0}", Time.GetTime());
        }

        public void UpdateThreadStart()
        {
            uint last_update_time = 0;
            do
            {
                uint now = (uint)Environment.TickCount;
                uint diff = now - last_update_time;
                last_update_time = now;
                Update(diff);
            } while (isRunning);
        }
       
        public void StopThread(bool wait)
        {
            isRunning = false;

            if (mSocket != null && mSocket.Connected)
                try
                {
                    mSocket.Disconnect(false);
                }
                catch (Exception) { }

#if WARDEN
            if (mWardenSocket != null && mWardenSocket.Connected)
                try
                {
                    mWardenSocket.Disconnect(false);
                }
                catch (Exception) { }
#endif

            if (wait)   // Wait till this thread shuts down.
                WorldThread.Join();

            
#if LOG
            if (tw != null)
                lock (tw)
                {
                    try
                    {
                        tw.Close();
                    } catch (Exception) {}
                }
#endif

            UpdateThread = null;
            WorldThread = null;
        }

        private void Ping(object source, ElapsedEventArgs e)
        {
            if (!mSocket.Connected)
            {
                PingTimer.Enabled = false;
                PingTimer.Stop();
                return;
            }

            Ping_Req_Time = (uint)Environment.TickCount;

            Log(LogType.NeworkComms, 5, "Ping!");
            WoWWriter ww = new WoWWriter(OpCode.CMSG_PING);
            ww.Write(Ping_Seq);
            ww.Write(Latency);
            Send(ww);
        }

        #region  Socket Functions

        private void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete the connection.
                client.EndConnect(ar);

                Log(LogType.System, 1, "Socket connected to {0}",
                    client.RemoteEndPoint.ToString());

                if (client == mSocket)
                {
                    isRunning = true;

                    WorldThread = new Thread(new ThreadStart(this.NetworkStart));
                    WorldThread.Name = "WS Client Thread";
                    WorldThread.IsBackground = true;
                    LastUpdateTime = (uint)Environment.TickCount;
                    WorldThread.Start();

                    UpdateThread = new Thread(new ThreadStart(this.UpdateThreadStart));
                    UpdateThread.Name = "WS Update Thread";
                    UpdateThread.IsBackground = true;
                    UpdateThread.Start();

                    Log(LogType.System, 1, "{0}: WS Thread Started", Time.GetTime());
                }
            }
            catch (Exception e)
            {
                Log(LogType.Error, 0, "ConnectCallback failed! {0}", e.ToString());
                isRunning = false;
            }
        }


        /// <summary>
        /// Reads bytes from the WoW Server.
        /// </summary>
        /// <param name="mSize">Number of bytes to read.</param>
        /// <returns>The data recieved. It will be exactly of mSize.</returns>
        protected byte[] OnReceive(int mSize)
        {
            byte[] data = new byte[mSize];


            try
            {
                int readSoFar = 0;
                // Keep looping till we recieve exactly how much we need.
                do
                {
                    mSocket.Poll(50000, SelectMode.SelectRead);

                    if (mSocket.Available > 0)
                    {
                        int read = mSocket.Receive(data, readSoFar, mSize - readSoFar, SocketFlags.None);
                        readSoFar += read;
                    }
                }
                while (readSoFar < mSize && isRunning);
            }
            catch (SocketException) { }


            return data;
        }

        private byte DecryptByte(byte[] inputData)
        {
            packetCrypt.Decrypt(inputData, 0, 1);

            return inputData[0];
        }

        private void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = client.EndSend(ar);
                Log(LogType.SystemDebug, 0, "Sent {0} bytes to server.", bytesSent);
            }
            catch (Exception e)
            {
                Log(LogType.Error, 0, "Error with SendCallBack(): {0}", e.ToString());
                isRunning = false;
            }
        }
#if WARDEN

        public class StateObject
        {
            // Client socket.
            public Socket workSocket = null;
            // Size of receive buffer.
            public const int BufferSize = 1024;
            // Receive buffer.
            public byte[] buffer = new byte[BufferSize];
        }

        public bool received = false;
        // Async socket stuff

        private void SendWarden(byte[] byteData)
        {
            mWardenSocket.Send(byteData, byteData.Length, SocketFlags.None);
        }

        private void Receive(Socket client)
        {
            if (received)
                return;
            received = true;
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.workSocket = client;

                // Begin receiving the data from the remote device.
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                StopThread(false);
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            received = false;
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;
                // Read data from the remote device.
                int bytesRead = client.EndReceive(ar);
                if (bytesRead <= 0)
                {
                    //  Get the rest of the data.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    WoWReader wr = new WoWReader(state.buffer);
                    byte WardenOp = wr.ReadByte();
                    UInt16 WardenSize = wr.ReadUInt16();

                    byte[] WardenData = wr.ReadBytes(WardenSize);


                    if (WardenOp == 0x02)
                    {
                        WoWWriter ww = new WoWWriter(OpCode.CMSG_WARDEN_DATA);
                        ww.Write(WardenData);
                        Send(ww);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
#endif

        private void decryptData(byte[] Data)
        {
            if (packetCrypt != null)
                packetCrypt.Decrypt(Data, 0, mRecvCryptSize);

            UInt16 Op2 = 0;
            OpCode Op = OpCode.CMSG_1180;
            int left = 0;
#if (LOG)
            WoWReader wr = new WoWReader(Data);
            try
            {
                Op2 = wr.ReadUInt16();
                Op = (OpCode)Op2;
                left = wr.Remaining;
            }
            catch (Exception ex) { Log(LogType.Error, 0, "Unable to read opcode! {0} ", ex.Message); }

            try
            {
                tw.WriteLine("S->C Packet: (0x{2:x4}) {1} PacketSize = {0} TimeStamp = {3}", Data.Length, Op, Op2, Environment.TickCount);
                tw.WriteLine("|------------------------------------------------|----------------|");
                tw.WriteLine("|00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F |0123456789ABCDEF|");
                tw.WriteLine("|------------------------------------------------|----------------|");
                Foole.Utils.Debug.DumpBuffer(wr.ReadRemaining(), left, tw);
                tw.WriteLine("-------------------------------------------------------------------");
                tw.WriteLine();


                tw.Flush();
            }
            catch (Exception) { }
#endif
        }

        public void Send(WoWWriter wr)
        {
            byte[] arr = wr.ToArray();
            Send(arr);
        }


        public static string ByteArrayToHexString(byte[] Bytes)
        {
            StringBuilder Result = new StringBuilder();
            string HexAlphabet = "0123456789ABCDEF";

            foreach (byte B in Bytes)
            {
                Result.Append(HexAlphabet[(int)(B >> 4)]);
                Result.Append(HexAlphabet[(int)(B & 0xF)]);
            }

            return Result.ToString();
        }

        public static byte[] HexStringToByteArray(string Hex)
        {
            byte[] Bytes = new byte[Hex.Length / 2];
            int[] HexValue = new int[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09,
                                 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0A, 0x0B, 0x0C, 0x0D,
                                 0x0E, 0x0F };

            for (int x = 0, i = 0; i < Hex.Length; i += 2, x += 1)
            {
                Bytes[x] = (byte)(HexValue[Char.ToUpper(Hex[i + 0]) - '0'] << 4 |
                                  HexValue[Char.ToUpper(Hex[i + 1]) - '0']);
            }

            return Bytes;
        }



        object SendLock = new object();

        public void Send(byte[] Data)
        {
            if (!mSocket.Connected)
                return;
#if (LOG)
            WoWReader wr = new WoWReader(Data);
            UInt32 Op2 = wr.ReadUInt();
            OpCode Op = (OpCode)Op2;
            int left = wr.Remaining;

            lock (tw)
            {
                // Still throwing exceptions :(
                try
                {
                    tw.WriteLine("C->S Packet: (0x{2:x4}) {1} PacketSize = {0} TimeStamp = {3}", Data.Length, Op, Op2, Environment.TickCount);
                    tw.WriteLine("|------------------------------------------------|----------------|");
                    tw.WriteLine("|00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F |0123456789ABCDEF|");
                    tw.WriteLine("|------------------------------------------------|----------------|");
                    Foole.Utils.Debug.DumpBuffer(wr.ReadRemaining(), left, tw);
                    tw.WriteLine("-------------------------------------------------------------------");
                    tw.WriteLine();
                    tw.Flush();
                }
                catch (Exception) { }
            }
#endif
            int Length = Data.Length;
            byte[] Packet = new byte[2 + Length];
            Packet[0] = (byte)(Length >> 8);
            Packet[1] = (byte)(Length & 0xff);
            Data.CopyTo(Packet, 2);

            if (packetCrypt != null)
                packetCrypt.Encrypt(Packet, 0, mSendCryptSize);

            try
            {
                lock (SendLock)
                {
                    mSocket.Send(Packet);
                }
            }
            catch(SocketException e)
            {
                Log(LogType.Error,0, "Unable to send packet! Error: {0}", e.Message);
                isRunning = false;
                
            }
        }
        

        public void Close()
        {
            StopThread(false);
        }

#endregion


        #region Misc Crapola

        private void SMSG_Debug(WoWReader wr)
        {
                Foole.Utils.Debug.DumpBuffer(wr.ToArray());
        }

        public bool IsRunning
        {
            get { return isRunning;  }
        }

        #endregion


    }
}
