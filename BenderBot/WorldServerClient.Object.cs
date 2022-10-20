#define DEBUG
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Xml;
using System.Timers;
using System.IO;
using System.Linq;


using Foole.Crypt;
using Foole.Utils;
using Foole.WoW;

using WCell.Constants;



namespace BenderBot.Common
{

    // WoWObject Packet Handling
    partial class BenderCore
    {

        private byte LootableItems = 0;

        private void HandleUpdateBlock(UpdateBlock block)
        {
            
        }

        private uint[] GetIndiceValues(byte[]array)
        {
            WoWReader wr = new WoWReader(array);
            var list = new List<uint>();

            while (wr.Remaining != 0)
                list.Add(wr.ReadUInt32());
            return list.ToArray();
        }

        public WoWGuid EntityToGuid(EntityId id)
        {
            BinaryWriter bw = new BinaryWriter(new MemoryStream());
            int len = id.WritePacked(bw);
            bw.BaseStream.Position = 0;
            var wr = new WoWReader(bw.BaseStream);
            WoWGuid guid = wr.ReadPackedGuid();
            return guid;
        }

        private void Handle_ObjUpdate(WoWReader wr, bool Compressed)
        {
            if (Compressed)
            {
                Int32 size = wr.ReadInt();
                byte[] decomped = Foole.Utils.Compression.Decompress(size, wr.ReadRemaining());
                wr = new WoWReader(decomped);
            }

            
            UInt32 blockCount;
            IcarusBot.Core.UpdateType blockType;
            IcarusBot.Core.ObjectTypeId objTypeId;

            blockCount = wr.ReadUInt();

            for (UInt32 i = 0; i < blockCount; i++)
            {
                blockType = (IcarusBot.Core.UpdateType)wr.ReadByte();
#if (DEBUG)
                Log(LogType.NeworkComms, 5, "Block #{0}/{1} Type: {2}", i + 1, blockCount, blockType);
#endif

                switch (blockType)
                {
                    case IcarusBot.Core.UpdateType.Values: // Fields update
                        {
                            byte mask = wr.ReadByte();

                            if (mask == 0x00)
                                break;

                            guid = new WoWGuid(mask, wr.ReadBytes(WoWGuid.BitCount8(mask)));

                            UpdateMask UpdateMask = new UpdateMask();
                            byte bc = wr.ReadByte(); // Block Count

                            UpdateMask.SetCount((ushort)(bc * 32));
                            UpdateMask.SetMask(wr.ReadBytes(bc * 4), bc);

                            Log(LogType.NeworkComms, 5, "Field Update! FieldCount: {0}", UpdateMask.GetCount());

                            UInt32[] Fields = new UInt32[UpdateMask.GetCount()];

                            WowObject obj = World.GetObject(guid);

                            if (obj == null)
                            {
                                Log(LogType.Error, 0, "Object with the guid {0} not recognized in field update.", guid.GetOldGuid());
                            }
                            else
                            {
                                for (ushort x = 0; x < UpdateMask.GetCount(); x++)
                                {
                                    if (UpdateMask.GetBit(x))
                                        if (obj == null) // FixMe
                                            wr.ReadUInt();
                                        else
                                            obj.SetUField(x, wr.ReadUInt());
                                }

                                CurrentPlayer cp = obj as CurrentPlayer;
                                Player p = obj as Player;
                                Unit u = obj as Unit;

                                if (cp != null)
                                {
                                    cp.Update(this);
                                    FireUpdatePlayer();
                                }
                                else
                                    if (p != null)
                                    {
                                        p.Update(this);
                                    }
                                    else
                                        if (u != null)
                                            u.Update(this);
                                        else
                                            obj.Update(this);



                            }
                            break;
                        }
                    case IcarusBot.Core.UpdateType.Movement: // Movement Update
                        {
                            byte mask = wr.ReadByte();

                            if (mask == 0x00)
                                break;

                            guid = new WoWGuid(mask, wr.ReadBytes(WoWGuid.BitCount8(mask)));

                            //Log(LogType.NeworkComms, 2, "Got Movement update for GUID {0}", guid);

                            ushort flags = wr.ReadUInt16();
                            MovementBlock mb = new MovementBlock(this, ref wr, flags);

                            if (World.GetObject(guid) != null)
                                World.GetObject(guid).MoveBlock = mb;

                            break;
                        }

                    case IcarusBot.Core.UpdateType.Create: // ObjCreate
                    case IcarusBot.Core.UpdateType.CreateSelf: // ObjCreate
                        {
                            guid = wr.ReadPackedGuid();

                            objTypeId = (IcarusBot.Core.ObjectTypeId)wr.ReadByte();

                            Log(LogType.NeworkComms, 10, "Got Object Create Mask: GUID: {0} ObjTypeID: {1} ", guid, objTypeId);

                            ushort flags = wr.ReadUInt16();

                            //Log(LogType.System, 0, "Adding new Object {0} Flags: {1}", guid, flags);

                            MovementBlock mb = new MovementBlock(this, ref wr, flags);

                            UpdateMask UpdateMask = new UpdateMask();

                            byte bc = wr.ReadByte(); // Block Count
                            //Log(LogType.NeworkComms, 3, "Block Count = {0}, Mask = {1}, flags = {2}", bc * 32, mask, flags);


                            UpdateMask.SetCount((ushort)(bc * 32));
                            UpdateMask.SetMask(wr.ReadBytes(bc * 4), bc);


                            if (objTypeId == IcarusBot.Core.ObjectTypeId.GameObject)
                            {
                                //Log(LogType.System, 0, "Object {0} {1} {2} {3}", mb.X, mb.Y, mb.Z, (flags & 0x40));
                                int count = UpdateMask.GetCount();
                                if (count > 256)
                                {
                                    //Log(LogType.Error, 0, "Got update fields for a GameObject > GO_END ({0} > {1})", count, (int)UpdateFields.GAMEOBJECT_END);
                                    return;
                                }
                            }
                            if (objTypeId == IcarusBot.Core.ObjectTypeId.Unit)
                            {
                                int count = UpdateMask.GetCount();
                                if (count > 256)
                                {
                                   // Log(LogType.Error, 0, "Got update fields for a Unit > UNIT_END ({0} > {1})", count, (int)UpdateFields.UNIT_END);
                                    return;
                                }
                            }
                            if (objTypeId == IcarusBot.Core.ObjectTypeId.Player)
                            {
                                int count = UpdateMask.GetCount();
                                if (count > 1750)
                                {
                                  //  Log(LogType.Error, 0, "Got update fields a Player > PLAYER_END ({0} > {1})", count, (int)UpdateFields.PLAYER_END);
                                    return;
                                }
                            }

                            UInt32[] Fields = new UInt32[UpdateMask.GetCount()];

                            for (ushort x = 0; x < UpdateMask.GetCount(); x++)
                            {
                                if (UpdateMask.GetBit(x))
                                    Fields[x] = wr.ReadUInt();
                            }

                            if (blockType == IcarusBot.Core.UpdateType.CreateSelf)
                            {
                                RealMover.MovementFlags = mb.Flags;

                                //lock (Player)
                                //{
                                //    Player.Location = new Location(mb.X, mb.Y, mb.Z, mb.Facing);
                                //}

                                /*lock (Player)
                                {
                                    Player.Location = new Location(mb.X, mb.Y, mb.Z, mb.Facing);
                                }*/

                                
                                
            
                            }

                            if (objTypeId == IcarusBot.Core.ObjectTypeId.Item)
                            {

                                uint templateId = Fields[(int)ObjectFields.ENTRY];

                                var item = (from u in Player.Inventory.AllItems
                                            where u.GUID == guid
                                            select u).FirstOrDefault();

                                if (item == null)
                                {
                                    item = new Item(this, guid, objTypeId, Fields, mb);
                                   // item.TemplateId = templateId;
                                    item.Update(this);

                                    Player.Inventory.AllItems.Add(item);
                                    //refresh player, in case equiped items got updated.
                                    Player.Update(this);
                                }

                                
                                if (!ItemTemplate.Templates.ContainsKey(templateId))
                                {
                                    var temp = new ItemTemplate();
                                    temp.Id = templateId;
                                    ItemTemplate.Templates[templateId] = temp;
                                    Query_Item_Single(templateId);
                                    Log(LogType.Unknown, 3, "Querying for item template: {0}", templateId);
                                }

  
                            }
                            else if (objTypeId == IcarusBot.Core.ObjectTypeId.Container)
                            {
                                uint templateId = Fields[(int)ObjectFields.ENTRY];
                                var item = (from o in Player.Inventory.AllItems
                                            where o.GUID == guid
                                            select o).FirstOrDefault();

                                if (item == null)
                                {
                                    item = new Item(this, guid, objTypeId, Fields, mb);
                                    // item.TemplateId = templateId;
                                    item.Update(this);
                                    Player.Inventory.AllItems.Add(item);
                                    //refresh player, in case equiped items got updated.
                                    Player.Update(this);
                                }


                                if (!ItemTemplate.Templates.ContainsKey(templateId))
                                {
                                    var temp = new ItemTemplate();
                                    temp.Id = templateId;
                                    ItemTemplate.Templates[templateId] = temp;
                                    Query_Item_Single(templateId);
                                }
                            }

                            else //dont add inventory items to the world.
                            if (!World.ObjectExists(guid))   // Add new Object
                            {
                                UInt32 entryid = Fields[(int)ObjectFields.ENTRY];

                                if (objTypeId == IcarusBot.Core.ObjectTypeId.Player)
                                {
                                    Player NewPlayer = new Player(this, guid, objTypeId, Fields, mb); // ToDo: Fix MoveBlock!
                                    World.AddPlayer(NewPlayer);
                                    QueryName(guid);
                                    Log(LogType.NeworkComms, 2, "Adding new Player {0}", guid);
                                    NewPlayer.Update(this);
                                }


                                if (objTypeId == IcarusBot.Core.ObjectTypeId.Unit || objTypeId == IcarusBot.Core.ObjectTypeId.GameObject)
                                {

                                    if (EntryList.ContainsKey(entryid) == false && EntryQueue.ContainsKey(entryid) == false)
                                    {
                                        Log(LogType.System, 5, "Querying for name of object with an entry of {0} and type of {1}", entryid, objTypeId);
                                        //EntryQueue.Add(entryid, true);
                                    }
                                    if (objTypeId == IcarusBot.Core.ObjectTypeId.Unit)
                                    {
                                        var newUnit = new Unit(this, guid, objTypeId, Fields, mb); // ToDo: Fix MoveBlock!
                                        World.AddUnit(newUnit);
                                        CreatureQuery(guid, entryid);
                                        Log(LogType.System, 5, "Adding new Unit {0}", guid);
                                        newUnit.Update(this);
                                    }
                                    if (objTypeId == IcarusBot.Core.ObjectTypeId.GameObject)
                                    {
                                        var newObj = new WowObject(this,guid, objTypeId, Fields, mb); // ToDo: Fix MoveBlock!
                                        World.AddObject(newObj);
                                        GameObjectQuery(guid, entryid);
                                        Log(LogType.System, 0, "Adding new GameObject {0} {1} {2} {3}", guid, mb.X, mb.Y, mb.Z);
                                        newObj.Update(this);
                                    }
                                }
                                else
                                {
                                    var newObj = new WowObject(this, guid, objTypeId, Fields, mb);
                                    World.AddObject(newObj);
                                    Log(LogType.System, 0, "Adding new Object {0} Type: {1}", guid, objTypeId);
                                    newObj.Update(this);
                                }

                            }

                            else    // Update Existing Object
                            {
                                WowObject updateObj = World.GetObject(guid);

                                updateObj.MoveBlock = mb;
                                updateObj.InteropFields = Fields;

                                CurrentPlayer cp = updateObj as CurrentPlayer;
                                Player p = updateObj as Player;
                                Unit u = updateObj as Unit;

                                if (cp != null)
                                {
                                    RealMover.Position = new Location(mb.X, mb.Y, mb.Z, mb.Facing);
                                    Log(LogType.System, 0, "Run speed is: {0}", mb.turnRate);
                                    cp.Update(this);
                                    FireUpdatePlayer();
                                }
                                else
                                    if (p != null)
                                        p.Update(this);
                                    else
                                        if (u != null)
                                            u.Update(this);
                                        else
                                            updateObj.Update(this);
                                /*updateObj.Type = flags;
                                updateObj.Fields = Fields; */
                                //World.updateObject(updateObj);
        
                            }
                            break;
                        }
                    case IcarusBot.Core.UpdateType.OutOfRange: // Out Of Range update
                        {
                            UInt32 count = wr.ReadUInt();

                            for (UInt32 j = 0; j < count; j++)
                                World.RemoveObject(wr.ReadPackedGuid());

                            break;
                        }
                }
            }
        }

