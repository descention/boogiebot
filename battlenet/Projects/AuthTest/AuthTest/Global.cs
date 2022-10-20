using System;

namespace AuthTest
{
    public static class Global
    {
        private static readonly TcpConnection TcpConnection;

        static Global()
        {
            TcpConnection = new TcpConnection("us.logon.battle.net", 1119);
        }
        
        public static TcpConnection Connection
        {
            get { return TcpConnection; }
        }

        internal static RealmClient RealmClient;

        public static uint GenerateClientSalt()
        {
            var r = new Random();
            return ClientSalt = Convert.ToUInt32(r.Next());
        }

        public static uint ClientSalt;
        public static uint ServerSalt;

        public static byte[] SessionKey;
        public static byte[] RealmKey;

        public static string Username;
        public static string Email = "bender@openwow.net";
        public static string Password = "p4ssw0rd";
    }

    public enum Channels
    {
        App = 0,
        Crep = 1,
        WoW = 2
    }
}