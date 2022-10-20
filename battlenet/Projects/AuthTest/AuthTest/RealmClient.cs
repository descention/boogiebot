using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Foole.Crypt;

namespace AuthTest
{
    internal class RealmClient
    {
        private readonly Socket _socket;
        private PacketCrypt _crypt;
        private Thread _realmThread;

        internal RealmClient(IPAddress ipAddr, short port)
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _socket.BeginConnect(ipAddr, port, ConnectionCallback, _socket);
        }

        private void ConnectionCallback(IAsyncResult ar)
        {
            var socket = (Socket) ar.AsyncState;
            socket.EndConnect(ar);

            Console.WriteLine("RealmClient::Connected");

            _realmThread = new Thread(NetworkLoop) {IsBackground = false};
            _realmThread.Start();
        }


        private byte[] ReadData(int numBytes)
        {
            var data = new byte[numBytes];

            try
            {
                int bytesRead = 0;

                do
                {
                    _socket.Poll(50000, SelectMode.SelectRead);

                    if (_socket.Available > 0)
                        bytesRead += _socket.Receive(data, bytesRead, numBytes - bytesRead, SocketFlags.None);
                } while (bytesRead < numBytes);
            }
            catch (SocketException)
            {
            }

            return data;
        }

        private void NetworkLoop()
        {
            while (true)
            {
                try
                {
                    byte[] tmp = ReadData(2);
                    if (_crypt != null)
                    {
                        _crypt.Decrypt(tmp, 0, 2);
                    }
                    int dataSize = 0;
                    dataSize |= tmp[0] << 8;
                    dataSize |= tmp[1];

                    byte[] data = ReadData(dataSize);

                    var ms = new MemoryStream(data);
                    var br = new BinaryReader(ms);

                    short opcode = br.ReadInt16();
                    switch (opcode)
                    {
                        case 492:
                            HandleAuthChallenge(br);
                            break;
                        case 494:
                            HandleAuthResponse(br);
                            break;
                    }

                    Console.WriteLine(data.ToHexDump());
                }
                catch (SocketException e)
                {
                    Console.WriteLine("NetworkLoop::Error - {0}", e);
                    break;
                }
            }
        }

        private void HandleAuthChallenge(BinaryReader packetReader)
        {
            uint shuffleCount = packetReader.ReadUInt32();
            if (shuffleCount < 1 || shuffleCount > 32)
                return;

            uint serverSeed = packetReader.ReadUInt32();

            var serverStates = new uint[4];
            for (int i = 0; i < 4; i++)
                serverStates[i] = packetReader.ReadUInt32();

            var ms = new MemoryStream();
            var br = new BinaryWriter(ms);

            br.Write(493);
            br.Write(10505);

            br.Write(0);

            br.Write(Encoding.Default.GetBytes(Global.Username));
            br.Write((byte) 0);

            br.Write(1);
            br.Write(Global.ClientSalt);
            br.Write(Calculation(Global.Username, serverStates, shuffleCount));

            var sha1 = new Sha1Hash();
            sha1.Update(Global.Username);
            sha1.Update(0);
            sha1.Update(Global.ClientSalt);
            sha1.Update(serverSeed);
            sha1.Update(Global.RealmKey);

            byte[] digest = sha1.Final();
            br.Write(digest);

            br.Write(0); // addon compressed len

            var outPacket = new byte[2 + ms.Length];
            Array.Copy(ms.ToArray(), 0, outPacket, 2, ms.Length);
            outPacket[0] = (byte) (ms.Length >> 8);
            outPacket[1] = (byte) (ms.Length & 0xff);

            _socket.Send(outPacket);
            _crypt = new PacketCrypt(Global.RealmKey);
        }

        private UInt64 Calculation(string accountName, uint[] serverState, uint shuffleCount)
        {
            UInt64 unkUl = 0;
            while (true)
            {
                var sha = new Sha1Hash();
                sha.Update(accountName);
                for (int i = 0; i < 4; i++)
                    sha.Update(serverState[i]);
                sha.Update(BitConverter.GetBytes(unkUl));
                byte[] digest = sha.Final();
                int shiftCount = 0;
                int index = 0;
                while (digest[index] <= 0)
                {
                    ++index;
                    shiftCount += 8;
                    if (index >= 20)
                        goto LABEL_8;
                }

                for (int i = digest[index]; (i & 1) == 0; ++shiftCount)
                    i >>= 1;

                LABEL_8:
                if (shiftCount >= shuffleCount)
                    break;
                unkUl++;
            }
            return unkUl;
        }

        enum AuthError
        {
            AUTH_OK = 12,
            AUTH_FAILED = 13,
            AUTH_REJECT = 14,
            AUTH_BAD_SERVER_PROOF = 15,
            AUTH_UNAVAILABLE = 16,
            AUTH_SYSTEM_ERROR = 17,
            AUTH_BILLING_ERROR = 18,
            AUTH_BILLING_EXPIRED = 19,
            AUTH_VERSION_MISMATCH = 20,
            AUTH_UNKNOWN_ACCOUNT = 21,
            AUTH_INCORRECT_PASSWORD = 22,
            AUTH_SESSION_EXPIRED = 23,
            AUTH_SERVER_SHUTTING_DOWN = 24,
            AUTH_ALREADY_LOGGING_IN = 25,
            AUTH_LOGIN_SERVER_NOT_FOUND = 26,
        }
        void HandleAuthResponse(BinaryReader packet)
        {
            var authError = (AuthError) packet.ReadByte();

            Console.WriteLine("SMSG_AUTH_RESPONSE: {0}", authError);
        }
    }
}