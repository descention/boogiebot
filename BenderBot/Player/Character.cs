using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BenderBot.Common
{
    public class Character
    {
        public UInt64 GUID { get; set; }
        public string Name { get; set; }
        public byte Race { get; set; }
        public byte Class { get; set; }
        public byte Gender { get; set; }
        public byte Skin { get; set; }
        public byte Face { get; set; }
        public byte HairStyle { get; set; }
        public byte HairColor { get; set; }
        public byte FacialHair { get; set; }
        public byte Level { get; set; }
        public UInt32 ZoneID { get; set; }
        public UInt32 MapID { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public UInt32 Guild { get; set; }
        public UInt32 Unk { get; set; }
        public byte RestState { get; set; }
        public UInt32 PetInfoID { get; set; }
        public UInt32 PetLevel { get; set; }
        public UInt32 PetFamilyID { get; set; }
        public CharEquipment[] Equipment { get; set; }
    }
}
