using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using System.Timers;
using System.IO;
using System.Collections.Generic;
using System.Threading;

using Foole.Crypt;
using Foole.Utils;
using Foole.WoW;
using System.Text;
using Data;

namespace BenderBot.Common
{
    public struct CharEquipment
    {
        public UInt32 EntryID;
        public byte Type;
    }

    partial class BenderCore
    {
        // Lecht - Bastardized algorithm for calcing the UInt64 in CMSG_AUTH_SESSION =P
        // 3.2.2
        private UInt64 Calculation(string AccountName, uint[] serverState, uint shuffleCount)
        {
            byte[] digest;
            UInt64 unkUL = 0;
            while (true)
            {
                Sha1Hash sha = new Sha1Hash();
                sha.Update(AccountName);
                for (int i = 0; i < 4; i++)
                    sha.Update(serverState[i]);
                sha.Update(BitConverter.GetBytes(unkUL));
                digest = sha.Final();
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
                unkUL++;

            }
            return unkUL;
        }

        private void Handle_AuthRequest(WoWReader wr)
        {
            Log(LogType.System,0, "WS: Recieved Authentication Challenge: Sending out response");
            uint shuffleCount = wr.ReadUInt(); // Lecht - 3.2.2
            ServerSeed = wr.ReadUInt();

            uint serverState1 = wr.ReadUInt();
            uint serverState2 = wr.ReadUInt();
            uint serverState3 = wr.ReadUInt();
            uint serverState4 = wr.ReadUInt();

            ClientSeed = (UInt32)random.Next();



            Sha1Hash sha = new Sha1Hash();
            sha.Update(mUsername);
            sha.Update(0); // t
            sha.Update(ClientSeed);
            sha.Update(ServerSeed);
            sha.Update(Key);
            byte[] Digest = sha.Final();

            WoWWriter ww = new WoWWriter(OpCode.CMSG_AUTH_SESSION);
            ww.Write(9947);
            ww.Write((UInt32)0);
            ww.Write(mUsername);
            ww.Write((UInt32)0);
            ww.Write(ClientSeed);
            ww.Write((UInt64)Calculation(mUsername, new uint[] { serverState1, serverState2, serverState3, serverState4}, shuffleCount)); // Lecht - 3.2.2
            ww.Write(Digest);


            ww.Write(0); // Addon Info (0 = none)

            Send(ww);

            packetCrypt = new PacketCrypt(Key);


#if WARDEN
            // Initiate Warden Encryption
            ww = new WoWWriter();
            ww.Write((byte) 0);
            ww.Write((UInt16) 40);
            ww.Write(Key);
            try
            {
                SendWarden(ww.ToArray());
            }
            catch (Exception) { }
#endif
        }

        private void Handle_AuthResponse(WoWReader wr)
        {
            byte error = wr.ReadByte();
            if (error != 0x0C)
            {
                Log(LogType.Error, 0,"WS: Authentication Failed: Error = {0}", error);
                return;
            }
            Log(LogType.System,0, "WS: Authentication Successful!");

        }

        private void Handle_CharEnum(WoWReader wr)
        {
            // FIND TEH PANK ELEPHENT
            Log(LogType.NeworkComms, 1, "WS: Recieved Character List..");
            byte count = wr.ReadByte();

            //temporary local collection, so that other classes don't see the list until the list is fully populated.
            List<Character> characters = new List<Character>();

            for (int i = 0; i < count; i++)
            {
                Character character = new Character();
                characters.Add(character);
                character.GUID = wr.ReadUInt64();
                character.Name = wr.ReadString();
                character.Race = wr.ReadByte();
                character.Class = wr.ReadByte();
                character.Gender = wr.ReadByte();
                character.Skin = wr.ReadByte();
                character.Face = wr.ReadByte();
                character.HairStyle = wr.ReadByte();
                character.HairColor = wr.ReadByte();
                character.FacialHair = wr.ReadByte();
                character.Level = wr.ReadByte();
                character.ZoneID = wr.ReadUInt();
                character.MapID = wr.ReadUInt();
                character.X = wr.ReadFloat();
                character.Y = wr.ReadFloat();
                character.Z = wr.ReadFloat();
                character.Guild = wr.ReadUInt();
                character.Unk = wr.ReadUInt();
                character.RestState = wr.ReadByte();
                character.PetInfoID = wr.ReadUInt();
                character.PetLevel = wr.ReadUInt();
                character.PetFamilyID = wr.ReadUInt();

                CharEquipment[] equip = new CharEquipment[20];

                for (int x = 0; x < 20; x++)
                {
                    equip[x].EntryID = wr.ReadUInt();
                    equip[x].Type = wr.ReadByte();
                    wr.ReadUInt(); // enchant (2.4 patch)
                }

                //wrong number of chars to get to second char?
                wr.ReadByte();
                wr.ReadByte();
                wr.ReadByte();
                wr.ReadByte();

                character.Equipment = equip;

                Log(LogType.NeworkComms, 2, "Found Character {0} {1} {2} {3}", character.Name, character.Level, character.Race, character.Class);
            }
            Characters = characters;

            Log(LogType.NeworkComms, 1, "{0} characters in total.", Characters.Count);
        }

        public void WorldZone(UInt64 guid)
        {
            WoWWriter ww = new WoWWriter(OpCode.CMSG_PLAYER_LOGIN);
            ww.Write(guid);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_NAME_QUERY);
            ww.Write(guid);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_SET_ACTIVE_MOVER);
            ww.Write(guid);
            Send(ww);
        }

        public void LoginChar(Character character)
        {
            var ww = new WoWWriter(OpCode.CMSG_PLAYER_LOGIN);
            ww.Write(character.GUID);
            Send(ww);

            ww = new WoWWriter(OpCode.CMSG_Unknown1);
            ww.Write((byte)0x00);
            Send(ww);
            
        }

    }
}
