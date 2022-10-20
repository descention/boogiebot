using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foole.WoW;

namespace BenderBot.Common
{


    public static class InteropExtensions
    {


        public static void SetUField(this WowObject target, int index, UInt32 value)
        {
            lock (target)
            {
                if (index >= 0 && index < (int)UpdateFields.PLAYER_END)
                    target.InteropFields[index] = value;
            }
        }

        public static void Update(this WowObject target, BenderCore benderCore)
        {
        }

        public static void Update(this Item target, BenderCore benderCore)
        {
            target.TemplateId = target.InteropFields[(int)ObjectFields.ENTRY];
            target.StackCount = (byte) target.InteropFields[(int)ItemFields.STACK_COUNT];
            target.OwnerGuid = target.InteropFields.GetGuid((int)ItemFields.OWNER);
            target.ContainerGuid = target.InteropFields.GetGuid((int)ItemFields.CONTAINED);
            target.Flags = (ItemFlags)target.InteropFields[(int)ItemFields.FLAGS];

        }


        public static void Update(this Unit target, BenderCore benderCore)
        {
            lock (target)
            {
                ((WowObject)target).Update(benderCore);
                benderCore.Log(LogType.NeworkComms, 2, "Updating fields for unit {0}", target);

                target.Flags = (UnitFlags)target.InteropFields[(int)UnitFields.FLAGS];
                target.DynamicFlags = (UnitDynamicFlags)target.InteropFields[(int)UnitFields.DYNAMIC_FLAGS];

                target.HealthPoints = target.InteropFields[(int)UnitFields.HEALTH];
                target.MaxHealth = target.InteropFields[(int)UnitFields.MAXHEALTH];

                target.ManaPoints = target.InteropFields[(int)UnitFields.POWER1];
                target.MaxMana = target.InteropFields[(int)UnitFields.MAXPOWER1];

                target.Level = target.InteropFields[(int)UnitFields.LEVEL];

                target.Target = benderCore.World.GetObject(new WoWGuid((ulong)target.InteropFields[(int)UnitFields.TARGET])) as Unit;

                target.Pet = benderCore.World.GetObject(new WoWGuid((ulong)target.InteropFields[(int)UnitFields.SUMMON])) as Unit;
                target.SummonedBy = benderCore.World.GetObject(new WoWGuid((ulong)target.InteropFields[(int)UnitFields.SUMMONEDBY])) as Unit;
            }
        }

        public static void Update(this Player target, BenderCore benderCore)
        {
            lock (target)
            {
                ((Unit)target).Update(benderCore);
            }
        }


        public static void Update(this CurrentPlayer target, BenderCore benderCore)
        {
            if (target.InteropFields != null)
            {
                lock (target)
                {
                    ((Player)target).Update(benderCore);

                    target.Experience = target.InteropFields[(int)PlayerFields.XP];
                    target.NextLevelExperience = target.InteropFields[(int)PlayerFields.NEXT_LEVEL_XP];
                    target.Equipment = new Dictionary<EquipmentSlot, Item>();
                    target.Inventory.MainBag = new Item[16];
                    target.Inventory.Bags = new List<InventoryContainer>();
                    if (target.Inventory.AllItems.Count > 0)
                    {
                        for (int i = 0; i < 19; i += 1)
                        {
                            int offset = i + (int) PlayerFields.INV_SLOT_HEAD;
                            EquipmentSlot slot = (EquipmentSlot) i;
                            WoWGuid guid = target.InteropFields.GetGuid(offset);
                            var item = (from intentory in target.Inventory.AllItems
                                        where intentory.GUID == guid
                                        select intentory).FirstOrDefault();

                            if (item != null)
                                target.Equipment[slot] = item;

                        }
                        for (int i = 0; i < 32; i++)
                        {
                            int offset = i + (int) PlayerFields.PACK_SLOT_1;
                            WoWGuid guid = GetGuid(target.InteropFields, offset);
                            var item = (from intentory in target.Inventory.AllItems
                                        where intentory.GUID == guid
                                        select intentory).FirstOrDefault();
                            if (item != null)
                                if (i == 0)
                                    target.Inventory.MainBag[0] = item;
                                else if (i==2)
                                    target.Inventory.MainBag[1] = item;
                                else
                                    target.Inventory.MainBag[(i / 2)] = item;

                        }
                        for (int i = 0; i <= 6; i++)
                        {
                            int offset = i + (int) PlayerFields.INV_SLOT_HEAD + (19*2);
                            WoWGuid guid = GetGuid(target.InteropFields, offset);
                            var item = (from intentory in target.Inventory.AllItems
                                        where intentory.GUID == guid
                                        select intentory).FirstOrDefault();
                            if (item != null)
                                target.Inventory.Bags.Add(new InventoryContainer(item));
                        }
                        foreach (var bag in target.Inventory.Bags)
                        {
                            bag.BagObject.Template.ContainerSlots =
                                (int)bag.BagObject.InteropFields[(int)ContainerFields.NUM_SLOTS];
                            bag.ContainedItems = new Item[bag.BagObject.Template.ContainerSlots];
                            for (int a = 0; a < (bag.BagObject.Template.ContainerSlots*2); a++)
                            {
                                int offset = a + (int) ContainerFields.SLOT_1;
                                WoWGuid guid = GetGuid(bag.BagObject.InteropFields, offset);
                                var item = (from intentory in target.Inventory.AllItems
                                            where intentory.GUID == guid
                                            select intentory).FirstOrDefault();
                                if (item != null)
                                {
                                    if (a == 0)
                                        bag.ContainedItems[0] = item;
                                    else if (a == 2)
                                        bag.ContainedItems[1] = item;
                                    else
                                        bag.ContainedItems[a/2] = item;
                                }
                            }
                        }
                    }
                    target.SendUpdate();
                }

            }
        }

        public static WoWGuid GetGuid(this UInt32[] target, int offset)
        {
            uint low = target[offset];
            uint high = target[offset + 1];

            ulong guid = ((ulong)high << 32) | low;
            WoWGuid wowGuid = new WoWGuid(guid);
            return wowGuid;
        }

    }
}
