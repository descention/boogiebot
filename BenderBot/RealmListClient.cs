using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

using Foole.Crypt;
using Foole.WoW;

// This is no longer used. Battle.net took over

namespace BenderBot.Common
{
    public partial class RealmListClient
    {
        private BenderCore BenderCore { get; set; }
        public string mUsername;
        private string mPassword;

        private Socket mSocket;
        private NetworkStream ns;
        private WoWReader win;
        private WoWWriter wout;



        public RealmListClient(BenderCore benderCore, string Username, string Password)
        {
            BenderCore = benderCore;
            mUsername = Username;
            mPassword = Password;

            BenderCore.Log(LogType.System, 0, "Logging in with account \"{0}\" and password \"{1}\"", Username, Password);

            if (mUsername.Length < 3 || mPassword.Length < 3)
            {
                BenderCore.Log(LogType.Error, 0,"Invalid user/pass given ({0} - {1}). Please correct in BenderBot.ini", mUsername, mPassword);
                mSocket.Disconnect(false);
                return;
            }
        }


        public bool Connect(IPEndPoint ep)
        {
            try
            {
                mSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                mSocket.Connect(ep);

                ns = new NetworkStream(mSocket, true);
                win = new WoWReader(ns);
                wout = new WoWWriter(ns);

                
                BenderCore.Log(LogType.System,0, "Connected successfully.");
                return true;
            }
            catch (Exception ex)
            {
                BenderCore.Log(LogType.System, 0,"Failed to open connection to realm list server. Details below:\n{0}", ex.Message);
                return false;
            }
        }

        public bool Logon()
        {
            if (mSocket.Connected == false)
                return false;

            BenderCore.Log(LogType.System, 1,"Login Challenge: Sending...");
            DoLogonChallenge();
            BenderCore.Log(LogType.System,1, "Login Challenge: Waiting on response...");

            if (HandleLogonChallenge() == false)
            {
                BenderCore.Log(LogType.System, 0,"Login Challenge: Failed!");
                mSocket.Close();
                return false;
            }

            BenderCore.Log(LogType.System,0, "Login Challenge: Success!");
            BenderCore.Log(LogType.System,0, "Login Proof: Sending...");
            DoLogonProof();
            BenderCore.Log(LogType.System,1, "Login Proof: Waiting on response...");

            if (HandleLogonProof() == false)
            {
                BenderCore.Log(LogType.System, 0,"Login Proof: Authentication Failure.");
                mSocket.Close();
                return false;
            }

            BenderCore.Log(LogType.System,0, "Login Proof: Authentication Successful");
            BenderCore.Log(LogType.System,0, "Sending RealmList Request...");
            SendRealmlistRequest();
            BenderCore.Log(LogType.System, 0,"Retrieving RealmList...");
            RetrieveRealmList();
            mSocket.Close();
            return true;
        }

        private void SendRealmlistRequest()
        {
            wout.Write((byte)RLOp.REALM_LIST);
            wout.Write(0);
            wout.Flush();
        }