        private void Handle_ObjDestroy(WoWReader wr)
        {
            WoWGuid guid = new WoWGuid(wr.ReadUInt64());
            int count = Player.Inventory.AllItems.RemoveAll(i => i.GUID == guid);
            if (count > 0)
            {
                Player.Update(this);
            }

            World.RemoveObject(guid);
        }


        private void Handle_HealthUpdate(WoWReader wr)
        {
            WoWGuid guid = wr.ReadPackedGuid();
            uint health = wr.ReadUInt();

            Log(LogType.Combat, 0, "Got health update for {0} - Health: {1}", guid, health);

            WowObject updateObj = World.GetObject(guid);

            updateObj.InteropFields[(uint)UnitFields.HEALTH] = health;

            CurrentPlayer cp = updateObj as CurrentPlayer;
            Player p = updateObj as Player;
            Unit u = updateObj as Unit;

            if (cp != null)
            {
                cp.Update(this);
                FireUpdatePlayer();
            }
            else
                if (p != null)
                    p.Update(this);
                else
                    if (u != null)
                        u.Update(this);
                    else
                        updateObj.Update(this);


        }

        private void Handle_GameObjectQuery(WoWReader wr)
        {
            Entry entry = new Entry();
            entry.entry = wr.ReadUInt();
            if (entry.entry < 1 || wr.Remaining < 4)
            {
                Log(LogType.System, 0,
                    "Got {1} in GameObject query response for entryid or remaining in packet too small {0}",
                    wr.Remaining, entry.entry);
                return;
            }

            entry.Type = (IcarusBot.Core.ObjectTypeId) wr.ReadUInt();
            entry.DisplayID = wr.ReadUInt();
            entry.name = wr.ReadString();

            Log(LogType.NeworkComms, 5, "Got GameObject Query Response - Entry: {0} - Name: {1} - Type {2}", entry.entry,
                entry.name, entry.Type);
            if (EntryList.ContainsKey(entry.entry) == false)
                EntryList.Add(entry.entry, entry);

            if (EntryQueue.ContainsKey(entry.entry))
                EntryQueue.Remove(entry.entry);

            World.Objects.FindAll(o => o.InteropFields[(int) ObjectFields.ENTRY] == entry.entry).ForEach(u =>
                                                                                                             {
                                                                                                                 u.Type
                                                                                                                     =
                                                                                                                     entry
                                                                                                                         .
                                                                                                                         Type;
                                                                                                                 u.Name
                                                                                                                     =
                                                                                                                     entry
                                                                                                                         .
                                                                                                                         name;
                                                                                                             });

        }

