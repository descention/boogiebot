using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Foole.Crypt;
using Foole.WoW;

// This is no longer used. Battle.net took over for this.

namespace BenderBot.Common
{
    public partial class RealmListClient
    {
        private Srp6 srp;       // http://srp.stanford.edu/design.html  <- SRP6 information

        private BigInteger A;   // My public key?
        private BigInteger B;   // Server's public key
        private BigInteger a;   // my random number, used to initalize A from g and N.
        private byte[] I;       // Hash of "username:password"
        private BigInteger M;   // Combination of... everything!
        private byte[] M2;      // M2 is the combination of the server's everything to proof with ours (which we don't actually do, cause we trust blizzard, right?)


        private byte[] N;       // Modulus for A and B
        private byte[] g;       // base for A and B

        private BigInteger Salt;    // Server provided salt
        private byte[] crcsalt;     // Server provided crcsalt for file crc's.

        public byte[] K;        // Our combined key used for encryption of all traffic

        /// <summary>
        /// Realm Auth Proof Error Codes
        /// </summary>
        public enum AccountStatus : byte
        {
            Success = 0,
            Failure = 1,                                ///< Unable to connect
            //Unknown1 = 2,                               ///< Unable to connect
            AccountBanned = 3,                         ///< This <game> account has been closed and is no longer available for use. Please go to <site>/banned.html for further information.
            InvalidInformation = 4,                               ///< The information you have entered is not valid. Please check the spelling of the account name and password. If you need help in retrieving a lost or stolen password, see <site> for more information
            InvalidInformation_2 = 5,                               ///< The information you have entered is not valid. Please check the spelling of the account name and password. If you need help in retrieving a lost or stolen password, see <site> for more information
            AccountInUse = 6,                         ///< This account is already logged into <game>. Please check the spelling and try again.
            PrepaidTimeLimitReached = 7,                     ///< You have used up your prepaid time for this account. Please purchase more to continue playing
            ServerFull = 8,                            ///< Could not log in to <game> at this time. Please try again later.
            WrongBuild = 9,                     ///< Unable to validate game version. This may be caused by file corruption or interference of another program. Please visit <site> for more information and possible solutions to this issue.
            UpdateClientVersion = 10,                          ///< Downloading
            //Unknown2 = 11,                               ///< Unable to connect
            AccountFrozen = 12,                        ///< This <game> account has been temporarily suspended. Please go to <site>/banned.html for further information
            //Unknown3 = 13,                               ///< Unable to connect
            //Unknown4 = 14,                               ///< Connected.
            ParentalControlRestriction = 15                        ///< Access to this account has been blocked by parental controls. Your settings may be changed in your account preferences at <site>
        }


        public void DoLogonChallenge()
        {
            wout.Write((byte)RLOp.AUTH_LOGON_CHALLENGE);
            wout.Write((byte)8);                             // Used to be 2, now its 3. - and now it's 8

            wout.Write((UInt16)(30 + mUsername.Length));                                                        // Packet size + name length

            wout.Write((byte)'W'); wout.Write((byte)'o'); wout.Write((byte)'W'); wout.Write((byte)'\0');        // WoW

            // FIX ME!!! HARD CODED VERSION
            wout.Write((byte)3);
            wout.Write((byte)2);
            wout.Write((byte)2);
            wout.Write((ushort)10505);


            wout.Write((byte)'6'); wout.Write((byte)'8'); wout.Write((byte)'x'); wout.Write((byte)'\0');     // 68x
            wout.Write((byte)'n'); wout.Write((byte)'i'); wout.Write((byte)'W'); wout.Write((byte)'\0');     // niW
                

            wout.Write((byte)'S'); wout.Write((byte)'U'); wout.Write((byte)'n'); wout.Write((byte)'e');  // SUne

            wout.Write((byte)0x20); wout.Write((byte)0xfe); wout.Write((byte)0xff); wout.Write((byte)0xff);

            wout.Write((byte)127); wout.Write((byte)0); wout.Write((byte)0); wout.Write((byte)1);       // Interestingly, mac sends IPs in reverse order.

            wout.Write((byte)mUsername.Length);
            wout.Write(Encoding.Default.GetBytes(mUsername)); // Name - NOT null terminated
            wout.Flush();
        }

