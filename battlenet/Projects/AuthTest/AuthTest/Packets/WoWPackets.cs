using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace AuthTest.Packets
{
    internal class WoWPackets
    {
        #region In enum

        public enum In
        {
            /// <summary>
            /// Battlenet::Client::WoWMaster::ListSubscribeResponse - body 0xA8
            /// </summary>
            ListSubscribeResponse = 0,
            /// <summary>
            /// Battlenet::Client::WoWMaster::ListUpdate - body 0xC9
            /// </summary>
            ListUpdate = 2,
            /// <summary>
            /// Battlenet::Client::WoWMaster::ListComplete - body 0xF0
            /// </summary>
            ListComplete = 3,
            /// <summary>
            /// Battlenet::Client::WoWMaster::JoinResponse - body 0xF9	
            /// </summary>
            JoinResponse = 4,
        }

        #endregion

        #region Out enum

        public enum Out
        {
            /// <summary>
            /// Battlenet::Client::WoWMaster::ListSubscribeRequest - body 0x99
            /// </summary>
            ListSubscribeRequest = 0,
            /// <summary>
            /// Battlenet::Client::WoWMaster::ListUnsubscribe - body 0xB0
            /// </summary>
            ListUnsubscribe = 1,
            /// <summary>
            /// Battlenet::Client::WoWMaster::JoinRequest - body 0xF3
            /// </summary>
            JoinRequest = 4,
        }

        #endregion

        public static void HandlePacket(In packetId, BitReader bitReader)
        {
            switch (packetId)
            {
                case In.ListSubscribeResponse:
                    HandleListSubscribeResponse(bitReader);
                    break;
                case In.ListUpdate:
                    HandleListUpdate(bitReader);
                    break;
                case In.ListComplete:
                    HandleListComplete(bitReader);
                    break;
                case In.JoinResponse:
                    HandleJoinResponse(bitReader);
                    break;
                default:
                    Console.WriteLine("WoW: Unhandled packet, {0}", (int)packetId);
                    break;
            }
        }

        public static void HandleListComplete(BitReader biReader)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("HandleListComplete");
            Console.ResetColor();
        }

        public static void SendListSubscribeRequest()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SendListSubscribeRequest");
            Console.ResetColor();

            var bitWriter = new BitWriter(3);
            bitWriter.WriteHeader((int) Out.ListSubscribeRequest, (int) Channels.WoW);

            var myBuf = new byte[bitWriter.Length];
            Array.Copy(bitWriter.Buffer, 0, myBuf, 0, bitWriter.Length);
            Console.WriteLine("Sending: \n{0}", myBuf.ToHexDump());

            Global.Connection.Write(myBuf);

            Console.WriteLine();
        }

        public static void HandleListSubscribeResponse(BitReader bitReader)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("HandleListSubscribeResponse");
            Console.ResetColor();

            int choiceId = bitReader.ReadInt32(1);
            if (choiceId == 0)
            {
                int arrNum = bitReader.ReadInt32(7);
                Console.WriteLine("Realms: {0}", arrNum);
                for (int i = 0; i < arrNum; i++)
                {
                    int region = bitReader.ReadInt32(8);
                    int site = bitReader.ReadInt32(8);
                    int realm = bitReader.ReadInt32(16);
                    int count = bitReader.ReadInt32(16);

                    Console.WriteLine("{{ Region: {0}, Site: {1:d2}, Realm: {2}, Count: {3} }}",
                                      region,
                                      site,
                                      realm,
                                      count);
                }
            }

            Console.WriteLine();

            // TODO: Send
        }

        public static void HandleListUpdate(BitReader bitReader)
        {
            int region = bitReader.ReadInt32(8);
            int site = bitReader.ReadInt32(8);
            int realm = bitReader.ReadInt32(16);

            int choiceOption = bitReader.ReadInt32(1);

            if ( choiceOption == 0 )
            {
                // Delete
            } else if ( choiceOption == 1 )
            {
                var perm = bitReader.ReadInt32(8); // permissionBit
                //var strLen = bitReader.ReadInt32(10);
                //var name = Encoding.ASCII.GetString(bitReader.ReadBytes(strLen));
                var name = bitReader.ReadUTFString(8);
                var type = bitReader.ReadInt32(32);
                var category = bitReader.ReadInt32(32);
                var stateFlags = bitReader.ReadInt32(8);
                var population = bitReader.ReadFloat();

                //Console.WriteLine("Realm: {0} - {1} {2} {3}", name, region, site, realm);
                //Console.WriteLine("Type: {0}, Category: {1}, StateFlags: {2}, Permissions: {3}, Population: {4}",
                                  //(RealmServerType) type, category, (RealmFlags) stateFlags, perm, population);

                bool optional = bitReader.ReadBoolean();
                if ( optional )
                {
                    //strLen = bitReader.ReadInt32(5);
                    //var version = Encoding.ASCII.GetString(bitReader.ReadBytes(strLen));
                    var version = bitReader.ReadAsciiString(5);
                    int configId = bitReader.ReadInt32(32);

                    byte[] address = bitReader.ReadBytes(4);
                    byte[] port = bitReader.ReadBytes(2);

                    Console.WriteLine("Realm:Optional - Version: {0} ConfigID: {1}", version, configId);
                }

            }
        }

        [Flags]
        public enum RealmFlags : byte
        {
            None = 0,
            RedName = 1,
            Offline = 2,
            SpecifyBuild = 4,

            Recommended = 0x20,// client checks pop == 600f
            New = 0x40,// client checks pop == 200f
            Full = 0x80,// client checks pop == 400f
        }

        public enum RealmServerType : byte
        {
            Normal = 0x00,
            PVP = 0x01,
            RP = 0x06,
            RPPVP = 0x07
        }

        public static void HandleJoinResponse(BitReader bitReader)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("HandleJoinResponse");
            Console.ResetColor();

            int choiceId = bitReader.ReadInt32(1);

            IPAddress addr = IPAddress.None;
            short port = short.MinValue;
            if (choiceId == 0)
            {
                Global.ServerSalt = bitReader.ReadUInt32(32);

                addr = new IPAddress(bitReader.ReadBytes(4));
                port = BitConverter.ToInt16(bitReader.ReadBytes(2), 0);
                port = IPAddress.NetworkToHostOrder(port);

                Console.WriteLine("Server Salt: {0:x} Addr: {1} Port: {2}", Global.ServerSalt, addr, port);
            }


            // The HMAC code here is fine, i tested it using a sessionKey from WoW and Client/Server salts too
            var hmacsha1 = new HMACSHA1(Global.SessionKey);
            var hmacsha2 = new HMACSHA1(Global.SessionKey);
            var wowStr = Encoding.ASCII.GetBytes("WoW\0");
            var clientSalt = BitConverter.GetBytes(Global.ClientSalt);
            var serverSalt = BitConverter.GetBytes(Global.ServerSalt);

            hmacsha1.TransformBlock(wowStr, 0, wowStr.Length, wowStr, 0);
            hmacsha1.TransformBlock(clientSalt, 0, clientSalt.Length, clientSalt, 0);
            hmacsha1.TransformFinalBlock(serverSalt, 0, serverSalt.Length);

            hmacsha2.TransformBlock(wowStr, 0, wowStr.Length, wowStr, 0);
            hmacsha2.TransformBlock(serverSalt, 0, serverSalt.Length, serverSalt, 0);
            hmacsha2.TransformFinalBlock(clientSalt, 0, clientSalt.Length);

            var firstHash = hmacsha1.Hash;
            var secondHash = hmacsha2.Hash;

            Global.RealmKey = new byte[40];
            Array.Copy(firstHash, 0, Global.RealmKey, 0, firstHash.Length);
            Array.Copy(secondHash, 0, Global.RealmKey, firstHash.Length, secondHash.Length);
            //Buffer.BlockCopy(secondHash, 0, Global.RealmKey, 0, 20);
            //Buffer.BlockCopy(firstHash, 0, Global.RealmKey, 20, 20);

            Console.WriteLine(Global.RealmKey.ToHexDump());

            Console.WriteLine();

            //var realmClient = new RealmClient(addr, port);
            Global.RealmClient = new RealmClient(addr, port);
        }

        public static void SendJoinRequest( int region, int site, int realmId )
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SendJoinRequest");
            Console.ResetColor();

            var bitWriter = new BitWriter(100);
            bitWriter.WriteHeader((int) Out.JoinRequest, (int) Channels.WoW);
            bitWriter.WriteBits(region, 8);
            bitWriter.WriteBits(site, 8);
            bitWriter.WriteBits(realmId, 16);
            bitWriter.WriteBits(Global.GenerateClientSalt(), 32);

            Console.WriteLine("ClientSalt: {0:x}", Global.ClientSalt);

            var myBuf = new byte[bitWriter.Length];
            Array.Copy(bitWriter.Buffer, 0, myBuf, 0, bitWriter.Length);
            Console.WriteLine("Sending: \n{0}", myBuf.ToHexDump());

            Global.Connection.Write(myBuf);
        }
    }
}