        private void Handle_CreatureQuery(WoWReader wr)
        {
            Entry entry = new Entry();
            entry.entry = wr.ReadUInt();
            entry.name = wr.ReadString();
            entry.blarg = wr.ReadBytes(3);
            entry.subname = wr.ReadString();
            entry.flags = wr.ReadUInt();
            entry.subtype = wr.ReadUInt();
            entry.family = wr.ReadUInt();
            entry.rank = wr.ReadUInt();

            Log(LogType.NeworkComms, 2, "Got CreatureQuery Response - Entry: {0} - Name: {1} - SubName {2}", entry.entry, entry.name, entry.subname);
            if (EntryList.ContainsKey(entry.entry) == false)
                EntryList.Add(entry.entry, entry);

            if (EntryQueue.ContainsKey(entry.entry))
                EntryQueue.Remove(entry.entry);

            World.Units.FindAll(o => o.InteropFields[(int)ObjectFields.ENTRY] == entry.entry)
             .ForEach(u =>
             {
                 u.Name = entry.name;
                 u.SubName = entry.subname;
                 u.SubType = entry.subtype;
                 u.Family = entry.family;
                 u.Rank = entry.rank;
             });
        }

        private void Handle_ItemQuery(WoWReader wr, bool multi)
        {
            uint i;
            uint id;

            ItemTemplate item;
            id = wr.ReadUInt();


            if (ItemTemplate.Templates.ContainsKey(id)) 
                item = ItemTemplate.Templates[id];
            else
            {
                item = new ItemTemplate();
                item.Id = id;
                ItemTemplate.Templates[id] = item;
            }

            
            item.ItemId = (ItemId)item.Id;
            item.Class = (ItemClass)wr.ReadUInt();
            item.SubClass = (ItemSubClass)wr.ReadUInt();

            wr.ReadInt(); // unknown

            item.Name = wr.ReadString();
            wr.ReadBytes(3); // Names 2-4?


            Log(LogType.SystemDebug, 0, "Handling item query on item: {0} id: {1} name: {2} class: {3} subclass: {4}", item.ItemId, item.Id, item.Name, item.Class, item.SubClass);

            item.DisplayId = wr.ReadUInt();
            item.Quality = (IcarusBot.Core.ItemQuality)wr.ReadUInt();
            item.Flags = (IcarusBot.Core.ItemFlags)wr.ReadUInt();

            item.BuyPrice = wr.ReadUInt();
            item.Faction = wr.ReadUInt(); // Lecht 3.2.0
            item.SellPrice = wr.ReadUInt();

            item.InventorySlotType = (InventorySlotType)wr.ReadInt();
            item.RequiredClassMask = (IcarusBot.Core.ClassMask)wr.ReadUInt();
            item.RequiredRaceMask = (IcarusBot.Core.RaceMask)wr.ReadUInt();

            item.Level = wr.ReadUInt();
            item.RequiredLevel = wr.ReadUInt();

            item.RequiredSkill = wr.ReadUInt();
            item.RequiredProfession = wr.ReadUInt();
            item.RequiredProfessionId = (SpellId)wr.ReadUInt(); // Lecht 3.2.0 not sure if this is the right property to assign to

            item.RequiredPvPRank = wr.ReadUInt();
            item.UnknownRank = wr.ReadUInt(); // PVP Medal?

            item.RequiredFaction = wr.ReadUInt();
            item.RequiredFactionStanding = (StandingLevel)wr.ReadInt();

            item.UniqueCount = wr.ReadUInt();
            item.MaxAmount = wr.ReadUInt();
            item.ContainerSlots = wr.ReadInt();

            int modCount = wr.ReadInt();

            item.Mods = new StatModifier[modCount];
            for (i = 0; i < modCount; i++)
                item.Mods[i] = wr.ReadStruct<StatModifier>();


            wr.ReadUInt(); // NEW 3.0.2 ScalingStatDistribution.dbc
            wr.ReadUInt(); // NEW 3.0.2 ScalingStatFlags


            // In 3.1 there are only 2 damages instead of 5

            item.Damages = new DamageInfo[2];

            for (i = 0; i < 2; i++)
                item.Damages[i] = wr.ReadStruct<DamageInfo>();


            item.Resistances = new int[ItemConstants.MaxResCount];

            for (i = 0; i < ItemConstants.MaxResCount; i++)
                item.Resistances[i] = wr.ReadInt();

            item.AttackTime = wr.ReadInt();
            item.ProjectileType = (ItemProjectileType)wr.ReadUInt();
            item.RangeModifier = wr.ReadFloat();

            // Lecht - Implemented ItemSpellInfo 3.2.0 
            item.Spells = new ItemSpellInfo[5];
            for (i = 0; i < 5; i++)
                //item.Spells[i] = wr.ReadStruct<ItemSpellInfo>(); // FIX ME


            item.BondType = (ItemBondType)wr.ReadUInt();
            item.Description = wr.ReadString();


            // skip these for now, not sure what they're for.
            /*packet.Write(item.PageTextId);
            packet.Write(item.PageCount);
            packet.Write((uint)item.PageMaterial);
             */

            wr.BaseStream.Position += 4 * 3;

            item.QuestId = wr.ReadUInt();
            item.LockId = wr.ReadUInt(); // ? wtf is this

            item.Material = (Material)wr.ReadInt();
            item.SheathType = (SheathType)wr.ReadInt();

            item.RandomPropertiesId = wr.ReadUInt();
            item.RandomSuffixId = wr.ReadUInt();

            item.BlockValue = wr.ReadUInt();
            item.SetId = (ItemSetId)wr.ReadUInt();
            item.MaxDurability = wr.ReadInt();

            item.ZoneId = (ZoneId)wr.ReadUInt();
            item.MapId = (IcarusBot.Core.MapId)wr.ReadUInt();
            item.BagFamily = (ItemBagFamilyMask)wr.ReadUInt();
            item.TotemCategory = (TotemCategory)wr.ReadUInt();


            item.Sockets = new GemSocketInfo[ItemConstants.MaxSocketCount];
            for (i = 0; i < ItemConstants.MaxSocketCount; i++)
                item.Sockets[i] = wr.ReadStruct<GemSocketInfo>();

            item.SocketBonusEnchantId = wr.ReadUInt();
            item.GemPropertiesId = wr.ReadUInt();
            item.RequiredDisenchantingLevel = wr.ReadInt();
            item.ArmorModifier = wr.ReadUInt();
            item.Duration = wr.ReadInt(); // Lecht 3.2.0
            item.ItemLimitCategory = wr.ReadUInt(); // Lecht 3.2.0
            item.HolidayId = wr.ReadUInt(); // Lecht 3.2.0

            botEventManager.Raise(BotEventType.ItemQuery, item, id);

            

            // ToDo: Add some kind of central item template database. 
            // Probably wise to cache it, too.

        }

