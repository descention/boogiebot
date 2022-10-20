using System;
using AuthTest.Packets;

namespace AuthTest
{
    internal static class Extensions
    {
        public static string ToHexString(this byte[] byteArray)
        {
            string retStr = "";
            foreach (byte b in byteArray)
                retStr += b.ToString("x2");
            return retStr;
        }

        public static string ToHexDump(this byte[] byteArray)
        {
            string retStr = "";
            for (int i = 0; i < byteArray.Length; i++)
            {
                if (i > 0 && i%16 == 0)
                    retStr += "\n";
                retStr += byteArray[i].ToString("x2") + " ";
            }
            return retStr;
        }

        public static uint ToBin(this String s, out byte[] bytes)
        {
            char[] ca = s.ToCharArray();
            bytes = new byte[4];
            bytes[0] = (byte) ca[0];
            bytes[1] = (byte) ca[1];
            bytes[2] = (byte) ca[2];
            bytes[3] = (byte) ca[3];
            var b0 = (uint) ca[0];
            var b1 = (uint) ca[1];
            var b2 = (uint) ca[2];
            var b3 = (uint) ca[3];
            uint r = b3 | (b2 << 8) | (b1 << 16) | (b0 << 24);
            //using (var file = new StreamWriter("sigs.txt", true))
            //{
            //    file.WriteLine("{0} - {1}", s, r);
            //}
            return r;
        }
    }

    internal class Program
    {
        private static byte[] _bigBuf = new byte[0];
        private static bool _gotRealmlist;
        private static int _previousChannel;
        private static bool _receivingRealmlist;

        private static UInt64 Calculation(string accountName, uint[] serverState, uint shuffleCount)
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

        private static void Main(string[] args)
        {
            Global.Connection.DataReceived += ConnectionDataReceived;
            Global.Connection.Connect();
            AppPackets.SendInformationRequest();

            Console.ReadKey();
        }

        private static void ConnectionDataReceived(TcpConnection conn, byte[] data)
        {
            BitReader bitReader;

            if (_receivingRealmlist && !_gotRealmlist)
            {
                int bufSize = _bigBuf.Length;
                Array.Resize(ref _bigBuf, bufSize + data.Length);
                Array.Copy(data, 0, _bigBuf, bufSize, data.Length);

                var endBuf = new byte[2];
                Array.Copy(data, data.Length - 2, endBuf, 0, 2);
                bitReader = new BitReader(endBuf);

                int packetId = bitReader.ReadInt32(6);
                bool hasChannel = bitReader.ReadBoolean();
                int channelId;

                if (hasChannel) // If we have a channel specified
                    channelId = _previousChannel = bitReader.ReadInt32(4);
                else
                    channelId = _previousChannel;

                if ((packetId == (int) WoWPackets.In.ListComplete) && channelId == (int) Channels.WoW)
                {
                    Console.WriteLine("Done!");

                    _receivingRealmlist = false;

                    var myBitReader = new BitReader(_bigBuf);
                    while (myBitReader.ReadPos < myBitReader.NumBits)
                    {
                        myBitReader.ReadInt32(6);

                        if (myBitReader.ReadBoolean()) // If we have a channel specified
                            myBitReader.ReadInt32(4);

                        WoWPackets.HandleListUpdate(myBitReader);
                        myBitReader.ReadBytes(0); //align
                    }

                    WoWPackets.SendJoinRequest(1, 4, 31);

                    _gotRealmlist = true;
                }

                return;
            }

            bitReader = new BitReader(data);

            while (bitReader.ReadPos < bitReader.NumBits)
            {
                int arrayIndex = bitReader.ReadPos/8;

                int packetId = bitReader.ReadInt32(6);
                bool hasChannel = bitReader.ReadBoolean();
                int channelId;

                if (hasChannel) // If we have a channel specified
                    channelId = _previousChannel = bitReader.ReadInt32(4);
                else
                    channelId = _previousChannel;

                Console.WriteLine("PacketID: {0} hasChannel: {1} ChannelID: {2}", packetId, hasChannel, channelId);

                switch ((Channels) channelId)
                {
                    case Channels.App:
                        AppPackets.HandlePacket((AppPackets.In) packetId, bitReader);
                        break;
                    case Channels.WoW:
                        if (packetId == (int) WoWPackets.In.ListUpdate && !_gotRealmlist)
                        {
                            _receivingRealmlist = true;

                            Array.Resize(ref _bigBuf, data.Length - arrayIndex);
                            Array.Copy(data, arrayIndex, _bigBuf, 0, data.Length - arrayIndex);

                            return;
                        }

                        WoWPackets.HandlePacket((WoWPackets.In) packetId, bitReader);
                        break;
                    case Channels.Crep:
                        CrepPackets.HandlePacket((CrepPackets.In) packetId, bitReader);
                        break;
                }

                bitReader.ReadBytes(0); // align
            }
        }
    }
}