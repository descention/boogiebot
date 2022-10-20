using System.Runtime.InteropServices;

namespace AuthTest
{
    internal class AuthInterface
    {
        [DllImport("AuthInterface.dll", EntryPoint = "RequestPassword", CallingConvention = CallingConvention.StdCall)]
        public static extern void RequestPassword(byte[] inBuffer, int length, byte[] outBuffer, out int outSize, byte[] Password);

        [DllImport("AuthInterface.dll", EntryPoint = "RequestSessionKey", CallingConvention = CallingConvention.StdCall)
        ]
        public static extern void RequestSessionKey(byte[] inBuffer, int length, byte[] outBuffer);

        [DllImport("AuthInterface.dll", EntryPoint = "GetSessionKey", CallingConvention = CallingConvention.StdCall)]
        public static extern void GetSessionKey(byte[] pSessionKey);
    }
}