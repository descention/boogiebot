using System;
using System.Collections.Generic;
using System.Text;

namespace AuthTest.Packets
{
    internal static class AppPackets
    {
        #region In enum

        public enum In
        {
            AuthComplete = 0,
            ProofRequest = 2
        }

        #endregion

        #region Out enum

        public enum Out
        {
            InformationRequest = 0,
            ProofResponse = 2
        }

        #endregion

        public static void HandlePacket(In packetId, BitReader bitReader)
        {
            switch (packetId)
            {
                case In.ProofRequest:
                    HandleProofRequest(bitReader);
                    break;
                case In.AuthComplete:
                    HandleAuthComplete(bitReader);
                    break;
                default:
                    Console.WriteLine("App: Unhandled packet, {0}", (int)packetId);
                    break;
            }
        }

        public static void HandleProofRequest(BitReader bitReader)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("HandleProofRequest");
            Console.ResetColor();

            int numModules = bitReader.ReadInt32(3);
            var moduleInputs = new List<ModuleInput>();

            Console.WriteLine("Modules ({0}):", numModules);
            for (int i = 0; i < numModules; i++)
            {
                var cacheHandle = ReadModuleInfo(bitReader);
                int blobSize = bitReader.ReadInt32(10);
                byte[] moduleBlob = bitReader.ReadBytes(blobSize);

                Console.WriteLine("ModuleID: {0}", cacheHandle.ModuleID.ToHexString());
                Console.WriteLine("Auth: {0}", cacheHandle.AuthString);
                Console.WriteLine("Locale: {0}", cacheHandle.Locale);
                Console.WriteLine("Blob:\n{0}", moduleBlob.ToHexString());

                Console.WriteLine();

                var moduleInput = new ModuleInput { ModuleCacheHandle = cacheHandle, ModuleData = moduleBlob };
                moduleInputs.Add(moduleInput);
            }

            byte[] inBuf = moduleInputs[0].ModuleData;
            var outBuf = new byte[1024];
            int outSize;

            AuthInterface.RequestPassword(inBuf, inBuf.Length, outBuf, out outSize, Encoding.ASCII.GetBytes(Global.Password));


            var bitWriter = new BitWriter(1024);
            bitWriter.WriteHeader((int)Out.ProofResponse, (int)Channels.App);
            bitWriter.WriteBits(1, 3); // module count
            bitWriter.WriteBuffer(outBuf, outSize, 10); // [14] Blob, {Type: UInt16, Bits: 10, Min: 0, Max: 1023} - Battlenet::Client::Authentication::ModuleData

            var myBuf = new byte[bitWriter.Length - 1];
            Array.Copy(bitWriter.Buffer, 0, myBuf, 0, bitWriter.Length - 1);
            Console.WriteLine("Sending: \n{0}\n", myBuf.ToHexDump());

            Global.Connection.Write(myBuf);
        }

        public static void HandleAuthComplete(BitReader bitReader)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("HandleAuthComplete");
            Console.ResetColor();

