
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Xml;
using System.Timers;
using System.IO;

using Foole.Crypt;
using Foole.Utils;
using Foole.WoW;

namespace BenderBot.Common
{


   
    partial class BenderCore
    {
        WowObject currentTarget;

        public void CastSpell(uint spellId)
        {
            WoWWriter wr;
            wr = new WoWWriter(OpCode.CMSG_CAST_SPELL);
            wr.Write(++SpellCounter);
            wr.Write(spellId);
            wr.Write((byte)0); // unk flags in WCell
            wr.Write((UInt32)0);
            Send(wr);
        }

        ///<summary>
        ///  
        ///</summary>
        public void CastSpell(uint spellId, WowObject target)
        {
            currentTarget = target;

            Log(LogType.Combat, 1, "Sending CastSpell {0} on {1} (GUID: {2})", spellId, target.Name, target.GUID.GetOldGuid());

            SpellTargetFlags flags;
            WoWWriter wr;

            if (target == Player)
                flags = SpellTargetFlags.Self;
            else
            {
                flags = SpellTargetFlags.Unit;
                //Target(target as Unit);
            }

            wr = new WoWWriter(OpCode.CMSG_CAST_SPELL);
            wr.Write(++SpellCounter);
            wr.Write(spellId);
            wr.Write((byte)0); // unk flags in WCell

            wr.Write((UInt32)flags);

            // 0x18A02
            if (flags.Has(SpellTargetFlags.Flag_0x10000 | SpellTargetFlags.Corpse | SpellTargetFlags.Object |
                SpellTargetFlags.PvPCorpse | SpellTargetFlags.Unit))
            {
                wr.Write(target.GUID.PackedGuid());
            }

            // 0x1010
            if (flags.Has(SpellTargetFlags.TradeItem | SpellTargetFlags.Item))
            {
                wr.Write(target.GUID.PackedGuid());
            }

            // 0x20
            if (flags.Has(SpellTargetFlags.SourceLocation))
            {
                wr.Write(Player.Location.X);
                wr.Write(Player.Location.Y);
                wr.Write(Player.Location.Z);
            }

            // 0x40
            if (flags.Has(SpellTargetFlags.DestinationLocation))
            {
                wr.Write(target.GUID.PackedGuid());

                wr.Write(target.Location.X);
                wr.Write(target.Location.Y);
                wr.Write(target.Location.Z);

            }
            // 0x2000
            if (flags.Has(SpellTargetFlags.String))
            {
                // ?? nfi what the hell this is for.
            }


            // NFI what this is either.
            /*if ((unkFlags & 2) != 0)
            {
                float f1 = packet.ReadFloat();
                float f2 = packet.ReadFloat();
                byte b1 = packet.ReadByte();
                // here the client appends a MSG_MOVE_STOP movement packet
            }*/



            Send(wr);
        }

        public bool WeaponSheathed { get; set; }

        public void Attack(Unit target)
        {
            if (WeaponSheathed)
            {
                UnSheathWeapon();
                WeaponSheathed = false;
            }
            var wr = new WoWWriter(OpCode.CMSG_ATTACKSWING);
            wr.Write(target.GUID.GetOldGuid());
            Send(wr);
        }

        public void SheathWeapon()
        {
            var wr = new WoWWriter(OpCode.CMSG_SETSHEATHED);
            wr.Write((uint)0);
            Send(wr);
        }

        public void UnSheathWeapon()
        {
            var wr = new WoWWriter(OpCode.CMSG_SETSHEATHED);
            wr.Write(0x01000000);
            Send(wr);
        }


        //private void Handle_AttackStart(WoWReader wr)
        //{
        //    WoWGuid guid = wr.ReadUnpackedGuid();
        //    Unit unit = World.GetObject(guid) as Unit;

        //    guid = wr.ReadUnpackedGuid();
        //    Unit enemy = World.GetObject(guid) as Unit;

        //    if (unit != null)
        //    {
        //        lock (unit)
        //        {
        //            //unit.IsInCombat = true;
        //        }

        //        Log(LogType.Combat, 1, "{0} entered combat with {1}", unit, enemy!=null?enemy.ToString(): "!unknown!");
        //    }
        //}

        //private void Handle_AttackStop(WoWReader wr)
        //{
        //    WoWGuid guid = wr.ReadPackedGuid();
        //    Unit unit = World.GetObject(guid) as Unit;

        //    guid = wr.ReadPackedGuid();

        //    Unit enemy = World.GetObject(guid) as Unit;
        //    if (unit != null)
        //    {
        //        lock (unit)
        //        {
        //            unit.IsInCombat = false;
        //        }
        //        Log(LogType.Combat, 1, "{0} dropped combat with {1}", unit, enemy != null ? enemy.ToString() : "!unknown!");
        //    }
        //}

        ///<summary>
        ///  SMSG_CAST_FAILED
        ///</summary>
        private void Handle_SpellFailed(WoWReader wr)
        {
            byte cast_id = wr.ReadByte();
            UInt32 spell_id = wr.ReadUInt();
            SpellFailedReason reason = (SpellFailedReason)wr.ReadByte();
            lock (Player)
            {
                if (reason != SpellFailedReason.SpellInProgress)
                    Player.Casting = null;

                Player.LastSpellStatus = reason;
            }

            /*if (reason == SpellFailedReason.TargetsDead)
            {
                LootObject(currentTarget);
            }*/

            Log(LogType.Error, 1, "Failed to cast spell id: {0} for reason: {1} (cast_id: {2})", spell_id, reason, cast_id);
        }


        ///<summary>
        /// SMSG_SPELL_START
        ///</summary>
        public void Handle_SpellStart(WoWReader wr)
        {
            WoWGuid guid = wr.ReadPackedGuid();
            wr.ReadPackedGuid();
            byte castId = wr.ReadByte();
            uint spellId = wr.ReadUInt();

            WowObject caster = World.GetObject(guid);
            Unit casterUnit = caster as Unit;

            if (casterUnit != null )
            {

                SpellItem spell = SpellItem.GetSpell(spellId);
                casterUnit.Casting = spell;

                if (casterUnit == Player)
                    Player.Casting = spell;

                int severity = 2;

                if (casterUnit.Target == Player)
                    severity = 0;

                Log(LogType.Combat, severity, "{0} started casting {1} (Cast ID: {2} - Spell ID: {3})", casterUnit, spell, castId, spellId);
                casterUnit.GenericRaise(ref casterUnit.CastSpell, spell);
            }
            else
            {
                Log(LogType.Combat, 0, "GUID {0} started casting (Cast ID: {1} - Spell ID: {2})", casterUnit, castId, spellId);
            }
        }

        ///<summary>
        ///  
        ///</summary>
        public void Handle_SpellGo(WoWReader wr)
        {
            WoWGuid guid = wr.ReadPackedGuid();

            WowObject caster = World.GetObject(guid);
            Unit casterUnit = caster as Unit;
            if (casterUnit != null)
            {

                WoWGuid guid2 = wr.ReadPackedGuid();

            
                byte castid = wr.ReadByte();

                SpellItem spell = SpellItem.GetSpell((uint)wr.ReadInt());

                if (casterUnit.Casting == spell)
                    casterUnit.Casting = null;

                int prio =2;

                if (casterUnit == Player)
                    prio = 0;

               

                Log(LogType.Combat, prio, "{0} finished casting {1}", casterUnit, spell);

            }


        }
    }
}
