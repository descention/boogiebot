using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuthTest.Packets
{
    class CrepPackets
    {
        public enum In
        {
            PingRequest = 0,
            Unknown = 1,
        }

        public enum Out
        {
            PingResponse = 0,
        }

        public static void HandlePacket(In packetId, BitReader bitReader)
        {
            switch (packetId)
            {
                case In.PingRequest:
                    HandlePingRequest(bitReader);
                    break;
                case In.Unknown:
                    HandleUnknownPacket(bitReader);
                    break;
                default:
                    Console.WriteLine("Unhandled Crep channel");
                    break;
            }
        }

        private static void HandleUnknownPacket(BitReader reader)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("HandleUnknownPacket");
            Console.ResetColor();

            int unkShort = reader.ReadInt32(16);
            Console.WriteLine("UnkPacket: Short: {0}", unkShort);
        }

        public static void SendPingResponse()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("SendPingResponse");
            Console.ResetColor();

            var bitWriter = new BitWriter(5);
            bitWriter.WriteHeader((int) Out.PingResponse, (int) Channels.Crep);

            var myBuf = new byte[bitWriter.Length];
            Array.Copy(bitWriter.Buffer, 0, myBuf, 0, bitWriter.Length);
            Console.WriteLine("Sending: \n{0}", myBuf.ToHexDump());

            Global.Connection.Write(myBuf);
        }

        public static void HandlePingRequest(BitReader br)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("HandlePingRequest");
            Console.ResetColor();

            SendPingResponse();
        }
    }
}