using System;
using System.Collections.Generic;
using System.Threading;
using Foole.WoW;

namespace BenderBot.Common
{
    // Misc. Packet Handling
    partial class BenderCore
    {
        private void Handle_InitWorldStates(WoWReader wr)
        {
            Log(LogType.NeworkComms,0, "WS: Recieved Init World States..");
            //SMSG_Debug(wr);
        }
                
        ///<summary>
        ///  SMSG_LOGIN_SETTIMESPEED
        ///</summary>
        private void Handle_LoginSetTimeSpeed(WoWReader packet)
        {
            float time = packet.ReadFloat();
            float timeSpeed = packet.ReadFloat();
            Log(LogType.NeworkComms, 0,"WS: Recieved Login SetTimeSpeed (??)..");
            //SMSG_Debug(wr);
        }

        ///<summary>
        ///  SMSG_SPELLLOGEXECUTE
        ///</summary>
        private void Handle_SpellLogExecute(WoWReader packet)
        {
            WoWGuid trainerGuid = new WoWGuid(packet.ReadUInt64());
            UInt32 spellId = packet.ReadUInt32();
            Int32 effectCount = packet.ReadInt32();

            // O shit.   Helllllp
            /* From Wcell
             *            var packet = new RealmPacketOut(RealmServerOpCode.SMSG_SPELLLOGEXECUTE, 37);
            caster.EntityId.WritePacked(packet);
            packet.Write(spellId);
            const int effectCount = 1;
            packet.Write(effectCount);

            for (int i = 0; i < effectCount; i++)
            {
                packet.Write((int)effect);
                const int targetCount = 1; // unsure

                for (int j = 0; j < targetCount; j++)
                {
                    switch (effect)
                    {
                        case SpellEffectType.PowerDrain:
                            {
                                target.EntityId.WritePacked(packet);
                                packet.Write(0);
                                packet.Write(0);
                                packet.Write(0.0f);
                                break;
                            }
                        case SpellEffectType.AddExtraAttacks:
                            {
                                target.EntityId.WritePacked(packet);
                                packet.Write(0);
                                break;
                            }
                        case SpellEffectType.InterruptCast:
                            {
                                packet.Write(0); // spellId of interrupted spell
                                break;
                            }
                        case SpellEffectType.DurabilityDamage:
                            {
                                packet.Write(0);
                                packet.Write(0);
                                break;
                            }
                        case SpellEffectType.OpenLock:
                        case SpellEffectType.OpenLockItem:
                            {
                                if (target is Item)
                                {
                                    target.EntityId.WritePacked(packet);
                                }
                                else
                                {
                                    packet.Write((byte)0);
                                }
                                break;
                            }
                        case SpellEffectType.CreateItem:
                        case SpellEffectType.CreateItem2:
                            {
                                packet.Write(0); // itemId
                                break;
                            }
                        case SpellEffectType.Summon:
                        case SpellEffectType.TransformItem:
                        case SpellEffectType.SummonPet:
                        case SpellEffectType.SummonObjectWild:
                        case SpellEffectType.CreateHouse:
                        case SpellEffectType.Duel:
                        case SpellEffectType.SummonObjectSlot1:
                        case SpellEffectType.SummonObjectSlot2:
                        case SpellEffectType.Unused_SummonObjectSlot3:
                        case SpellEffectType.Unused_SummonObjectSlot4:
                            {
                                if (target is Unit)
                                {
                                    target.EntityId.WritePacked(packet); // summon recipient
                                }
                                else
                                {
                                    packet.Write((byte)0);
                                }
                                break;
                            }
                        case SpellEffectType.FeedPet:
                            {
                                if (target is Item)
                                {
                                    packet.Write(target.EntryId);
                                }
                                else
                                {
                                    packet.Write(0);
                                }
                                break;
                            }
                        case SpellEffectType.DismissPet:
                            {
                                target.EntityId.WritePacked(packet);
                                break;
                            }
                        case SpellEffectType.Resurrect:
                        case SpellEffectType.ResurrectFlat:
                            {
                                if (target is Unit)
                                {
                                    target.EntityId.WritePacked(packet);
                                }
                                else
                                {
                                    packet.Write((byte)0);
                                }
                                break;
                            }

                    }
                }
            }

            return packet;
        }
             * 
             *    public enum SpellEffectType
    {
        None = 0,
        InstantKill = 1,
        SchoolDamage = 2,
        Dummy = 3,
        Unused_PortalTeleport = 4,
        TeleportUnits = 5,
        //
        // Summary:
        //     MiscValue: AuraId MiscValueB: StatType
        ApplyAura = 6,
        EnvironmentalDamage = 7,
        PowerDrain = 8,
        HealthLeech = 9,
        Heal = 10,
        Bind = 11,
        Portal = 12,
        Unused_RitualBase = 13,
        Unused_RitualSpecialize = 14,
        Unused_RitualActivatePortal = 15,
        QuestComplete = 16,
        WeaponDamageNoSchool = 17,
        Resurrect = 18,
        AddExtraAttacks = 19,
        Dodge = 20,
        Evade = 21,
        Parry = 22,
        Block = 23,
        CreateItem = 24,
        Weapon = 25,
        Defense = 26,
        PersistantAreaAura = 27,
        //
        // Summary:
        //     MiscValue: Pet entry MiscValueB: Index in SummonProperties.dbc
        Summon = 28,
        Leap = 29,
        Energize = 30,
        WeaponPercentDamage = 31,
        TriggerMissile = 32,
        OpenLock = 33,
        TransformItem = 34,
        //
        // Summary:
        //     Mobile AreaAura.  Totems and Paladins mostly
        ApplyAreaAura = 35,
        LearnSpell = 36,
        SpellDefense = 37,
        Dispel = 38,
        Language = 39,
        DualWeild = 40,
        Unused_SummonWild = 41,
        Unused_SummonGuardian = 42,
        TeleportUnitsFaceCaster = 43,
        SkillStep = 44,
        AddHonor = 45,
        Spawn = 46,
        TradeSkill = 47,
        Stealth = 48,
        Detect = 49,
        SummonObject = 50,
        Unused_ForceCriticalHit = 51,
        Unused_GuaranteeHit = 52,
        EnchantItem = 53,
        EnchantItemTemporary = 54,
        TameCreature = 55,
        SummonPet = 56,
        LearnPetSpell = 57,
        WeaponDamage = 58,
        OpenLockItem = 59,
        Proficiency = 60,
        SendEvent = 61,
        PowerBurn = 62,
        Threat = 63,
        TriggerSpell = 64,
        ApplyAreaAura2 = 65,
        CreateManaGem = 66,
        HealMaxHealth = 67,
        InterruptCast = 68,
        Distract = 69,
        Pull = 70,
        Pickpocket = 71,
        AddFarsight = 72,
        Unused_SummonPossessed = 73,
        //
        // Summary:
        //     MiscValue = GlyphProperties.dbc
        ApplyGlyph = 74,
        HealMechanical = 75,
        SummonObjectWild = 76,
        ScriptEffect = 77,
        Attack = 78,
        Sanctuary = 79,
        AddComboPoints = 80,
        CreateHouse = 81,
        BindSight = 82,
        Duel = 83,
        Stuck = 84,
        SummonPlayer = 85,
        ActivateObject = 86,
        Unused_SummonTotemSlot1 = 87,
        Unused_SummonTotemSlot2 = 88,
        Unused_SummonTotemSlot3 = 89,
        Unused_SummonTotemSlot4 = 90,
        Unused_ThreatAll = 91,
        EnchantHeldItem = 92,
        Unused_SummonPhantasm = 93,
        SelfResurrect = 94,
        Skinning = 95,
        Charge = 96,
        Unused_SummonCritter = 97,
        KnockBack = 98,
        Disenchant = 99,
        Inebriate = 100,
        FeedPet = 101,
        DismissPet = 102,
        Reputation = 103,
        SummonObjectSlot1 = 104,
        SummonObjectSlot2 = 105,
        Unused_SummonObjectSlot3 = 106,
        Unused_SummonObjectSlot4 = 107,
        DispelMechanic = 108,
        SummonDeadPet = 109,
        DestroyAllTotems = 110,
        DurabilityDamage = 111,
        Unused_SummonDemon = 112,
        ResurrectFlat = 113,
        AttackMe = 114,
        DurabilityDamagePercent = 115,
        SkinPlayerCorpse = 116,
        SpiritHeal = 117,
        Skill = 118,
        ApplyPetAura = 119,
        TeleportGraveyard = 120,
        NormalizedWeaponDamagePlus = 121,
        //
        // Summary:
        //     Unused
        Unused_Effect_122 = 122,
        //
        // Summary:
        //     Scripted Event?
        Video = 123,
        //
        // Summary:
        //     Pulls the target towards the caster
        PlayerPull = 124,
        ReduceThreatPercent = 125,
        //
        // Summary:
        //     Spellsteal
        StealBeneficialBuff = 126,
        Prospecting = 127,
        ApplyStatAura = 128,
        ApplyStatAuraPercent = 129,
        //
        // Summary:
        //     Effect 3 of spell 34477, Misdirection
        Effect_130 = 130,
        Effect_131 = 131,
        //
        // Summary:
        //     Unused
        Effect_132 = 132,
        ForgetSpecialization = 133,
        Effect_134 = 134,
        Effect_135 = 135,
        //
        // Summary:
        //     Heal %?
        RestoreHealthPercent = 136,
        RestoreManaPercent = 137,
        //
        // Summary:
        //     Something about leaping
        Effect_138 = 138,
        //
        // Summary:
        //     Unused
        Unused_Effect_139 = 139,
        Effect_140 = 140,
        Effect_141 = 141,
        //
        // Summary:
        //     Deals with branching targets
        Effect_142 = 142,
        //
        // Summary:
        //     Soul link and Demonic Knowledge
        ApplyAuraToMaster = 143,
        Effect_144 = 144,
        Effect_145 = 145,
        ActivateRune = 146,
        QuestFail = 147,
        Unused_Effect_148 = 148,
        Effect_149 = 149,
        Unused_Effect_150 = 150,
        TriggerRitualOfSummoning = 151,
        //
        // Summary:
        //     Spell 45927, Alows you to summon your Refer-A-Friend.
        SummonReferAFriend = 152,
        //
        // Summary:
        //     Tame Creature
        Effect_153 = 153,
        Unused_154 = 154,
        EnableTitanGrip = 155,
        AddPrismaticGem = 156,
        CreateItem2 = 157,
        Milling = 158,
        RenamePet = 159,
        Effect_160 = 160,
        SetNumberOfTalentGroups = 161,
        ActivateTalentGroup = 162,
        End = 163,

        */


            Log(LogType.NeworkComms, 0,"WS: Recieved Spell Log Execute..");
            //SMSG_Debug(wr);
        }
        public bool newWorld = false;
        public bool WaitForWarden = false;
        private void Handle_NewWorld(WoWReader wr)
        {
            EngineInited = false;
            CurrentPlayer obj = Player;
            UInt32 mapid = wr.ReadUInt();
            obj.MapId = mapid;
            World.zoned(mapid);          // Tell World we zoned, and give new mapid
            obj.Location = new Location(wr.ReadSingle(), wr.ReadSingle(), wr.ReadSingle(), wr.ReadSingle());
            RealMover.Position = obj.Location;
            //WaitForWarden = true;
            WoWWriter ww = new WoWWriter(OpCode.CMSG_CANCEL_TRADE);
            Send(ww);
            Send(ww);
            ww = new WoWWriter(OpCode.MSG_MOVE_WORLDPORT_ACK);
            Send(ww);
            newWorld = true;

            Log(LogType.System, 0,"Got worldport for mapid: {0} xyz: {1} {2} {3}", mapid, obj.Location.X, obj.Location.Y, obj.Location.Z);
        }

        
        ///<summary>
        ///  SMSG_LIST_INVENTORY
        ///</summary>
        private void Handle_VendorInventoryList(WoWReader packet)
        {
            UInt64 vendorGuid =  packet.ReadUInt64();
            Byte numItems = packet.ReadByte();
            List<Npc.VendorItems> items = new List<Npc.VendorItems>();
            for (int i = 0; i < numItems; i++)
            {
                items.Add(packet.ReadStruct<Npc.VendorItems>());
            }

            GenericEvent.Raise(this, new EventArgs<GenericEventArgs>(new GenericEventArgs("VendorInventory", items)));
            //VendorInventory.Raise(this, new EventArgs<List<Npc.VendorItems>>(items));
            ReceivedVendorList = true;
        }

        public bool ReceivedVendorList { get; set; }

        //public EventHandler<EventArgs<List<Npc.VendorItems>>> VendorInventory { get; set; }



        ///<summary>
        ///  
        ///</summary>
        public void Query_Item_Single(UInt32 id)
        {
            WoWWriter ww = new WoWWriter(OpCode.CMSG_ITEM_QUERY_SINGLE);
            ww.Write(id);
            ww.Write((UInt64)0);
            Send(ww);
        }
    }
}