        public void QueryName(WoWGuid guid)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_NAME_QUERY);
            wr.Write(guid.GetOldGuid());
            Send(wr);
        }

        public void QueryName(UInt64 guid)
        {
            WoWWriter wr = new WoWWriter(OpCode.CMSG_NAME_QUERY);
            wr.Write(guid);
            Send(wr);
        }

        public void CreatureQuery(WoWGuid guid, UInt32 entry)
        {

            if (EntryList.ContainsKey(entry))
            {
                Entry entity;
                EntryList.TryGetValue(entry, out entity);

                World.Units.FindAll(o => o.InteropFields[(int)ObjectFields.ENTRY] == entry)
                     .ForEach(u =>
                     {
                         u.Name = entity.name;
                         u.SubName = entity.subname;
                         u.SubType = entity.subtype;
                         u.Family = entity.family;
                         u.Rank = entity.rank;
                     });

                return;
            }

            if (EntryQueue.ContainsKey(entry))
                return;


            var wr = new WoWWriter(OpCode.CMSG_CREATURE_QUERY);
            wr.Write(entry);
            wr.Write(guid.GetOldGuid());
            Send(wr);

            EntryQueue.Add(entry, true);
        }

        public void GameObjectQuery(WoWGuid guid, UInt32 entry)
        {
            var wr = new WoWWriter(OpCode.CMSG_GAMEOBJECT_QUERY);
            wr.Write(entry);
            wr.Write(guid.GetOldGuid());
            Send(wr);
        }


        private float GetDistance2dSq(WowObject obj)
        {
            WowObject mObj = Player;

            float dx = obj.Location.X - mObj.Location.X;
            float dy = obj.Location.Y - mObj.Location.Y;

            return (dx * dx) + (dy * dy);
        }

        private void Handle_NameQuery(WoWReader wr)
        {
            WoWGuid guid = wr.ReadPackedGuid();
            wr.ReadByte(); // 3.1 unk
            string name = wr.ReadString();
            UInt16 unk = wr.ReadByte();
            RaceType Race = (RaceType)wr.ReadByte();
            IcarusBot.Core.GenderType Gender = (IcarusBot.Core.GenderType)wr.ReadByte();
            ClassType Class = (ClassType)wr.ReadByte();
            wr.ReadByte(); // 3.1 unk2


            Log(LogType.System, 2, "Got NameQuery Response - GUID: {3} Name: {0} - Race: {1} - Gender: {2} - Class: {4}", name, Race, Gender, guid, Class);

            Player obj = World.GetObject(guid) as Player;

            if (obj != null)    // Update existing object
            {
                obj.Name = name;
                obj.Race = Race;
                obj.Gender = Gender;
                obj.Class = Class;
                obj.Update(this);
            }
            else                // Create new Object
            {
                NameEntry ne = new NameEntry();
                ne.GUID = guid;
                ne.Name = name;
                ne.Race = Race;
                ne.Gender = Gender;
                ne.Class = Class;
                World.AddName(ne);
            }

            /* Process chat message if we looked them up now */
            for (int i = 0; i < ChatMessaged.Count; i++)
            {
                ChatMessage message = (ChatMessage)ChatMessaged[i];
                if (message.GUID.GetOldGuid() == guid.GetOldGuid())
                {
                    message.Name = name;
                    Chat(message);
                    ChatMessaged.Remove(message);
                }
            }
            botEventManager.Raise(BotEventType.NameQuery, name, guid.GetOldGuid());
        }

        // Looting
        public void Loot(UInt64 guid)
        {
            WoWWriter ww = new WoWWriter(OpCode.CMSG_LOOT);
            ww.Write(guid);

            Send(ww);
        }

        public void Loot(WowObject obj)
        {
            Log(LogType.Combat, 0, "Trying to loot object {0}", obj.Name);
            Loot(obj.GUID.GetOldGuid());
        }

        public void UseItem(WowObject target)
        {
            WoWWriter ww = new WoWWriter(OpCode.CMSG_USE_ITEM);
            ww.Write(target.GUID.GetOldGuid());
            Send(ww);
        }
        public void UseObject(WoWGuid guid)
        {
            WoWWriter ww = new WoWWriter(OpCode.CMSG_GAMEOBJ_USE);
            ww.Write(guid.GetOldGuid());
            Send(ww);
        }

        public void LootItem(LootItem item)
        {
            WoWWriter ww = new WoWWriter(OpCode.CMSG_AUTOSTORE_LOOT_ITEM);
            ww.Write((byte)item.Index);
            Send(ww);
        }
        public BotEventManager botEventManager { get; set; }
        private void Handle_LootResponse(WoWReader wr)
        {
            var looted_guid = wr.ReadUnpackedGuid();
            WowObject looted = World.GetObject(looted_guid);
            var response_type = (IcarusBot.Core.LootResponseType)wr.ReadByte();



            List<LootItem> loot = new List<LootItem>();

            if (response_type != IcarusBot.Core.LootResponseType.Fail)
            {

                var money = wr.ReadUInt();

                var count = wr.ReadByte();

                LootableItems = count;

                Log(LogType.Combat, 0, "Got loot response for GUID: {0:x} Type: {1} Money: {2} Item Count: {3}", looted_guid, response_type, money, count);

                

                for (var i = 0; i < count; i++)
                {
                   

                    var index = wr.ReadByte();
                    var item_id = wr.ReadUInt();
                    var stack_count = wr.ReadUInt();
                    var display_id = wr.ReadUInt();

                    var random_suffix = wr.ReadUInt();
                    var properties = wr.ReadUInt();
                    var decision = (IcarusBot.Core.LootDecision)wr.ReadByte();


                   LootItem item = new LootItem()
                   {
                       Index = index
                       ,ItemId = item_id
                       ,StackCount = stack_count
                       ,DisplayId = display_id
                       ,Suffix = random_suffix
                       ,Properties = properties
                       ,Decision = decision
                       ,Name = "Placeholder"
                   };

                   loot.Add(item);
                }
                if (botEventManager.IsWaiting(BotEventType.LootReceived))
                    botEventManager.Raise(BotEventType.LootReceived, loot);
            }
        }
        public void HandleLoot(List<LootItem> loot)
        {
            GenericEvent.Raise(this, new EventArgs<GenericEventArgs>(new GenericEventArgs("LootReceived", loot)));
        }

        public void ReleaseLoot(WowObject target)
        {
            var ww2 = new WoWWriter(OpCode.CMSG_LOOT_RELEASE);
            ww2.Write(target.GUID.GetOldGuid());
            Send(ww2);
            LootableItems = 0;
        }

        public void Mine(WowObject obj)
        {
            WoWWriter wr;

            wr = new WoWWriter(OpCode.CMSG_CAST_SPELL);
            wr.Write(++SpellCounter);
            wr.Write((ushort)0x72AA);
            wr.Write((uint)0);
            wr.Write((byte)0x08);
            wr.Write((byte)0x00);
            wr.Write((byte)0x00);
            wr.Write(obj.GUID.PackedGuid());

            Send(wr);

            InitiateLoot(obj);
        }

        public void InitiateLoot(WowObject obj)
        {
            WoWWriter wr;
            wr = new WoWWriter(OpCode.CMSG_GAMEOBJ_REPORT_USE);
            wr.Write(obj.GUID.GetOldGuid());
            Send(wr);
        }

        public void GatherLoot(WoWGuid guid)
        {
            WoWWriter wr;
            wr = new WoWWriter(OpCode.CMSG_GAMEOBJ_REPORT_USE);
            wr.Write(guid.GetOldGuid());
            Send(wr);
        }
        public void LootRelease(WowObject obj)
        {
            var wr = new WoWWriter(OpCode.CMSG_LOOT_RELEASE);
            wr.Write(obj.GUID.GetOldGuid());
            Send(wr);
        }
        public void LootRelease(WoWGuid guid)
        {
            var wr = new WoWWriter(OpCode.CMSG_LOOT_RELEASE);
            wr.Write(guid.GetOldGuid());
            Send(wr);
        }
        //private void Handle_LootRemoved(WoWReader wr)
        //{
        //    var index = wr.ReadByte();

        //    Log(LogType.Combat, 1, "Loot {0}/{1} completed.", index, LootableItems);

        //    if (index >= LootableItems)
        //    {
        //        var ww2 = new WoWWriter(OpCode.CMSG_LOOT_RELEASE);
        //        ww2.Write(currentTarget.GUID.GetOldGuid());
        //        Send(ww2);
        //        LootableItems = 0;
        //    }
        //}
        private void Handle_ObjectAnim(WoWReader packet)
        {
            UInt64 guid = packet.ReadUInt64();
            packet.ReadUInt();
            if (botEventManager.IsWaiting(BotEventType.Fishing))
                botEventManager.Raise(BotEventType.Fishing, guid);
        }
    }

    public class Entry
    {
        public IcarusBot.Core.ObjectTypeId Type;
        public UInt32 DisplayID;
        public UInt32 entry;
        public string name;
        public byte[] blarg;
        public string subname;
        public UInt32 flags;
        public UInt32 subtype;
        public UInt32 family;
        public UInt32 rank;

        public override string ToString()
        {
            return name;
        }


    }
}