            bool isFailure = bitReader.ReadBoolean(); // choice of 0,1
            Console.WriteLine("Choice: {0}", isFailure == false ? "Success" : "Failure");
            if (isFailure == false) // Battlenet::Client::Authentication::Complete::Result::Success
            {
                int numModules = bitReader.ReadInt32(3); // [1A] Array, {Type: UInt8, Bits: 3, Min: 0, Max: 4}, NextTypeId: 0x15 - Battlenet::Client::Authentication::ModuleRequest

                for (int i = 0; i < numModules; i++)
                {
                    //byte[] authStr = bitReader.ReadBytes(4);
                    //Console.WriteLine("Auth: {0}", Encoding.ASCII.GetString(authStr));
                    //bitReader.ReadBytes(2); // Unk
                    //Console.WriteLine("Locale: {0}", Encoding.ASCII.GetString(bitReader.ReadBytes(2)));
                    //byte[] moduleId = bitReader.ReadBytes(32);// - Battlenet::Cache::Handle
                    //Console.WriteLine("Module Id: {0}", moduleId.ToHexString());
                    ModuleCacheHandle moduleCacheHandle = ReadModuleInfo(bitReader);
                    Console.WriteLine("Auth: {0}", moduleCacheHandle.AuthString);
                    Console.WriteLine("Locale: {0}", moduleCacheHandle.Locale);
                    Console.WriteLine("ModuleId: {0}", moduleCacheHandle.ModuleID.ToHexString());


                    //int blobSize = bitReader.ReadInt32(10);
                    //byte[] blob = bitReader.ReadBytes(blobSize);
                    byte[] blob = bitReader.ReadBuffer(10);
                    //Console.WriteLine("Blob Size: {0}, blobId: {1}", blobSize, blob[0]);
                    Console.WriteLine("Blob Size: {0}, blobId: {1}", blob.Length, blob[0]);
                    Console.WriteLine();

                    if (i == 0)
                    {
                        var sessionKey = new byte[64];
                        //AuthInterface.RequestSessionKey(blob, blobSize, sessionKey);
                        AuthInterface.RequestSessionKey(blob, blob.Length, sessionKey);

                        Global.SessionKey = sessionKey;
                        Console.WriteLine("Session Key: \n{0}", sessionKey.ToHexDump());
                    }
                }

                //int pingTimeout = Convert.ToInt32(bitReader.ReadInt32(32) + 2147483648); // 2147483648 is the "Min"
                int pingTimeout = bitReader.ReadInt32(32, int.MinValue);// 2147483648
                Console.WriteLine("Ping Timeout: {0}", pingTimeout);


                if (bitReader.ReadOptional()) // optional segment
                {
                    // Choice of 0, 1
                    bool choice = bitReader.ReadBoolean();
                    if (choice) // choice 1
                    {
                        // Battlenet::Regulator::LeakyBucketParams - Struct, Components: { 1 - m_threshold, 1 - m_rate}
                        // m_regulatorRules?
                        int threshold = bitReader.ReadInt32(32);
                        int rate = bitReader.ReadInt32(32);
                        Console.WriteLine("Regulator Rules:");
                        Console.WriteLine("\tThreshold: {0}", threshold);
                        Console.WriteLine("\tRate: {0}", rate);
                    }
                    else // choice 0
                    {

                    }
                }

                //int strLen = bitReader.ReadInt32(7);
                //string accountHolder = Encoding.ASCII.GetString(bitReader.ReadBytes(strLen));
                var accountHolder = bitReader.ReadAsciiString(7);
                Console.WriteLine("Account Holder: {0}", accountHolder);

                int region = bitReader.ReadInt32(8);
                // Possibly region, US = 1, EU = 2
                Console.WriteLine("Region?: {0}", region);

                //int strLen = bitReader.ReadInt32(5) + 1; // + 1 for the "Min" value
                //int strLen = bitReader.ReadInt32(5, 1); // 1 is the min for [67] AsciiString, {Type: UInt8, Bits: 5, Min: 1, Max: 32}
                //string accountName = Encoding.ASCII.GetString(bitReader.ReadBytes(strLen));
                var accountName = bitReader.ReadAsciiString(5, 1);
                Console.WriteLine("Account Name: {0}", accountName);

                Global.Username = accountName;

                long subLong = bitReader.ReadInt64(64);
                int subInt4 = bitReader.ReadInt32(32);

                Console.WriteLine("SubInts: {0:x} {1:x}", subLong, subInt4);
                Console.WriteLine();
                WoWPackets.SendListSubscribeRequest();
            }
            else
            {
                if (bitReader.ReadOptional())
                {
                    // 40 byte Blob - Battlenet::Cache::Handle
                    /* Choice
                     * 0 - Null
                     * 1 - Int16, Int32
                     * 2 - Null
                    */
                    ModuleCacheHandle moduleCacheHandle = ReadModuleInfo(bitReader);
                    Console.WriteLine("Didn't handle optional argument");
                }
                switch (bitReader.ReadInt32(2)) // Choice of 0,1,2
                {
                    case 0:
                    case 2:
                        break;
                    case 1:
                        {
                            var errorCode = bitReader.ReadInt32(16);
                            //var uint_1 = bitReader.ReadInt32(32) + 2147483648; // min
                            var uint_1 = bitReader.ReadInt32(32, int.MinValue);
                            Console.WriteLine("AuthComplete Error: {0} {1}", errorCode, uint_1);
                            break;
                        }
                }
            }