        public List<Realm> Realms { get; set; }
        private void RetrieveRealmList()
        {
            


            try
            {
            
                byte op = win.ReadByte();

                BenderCore.Log(LogType.System, 5,"Got op: {0}", (RLOp)op);

                if (op == (byte)RLOp.SURVEY)
                {
                    BenderCore.Log(LogType.System,5, "Got survey, reading off 31 bytes on the stream");
                    win.ReadBytes(31);

                    op = win.ReadByte();
                 //* char peer1_2[] = { 0x10, 0x0a, 0x01, 0x00, 0x00, 0x00, 0x00, 0x05, 
                }

                while ((RLOp)op != RLOp.REALM_LIST)
                {
                    op = win.ReadByte();
                }

                UInt16 Length = win.ReadUInt16();
                UInt32 Request = win.ReadUInt32();
                UInt16 NumOfRealms = win.ReadUInt16();

                BenderCore.Log(LogType.System,5, "op = {0}, Length = {1}, Request = {2}, # of Realms = {3}", op, Length, Request, NumOfRealms);

                Realms = new List<Realm>();

                /*
                 *
                 * 00 
                 * 00 
                 * 00 
                 * 47 72 65 79 6d 61 6e 65 00 Greymane
                 * 36 33 2e 32 34 31 2e 32 35 35 63 2e 32 35 3a 33 37 32 34 00 63.241.255.25:3724
                 * 00 00 c8 43 
                 * 00 
                 * 02 
                 * 1e

                 * 00
                 * 00 
                 * 00 
                 * 57 69 6e 74 65 72  68 6f 6f 66 00 Winterhoof
                 * 37 32 35 2e 32 31 33 2e 39 37  3a 33 37 32 34 00           72.5.213.97:3724
                 * 00 00 48 43 
                 * 00 
                 * 02 
                 * 12

                /*
                 * 2.4.2 official realms
                 * 
                 * 00
                 * 00
                 * 00
                 * 00 
                 * 47 72 65 79 6d 61 6e 65 00 Greymane
                 * 36 33 2e 32 34 31 2e 32 35 35 63 2e 32 35 3a 33 37 32 34 00 63.241.255.25:3724
                 * 2b 87 96 3f pop
                 * 00 # chars
                 * 02 lang
                 * 1e unk??
                 * 01 unk2??
                 * 
                 * 
                 * 00
                 * 00
                 * 00
                 * 00
                 * 41 72 63  68 69 6d 6f 6e 64 65 00 Archimonde
                 * 32 30 36 2e 31 37 2e 31  31 31 2e 37 35 3a 33 37 32 34 00 206.17.111.75:3724
                 * a8 c6 8b 3f
                 * 00
                 * 02
                 * 06
                 * 01
     */
                for (int i = 0; i < NumOfRealms; i++)
                {
                    Realm realm = new Realm();
                    Realms.Add(realm);

                    if ((i + 1) % 10 == 0)
                        BenderCore.Log(LogType.SystemDebug,5, "Retrieved realm {0} of {1}.", i + 1, NumOfRealms);

                    realm.Type = win.ReadByte();
                    realm.Color = win.ReadByte();
                    byte unk1 = win.ReadByte(); // unk

                    realm.Name = win.ReadString();
                    realm.Address = win.ReadString();
                    realm.Population = win.ReadFloat();
                    realm.NumChars = win.ReadByte();
                    realm.Language = win.ReadByte();
                    realm.Unk = win.ReadByte();
                    //win.ReadByte(); // unk2
                    //win.ReadByte(); // unk3
                }

                //win.ReadByte(); // unk 4

                BenderCore.Log(LogType.SystemDebug, 5,"Done.");

                //String defaultRealm = "";// = BenderCore.configFile.ReadString("Connection", "DefaultRealm");

                //if (defaultRealm != "")
                //{
                //    foreach (Realm r in Realms)
                //        if (r.Name.ToLower() == defaultRealm.ToLower())
                //        {
                //            BenderCore.Log(LogType.System, "Defaulting to realm {0}", defaultRealm);

                //            string[] address = r.Address.Split(':');
                //            BenderCore.Log(LogType.System, "Defaulting to realm {0} IP: {1} port: {2}", defaultRealm, address[0], address[1]);
                //            IPAddress WSAddr = IPAddress.Parse(address[0]);//Dns.GetHostEntry(address[0]).AddressList[0];
                //            BenderCore.Log(LogType.System, "IP: {0}", WSAddr.ToString());
                //            int WSPort = Int32.Parse(address[1]);
                //           // BenderCore.ConnectToWorldServer(new IPEndPoint(WSAddr, WSPort));

                //            return;
                //        }
                //}

                //BenderCore.Event(new Event(EventType.EVENT_REALMLIST, Time.GetTime(), Realms));
            }
            catch (Exception e)
            {
                BenderCore.Log(LogType.System,0, e.Message + "\n" + e.StackTrace);
            }
        }
    }

    public class Realm
    {
        public UInt32 Type {get;set;}
        public byte Color { get; set; }
        public byte NameLen { get; set; }
        public string Name { get; set; }
        public byte AddrLen { get; set; }
        public string Address { get; set; }
        public float Population { get; set; }
        public byte NumChars { get; set; }
        public byte Language { get; set; }
        public byte Unk { get; set; } // const: 1
    }
}