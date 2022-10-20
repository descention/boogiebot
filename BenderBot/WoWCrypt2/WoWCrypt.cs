/*
 * Copyright ¸ 2005 Kele (fooleau@gmail.com)
 * This library is free software; you can redistribute it and/or 
 * modify it under the terms of the GNU Lesser General Public 
 * License version 2.1 as published by the Free Software Foundation
 * (the "LGPL").
 * This software is distributed on an "AS IS" basis, WITHOUT WARRANTY
 * OF ANY KIND, either express or implied.
 */

using System;
using System.Security.Cryptography;

namespace Foole.Crypt
{
	/// <summary>
	/// This class handles the encryption that is done on the headers of world server packets.
	/// The Key is 20 bytes long
	/// </summary>
    /// 
    public class PacketCrypt
    {
        /// <summary>
        /// This is the key the client uses to encrypt its packets
        /// This is also the key the server uses to decrypt the packets
        /// </summary>
        private static readonly byte[] ServerDecryptionKey =
            {
                0xF4, 0x66, 0x31, 0x59, 0xFC, 0x83, 0x6E, 0x31,
                0x31, 0x02, 0x51, 0xD5, 0x44, 0x31, 0x67, 0x98
            };

        /// <summary>
        /// This is the key the client uses to decrypt server packets
        /// This is also the key the server uses to encrypt the packets
        /// </summary>
        private static readonly byte[] ServerEncryptionKey =
            {
                0x22, 0xBE, 0xE5, 0xCF, 0xBB, 0x07, 0x64, 0xD9,
                0x00, 0x45, 0x1B, 0xD0, 0x24, 0xB8, 0xD5, 0x45
            };

        // This is valid as HMAC-SHA1 transforms can be reused
        static readonly HMACSHA1 s_decryptClientDataHMAC = new HMACSHA1(ServerDecryptionKey);
        static readonly HMACSHA1 s_encryptServerDataHMAC = new HMACSHA1(ServerEncryptionKey);

        /// <summary>
        /// Decrypts data from Server
        /// </summary>
        private readonly ARC4 InData;
        /// <summary>
        /// Encrypts data for server
        /// </summary>
        private readonly ARC4 OutData;

        public PacketCrypt(byte[] sessionKey)
        {
            byte[] encryptHash = s_encryptServerDataHMAC.ComputeHash(sessionKey);
            byte[] decryptHash = s_decryptClientDataHMAC.ComputeHash(sessionKey);

            // Used by the client to decrypt packets sent by the server
            InData = new ARC4(encryptHash); // CLIENT-SIDE
            // Used by the server to decrypt packets sent by the client
            var decryptClientData = new ARC4(decryptHash); // SERVER-SIDE
            // Used by the server to encrypt packets sent to the client
            var encryptServerData = new ARC4(encryptHash); // SERVER-SIDE
            // Used by the client to encrypt packets sent to the server
            OutData = new ARC4(decryptHash); // CLIENT-SIDE

            // Use the 2 encryption objects to generate a common starting point
            var syncBuffer = new byte[1024];
            encryptServerData.Process(syncBuffer, 0, syncBuffer.Length);
            InData.Process(syncBuffer, 0, syncBuffer.Length);

            // Use the 2 decryption objects to generate a common starting point
            syncBuffer = new byte[1024];
            OutData.Process(syncBuffer, 0, syncBuffer.Length);
            decryptClientData.Process(syncBuffer, 0, syncBuffer.Length);
        }

        public void Decrypt(byte[] data, int start, int count)
        {
            InData.Process(data, start, count);
        }

        public void Encrypt(byte[] data, int start, int count)
        {
            OutData.Process(data, start, count);
        }
    }
    public class PacketKeyGenerator
    {
        static readonly byte[] SeedKey = { 0x38, 0xA7, 0x83, 0x15, 0xF8, 0x92, 0x25, 0x30, 0x71, 0x98, 0x67, 0xB1, 0x8C, 0x4, 0xE2, 0xAA };

        public static byte[] GenerateKey(byte[] sessionKey)
        {
            byte[] firstBuffer = new byte[64];
            byte[] secondBuffer = new byte[64];

            memset(firstBuffer, 0x36);
            memset(secondBuffer, 0x5C);

            for (int i = 0; i < SeedKey.Length; i++)
            {
                firstBuffer[i] = (byte)(SeedKey[i] ^ firstBuffer[i]);
                secondBuffer[i] = (byte)(SeedKey[i] ^ secondBuffer[i]);
            }

            Sha1Hash sha = new Sha1Hash();

            sha.Update(firstBuffer);
            sha.Update(sessionKey);

            byte[] tempDigest = sha.Final();

            sha = new Sha1Hash();

            sha.Update(secondBuffer);
            sha.Update(tempDigest);

            byte[] finalKey = sha.Final();

            return finalKey;
        }

        private static void memset(byte[] buffer, byte value)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = value;
            }
        }
    }
	public class WoWCrypt
	{

       
		private bool mInitialised = false;
		
		// Encryption state
		private byte mEncPrev;
		public int mEncIndex;
		// Decryption state
		public byte mDecPrev; 
		public int mDecIndex;

		public byte[] mKey;

	    private static object LockObject;

		public void Init(byte[] Key)
		{
            mKey = PacketKeyGenerator.GenerateKey(Key);
			mInitialised = true;
		}
        public byte GetDecPrev()
        {
            return mDecPrev;
        }
        public void SetDecPrev(byte SetTo)
        {
            mDecPrev = SetTo;
        }
        public int GetDecIndex()
        {
            return mDecIndex;
        }
        public void SetDecIndex(int SetTo)
        {
            mDecIndex = SetTo;
        }
		public void Decrypt(byte[] Data, int Length)
		{
			if (mInitialised == false) return;

            lock (LockObject)
            {
                for (int i = 0; i < Length; ++i)
                {
                    byte x = (byte) ((Data[i] - mDecPrev) ^ mKey[mDecIndex]);
                    ++mDecIndex;
                    mDecIndex %= mKey.Length;
                    mDecPrev = Data[i];
                    Data[i] = x;
                }
            }
		}

		public void Encrypt(byte[] Data, int Length)
		{
			if (mInitialised == false) return;

            lock (LockObject)
            {
                for (int i = 0; i < Length; ++i)
                {
                    byte x = (byte) ((Data[i] ^ mKey[mEncIndex]) + mEncPrev);
                    ++mEncIndex;
                    mEncIndex %= mKey.Length;
                    mEncPrev = x;
                    Data[i] = x;
                }
            }
		}
	}
}