            Console.WriteLine();

        }

        static ModuleCacheHandle ReadModuleInfo(BitReader bitReader)
        {
            var moduleInfo = new ModuleCacheHandle(bitReader.ReadBytes(40));
            return moduleInfo;
            //byte[] authStr = bitReader.ReadBytes(4);
            //Console.WriteLine("Auth: {0}", Encoding.ASCII.GetString(authStr));
            //bitReader.ReadBytes(2); // Unk
            //Console.WriteLine("Locale: {0}", Encoding.ASCII.GetString(bitReader.ReadBytes(2)));

            //byte[] moduleId = bitReader.ReadBytes(32);// - Battlenet::Cache::Handle
            //Console.WriteLine("Module Id: {0}", moduleId.ToHexString());
        }

        public static void SendInformationRequest()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SendInformationRequest");
            Console.ResetColor();

            var bitWriter = new BitWriter(1024);
            bitWriter.WriteHeader((int)Out.InformationRequest, (int)Channels.App);

            bitWriter.WriteFourCC("WoW");
            bitWriter.WriteFourCC("Win");
            bitWriter.WriteFourCC("enUS");

            var components = new List<Component>
                                 {
                                     new Component("WoW", "Win", 11723),
                                     new Component("WoW", "base", 11723),
                                     new Component("WoW", "enUS", 11723),
                                     new Component("Tool", "Win", 1462),
                                     new Component("Bnet", "Win", 13590)
                                 };

            bitWriter.WriteBits(components.Count, 6);
            foreach (Component component in components)
            {
                bitWriter.WriteFourCC(component.Program);
                bitWriter.WriteFourCC(component.Platform);
                bitWriter.WriteInt32(component.Version);
            }

            bitWriter.WriteBits(1, 1);


            bitWriter.WriteBits(Global.Email.Length - 3, 9);
            bitWriter.WriteBytes(Encoding.ASCII.GetBytes(Global.Email));

            var myBuf = new byte[bitWriter.Length];
            Array.Copy(bitWriter.Buffer, 0, myBuf, 0, bitWriter.Length);

            Console.WriteLine("Sending: \n{0}\n", myBuf.ToHexDump());
            Global.Connection.Write(myBuf);
        }

        #region Nested type: Component

        private struct Component
        {
            public readonly string Platform;
            public readonly string Program;
            public readonly int Version;

            public Component(string program, string platform, int version)
            {
                Program = program;
                Version = version;
                Platform = platform;
            }
        }

        #endregion

        #region Nested type: ModuleCacheHandle


        public class ModuleInput
        {
            public ModuleCacheHandle ModuleCacheHandle;
            public byte[] ModuleData;
        }

        public class ModuleCacheHandle
        {
            public string AuthString;
            public short UnkShort;
            public string Locale;
            public byte[] ModuleID;

            public ModuleCacheHandle(byte[] buf)
            {
                AuthString = Encoding.ASCII.GetString(buf, 0, 4);
                UnkShort = BitConverter.ToInt16(buf, 4);
                Locale = Encoding.ASCII.GetString(buf, 6, 2);
                ModuleID = new byte[32];
                Array.Copy(buf, 8, ModuleID, 0, 32);
            }
        }

        #endregion
    }
}