        private bool HandleLogonChallenge()
        {
            try
            {
                win.ReadByte(); // opcode
                byte unk = win.ReadByte();

                BenderCore.Log(LogType.System, 1, "Login Challenge: Response Type = {0}", unk);

                byte error = win.ReadByte();
                if (error > 0)
                {
                    BenderCore.Log(LogType.Error, 1, "Login Challenge: Error = {0}", error);
                    return false;
                }
                B = new BigInteger(win.ReadBytes(32));               // Varies
                byte glen = win.ReadByte();                          // Length = 1
                g = win.ReadBytes(glen);                             // g = 7
                byte Nlen = win.ReadByte();                          // Length = 32
                N = win.ReadBytes(Nlen);                             // N = B79B3E2A87823CAB8F5EBFBF8EB10108535006298B5BADBD5B53E1895E644B89
                Salt = new BigInteger(win.ReadBytes(32));            // Salt = 3516482AC96291B3C84B4FC204E65B623EFC2563C8B4E42AA454D93FCD1B56BA
                crcsalt = win.ReadBytes(16);                         // Varies

                srp = new Srp6(new BigInteger(N), new BigInteger(g));

                // A hack, yes. We just keep trying till we get an S thats not negative so we get rid of auth=4 error logging on.
                BigInteger S;
                do
                {
                    a = BigInteger.Random(19 * 8);
                    A = srp.GetA(a);

                    I = Srp6.GetLogonHash(mUsername, mPassword);

                    BigInteger x = Srp6.Getx(Salt, I);
                    BigInteger u = Srp6.Getu(A, B);
                    S = srp.ClientGetS(a, B, x, u);
                }
                while (S < 0);

                K = Srp6.ShaInterleave(S);
                M = srp.GetM(mUsername, Salt, A, B, new BigInteger(K));

                unk = win.ReadByte();


                return true;
            }
            catch (Exception ex)
            {
                BenderCore.Log(LogType.Error, 0, "Unable to handle logon challenge. {0}.", ex.Message);
                return false;
            }
        }

        public void DoLogonProof()
        {
            // Generate CRC/hashes of the Game Files
            byte[] crc_hash = GenerateCrc(crcsalt);


            wout.Write((byte)RLOp.AUTH_LOGON_PROOF);
            wout.Write(A); // 32 bytes
            wout.Write(M); // 20 bytes
            wout.Write(crc_hash); // 20 bytes
            wout.Write((byte)0); // number of keys
            wout.Write((byte)0); // unk (1.11.x)
            wout.Flush();
        }

        private byte[] GenerateCrc(byte[] crcsalt)
        {
            
            Sha1Hash sha1, sha2, sha3;

            byte[] buffer1 = new byte[0x40];
            byte[] buffer2 = new byte[0x40];

            for (int i = 0; i < 0x40; ++i)
            {
                buffer1[i] = 0x36;
                buffer2[i] = 0x5c;
            }

            for (int i = 0; i < crcsalt.Length; ++i)
            {
                buffer1[i] ^= crcsalt[i];
                buffer2[i] ^= crcsalt[i];
            }

            sha1 = new Sha1Hash();
            sha1.Update(buffer1);


            try
            {
                FileStream fs = new FileStream("crc.bin", FileMode.Open, FileAccess.Read);

                byte[] b1 = new byte[fs.Length];
                fs.Read(b1, 0, (int)fs.Length);

                WoWReader wr = new WoWReader(b1);

                int count = 0;
                while (wr.Remaining > 0)
                {
                    UInt32 size = wr.ReadUInt();
                    byte[] b2 = wr.ReadBytes((int)size);
                    sha1.Update(b2);
                    count++;
                }

                fs.Close();

                BenderCore.Log(LogType.System,5, "Count = {0}, A = {1}", count, A);
            }
            catch (Exception e)
            {
                BenderCore.Log(LogType.Error,0, e.Message + " " + e.StackTrace);
            }

            sha2 = new Sha1Hash();
            sha2.Update(buffer2);
            sha2.Update(sha1.Final());

            sha3 = new Sha1Hash();
            sha3.Update(A.getBytes());
            sha3.Update(sha2.Final());
           

            return sha3.Final();
        }

        private bool HandleLogonProof()
        {
            try
            {

                byte op = win.ReadByte();
                AccountStatus error = (AccountStatus)win.ReadByte();

                if (error != AccountStatus.Success)
                {
                    BenderCore.Log(LogType.Error, 0, "Login Proof: Error = {0}", error);
                    return false;
                }

                M2 = win.ReadBytes(20);
                int unknown = win.ReadInt32();
                //UInt16 unk2 = win.ReadUInt16();
                //win.ReadUInt32();

                return true;
            }
            catch (Exception ex)
            {
                BenderCore.Log(LogType.Error, 0, "Unable to parse login proof. {0}", ex.Message);
                return false;
            }
        }
    }
}