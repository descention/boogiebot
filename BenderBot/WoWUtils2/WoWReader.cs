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
using System.IO;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using IcarusBot.Core;

namespace Foole.WoW
{
	public class WoWReader : BinaryReader
	{
		public WoWReader(byte[] Data): base(new MemoryStream(Data))
		{
		}

		public WoWReader(Stream fs) : base(fs)
		{
		}

		public override string ReadString()
		{
			StringBuilder sb = new StringBuilder();
			while (true)
			{
                byte b;
                //if (Remaining > 0)
                    b = ReadByte();
                //else
                //   b = 0;

				if (b == 0) break;
				sb.Append((char)b);
			}
			return sb.ToString();
		}

		public byte[] ReadRemaining()
		{
			MemoryStream ms = (MemoryStream)BaseStream;
			int Remaining = (int)(ms.Length - ms.Position);
			return ReadBytes(Remaining);
		}

		public int Remaining
		{
			get
			{
				MemoryStream ms = (MemoryStream)BaseStream;
				return (int)(ms.Length - ms.Position);
			}
            set
            {
                MemoryStream ms = (MemoryStream)BaseStream;
                if (value <= (ms.Length - ms.Position))
                    ms.Position = value;
            }
		}
        public float ReadFloat()
        {
            return System.BitConverter.ToSingle(ReadBytes(4), 0);
        }


		public byte[] ToArray()
		{
			return ((MemoryStream)BaseStream).ToArray();
		}


        public WoWGuid ReadUnpackedGuid()
        {
            return new WoWGuid(ReadUInt64());
        }

        public WoWGuid ReadPackedGuid()
        {
            WoWGuid guid;
            byte mask = ReadByte();

            if (mask == 0x00)
            {
                return null;
            }

            guid = new WoWGuid(mask, ReadBytes(WoWGuid.BitCount8(mask)));
            return guid;
        }

        public T ReadStruct<T>() where T : struct
        {
            int count = Marshal.SizeOf(typeof(T));
            byte[] readBuffer = ReadBytes(count);
            GCHandle handle = GCHandle.Alloc(readBuffer, GCHandleType.Pinned);
            var ret = (T)Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(T));
            handle.Free();
            return ret;
        }

        public uint ReadUInt()
        {
            return ReadUInt32();
        }

        public int ReadInt()
        {
            return ReadInt32();
        }

        public Location ReadLocation()
        {
            return ReadLocation(true);
        }

        public Location ReadLocation(bool with_orientation)
        {
            Location location;
            
            location = new Location(ReadFloat(), ReadFloat(), ReadFloat());

            if (with_orientation)
                location.Orientation = ReadFloat();

            return location;
        }
	}
}