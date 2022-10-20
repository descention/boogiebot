using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Data;
using Foole.WoW;
using IcarusBot.Core;

// Lecht was here, all hail the pink elephant

namespace BenderBot.Common
{


    partial class BenderCore
    {
        //
        private void Handle_GroupStatPacket(WoWReader packet)
        {
            if (packet.PeekChar() == 0x00)
                packet.ReadByte();
            WoWReader packet2 = packet;
            while (Player.Group == null)
                Thread.Sleep(500);
            WoWGuid guid = packet.ReadPackedGuid();
            UInt32 flags = packet.ReadUInt32();

            int i = 0;
            Groups.GroupMember gmb = null;
            for (;i<Player.Group.Count;i++)
                if (Player.Group[i].PlayerID == guid.GetOldGuid())
                {
                    gmb = Player.Group[i];
                    break;
                }

            if (gmb == null)
            {
                Log(LogType.System, 0, "Got SMSG_PARTY_MEMBER_STATS for unknown player in group.");
                return;
            }

            if ((flags & (UInt32)Groups.UpdateFlags.GROUP_UPDATE_FLAG_ONLINE) > 0)
            {
                Player.Group[i].Flags = packet.ReadByte();
                packet.ReadByte();
            }
            if ((flags & (UInt32)Groups.UpdateFlags.GROUP_UPDATE_FLAG_HEALTH) > 0)
                Player.Group[i].HealthPoints = packet.ReadUInt32();
            if ((flags & (UInt32)Groups.UpdateFlags.GROUP_UPDATE_FLAG_MAXHEALTH) > 0)
                Player.Group[i].MaxHealthPoints = packet.ReadUInt32();
            if ((flags & (UInt32)Groups.UpdateFlags.GROUP_UPDATE_FLAG_POWER_TYPE) > 0)
            {
                switch(packet.ReadByte())
                {
                    case 0x00:
                        Player.Group[i].PowerType = PowerType.Mana;
                        break;
                    case 0x01:
                        Player.Group[i].PowerType = PowerType.Rage;
                        break;
                    case 0x03:
                        Player.Group[i].PowerType = PowerType.Energy;
                        break;
                    case 0x06:
                        Player.Group[i].PowerType = PowerType.RunicPower;
                        break;
                }
            }
            if ((flags & (UInt32)Groups.UpdateFlags.GROUP_UPDATE_FLAG_POWER) > 0)
                Player.Group[i].PowerPoints = packet.ReadUInt16();
            if ((flags & (UInt32)Groups.UpdateFlags.GROUP_UPDATE_FLAG_MAXPOWER) > 0)
                Player.Group[i].MaxPowerPoints = packet.ReadUInt16();
            if ((flags & (UInt32)Groups.UpdateFlags.GROUP_UPDATE_FLAG_LEVEL) > 0)
                Player.Group[i].Level = packet.ReadUInt16();
            if ((flags & (UInt32)Groups.UpdateFlags.GROUP_UPDATE_FLAG_ZONEID) > 0)
                Player.Group[i].ZoneID = packet.ReadUInt16();
            if ((flags & (UInt32)Groups.UpdateFlags.GROUP_UPDATE_FLAG_POSITION) > 0)
            {
                float x = packet.ReadSingle();
                float y = packet.ReadSingle();
                Player.Group[i].Position = new Location(x, y);
            }
            int oldi = i;
            Log(LogType.System, 1, "Updated group member \"{0}\".", Player.Group[i].Name);
            for (i = 0; i < World.Players.Count; i++)
                if (World.Players[i].GUID == guid)
                {
                    World.Players[i].Name = Player.Group[oldi].Name;
                    break;
                }
        }
    }
}
