using System;
using System.Collections.Generic;
using System.Text;

namespace Foole.WoW
{
    [Obsolete("Start using specific object type field enums?", false)]
    public enum UpdateFields : int
    {
   

        OBJECT_FIELD_GUID                                 = 0x000	,   //Size:2  Type:GUID  Flags:1
OBJECT_FIELD_GUID_01                              = 0x001	,   //Size:2  Type:GUID  Flags:1
OBJECT_FIELD_TYPE                                 = 0x002	,   //Size:1  Type:Int32  Flags:1
OBJECT_FIELD_ENTRY                                = 0x003	,   //Size:1  Type:Int32  Flags:1
OBJECT_FIELD_SCALE_X                              = 0x004	,   //Size:1  Type:Float  Flags:1
OBJECT_FIELD_PADDING                              = 0x005	,   //Size:1  Type:Int32  Flags:0
OBJECT_END                                        = 0x006

,   //CONTAINER:
CONTAINER_FIELD_NUM_SLOTS                         = ITEM_END + 0x000	,   //Size:1  Type:Int32  Flags:1
CONTAINER_ALIGN_PAD                               = ITEM_END + 0x001	,   //Size:1  Type:Bytes  Flags:0
CONTAINER_FIELD_SLOT_1                            = ITEM_END + 0x002	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_01                           = ITEM_END + 0x003	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_02                           = ITEM_END + 0x004	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_03                           = ITEM_END + 0x005	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_04                           = ITEM_END + 0x006	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_05                           = ITEM_END + 0x007	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_06                           = ITEM_END + 0x008	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_07                           = ITEM_END + 0x009	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_08                           = ITEM_END + 0x00A	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_09                           = ITEM_END + 0x00B	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_10                           = ITEM_END + 0x00C	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_11                           = ITEM_END + 0x00D	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_12                           = ITEM_END + 0x00E	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_13                           = ITEM_END + 0x00F	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_14                           = ITEM_END + 0x010	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_15                           = ITEM_END + 0x011	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_16                           = ITEM_END + 0x012	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_17                           = ITEM_END + 0x013	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_18                           = ITEM_END + 0x014	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_19                           = ITEM_END + 0x015	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_20                           = ITEM_END + 0x016	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_21                           = ITEM_END + 0x017	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_22                           = ITEM_END + 0x018	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_23                           = ITEM_END + 0x019	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_24                           = ITEM_END + 0x01A	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_25                           = ITEM_END + 0x01B	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_26                           = ITEM_END + 0x01C	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_27                           = ITEM_END + 0x01D	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_28                           = ITEM_END + 0x01E	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_29                           = ITEM_END + 0x01F	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_30                           = ITEM_END + 0x020	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_31                           = ITEM_END + 0x021	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_32                           = ITEM_END + 0x022	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_33                           = ITEM_END + 0x023	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_34                           = ITEM_END + 0x024	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_35                           = ITEM_END + 0x025	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_36                           = ITEM_END + 0x026	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_37                           = ITEM_END + 0x027	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_38                           = ITEM_END + 0x028	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_39                           = ITEM_END + 0x029	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_40                           = ITEM_END + 0x02A	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_41                           = ITEM_END + 0x02B	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_42                           = ITEM_END + 0x02C	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_43                           = ITEM_END + 0x02D	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_44                           = ITEM_END + 0x02E	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_45                           = ITEM_END + 0x02F	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_46                           = ITEM_END + 0x030	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_47                           = ITEM_END + 0x031	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_48                           = ITEM_END + 0x032	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_49                           = ITEM_END + 0x033	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_50                           = ITEM_END + 0x034	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_51                           = ITEM_END + 0x035	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_52                           = ITEM_END + 0x036	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_53                           = ITEM_END + 0x037	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_54                           = ITEM_END + 0x038	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_55                           = ITEM_END + 0x039	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_56                           = ITEM_END + 0x03A	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_57                           = ITEM_END + 0x03B	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_58                           = ITEM_END + 0x03C	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_59                           = ITEM_END + 0x03D	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_60                           = ITEM_END + 0x03E	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_61                           = ITEM_END + 0x03F	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_62                           = ITEM_END + 0x040	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_63                           = ITEM_END + 0x041	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_64                           = ITEM_END + 0x042	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_65                           = ITEM_END + 0x043	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_66                           = ITEM_END + 0x044	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_67                           = ITEM_END + 0x045	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_68                           = ITEM_END + 0x046	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_69                           = ITEM_END + 0x047	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_70                           = ITEM_END + 0x048	,   //Size:72  Type:GUID  Flags:1
CONTAINER_FIELD_SLOT_71                           = ITEM_END + 0x049	,   //Size:72  Type:GUID  Flags:1
CONTAINER_END                                     = ITEM_END + 0x04A

,   //ITEM:
ITEM_FIELD_OWNER                               = OBJECT_END + 0x000	,   //Size:2  Type:GUID  Flags:1
ITEM_FIELD_OWNER_01                            = OBJECT_END + 0x001	,   //Size:2  Type:GUID  Flags:1
ITEM_FIELD_CONTAINED                           = OBJECT_END + 0x002	,   //Size:2  Type:GUID  Flags:1
ITEM_FIELD_CONTAINED_01                        = OBJECT_END + 0x003	,   //Size:2  Type:GUID  Flags:1
ITEM_FIELD_CREATOR                             = OBJECT_END + 0x004	,   //Size:2  Type:GUID  Flags:1
ITEM_FIELD_CREATOR_01                          = OBJECT_END + 0x005	,   //Size:2  Type:GUID  Flags:1
ITEM_FIELD_GIFTCREATOR                         = OBJECT_END + 0x006	,   //Size:2  Type:GUID  Flags:1
ITEM_FIELD_GIFTCREATOR_01                      = OBJECT_END + 0x007	,   //Size:2  Type:GUID  Flags:1
ITEM_FIELD_STACK_COUNT                         = OBJECT_END + 0x008	,   //Size:1  Type:Int32  Flags:20
ITEM_FIELD_DURATION                            = OBJECT_END + 0x009	,   //Size:1  Type:Int32  Flags:20
ITEM_FIELD_SPELL_CHARGES                       = OBJECT_END + 0x00A	,   //Size:5  Type:Int32  Flags:20
ITEM_FIELD_SPELL_CHARGES_01                    = OBJECT_END + 0x00B	,   //Size:5  Type:Int32  Flags:20
ITEM_FIELD_SPELL_CHARGES_02                    = OBJECT_END + 0x00C	,   //Size:5  Type:Int32  Flags:20
ITEM_FIELD_SPELL_CHARGES_03                    = OBJECT_END + 0x00D	,   //Size:5  Type:Int32  Flags:20
ITEM_FIELD_SPELL_CHARGES_04                    = OBJECT_END + 0x00E	,   //Size:5  Type:Int32  Flags:20
ITEM_FIELD_FLAGS                               = OBJECT_END + 0x00F	,   //Size:1  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_1_1                     = OBJECT_END + 0x010	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_1_01                    = OBJECT_END + 0x011	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_1_3                     = OBJECT_END + 0x012	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_2_1                     = OBJECT_END + 0x013	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_2_01                    = OBJECT_END + 0x014	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_2_3                     = OBJECT_END + 0x015	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_3_1                     = OBJECT_END + 0x016	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_3_01                    = OBJECT_END + 0x017	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_3_3                     = OBJECT_END + 0x018	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_4_1                     = OBJECT_END + 0x019	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_4_01                    = OBJECT_END + 0x01A	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_4_3                     = OBJECT_END + 0x01B	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_5_1                     = OBJECT_END + 0x01C	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_5_01                    = OBJECT_END + 0x01D	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_5_3                     = OBJECT_END + 0x01E	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_6_1                     = OBJECT_END + 0x01F	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_6_01                    = OBJECT_END + 0x020	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_6_3                     = OBJECT_END + 0x021	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_7_1                     = OBJECT_END + 0x022	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_7_01                    = OBJECT_END + 0x023	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_7_3                     = OBJECT_END + 0x024	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_8_1                     = OBJECT_END + 0x025	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_8_01                    = OBJECT_END + 0x026	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_8_3                     = OBJECT_END + 0x027	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_9_1                     = OBJECT_END + 0x028	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_9_01                    = OBJECT_END + 0x029	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_9_3                     = OBJECT_END + 0x02A	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_10_1                    = OBJECT_END + 0x02B	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_10_01                   = OBJECT_END + 0x02C	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_10_3                    = OBJECT_END + 0x02D	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_11_1                    = OBJECT_END + 0x02E	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_11_01                   = OBJECT_END + 0x02F	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_11_3                    = OBJECT_END + 0x030	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_ENCHANTMENT_12_1                    = OBJECT_END + 0x031	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_12_01                   = OBJECT_END + 0x032	,   //Size:2  Type:Int32  Flags:1
ITEM_FIELD_ENCHANTMENT_12_3                    = OBJECT_END + 0x033	,   //Size:1  Type:Chars?  Flags:1
ITEM_FIELD_PROPERTY_SEED                       = OBJECT_END + 0x034	,   //Size:1  Type:Int32  Flags:1
ITEM_FIELD_RANDOM_PROPERTIES_ID                = OBJECT_END + 0x035	,   //Size:1  Type:Int32  Flags:1
ITEM_FIELD_ITEM_TEXT_ID                        = OBJECT_END + 0x036	,   //Size:1  Type:Int32  Flags:4
ITEM_FIELD_DURABILITY                          = OBJECT_END + 0x037	,   //Size:1  Type:Int32  Flags:20
ITEM_FIELD_MAXDURABILITY                       = OBJECT_END + 0x038	,   //Size:1  Type:Int32  Flags:20
ITEM_FIELD_PAD                                 = OBJECT_END + 0x039	,   //Size:1  Type:Int32  Flags:0
ITEM_END                                       = OBJECT_END + 0x03A

,   //UNIT:
UNIT_FIELD_CHARM                               = OBJECT_END + 0x000	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_CHARM_01                            = OBJECT_END + 0x001	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_SUMMON                              = OBJECT_END + 0x002	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_SUMMON_01                           = OBJECT_END + 0x003	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_CRITTER                             = OBJECT_END + 0x004	,   //Size:2  Type:GUID  Flags:2
UNIT_FIELD_CRITTER_01                          = OBJECT_END + 0x005	,   //Size:2  Type:GUID  Flags:2
UNIT_FIELD_CHARMEDBY                           = OBJECT_END + 0x006	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_CHARMEDBY_01                        = OBJECT_END + 0x007	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_SUMMONEDBY                          = OBJECT_END + 0x008	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_SUMMONEDBY_01                       = OBJECT_END + 0x009	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_CREATEDBY                           = OBJECT_END + 0x00A	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_CREATEDBY_01                        = OBJECT_END + 0x00B	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_TARGET                              = OBJECT_END + 0x00C	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_TARGET_01                           = OBJECT_END + 0x00D	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_CHANNEL_OBJECT                      = OBJECT_END + 0x00E	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_CHANNEL_OBJECT_01                   = OBJECT_END + 0x00F	,   //Size:2  Type:GUID  Flags:1
UNIT_FIELD_BYTES_0                             = OBJECT_END + 0x010	,   //Size:1  Type:Bytes  Flags:1
UNIT_FIELD_HEALTH                              = OBJECT_END + 0x011	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_POWER1                              = OBJECT_END + 0x012	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_POWER2                              = OBJECT_END + 0x013	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_POWER3                              = OBJECT_END + 0x014	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_POWER4                              = OBJECT_END + 0x015	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_POWER5                              = OBJECT_END + 0x016	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_POWER6                              = OBJECT_END + 0x017	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_POWER7                              = OBJECT_END + 0x018	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_MAXHEALTH                           = OBJECT_END + 0x019	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_MAXPOWER1                           = OBJECT_END + 0x01A	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_MAXPOWER2                           = OBJECT_END + 0x01B	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_MAXPOWER3                           = OBJECT_END + 0x01C	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_MAXPOWER4                           = OBJECT_END + 0x01D	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_MAXPOWER5                           = OBJECT_END + 0x01E	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_MAXPOWER6                           = OBJECT_END + 0x01F	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_MAXPOWER7                           = OBJECT_END + 0x020	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER           = OBJECT_END + 0x021	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_01        = OBJECT_END + 0x022	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_02        = OBJECT_END + 0x023	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_03        = OBJECT_END + 0x024	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_04        = OBJECT_END + 0x025	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_05        = OBJECT_END + 0x026	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_FLAT_MODIFIER_06        = OBJECT_END + 0x027	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER       = OBJECT_END + 0x028	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_01    = OBJECT_END + 0x029	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_02    = OBJECT_END + 0x02A	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_03    = OBJECT_END + 0x02B	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_04    = OBJECT_END + 0x02C	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_05    = OBJECT_END + 0x02D	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_06    = OBJECT_END + 0x02E	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_LEVEL                               = OBJECT_END + 0x02F	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_FACTIONTEMPLATE                     = OBJECT_END + 0x030	,   //Size:1  Type:Int32  Flags:1
UNIT_VIRTUAL_ITEM_SLOT_ID                      = OBJECT_END + 0x031	,   //Size:3  Type:Int32  Flags:1
UNIT_VIRTUAL_ITEM_SLOT_ID_1                    = OBJECT_END + 0x032	,   //Size:3  Type:Int32  Flags:1
UNIT_VIRTUAL_ITEM_SLOT_ID_2                    = OBJECT_END + 0x033	,   //Size:3  Type:Int32  Flags:1
UNIT_FIELD_FLAGS                               = OBJECT_END + 0x034	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_FLAGS_2                             = OBJECT_END + 0x035	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_AURASTATE                           = OBJECT_END + 0x036	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_BASEATTACKTIME                      = OBJECT_END + 0x037	,   //Size:2  Type:Int32  Flags:1
UNIT_FIELD_BASEATTACKTIME_01                   = OBJECT_END + 0x038	,   //Size:2  Type:Int32  Flags:1
UNIT_FIELD_RANGEDATTACKTIME                    = OBJECT_END + 0x039	,   //Size:1  Type:Int32  Flags:2
UNIT_FIELD_BOUNDINGRADIUS                      = OBJECT_END + 0x03A	,   //Size:1  Type:Float  Flags:1
UNIT_FIELD_COMBATREACH                         = OBJECT_END + 0x03B	,   //Size:1  Type:Float  Flags:1
UNIT_FIELD_DISPLAYID                           = OBJECT_END + 0x03C	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_NATIVEDISPLAYID                     = OBJECT_END + 0x03D	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_MOUNTDISPLAYID                      = OBJECT_END + 0x03E	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_MINDAMAGE                           = OBJECT_END + 0x03F	,   //Size:1  Type:Float  Flags:38
UNIT_FIELD_MAXDAMAGE                           = OBJECT_END + 0x040	,   //Size:1  Type:Float  Flags:38
UNIT_FIELD_MINOFFHANDDAMAGE                    = OBJECT_END + 0x041	,   //Size:1  Type:Float  Flags:38
UNIT_FIELD_MAXOFFHANDDAMAGE                    = OBJECT_END + 0x042	,   //Size:1  Type:Float  Flags:38
UNIT_FIELD_BYTES_1                             = OBJECT_END + 0x043	,   //Size:1  Type:Bytes  Flags:1
UNIT_FIELD_PETNUMBER                           = OBJECT_END + 0x044	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_PET_NAME_TIMESTAMP                  = OBJECT_END + 0x045	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_PETEXPERIENCE                       = OBJECT_END + 0x046	,   //Size:1  Type:Int32  Flags:4
UNIT_FIELD_PETNEXTLEVELEXP                     = OBJECT_END + 0x047	,   //Size:1  Type:Int32  Flags:4
UNIT_DYNAMIC_FLAGS                             = OBJECT_END + 0x048	,   //Size:1  Type:Int32  Flags:256
UNIT_CHANNEL_SPELL                             = OBJECT_END + 0x049	,   //Size:1  Type:Int32  Flags:1
UNIT_MOD_CAST_SPEED                            = OBJECT_END + 0x04A	,   //Size:1  Type:Float  Flags:1
UNIT_CREATED_BY_SPELL                          = OBJECT_END + 0x04B	,   //Size:1  Type:Int32  Flags:1
UNIT_NPC_FLAGS                                 = OBJECT_END + 0x04C	,   //Size:1  Type:Int32  Flags:256
UNIT_NPC_EMOTESTATE                            = OBJECT_END + 0x04D	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_STAT0                               = OBJECT_END + 0x04E	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_STAT1                               = OBJECT_END + 0x04F	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_STAT2                               = OBJECT_END + 0x050	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_STAT3                               = OBJECT_END + 0x051	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_STAT4                               = OBJECT_END + 0x052	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_POSSTAT0                            = OBJECT_END + 0x053	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_POSSTAT1                            = OBJECT_END + 0x054	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_POSSTAT2                            = OBJECT_END + 0x055	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_POSSTAT3                            = OBJECT_END + 0x056	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_POSSTAT4                            = OBJECT_END + 0x057	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_NEGSTAT0                            = OBJECT_END + 0x058	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_NEGSTAT1                            = OBJECT_END + 0x059	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_NEGSTAT2                            = OBJECT_END + 0x05A	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_NEGSTAT3                            = OBJECT_END + 0x05B	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_NEGSTAT4                            = OBJECT_END + 0x05C	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCES                         = OBJECT_END + 0x05D	,   //Size:7  Type:Int32  Flags:38
UNIT_FIELD_RESISTANCES_01                      = OBJECT_END + 0x05E	,   //Size:7  Type:Int32  Flags:38
UNIT_FIELD_RESISTANCES_02                      = OBJECT_END + 0x05F	,   //Size:7  Type:Int32  Flags:38
UNIT_FIELD_RESISTANCES_03                      = OBJECT_END + 0x060	,   //Size:7  Type:Int32  Flags:38
UNIT_FIELD_RESISTANCES_04                      = OBJECT_END + 0x061	,   //Size:7  Type:Int32  Flags:38
UNIT_FIELD_RESISTANCES_05                      = OBJECT_END + 0x062	,   //Size:7  Type:Int32  Flags:38
UNIT_FIELD_RESISTANCES_06                      = OBJECT_END + 0x063	,   //Size:7  Type:Int32  Flags:38
UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE          = OBJECT_END + 0x064	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_01       = OBJECT_END + 0x065	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_02       = OBJECT_END + 0x066	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_03       = OBJECT_END + 0x067	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_04       = OBJECT_END + 0x068	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_05       = OBJECT_END + 0x069	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSPOSITIVE_06       = OBJECT_END + 0x06A	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE          = OBJECT_END + 0x06B	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_01       = OBJECT_END + 0x06C	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_02       = OBJECT_END + 0x06D	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_03       = OBJECT_END + 0x06E	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_04       = OBJECT_END + 0x06F	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_05       = OBJECT_END + 0x070	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_RESISTANCEBUFFMODSNEGATIVE_06       = OBJECT_END + 0x071	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_BASE_MANA                           = OBJECT_END + 0x072	,   //Size:1  Type:Int32  Flags:1
UNIT_FIELD_BASE_HEALTH                         = OBJECT_END + 0x073	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_BYTES_2                             = OBJECT_END + 0x074	,   //Size:1  Type:Bytes  Flags:1
UNIT_FIELD_ATTACK_POWER                        = OBJECT_END + 0x075	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_ATTACK_POWER_MODS                   = OBJECT_END + 0x076	,   //Size:1  Type:Chars?  Flags:6
UNIT_FIELD_ATTACK_POWER_MULTIPLIER             = OBJECT_END + 0x077	,   //Size:1  Type:Float  Flags:6
UNIT_FIELD_RANGED_ATTACK_POWER                 = OBJECT_END + 0x078	,   //Size:1  Type:Int32  Flags:6
UNIT_FIELD_RANGED_ATTACK_POWER_MODS            = OBJECT_END + 0x079	,   //Size:1  Type:Chars?  Flags:6
UNIT_FIELD_RANGED_ATTACK_POWER_MULTIPLIER      = OBJECT_END + 0x07A	,   //Size:1  Type:Float  Flags:6
UNIT_FIELD_MINRANGEDDAMAGE                     = OBJECT_END + 0x07B	,   //Size:1  Type:Float  Flags:6
UNIT_FIELD_MAXRANGEDDAMAGE                     = OBJECT_END + 0x07C	,   //Size:1  Type:Float  Flags:6
UNIT_FIELD_POWER_COST_MODIFIER                 = OBJECT_END + 0x07D	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_POWER_COST_MODIFIER_01              = OBJECT_END + 0x07E	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_POWER_COST_MODIFIER_02              = OBJECT_END + 0x07F	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_POWER_COST_MODIFIER_03              = OBJECT_END + 0x080	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_POWER_COST_MODIFIER_04              = OBJECT_END + 0x081	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_POWER_COST_MODIFIER_05              = OBJECT_END + 0x082	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_POWER_COST_MODIFIER_06              = OBJECT_END + 0x083	,   //Size:7  Type:Int32  Flags:6
UNIT_FIELD_POWER_COST_MULTIPLIER               = OBJECT_END + 0x084	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_COST_MULTIPLIER_01            = OBJECT_END + 0x085	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_COST_MULTIPLIER_02            = OBJECT_END + 0x086	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_COST_MULTIPLIER_03            = OBJECT_END + 0x087	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_COST_MULTIPLIER_04            = OBJECT_END + 0x088	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_COST_MULTIPLIER_05            = OBJECT_END + 0x089	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_POWER_COST_MULTIPLIER_06            = OBJECT_END + 0x08A	,   //Size:7  Type:Float  Flags:6
UNIT_FIELD_MAXHEALTHMODIFIER                   = OBJECT_END + 0x08B	,   //Size:1  Type:Float  Flags:6
UNIT_FIELD_HOVERHEIGHT                         = OBJECT_END + 0x08C	,   //Size:1  Type:Float  Flags:1
UNIT_FIELD_PADDING                             = OBJECT_END + 0x08D	,   //Size:1  Type:Int32  Flags:0
UNIT_END                                       = OBJECT_END + 0x08E

,   //PLAYER:
PLAYER_DUEL_ARBITER                           =    UNIT_END + 0x000	,   //Size:2  Type:GUID  Flags:1
PLAYER_DUEL_ARBITER_01                        =    UNIT_END + 0x001	,   //Size:2  Type:GUID  Flags:1
PLAYER_FLAGS                                  =    UNIT_END + 0x002	,   //Size:1  Type:Int32  Flags:1
PLAYER_GUILDID                                =    UNIT_END + 0x003	,   //Size:1  Type:Int32  Flags:1
PLAYER_GUILDRANK                              =    UNIT_END + 0x004	,   //Size:1  Type:Int32  Flags:1
PLAYER_BYTES                                  =    UNIT_END + 0x005	,   //Size:1  Type:Bytes  Flags:1
PLAYER_BYTES_2                                =    UNIT_END + 0x006	,   //Size:1  Type:Bytes  Flags:1
PLAYER_BYTES_3                                =    UNIT_END + 0x007	,   //Size:1  Type:Bytes  Flags:1
PLAYER_DUEL_TEAM                              =    UNIT_END + 0x008	,   //Size:1  Type:Int32  Flags:1
PLAYER_GUILD_TIMESTAMP                        =    UNIT_END + 0x009	,   //Size:1  Type:Int32  Flags:1
PLAYER_QUEST_LOG_1_1                          =    UNIT_END + 0x00A	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_1_2                          =    UNIT_END + 0x00B	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_1_3                          =    UNIT_END + 0x00C	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_1_4                          =    UNIT_END + 0x00D	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_2_1                          =    UNIT_END + 0x00E	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_2_2                          =    UNIT_END + 0x00F	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_2_3                          =    UNIT_END + 0x010	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_2_4                          =    UNIT_END + 0x011	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_3_1                          =    UNIT_END + 0x012	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_3_2                          =    UNIT_END + 0x013	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_3_3                          =    UNIT_END + 0x014	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_3_4                          =    UNIT_END + 0x015	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_4_1                          =    UNIT_END + 0x016	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_4_2                          =    UNIT_END + 0x017	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_4_3                          =    UNIT_END + 0x018	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_4_4                          =    UNIT_END + 0x019	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_5_1                          =    UNIT_END + 0x01A	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_5_2                          =    UNIT_END + 0x01B	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_5_3                          =    UNIT_END + 0x01C	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_5_4                          =    UNIT_END + 0x01D	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_6_1                          =    UNIT_END + 0x01E	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_6_2                          =    UNIT_END + 0x01F	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_6_3                          =    UNIT_END + 0x020	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_6_4                          =    UNIT_END + 0x021	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_7_1                          =    UNIT_END + 0x022	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_7_2                          =    UNIT_END + 0x023	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_7_3                          =    UNIT_END + 0x024	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_7_4                          =    UNIT_END + 0x025	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_8_1                          =    UNIT_END + 0x026	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_8_2                          =    UNIT_END + 0x027	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_8_3                          =    UNIT_END + 0x028	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_8_4                          =    UNIT_END + 0x029	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_9_1                          =    UNIT_END + 0x02A	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_9_2                          =    UNIT_END + 0x02B	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_9_3                          =    UNIT_END + 0x02C	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_9_4                          =    UNIT_END + 0x02D	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_10_1                         =    UNIT_END + 0x02E	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_10_2                         =    UNIT_END + 0x02F	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_10_3                         =    UNIT_END + 0x030	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_10_4                         =    UNIT_END + 0x031	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_11_1                         =    UNIT_END + 0x032	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_11_2                         =    UNIT_END + 0x033	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_11_3                         =    UNIT_END + 0x034	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_11_4                         =    UNIT_END + 0x035	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_12_1                         =    UNIT_END + 0x036	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_12_2                         =    UNIT_END + 0x037	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_12_3                         =    UNIT_END + 0x038	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_12_4                         =    UNIT_END + 0x039	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_13_1                         =    UNIT_END + 0x03A	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_13_2                         =    UNIT_END + 0x03B	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_13_3                         =    UNIT_END + 0x03C	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_13_4                         =    UNIT_END + 0x03D	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_14_1                         =    UNIT_END + 0x03E	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_14_2                         =    UNIT_END + 0x03F	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_14_3                         =    UNIT_END + 0x040	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_14_4                         =    UNIT_END + 0x041	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_15_1                         =    UNIT_END + 0x042	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_15_2                         =    UNIT_END + 0x043	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_15_3                         =    UNIT_END + 0x044	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_15_4                         =    UNIT_END + 0x045	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_16_1                         =    UNIT_END + 0x046	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_16_2                         =    UNIT_END + 0x047	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_16_3                         =    UNIT_END + 0x048	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_16_4                         =    UNIT_END + 0x049	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_17_1                         =    UNIT_END + 0x04A	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_17_2                         =    UNIT_END + 0x04B	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_17_3                         =    UNIT_END + 0x04C	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_17_4                         =    UNIT_END + 0x04D	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_18_1                         =    UNIT_END + 0x04E	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_18_2                         =    UNIT_END + 0x04F	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_18_3                         =    UNIT_END + 0x050	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_18_4                         =    UNIT_END + 0x051	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_19_1                         =    UNIT_END + 0x052	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_19_2                         =    UNIT_END + 0x053	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_19_3                         =    UNIT_END + 0x054	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_19_4                         =    UNIT_END + 0x055	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_20_1                         =    UNIT_END + 0x056	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_20_2                         =    UNIT_END + 0x057	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_20_3                         =    UNIT_END + 0x058	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_20_4                         =    UNIT_END + 0x059	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_21_1                         =    UNIT_END + 0x05A	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_21_2                         =    UNIT_END + 0x05B	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_21_3                         =    UNIT_END + 0x05C	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_21_4                         =    UNIT_END + 0x05D	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_22_1                         =    UNIT_END + 0x05E	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_22_2                         =    UNIT_END + 0x05F	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_22_3                         =    UNIT_END + 0x060	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_22_4                         =    UNIT_END + 0x061	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_23_1                         =    UNIT_END + 0x062	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_23_2                         =    UNIT_END + 0x063	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_23_3                         =    UNIT_END + 0x064	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_23_4                         =    UNIT_END + 0x065	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_24_1                         =    UNIT_END + 0x066	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_24_2                         =    UNIT_END + 0x067	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_24_3                         =    UNIT_END + 0x068	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_24_4                         =    UNIT_END + 0x069	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_25_1                         =    UNIT_END + 0x06A	,   //Size:1  Type:Int32  Flags:64
PLAYER_QUEST_LOG_25_2                         =    UNIT_END + 0x06B	,   //Size:1  Type:Int32  Flags:2
PLAYER_QUEST_LOG_25_3                         =    UNIT_END + 0x06C	,   //Size:1  Type:Bytes  Flags:2
PLAYER_QUEST_LOG_25_4                         =    UNIT_END + 0x06D	,   //Size:1  Type:Int32  Flags:2
PLAYER_VISIBLE_ITEM_1_CREATOR                 =    UNIT_END + 0x06E	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_1_CREATOR_01              =    UNIT_END + 0x06F	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_1_0                       =    UNIT_END + 0x070	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_01                      =    UNIT_END + 0x071	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_02                      =    UNIT_END + 0x072	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_03                      =    UNIT_END + 0x073	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_04                      =    UNIT_END + 0x074	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_05                      =    UNIT_END + 0x075	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_06                      =    UNIT_END + 0x076	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_07                      =    UNIT_END + 0x077	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_08                      =    UNIT_END + 0x078	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_09                      =    UNIT_END + 0x079	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_10                      =    UNIT_END + 0x07A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_11                      =    UNIT_END + 0x07B	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_12                      =    UNIT_END + 0x07C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_PROPERTIES              =    UNIT_END + 0x07D	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_1_SEED                    =    UNIT_END + 0x07E	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_1_PAD                     =    UNIT_END + 0x07F	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_CREATOR                 =    UNIT_END + 0x080	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_2_CREATOR_01              =    UNIT_END + 0x081	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_2_0                       =    UNIT_END + 0x082	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_01                      =    UNIT_END + 0x083	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_02                      =    UNIT_END + 0x084	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_03                      =    UNIT_END + 0x085	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_04                      =    UNIT_END + 0x086	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_05                      =    UNIT_END + 0x087	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_06                      =    UNIT_END + 0x088	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_07                      =    UNIT_END + 0x089	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_08                      =    UNIT_END + 0x08A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_09                      =    UNIT_END + 0x08B	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_10                      =    UNIT_END + 0x08C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_11                      =    UNIT_END + 0x08D	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_12                      =    UNIT_END + 0x08E	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_PROPERTIES              =    UNIT_END + 0x08F	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_2_SEED                    =    UNIT_END + 0x090	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_2_PAD                     =    UNIT_END + 0x091	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_CREATOR                 =    UNIT_END + 0x092	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_3_CREATOR_01              =    UNIT_END + 0x093	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_3_0                       =    UNIT_END + 0x094	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_01                      =    UNIT_END + 0x095	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_02                      =    UNIT_END + 0x096	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_03                      =    UNIT_END + 0x097	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_04                      =    UNIT_END + 0x098	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_05                      =    UNIT_END + 0x099	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_06                      =    UNIT_END + 0x09A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_07                      =    UNIT_END + 0x09B	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_08                      =    UNIT_END + 0x09C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_09                      =    UNIT_END + 0x09D	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_10                      =    UNIT_END + 0x09E	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_11                      =    UNIT_END + 0x09F	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_12                      =    UNIT_END + 0x0A0	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_PROPERTIES              =    UNIT_END + 0x0A1	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_3_SEED                    =    UNIT_END + 0x0A2	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_3_PAD                     =    UNIT_END + 0x0A3	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_CREATOR                 =    UNIT_END + 0x0A4	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_4_CREATOR_01              =    UNIT_END + 0x0A5	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_4_0                       =    UNIT_END + 0x0A6	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_01                      =    UNIT_END + 0x0A7	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_02                      =    UNIT_END + 0x0A8	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_03                      =    UNIT_END + 0x0A9	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_04                      =    UNIT_END + 0x0AA	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_05                      =    UNIT_END + 0x0AB	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_06                      =    UNIT_END + 0x0AC	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_07                      =    UNIT_END + 0x0AD	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_08                      =    UNIT_END + 0x0AE	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_09                      =    UNIT_END + 0x0AF	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_10                      =    UNIT_END + 0x0B0	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_11                      =    UNIT_END + 0x0B1	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_12                      =    UNIT_END + 0x0B2	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_PROPERTIES              =    UNIT_END + 0x0B3	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_4_SEED                    =    UNIT_END + 0x0B4	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_4_PAD                     =    UNIT_END + 0x0B5	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_CREATOR                 =    UNIT_END + 0x0B6	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_5_CREATOR_01              =    UNIT_END + 0x0B7	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_5_0                       =    UNIT_END + 0x0B8	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_01                      =    UNIT_END + 0x0B9	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_02                      =    UNIT_END + 0x0BA	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_03                      =    UNIT_END + 0x0BB	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_04                      =    UNIT_END + 0x0BC	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_05                      =    UNIT_END + 0x0BD	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_06                      =    UNIT_END + 0x0BE	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_07                      =    UNIT_END + 0x0BF	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_08                      =    UNIT_END + 0x0C0	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_09                      =    UNIT_END + 0x0C1	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_10                      =    UNIT_END + 0x0C2	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_11                      =    UNIT_END + 0x0C3	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_12                      =    UNIT_END + 0x0C4	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_PROPERTIES              =    UNIT_END + 0x0C5	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_5_SEED                    =    UNIT_END + 0x0C6	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_5_PAD                     =    UNIT_END + 0x0C7	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_CREATOR                 =    UNIT_END + 0x0C8	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_6_CREATOR_01              =    UNIT_END + 0x0C9	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_6_0                       =    UNIT_END + 0x0CA	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_01                      =    UNIT_END + 0x0CB	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_02                      =    UNIT_END + 0x0CC	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_03                      =    UNIT_END + 0x0CD	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_04                      =    UNIT_END + 0x0CE	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_05                      =    UNIT_END + 0x0CF	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_06                      =    UNIT_END + 0x0D0	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_07                      =    UNIT_END + 0x0D1	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_08                      =    UNIT_END + 0x0D2	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_09                      =    UNIT_END + 0x0D3	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_10                      =    UNIT_END + 0x0D4	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_11                      =    UNIT_END + 0x0D5	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_12                      =    UNIT_END + 0x0D6	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_PROPERTIES              =    UNIT_END + 0x0D7	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_6_SEED                    =    UNIT_END + 0x0D8	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_6_PAD                     =    UNIT_END + 0x0D9	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_CREATOR                 =    UNIT_END + 0x0DA	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_7_CREATOR_01              =    UNIT_END + 0x0DB	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_7_0                       =    UNIT_END + 0x0DC	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_01                      =    UNIT_END + 0x0DD	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_02                      =    UNIT_END + 0x0DE	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_03                      =    UNIT_END + 0x0DF	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_04                      =    UNIT_END + 0x0E0	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_05                      =    UNIT_END + 0x0E1	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_06                      =    UNIT_END + 0x0E2	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_07                      =    UNIT_END + 0x0E3	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_08                      =    UNIT_END + 0x0E4	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_09                      =    UNIT_END + 0x0E5	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_10                      =    UNIT_END + 0x0E6	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_11                      =    UNIT_END + 0x0E7	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_12                      =    UNIT_END + 0x0E8	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_PROPERTIES              =    UNIT_END + 0x0E9	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_7_SEED                    =    UNIT_END + 0x0EA	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_7_PAD                     =    UNIT_END + 0x0EB	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_CREATOR                 =    UNIT_END + 0x0EC	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_8_CREATOR_01              =    UNIT_END + 0x0ED	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_8_0                       =    UNIT_END + 0x0EE	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_01                      =    UNIT_END + 0x0EF	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_02                      =    UNIT_END + 0x0F0	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_03                      =    UNIT_END + 0x0F1	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_04                      =    UNIT_END + 0x0F2	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_05                      =    UNIT_END + 0x0F3	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_06                      =    UNIT_END + 0x0F4	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_07                      =    UNIT_END + 0x0F5	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_08                      =    UNIT_END + 0x0F6	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_09                      =    UNIT_END + 0x0F7	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_10                      =    UNIT_END + 0x0F8	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_11                      =    UNIT_END + 0x0F9	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_12                      =    UNIT_END + 0x0FA	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_PROPERTIES              =    UNIT_END + 0x0FB	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_8_SEED                    =    UNIT_END + 0x0FC	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_8_PAD                     =    UNIT_END + 0x0FD	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_CREATOR                 =    UNIT_END + 0x0FE	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_9_CREATOR_01              =    UNIT_END + 0x0FF	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_9_0                       =    UNIT_END + 0x100	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_01                      =    UNIT_END + 0x101	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_02                      =    UNIT_END + 0x102	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_03                      =    UNIT_END + 0x103	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_04                      =    UNIT_END + 0x104	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_05                      =    UNIT_END + 0x105	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_06                      =    UNIT_END + 0x106	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_07                      =    UNIT_END + 0x107	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_08                      =    UNIT_END + 0x108	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_09                      =    UNIT_END + 0x109	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_10                      =    UNIT_END + 0x10A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_11                      =    UNIT_END + 0x10B	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_12                      =    UNIT_END + 0x10C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_PROPERTIES              =    UNIT_END + 0x10D	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_9_SEED                    =    UNIT_END + 0x10E	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_9_PAD                     =    UNIT_END + 0x10F	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_CREATOR                =    UNIT_END + 0x110	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_10_CREATOR_01             =    UNIT_END + 0x111	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_10_0                      =    UNIT_END + 0x112	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_01                     =    UNIT_END + 0x113	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_02                     =    UNIT_END + 0x114	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_03                     =    UNIT_END + 0x115	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_04                     =    UNIT_END + 0x116	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_05                     =    UNIT_END + 0x117	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_06                     =    UNIT_END + 0x118	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_07                     =    UNIT_END + 0x119	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_08                     =    UNIT_END + 0x11A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_09                     =    UNIT_END + 0x11B	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_10                     =    UNIT_END + 0x11C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_11                     =    UNIT_END + 0x11D	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_12                     =    UNIT_END + 0x11E	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_PROPERTIES             =    UNIT_END + 0x11F	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_10_SEED                   =    UNIT_END + 0x120	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_10_PAD                    =    UNIT_END + 0x121	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_CREATOR                =    UNIT_END + 0x122	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_11_CREATOR_01             =    UNIT_END + 0x123	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_11_0                      =    UNIT_END + 0x124	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_01                     =    UNIT_END + 0x125	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_02                     =    UNIT_END + 0x126	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_03                     =    UNIT_END + 0x127	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_04                     =    UNIT_END + 0x128	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_05                     =    UNIT_END + 0x129	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_06                     =    UNIT_END + 0x12A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_07                     =    UNIT_END + 0x12B	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_08                     =    UNIT_END + 0x12C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_09                     =    UNIT_END + 0x12D	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_10                     =    UNIT_END + 0x12E	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_11                     =    UNIT_END + 0x12F	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_12                     =    UNIT_END + 0x130	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_PROPERTIES             =    UNIT_END + 0x131	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_11_SEED                   =    UNIT_END + 0x132	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_11_PAD                    =    UNIT_END + 0x133	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_CREATOR                =    UNIT_END + 0x134	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_12_CREATOR_01             =    UNIT_END + 0x135	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_12_0                      =    UNIT_END + 0x136	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_01                     =    UNIT_END + 0x137	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_02                     =    UNIT_END + 0x138	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_03                     =    UNIT_END + 0x139	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_04                     =    UNIT_END + 0x13A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_05                     =    UNIT_END + 0x13B	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_06                     =    UNIT_END + 0x13C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_07                     =    UNIT_END + 0x13D	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_08                     =    UNIT_END + 0x13E	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_09                     =    UNIT_END + 0x13F	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_10                     =    UNIT_END + 0x140	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_11                     =    UNIT_END + 0x141	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_12                     =    UNIT_END + 0x142	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_PROPERTIES             =    UNIT_END + 0x143	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_12_SEED                   =    UNIT_END + 0x144	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_12_PAD                    =    UNIT_END + 0x145	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_CREATOR                =    UNIT_END + 0x146	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_13_CREATOR_01             =    UNIT_END + 0x147	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_13_0                      =    UNIT_END + 0x148	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_01                     =    UNIT_END + 0x149	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_02                     =    UNIT_END + 0x14A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_03                     =    UNIT_END + 0x14B	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_04                     =    UNIT_END + 0x14C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_05                     =    UNIT_END + 0x14D	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_06                     =    UNIT_END + 0x14E	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_07                     =    UNIT_END + 0x14F	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_08                     =    UNIT_END + 0x150	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_09                     =    UNIT_END + 0x151	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_10                     =    UNIT_END + 0x152	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_11                     =    UNIT_END + 0x153	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_12                     =    UNIT_END + 0x154	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_PROPERTIES             =    UNIT_END + 0x155	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_13_SEED                   =    UNIT_END + 0x156	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_13_PAD                    =    UNIT_END + 0x157	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_CREATOR                =    UNIT_END + 0x158	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_14_CREATOR_01             =    UNIT_END + 0x159	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_14_0                      =    UNIT_END + 0x15A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_01                     =    UNIT_END + 0x15B	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_02                     =    UNIT_END + 0x15C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_03                     =    UNIT_END + 0x15D	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_04                     =    UNIT_END + 0x15E	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_05                     =    UNIT_END + 0x15F	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_06                     =    UNIT_END + 0x160	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_07                     =    UNIT_END + 0x161	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_08                     =    UNIT_END + 0x162	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_09                     =    UNIT_END + 0x163	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_10                     =    UNIT_END + 0x164	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_11                     =    UNIT_END + 0x165	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_12                     =    UNIT_END + 0x166	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_PROPERTIES             =    UNIT_END + 0x167	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_14_SEED                   =    UNIT_END + 0x168	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_14_PAD                    =    UNIT_END + 0x169	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_CREATOR                =    UNIT_END + 0x16A	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_15_CREATOR_01             =    UNIT_END + 0x16B	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_15_0                      =    UNIT_END + 0x16C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_01                     =    UNIT_END + 0x16D	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_02                     =    UNIT_END + 0x16E	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_03                     =    UNIT_END + 0x16F	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_04                     =    UNIT_END + 0x170	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_05                     =    UNIT_END + 0x171	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_06                     =    UNIT_END + 0x172	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_07                     =    UNIT_END + 0x173	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_08                     =    UNIT_END + 0x174	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_09                     =    UNIT_END + 0x175	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_10                     =    UNIT_END + 0x176	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_11                     =    UNIT_END + 0x177	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_12                     =    UNIT_END + 0x178	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_PROPERTIES             =    UNIT_END + 0x179	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_15_SEED                   =    UNIT_END + 0x17A	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_15_PAD                    =    UNIT_END + 0x17B	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_CREATOR                =    UNIT_END + 0x17C	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_16_CREATOR_01             =    UNIT_END + 0x17D	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_16_0                      =    UNIT_END + 0x17E	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_01                     =    UNIT_END + 0x17F	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_02                     =    UNIT_END + 0x180	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_03                     =    UNIT_END + 0x181	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_04                     =    UNIT_END + 0x182	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_05                     =    UNIT_END + 0x183	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_06                     =    UNIT_END + 0x184	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_07                     =    UNIT_END + 0x185	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_08                     =    UNIT_END + 0x186	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_09                     =    UNIT_END + 0x187	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_10                     =    UNIT_END + 0x188	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_11                     =    UNIT_END + 0x189	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_12                     =    UNIT_END + 0x18A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_PROPERTIES             =    UNIT_END + 0x18B	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_16_SEED                   =    UNIT_END + 0x18C	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_16_PAD                    =    UNIT_END + 0x18D	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_CREATOR                =    UNIT_END + 0x18E	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_17_CREATOR_01             =    UNIT_END + 0x18F	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_17_0                      =    UNIT_END + 0x190	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_01                     =    UNIT_END + 0x191	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_02                     =    UNIT_END + 0x192	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_03                     =    UNIT_END + 0x193	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_04                     =    UNIT_END + 0x194	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_05                     =    UNIT_END + 0x195	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_06                     =    UNIT_END + 0x196	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_07                     =    UNIT_END + 0x197	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_08                     =    UNIT_END + 0x198	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_09                     =    UNIT_END + 0x199	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_10                     =    UNIT_END + 0x19A	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_11                     =    UNIT_END + 0x19B	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_12                     =    UNIT_END + 0x19C	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_PROPERTIES             =    UNIT_END + 0x19D	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_17_SEED                   =    UNIT_END + 0x19E	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_17_PAD                    =    UNIT_END + 0x19F	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_CREATOR                =    UNIT_END + 0x1A0	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_18_CREATOR_01             =    UNIT_END + 0x1A1	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_18_0                      =    UNIT_END + 0x1A2	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_01                     =    UNIT_END + 0x1A3	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_02                     =    UNIT_END + 0x1A4	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_03                     =    UNIT_END + 0x1A5	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_04                     =    UNIT_END + 0x1A6	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_05                     =    UNIT_END + 0x1A7	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_06                     =    UNIT_END + 0x1A8	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_07                     =    UNIT_END + 0x1A9	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_08                     =    UNIT_END + 0x1AA	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_09                     =    UNIT_END + 0x1AB	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_10                     =    UNIT_END + 0x1AC	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_11                     =    UNIT_END + 0x1AD	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_12                     =    UNIT_END + 0x1AE	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_PROPERTIES             =    UNIT_END + 0x1AF	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_18_SEED                   =    UNIT_END + 0x1B0	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_18_PAD                    =    UNIT_END + 0x1B1	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_CREATOR                =    UNIT_END + 0x1B2	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_19_CREATOR_01             =    UNIT_END + 0x1B3	,   //Size:2  Type:GUID  Flags:1
PLAYER_VISIBLE_ITEM_19_0                      =    UNIT_END + 0x1B4	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_01                     =    UNIT_END + 0x1B5	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_02                     =    UNIT_END + 0x1B6	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_03                     =    UNIT_END + 0x1B7	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_04                     =    UNIT_END + 0x1B8	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_05                     =    UNIT_END + 0x1B9	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_06                     =    UNIT_END + 0x1BA	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_07                     =    UNIT_END + 0x1BB	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_08                     =    UNIT_END + 0x1BC	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_09                     =    UNIT_END + 0x1BD	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_10                     =    UNIT_END + 0x1BE	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_11                     =    UNIT_END + 0x1BF	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_12                     =    UNIT_END + 0x1C0	,   //Size:13  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_PROPERTIES             =    UNIT_END + 0x1C1	,   //Size:1  Type:Chars?  Flags:1
PLAYER_VISIBLE_ITEM_19_SEED                   =    UNIT_END + 0x1C2	,   //Size:1  Type:Int32  Flags:1
PLAYER_VISIBLE_ITEM_19_PAD                    =    UNIT_END + 0x1C3	,   //Size:1  Type:Int32  Flags:1
PLAYER_CHOSEN_TITLE                           =    UNIT_END + 0x1C4	,   //Size:1  Type:Int32  Flags:1
PLAYER_FIELD_PAD_0                            =    UNIT_END + 0x1C5	,   //Size:1  Type:Int32  Flags:0
PLAYER_FIELD_INV_SLOT_HEAD                    =    UNIT_END + 0x1C6	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_01                 =    UNIT_END + 0x1C7	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_02                 =    UNIT_END + 0x1C8	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_03                 =    UNIT_END + 0x1C9	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_04                 =    UNIT_END + 0x1CA	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_05                 =    UNIT_END + 0x1CB	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_06                 =    UNIT_END + 0x1CC	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_07                 =    UNIT_END + 0x1CD	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_08                 =    UNIT_END + 0x1CE	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_09                 =    UNIT_END + 0x1CF	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_10                 =    UNIT_END + 0x1D0	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_11                 =    UNIT_END + 0x1D1	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_12                 =    UNIT_END + 0x1D2	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_13                 =    UNIT_END + 0x1D3	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_14                 =    UNIT_END + 0x1D4	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_15                 =    UNIT_END + 0x1D5	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_16                 =    UNIT_END + 0x1D6	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_17                 =    UNIT_END + 0x1D7	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_18                 =    UNIT_END + 0x1D8	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_19                 =    UNIT_END + 0x1D9	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_20                 =    UNIT_END + 0x1DA	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_21                 =    UNIT_END + 0x1DB	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_22                 =    UNIT_END + 0x1DC	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_23                 =    UNIT_END + 0x1DD	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_24                 =    UNIT_END + 0x1DE	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_25                 =    UNIT_END + 0x1DF	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_26                 =    UNIT_END + 0x1E0	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_27                 =    UNIT_END + 0x1E1	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_28                 =    UNIT_END + 0x1E2	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_29                 =    UNIT_END + 0x1E3	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_30                 =    UNIT_END + 0x1E4	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_31                 =    UNIT_END + 0x1E5	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_32                 =    UNIT_END + 0x1E6	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_33                 =    UNIT_END + 0x1E7	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_34                 =    UNIT_END + 0x1E8	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_35                 =    UNIT_END + 0x1E9	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_36                 =    UNIT_END + 0x1EA	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_37                 =    UNIT_END + 0x1EB	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_38                 =    UNIT_END + 0x1EC	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_39                 =    UNIT_END + 0x1ED	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_40                 =    UNIT_END + 0x1EE	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_41                 =    UNIT_END + 0x1EF	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_42                 =    UNIT_END + 0x1F0	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_43                 =    UNIT_END + 0x1F1	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_44                 =    UNIT_END + 0x1F2	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_INV_SLOT_HEAD_45                 =    UNIT_END + 0x1F3	,   //Size:46  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_1                      =    UNIT_END + 0x1F4	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_01                     =    UNIT_END + 0x1F5	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_02                     =    UNIT_END + 0x1F6	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_03                     =    UNIT_END + 0x1F7	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_04                     =    UNIT_END + 0x1F8	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_05                     =    UNIT_END + 0x1F9	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_06                     =    UNIT_END + 0x1FA	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_07                     =    UNIT_END + 0x1FB	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_08                     =    UNIT_END + 0x1FC	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_09                     =    UNIT_END + 0x1FD	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_10                     =    UNIT_END + 0x1FE	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_11                     =    UNIT_END + 0x1FF	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_12                     =    UNIT_END + 0x200	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_13                     =    UNIT_END + 0x201	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_14                     =    UNIT_END + 0x202	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_15                     =    UNIT_END + 0x203	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_16                     =    UNIT_END + 0x204	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_17                     =    UNIT_END + 0x205	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_18                     =    UNIT_END + 0x206	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_19                     =    UNIT_END + 0x207	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_20                     =    UNIT_END + 0x208	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_21                     =    UNIT_END + 0x209	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_22                     =    UNIT_END + 0x20A	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_23                     =    UNIT_END + 0x20B	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_24                     =    UNIT_END + 0x20C	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_25                     =    UNIT_END + 0x20D	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_26                     =    UNIT_END + 0x20E	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_27                     =    UNIT_END + 0x20F	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_28                     =    UNIT_END + 0x210	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_29                     =    UNIT_END + 0x211	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_30                     =    UNIT_END + 0x212	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_PACK_SLOT_31                     =    UNIT_END + 0x213	,   //Size:32  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_1                      =    UNIT_END + 0x214	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_01                     =    UNIT_END + 0x215	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_02                     =    UNIT_END + 0x216	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_03                     =    UNIT_END + 0x217	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_04                     =    UNIT_END + 0x218	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_05                     =    UNIT_END + 0x219	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_06                     =    UNIT_END + 0x21A	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_07                     =    UNIT_END + 0x21B	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_08                     =    UNIT_END + 0x21C	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_09                     =    UNIT_END + 0x21D	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_10                     =    UNIT_END + 0x21E	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_11                     =    UNIT_END + 0x21F	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_12                     =    UNIT_END + 0x220	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_13                     =    UNIT_END + 0x221	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_14                     =    UNIT_END + 0x222	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_15                     =    UNIT_END + 0x223	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_16                     =    UNIT_END + 0x224	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_17                     =    UNIT_END + 0x225	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_18                     =    UNIT_END + 0x226	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_19                     =    UNIT_END + 0x227	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_20                     =    UNIT_END + 0x228	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_21                     =    UNIT_END + 0x229	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_22                     =    UNIT_END + 0x22A	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_23                     =    UNIT_END + 0x22B	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_24                     =    UNIT_END + 0x22C	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_25                     =    UNIT_END + 0x22D	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_26                     =    UNIT_END + 0x22E	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_27                     =    UNIT_END + 0x22F	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_28                     =    UNIT_END + 0x230	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_29                     =    UNIT_END + 0x231	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_30                     =    UNIT_END + 0x232	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_31                     =    UNIT_END + 0x233	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_32                     =    UNIT_END + 0x234	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_33                     =    UNIT_END + 0x235	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_34                     =    UNIT_END + 0x236	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_35                     =    UNIT_END + 0x237	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_36                     =    UNIT_END + 0x238	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_37                     =    UNIT_END + 0x239	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_38                     =    UNIT_END + 0x23A	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_39                     =    UNIT_END + 0x23B	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_40                     =    UNIT_END + 0x23C	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_41                     =    UNIT_END + 0x23D	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_42                     =    UNIT_END + 0x23E	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_43                     =    UNIT_END + 0x23F	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_44                     =    UNIT_END + 0x240	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_45                     =    UNIT_END + 0x241	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_46                     =    UNIT_END + 0x242	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_47                     =    UNIT_END + 0x243	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_48                     =    UNIT_END + 0x244	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_49                     =    UNIT_END + 0x245	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_50                     =    UNIT_END + 0x246	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_51                     =    UNIT_END + 0x247	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_52                     =    UNIT_END + 0x248	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_53                     =    UNIT_END + 0x249	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_54                     =    UNIT_END + 0x24A	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANK_SLOT_55                     =    UNIT_END + 0x24B	,   //Size:56  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_1                   =    UNIT_END + 0x24C	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_01                  =    UNIT_END + 0x24D	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_02                  =    UNIT_END + 0x24E	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_03                  =    UNIT_END + 0x24F	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_04                  =    UNIT_END + 0x250	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_05                  =    UNIT_END + 0x251	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_06                  =    UNIT_END + 0x252	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_07                  =    UNIT_END + 0x253	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_08                  =    UNIT_END + 0x254	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_09                  =    UNIT_END + 0x255	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_10                  =    UNIT_END + 0x256	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_11                  =    UNIT_END + 0x257	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_12                  =    UNIT_END + 0x258	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_BANKBAG_SLOT_13                  =    UNIT_END + 0x259	,   //Size:14  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_1             =    UNIT_END + 0x25A	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_01            =    UNIT_END + 0x25B	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_02            =    UNIT_END + 0x25C	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_03            =    UNIT_END + 0x25D	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_04            =    UNIT_END + 0x25E	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_05            =    UNIT_END + 0x25F	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_06            =    UNIT_END + 0x260	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_07            =    UNIT_END + 0x261	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_08            =    UNIT_END + 0x262	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_09            =    UNIT_END + 0x263	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_10            =    UNIT_END + 0x264	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_11            =    UNIT_END + 0x265	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_12            =    UNIT_END + 0x266	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_13            =    UNIT_END + 0x267	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_14            =    UNIT_END + 0x268	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_15            =    UNIT_END + 0x269	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_16            =    UNIT_END + 0x26A	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_17            =    UNIT_END + 0x26B	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_18            =    UNIT_END + 0x26C	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_19            =    UNIT_END + 0x26D	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_20            =    UNIT_END + 0x26E	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_21            =    UNIT_END + 0x26F	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_22            =    UNIT_END + 0x270	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_VENDORBUYBACK_SLOT_23            =    UNIT_END + 0x271	,   //Size:24  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_1                   =    UNIT_END + 0x272	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_01                  =    UNIT_END + 0x273	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_02                  =    UNIT_END + 0x274	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_03                  =    UNIT_END + 0x275	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_04                  =    UNIT_END + 0x276	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_05                  =    UNIT_END + 0x277	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_06                  =    UNIT_END + 0x278	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_07                  =    UNIT_END + 0x279	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_08                  =    UNIT_END + 0x27A	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_09                  =    UNIT_END + 0x27B	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_10                  =    UNIT_END + 0x27C	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_11                  =    UNIT_END + 0x27D	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_12                  =    UNIT_END + 0x27E	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_13                  =    UNIT_END + 0x27F	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_14                  =    UNIT_END + 0x280	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_15                  =    UNIT_END + 0x281	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_16                  =    UNIT_END + 0x282	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_17                  =    UNIT_END + 0x283	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_18                  =    UNIT_END + 0x284	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_19                  =    UNIT_END + 0x285	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_20                  =    UNIT_END + 0x286	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_21                  =    UNIT_END + 0x287	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_22                  =    UNIT_END + 0x288	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_23                  =    UNIT_END + 0x289	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_24                  =    UNIT_END + 0x28A	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_25                  =    UNIT_END + 0x28B	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_26                  =    UNIT_END + 0x28C	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_27                  =    UNIT_END + 0x28D	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_28                  =    UNIT_END + 0x28E	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_29                  =    UNIT_END + 0x28F	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_30                  =    UNIT_END + 0x290	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_31                  =    UNIT_END + 0x291	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_32                  =    UNIT_END + 0x292	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_33                  =    UNIT_END + 0x293	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_34                  =    UNIT_END + 0x294	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_35                  =    UNIT_END + 0x295	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_36                  =    UNIT_END + 0x296	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_37                  =    UNIT_END + 0x297	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_38                  =    UNIT_END + 0x298	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_39                  =    UNIT_END + 0x299	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_40                  =    UNIT_END + 0x29A	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_41                  =    UNIT_END + 0x29B	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_42                  =    UNIT_END + 0x29C	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_43                  =    UNIT_END + 0x29D	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_44                  =    UNIT_END + 0x29E	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_45                  =    UNIT_END + 0x29F	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_46                  =    UNIT_END + 0x2A0	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_47                  =    UNIT_END + 0x2A1	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_48                  =    UNIT_END + 0x2A2	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_49                  =    UNIT_END + 0x2A3	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_50                  =    UNIT_END + 0x2A4	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_51                  =    UNIT_END + 0x2A5	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_52                  =    UNIT_END + 0x2A6	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_53                  =    UNIT_END + 0x2A7	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_54                  =    UNIT_END + 0x2A8	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_55                  =    UNIT_END + 0x2A9	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_56                  =    UNIT_END + 0x2AA	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_57                  =    UNIT_END + 0x2AB	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_58                  =    UNIT_END + 0x2AC	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_59                  =    UNIT_END + 0x2AD	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_60                  =    UNIT_END + 0x2AE	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_61                  =    UNIT_END + 0x2AF	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_62                  =    UNIT_END + 0x2B0	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_KEYRING_SLOT_63                  =    UNIT_END + 0x2B1	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_1                 =    UNIT_END + 0x2B2	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_01                =    UNIT_END + 0x2B3	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_02                =    UNIT_END + 0x2B4	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_03                =    UNIT_END + 0x2B5	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_04                =    UNIT_END + 0x2B6	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_05                =    UNIT_END + 0x2B7	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_06                =    UNIT_END + 0x2B8	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_07                =    UNIT_END + 0x2B9	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_08                =    UNIT_END + 0x2BA	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_09                =    UNIT_END + 0x2BB	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_10                =    UNIT_END + 0x2BC	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_11                =    UNIT_END + 0x2BD	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_12                =    UNIT_END + 0x2BE	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_13                =    UNIT_END + 0x2BF	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_14                =    UNIT_END + 0x2C0	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_15                =    UNIT_END + 0x2C1	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_16                =    UNIT_END + 0x2C2	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_17                =    UNIT_END + 0x2C3	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_18                =    UNIT_END + 0x2C4	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_19                =    UNIT_END + 0x2C5	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_20                =    UNIT_END + 0x2C6	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_21                =    UNIT_END + 0x2C7	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_22                =    UNIT_END + 0x2C8	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_23                =    UNIT_END + 0x2C9	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_24                =    UNIT_END + 0x2CA	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_25                =    UNIT_END + 0x2CB	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_26                =    UNIT_END + 0x2CC	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_27                =    UNIT_END + 0x2CD	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_28                =    UNIT_END + 0x2CE	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_29                =    UNIT_END + 0x2CF	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_30                =    UNIT_END + 0x2D0	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_31                =    UNIT_END + 0x2D1	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_32                =    UNIT_END + 0x2D2	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_33                =    UNIT_END + 0x2D3	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_34                =    UNIT_END + 0x2D4	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_VANITYPET_SLOT_35                =    UNIT_END + 0x2D5	,   //Size:36  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_1             =    UNIT_END + 0x2D6	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_01            =    UNIT_END + 0x2D7	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_02            =    UNIT_END + 0x2D8	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_03            =    UNIT_END + 0x2D9	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_04            =    UNIT_END + 0x2DA	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_05            =    UNIT_END + 0x2DB	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_06            =    UNIT_END + 0x2DC	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_07            =    UNIT_END + 0x2DD	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_08            =    UNIT_END + 0x2DE	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_09            =    UNIT_END + 0x2DF	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_10            =    UNIT_END + 0x2E0	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_11            =    UNIT_END + 0x2E1	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_12            =    UNIT_END + 0x2E2	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_13            =    UNIT_END + 0x2E3	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_14            =    UNIT_END + 0x2E4	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_15            =    UNIT_END + 0x2E5	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_16            =    UNIT_END + 0x2E6	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_17            =    UNIT_END + 0x2E7	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_18            =    UNIT_END + 0x2E8	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_19            =    UNIT_END + 0x2E9	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_20            =    UNIT_END + 0x2EA	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_21            =    UNIT_END + 0x2EB	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_22            =    UNIT_END + 0x2EC	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_23            =    UNIT_END + 0x2ED	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_24            =    UNIT_END + 0x2EE	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_25            =    UNIT_END + 0x2EF	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_26            =    UNIT_END + 0x2F0	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_27            =    UNIT_END + 0x2F1	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_28            =    UNIT_END + 0x2F2	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_29            =    UNIT_END + 0x2F3	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_30            =    UNIT_END + 0x2F4	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_31            =    UNIT_END + 0x2F5	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_32            =    UNIT_END + 0x2F6	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_33            =    UNIT_END + 0x2F7	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_34            =    UNIT_END + 0x2F8	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_35            =    UNIT_END + 0x2F9	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_36            =    UNIT_END + 0x2FA	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_37            =    UNIT_END + 0x2FB	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_38            =    UNIT_END + 0x2FC	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_39            =    UNIT_END + 0x2FD	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_40            =    UNIT_END + 0x2FE	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_41            =    UNIT_END + 0x2FF	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_42            =    UNIT_END + 0x300	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_43            =    UNIT_END + 0x301	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_44            =    UNIT_END + 0x302	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_45            =    UNIT_END + 0x303	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_46            =    UNIT_END + 0x304	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_47            =    UNIT_END + 0x305	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_48            =    UNIT_END + 0x306	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_49            =    UNIT_END + 0x307	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_50            =    UNIT_END + 0x308	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_51            =    UNIT_END + 0x309	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_52            =    UNIT_END + 0x30A	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_53            =    UNIT_END + 0x30B	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_54            =    UNIT_END + 0x30C	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_55            =    UNIT_END + 0x30D	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_56            =    UNIT_END + 0x30E	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_57            =    UNIT_END + 0x30F	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_58            =    UNIT_END + 0x310	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_59            =    UNIT_END + 0x311	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_60            =    UNIT_END + 0x312	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_61            =    UNIT_END + 0x313	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_62            =    UNIT_END + 0x314	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_CURRENCYTOKEN_SLOT_63            =    UNIT_END + 0x315	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_1                  =    UNIT_END + 0x316	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_01                 =    UNIT_END + 0x317	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_02                 =    UNIT_END + 0x318	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_03                 =    UNIT_END + 0x319	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_04                 =    UNIT_END + 0x31A	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_05                 =    UNIT_END + 0x31B	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_06                 =    UNIT_END + 0x31C	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_07                 =    UNIT_END + 0x31D	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_08                 =    UNIT_END + 0x31E	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_09                 =    UNIT_END + 0x31F	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_10                 =    UNIT_END + 0x320	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_11                 =    UNIT_END + 0x321	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_12                 =    UNIT_END + 0x322	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_13                 =    UNIT_END + 0x323	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_14                 =    UNIT_END + 0x324	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_15                 =    UNIT_END + 0x325	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_16                 =    UNIT_END + 0x326	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_17                 =    UNIT_END + 0x327	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_18                 =    UNIT_END + 0x328	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_19                 =    UNIT_END + 0x329	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_20                 =    UNIT_END + 0x32A	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_21                 =    UNIT_END + 0x32B	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_22                 =    UNIT_END + 0x32C	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_23                 =    UNIT_END + 0x32D	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_24                 =    UNIT_END + 0x32E	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_25                 =    UNIT_END + 0x32F	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_26                 =    UNIT_END + 0x330	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_27                 =    UNIT_END + 0x331	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_28                 =    UNIT_END + 0x332	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_29                 =    UNIT_END + 0x333	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_30                 =    UNIT_END + 0x334	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_31                 =    UNIT_END + 0x335	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_32                 =    UNIT_END + 0x336	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_33                 =    UNIT_END + 0x337	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_34                 =    UNIT_END + 0x338	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_35                 =    UNIT_END + 0x339	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_36                 =    UNIT_END + 0x33A	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_37                 =    UNIT_END + 0x33B	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_38                 =    UNIT_END + 0x33C	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_39                 =    UNIT_END + 0x33D	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_40                 =    UNIT_END + 0x33E	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_41                 =    UNIT_END + 0x33F	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_42                 =    UNIT_END + 0x340	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_43                 =    UNIT_END + 0x341	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_44                 =    UNIT_END + 0x342	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_45                 =    UNIT_END + 0x343	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_46                 =    UNIT_END + 0x344	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_47                 =    UNIT_END + 0x345	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_48                 =    UNIT_END + 0x346	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_49                 =    UNIT_END + 0x347	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_50                 =    UNIT_END + 0x348	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_51                 =    UNIT_END + 0x349	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_52                 =    UNIT_END + 0x34A	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_53                 =    UNIT_END + 0x34B	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_54                 =    UNIT_END + 0x34C	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_55                 =    UNIT_END + 0x34D	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_56                 =    UNIT_END + 0x34E	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_57                 =    UNIT_END + 0x34F	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_58                 =    UNIT_END + 0x350	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_59                 =    UNIT_END + 0x351	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_60                 =    UNIT_END + 0x352	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_61                 =    UNIT_END + 0x353	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_62                 =    UNIT_END + 0x354	,   //Size:64  Type:GUID  Flags:2
PLAYER_FIELD_QUESTBAG_SLOT_63                 =    UNIT_END + 0x355	,   //Size:64  Type:GUID  Flags:2
PLAYER_FARSIGHT                               =    UNIT_END + 0x356	,   //Size:2  Type:GUID  Flags:2
PLAYER_FARSIGHT_01                            =    UNIT_END + 0x357	,   //Size:2  Type:GUID  Flags:2
PLAYER_FIELD_KNOWN_TITLES                    =    UNIT_END + 0x358	,   //Size:2  Type:GUID  Flags:2
PLAYER_FIELD_KNOWN_TITLES_01                 =    UNIT_END + 0x359	,   //Size:2  Type:GUID  Flags:2
PLAYER_FIELD_KNOWN_TITLES1                   =    UNIT_END + 0x35A	,   //Size:2  Type:GUID  Flags:2
PLAYER_FIELD_KNOWN_TITLES01                  =    UNIT_END + 0x35B	,   //Size:2  Type:GUID  Flags:2
PLAYER_FIELD_KNOWN_CURRENCIES                 =    UNIT_END + 0x35C	,   //Size:2  Type:GUID  Flags:2
PLAYER_FIELD_KNOWN_CURRENCIES_01              =    UNIT_END + 0x35D	,   //Size:2  Type:GUID  Flags:2
PLAYER_XP                                     =    UNIT_END + 0x35E	,   //Size:1  Type:Int32  Flags:2
PLAYER_NEXT_LEVEL_XP                          =    UNIT_END + 0x35F	,   //Size:1  Type:Int32  Flags:2
PLAYER_SKILL_INFO_1_1                         =    UNIT_END + 0x360	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_01                        =    UNIT_END + 0x361	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_02                        =    UNIT_END + 0x362	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_03                        =    UNIT_END + 0x363	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_04                        =    UNIT_END + 0x364	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_05                        =    UNIT_END + 0x365	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_06                        =    UNIT_END + 0x366	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_07                        =    UNIT_END + 0x367	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_08                        =    UNIT_END + 0x368	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_09                        =    UNIT_END + 0x369	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_10                        =    UNIT_END + 0x36A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_11                        =    UNIT_END + 0x36B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_12                        =    UNIT_END + 0x36C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_13                        =    UNIT_END + 0x36D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_14                        =    UNIT_END + 0x36E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_15                        =    UNIT_END + 0x36F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_16                        =    UNIT_END + 0x370	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_17                        =    UNIT_END + 0x371	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_18                        =    UNIT_END + 0x372	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_19                        =    UNIT_END + 0x373	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_20                        =    UNIT_END + 0x374	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_21                        =    UNIT_END + 0x375	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_22                        =    UNIT_END + 0x376	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_23                        =    UNIT_END + 0x377	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_24                        =    UNIT_END + 0x378	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_25                        =    UNIT_END + 0x379	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_26                        =    UNIT_END + 0x37A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_27                        =    UNIT_END + 0x37B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_28                        =    UNIT_END + 0x37C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_29                        =    UNIT_END + 0x37D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_30                        =    UNIT_END + 0x37E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_31                        =    UNIT_END + 0x37F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_32                        =    UNIT_END + 0x380	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_33                        =    UNIT_END + 0x381	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_34                        =    UNIT_END + 0x382	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_35                        =    UNIT_END + 0x383	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_36                        =    UNIT_END + 0x384	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_37                        =    UNIT_END + 0x385	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_38                        =    UNIT_END + 0x386	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_39                        =    UNIT_END + 0x387	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_40                        =    UNIT_END + 0x388	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_41                        =    UNIT_END + 0x389	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_42                        =    UNIT_END + 0x38A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_43                        =    UNIT_END + 0x38B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_44                        =    UNIT_END + 0x38C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_45                        =    UNIT_END + 0x38D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_46                        =    UNIT_END + 0x38E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_47                        =    UNIT_END + 0x38F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_48                        =    UNIT_END + 0x390	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_49                        =    UNIT_END + 0x391	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_50                        =    UNIT_END + 0x392	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_51                        =    UNIT_END + 0x393	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_52                        =    UNIT_END + 0x394	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_53                        =    UNIT_END + 0x395	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_54                        =    UNIT_END + 0x396	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_55                        =    UNIT_END + 0x397	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_56                        =    UNIT_END + 0x398	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_57                        =    UNIT_END + 0x399	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_58                        =    UNIT_END + 0x39A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_59                        =    UNIT_END + 0x39B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_60                        =    UNIT_END + 0x39C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_61                        =    UNIT_END + 0x39D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_62                        =    UNIT_END + 0x39E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_63                        =    UNIT_END + 0x39F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_64                        =    UNIT_END + 0x3A0	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_65                        =    UNIT_END + 0x3A1	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_66                        =    UNIT_END + 0x3A2	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_67                        =    UNIT_END + 0x3A3	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_68                        =    UNIT_END + 0x3A4	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_69                        =    UNIT_END + 0x3A5	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_70                        =    UNIT_END + 0x3A6	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_71                        =    UNIT_END + 0x3A7	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_72                        =    UNIT_END + 0x3A8	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_73                        =    UNIT_END + 0x3A9	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_74                        =    UNIT_END + 0x3AA	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_75                        =    UNIT_END + 0x3AB	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_76                        =    UNIT_END + 0x3AC	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_77                        =    UNIT_END + 0x3AD	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_78                        =    UNIT_END + 0x3AE	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_79                        =    UNIT_END + 0x3AF	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_80                        =    UNIT_END + 0x3B0	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_81                        =    UNIT_END + 0x3B1	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_82                        =    UNIT_END + 0x3B2	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_83                        =    UNIT_END + 0x3B3	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_84                        =    UNIT_END + 0x3B4	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_85                        =    UNIT_END + 0x3B5	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_86                        =    UNIT_END + 0x3B6	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_87                        =    UNIT_END + 0x3B7	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_88                        =    UNIT_END + 0x3B8	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_89                        =    UNIT_END + 0x3B9	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_90                        =    UNIT_END + 0x3BA	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_91                        =    UNIT_END + 0x3BB	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_92                        =    UNIT_END + 0x3BC	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_93                        =    UNIT_END + 0x3BD	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_94                        =    UNIT_END + 0x3BE	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_95                        =    UNIT_END + 0x3BF	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_96                        =    UNIT_END + 0x3C0	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_97                        =    UNIT_END + 0x3C1	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_98                        =    UNIT_END + 0x3C2	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_99                        =    UNIT_END + 0x3C3	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_100                       =    UNIT_END + 0x3C4	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_101                       =    UNIT_END + 0x3C5	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_102                       =    UNIT_END + 0x3C6	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_103                       =    UNIT_END + 0x3C7	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_104                       =    UNIT_END + 0x3C8	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_105                       =    UNIT_END + 0x3C9	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_106                       =    UNIT_END + 0x3CA	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_107                       =    UNIT_END + 0x3CB	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_108                       =    UNIT_END + 0x3CC	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_109                       =    UNIT_END + 0x3CD	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_110                       =    UNIT_END + 0x3CE	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_111                       =    UNIT_END + 0x3CF	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_112                       =    UNIT_END + 0x3D0	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_113                       =    UNIT_END + 0x3D1	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_114                       =    UNIT_END + 0x3D2	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_115                       =    UNIT_END + 0x3D3	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_116                       =    UNIT_END + 0x3D4	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_117                       =    UNIT_END + 0x3D5	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_118                       =    UNIT_END + 0x3D6	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_119                       =    UNIT_END + 0x3D7	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_120                       =    UNIT_END + 0x3D8	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_121                       =    UNIT_END + 0x3D9	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_122                       =    UNIT_END + 0x3DA	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_123                       =    UNIT_END + 0x3DB	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_124                       =    UNIT_END + 0x3DC	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_125                       =    UNIT_END + 0x3DD	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_126                       =    UNIT_END + 0x3DE	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_127                       =    UNIT_END + 0x3DF	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_128                       =    UNIT_END + 0x3E0	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_129                       =    UNIT_END + 0x3E1	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_130                       =    UNIT_END + 0x3E2	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_131                       =    UNIT_END + 0x3E3	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_132                       =    UNIT_END + 0x3E4	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_133                       =    UNIT_END + 0x3E5	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_134                       =    UNIT_END + 0x3E6	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_135                       =    UNIT_END + 0x3E7	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_136                       =    UNIT_END + 0x3E8	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_137                       =    UNIT_END + 0x3E9	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_138                       =    UNIT_END + 0x3EA	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_139                       =    UNIT_END + 0x3EB	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_140                       =    UNIT_END + 0x3EC	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_141                       =    UNIT_END + 0x3ED	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_142                       =    UNIT_END + 0x3EE	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_143                       =    UNIT_END + 0x3EF	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_144                       =    UNIT_END + 0x3F0	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_145                       =    UNIT_END + 0x3F1	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_146                       =    UNIT_END + 0x3F2	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_147                       =    UNIT_END + 0x3F3	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_148                       =    UNIT_END + 0x3F4	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_149                       =    UNIT_END + 0x3F5	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_150                       =    UNIT_END + 0x3F6	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_151                       =    UNIT_END + 0x3F7	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_152                       =    UNIT_END + 0x3F8	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_153                       =    UNIT_END + 0x3F9	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_154                       =    UNIT_END + 0x3FA	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_155                       =    UNIT_END + 0x3FB	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_156                       =    UNIT_END + 0x3FC	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_157                       =    UNIT_END + 0x3FD	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_158                       =    UNIT_END + 0x3FE	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_159                       =    UNIT_END + 0x3FF	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_160                       =    UNIT_END + 0x400	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_161                       =    UNIT_END + 0x401	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_162                       =    UNIT_END + 0x402	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_163                       =    UNIT_END + 0x403	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_164                       =    UNIT_END + 0x404	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_165                       =    UNIT_END + 0x405	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_166                       =    UNIT_END + 0x406	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_167                       =    UNIT_END + 0x407	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_168                       =    UNIT_END + 0x408	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_169                       =    UNIT_END + 0x409	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_170                       =    UNIT_END + 0x40A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_171                       =    UNIT_END + 0x40B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_172                       =    UNIT_END + 0x40C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_173                       =    UNIT_END + 0x40D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_174                       =    UNIT_END + 0x40E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_175                       =    UNIT_END + 0x40F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_176                       =    UNIT_END + 0x410	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_177                       =    UNIT_END + 0x411	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_178                       =    UNIT_END + 0x412	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_179                       =    UNIT_END + 0x413	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_180                       =    UNIT_END + 0x414	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_181                       =    UNIT_END + 0x415	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_182                       =    UNIT_END + 0x416	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_183                       =    UNIT_END + 0x417	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_184                       =    UNIT_END + 0x418	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_185                       =    UNIT_END + 0x419	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_186                       =    UNIT_END + 0x41A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_187                       =    UNIT_END + 0x41B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_188                       =    UNIT_END + 0x41C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_189                       =    UNIT_END + 0x41D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_190                       =    UNIT_END + 0x41E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_191                       =    UNIT_END + 0x41F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_192                       =    UNIT_END + 0x420	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_193                       =    UNIT_END + 0x421	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_194                       =    UNIT_END + 0x422	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_195                       =    UNIT_END + 0x423	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_196                       =    UNIT_END + 0x424	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_197                       =    UNIT_END + 0x425	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_198                       =    UNIT_END + 0x426	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_199                       =    UNIT_END + 0x427	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_200                       =    UNIT_END + 0x428	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_201                       =    UNIT_END + 0x429	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_202                       =    UNIT_END + 0x42A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_203                       =    UNIT_END + 0x42B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_204                       =    UNIT_END + 0x42C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_205                       =    UNIT_END + 0x42D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_206                       =    UNIT_END + 0x42E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_207                       =    UNIT_END + 0x42F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_208                       =    UNIT_END + 0x430	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_209                       =    UNIT_END + 0x431	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_210                       =    UNIT_END + 0x432	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_211                       =    UNIT_END + 0x433	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_212                       =    UNIT_END + 0x434	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_213                       =    UNIT_END + 0x435	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_214                       =    UNIT_END + 0x436	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_215                       =    UNIT_END + 0x437	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_216                       =    UNIT_END + 0x438	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_217                       =    UNIT_END + 0x439	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_218                       =    UNIT_END + 0x43A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_219                       =    UNIT_END + 0x43B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_220                       =    UNIT_END + 0x43C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_221                       =    UNIT_END + 0x43D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_222                       =    UNIT_END + 0x43E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_223                       =    UNIT_END + 0x43F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_224                       =    UNIT_END + 0x440	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_225                       =    UNIT_END + 0x441	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_226                       =    UNIT_END + 0x442	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_227                       =    UNIT_END + 0x443	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_228                       =    UNIT_END + 0x444	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_229                       =    UNIT_END + 0x445	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_230                       =    UNIT_END + 0x446	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_231                       =    UNIT_END + 0x447	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_232                       =    UNIT_END + 0x448	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_233                       =    UNIT_END + 0x449	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_234                       =    UNIT_END + 0x44A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_235                       =    UNIT_END + 0x44B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_236                       =    UNIT_END + 0x44C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_237                       =    UNIT_END + 0x44D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_238                       =    UNIT_END + 0x44E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_239                       =    UNIT_END + 0x44F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_240                       =    UNIT_END + 0x450	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_241                       =    UNIT_END + 0x451	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_242                       =    UNIT_END + 0x452	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_243                       =    UNIT_END + 0x453	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_244                       =    UNIT_END + 0x454	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_245                       =    UNIT_END + 0x455	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_246                       =    UNIT_END + 0x456	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_247                       =    UNIT_END + 0x457	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_248                       =    UNIT_END + 0x458	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_249                       =    UNIT_END + 0x459	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_250                       =    UNIT_END + 0x45A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_251                       =    UNIT_END + 0x45B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_252                       =    UNIT_END + 0x45C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_253                       =    UNIT_END + 0x45D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_254                       =    UNIT_END + 0x45E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_255                       =    UNIT_END + 0x45F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_256                       =    UNIT_END + 0x460	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_257                       =    UNIT_END + 0x461	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_258                       =    UNIT_END + 0x462	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_259                       =    UNIT_END + 0x463	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_260                       =    UNIT_END + 0x464	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_261                       =    UNIT_END + 0x465	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_262                       =    UNIT_END + 0x466	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_263                       =    UNIT_END + 0x467	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_264                       =    UNIT_END + 0x468	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_265                       =    UNIT_END + 0x469	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_266                       =    UNIT_END + 0x46A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_267                       =    UNIT_END + 0x46B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_268                       =    UNIT_END + 0x46C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_269                       =    UNIT_END + 0x46D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_270                       =    UNIT_END + 0x46E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_271                       =    UNIT_END + 0x46F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_272                       =    UNIT_END + 0x470	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_273                       =    UNIT_END + 0x471	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_274                       =    UNIT_END + 0x472	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_275                       =    UNIT_END + 0x473	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_276                       =    UNIT_END + 0x474	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_277                       =    UNIT_END + 0x475	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_278                       =    UNIT_END + 0x476	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_279                       =    UNIT_END + 0x477	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_280                       =    UNIT_END + 0x478	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_281                       =    UNIT_END + 0x479	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_282                       =    UNIT_END + 0x47A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_283                       =    UNIT_END + 0x47B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_284                       =    UNIT_END + 0x47C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_285                       =    UNIT_END + 0x47D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_286                       =    UNIT_END + 0x47E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_287                       =    UNIT_END + 0x47F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_288                       =    UNIT_END + 0x480	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_289                       =    UNIT_END + 0x481	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_290                       =    UNIT_END + 0x482	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_291                       =    UNIT_END + 0x483	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_292                       =    UNIT_END + 0x484	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_293                       =    UNIT_END + 0x485	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_294                       =    UNIT_END + 0x486	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_295                       =    UNIT_END + 0x487	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_296                       =    UNIT_END + 0x488	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_297                       =    UNIT_END + 0x489	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_298                       =    UNIT_END + 0x48A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_299                       =    UNIT_END + 0x48B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_300                       =    UNIT_END + 0x48C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_301                       =    UNIT_END + 0x48D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_302                       =    UNIT_END + 0x48E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_303                       =    UNIT_END + 0x48F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_304                       =    UNIT_END + 0x490	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_305                       =    UNIT_END + 0x491	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_306                       =    UNIT_END + 0x492	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_307                       =    UNIT_END + 0x493	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_308                       =    UNIT_END + 0x494	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_309                       =    UNIT_END + 0x495	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_310                       =    UNIT_END + 0x496	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_311                       =    UNIT_END + 0x497	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_312                       =    UNIT_END + 0x498	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_313                       =    UNIT_END + 0x499	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_314                       =    UNIT_END + 0x49A	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_315                       =    UNIT_END + 0x49B	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_316                       =    UNIT_END + 0x49C	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_317                       =    UNIT_END + 0x49D	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_318                       =    UNIT_END + 0x49E	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_319                       =    UNIT_END + 0x49F	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_320                       =    UNIT_END + 0x4A0	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_321                       =    UNIT_END + 0x4A1	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_322                       =    UNIT_END + 0x4A2	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_323                       =    UNIT_END + 0x4A3	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_324                       =    UNIT_END + 0x4A4	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_325                       =    UNIT_END + 0x4A5	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_326                       =    UNIT_END + 0x4A6	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_327                       =    UNIT_END + 0x4A7	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_328                       =    UNIT_END + 0x4A8	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_329                       =    UNIT_END + 0x4A9	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_330                       =    UNIT_END + 0x4AA	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_331                       =    UNIT_END + 0x4AB	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_332                       =    UNIT_END + 0x4AC	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_333                       =    UNIT_END + 0x4AD	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_334                       =    UNIT_END + 0x4AE	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_335                       =    UNIT_END + 0x4AF	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_336                       =    UNIT_END + 0x4B0	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_337                       =    UNIT_END + 0x4B1	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_338                       =    UNIT_END + 0x4B2	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_339                       =    UNIT_END + 0x4B3	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_340                       =    UNIT_END + 0x4B4	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_341                       =    UNIT_END + 0x4B5	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_342                       =    UNIT_END + 0x4B6	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_343                       =    UNIT_END + 0x4B7	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_344                       =    UNIT_END + 0x4B8	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_345                       =    UNIT_END + 0x4B9	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_346                       =    UNIT_END + 0x4BA	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_347                       =    UNIT_END + 0x4BB	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_348                       =    UNIT_END + 0x4BC	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_349                       =    UNIT_END + 0x4BD	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_350                       =    UNIT_END + 0x4BE	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_351                       =    UNIT_END + 0x4BF	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_352                       =    UNIT_END + 0x4C0	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_353                       =    UNIT_END + 0x4C1	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_354                       =    UNIT_END + 0x4C2	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_355                       =    UNIT_END + 0x4C3	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_356                       =    UNIT_END + 0x4C4	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_357                       =    UNIT_END + 0x4C5	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_358                       =    UNIT_END + 0x4C6	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_359                       =    UNIT_END + 0x4C7	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_360                       =    UNIT_END + 0x4C8	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_361                       =    UNIT_END + 0x4C9	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_362                       =    UNIT_END + 0x4CA	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_363                       =    UNIT_END + 0x4CB	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_364                       =    UNIT_END + 0x4CC	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_365                       =    UNIT_END + 0x4CD	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_366                       =    UNIT_END + 0x4CE	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_367                       =    UNIT_END + 0x4CF	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_368                       =    UNIT_END + 0x4D0	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_369                       =    UNIT_END + 0x4D1	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_370                       =    UNIT_END + 0x4D2	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_371                       =    UNIT_END + 0x4D3	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_372                       =    UNIT_END + 0x4D4	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_373                       =    UNIT_END + 0x4D5	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_374                       =    UNIT_END + 0x4D6	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_375                       =    UNIT_END + 0x4D7	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_376                       =    UNIT_END + 0x4D8	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_377                       =    UNIT_END + 0x4D9	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_378                       =    UNIT_END + 0x4DA	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_379                       =    UNIT_END + 0x4DB	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_380                       =    UNIT_END + 0x4DC	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_381                       =    UNIT_END + 0x4DD	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_382                       =    UNIT_END + 0x4DE	,   //Size:384  Type:Chars?  Flags:2
PLAYER_SKILL_INFO_1_383                       =    UNIT_END + 0x4DF	,   //Size:384  Type:Chars?  Flags:2
PLAYER_CHARACTER_POINTS1                      =    UNIT_END + 0x4E0	,   //Size:1  Type:Int32  Flags:2
PLAYER_CHARACTER_POINTS2                      =    UNIT_END + 0x4E1	,   //Size:1  Type:Int32  Flags:2
PLAYER_TRACK_CREATURES                        =    UNIT_END + 0x4E2	,   //Size:1  Type:Int32  Flags:2
PLAYER_TRACK_RESOURCES                        =    UNIT_END + 0x4E3	,   //Size:1  Type:Int32  Flags:2
PLAYER_BLOCK_PERCENTAGE                       =    UNIT_END + 0x4E4	,   //Size:1  Type:Float  Flags:2
PLAYER_DODGE_PERCENTAGE                       =    UNIT_END + 0x4E5	,   //Size:1  Type:Float  Flags:2
PLAYER_PARRY_PERCENTAGE                       =    UNIT_END + 0x4E6	,   //Size:1  Type:Float  Flags:2
PLAYER_EXPERTISE                              =    UNIT_END + 0x4E7	,   //Size:1  Type:Int32  Flags:2
PLAYER_OFFHAND_EXPERTISE                      =    UNIT_END + 0x4E8	,   //Size:1  Type:Int32  Flags:2
PLAYER_CRIT_PERCENTAGE                        =    UNIT_END + 0x4E9	,   //Size:1  Type:Float  Flags:2
PLAYER_RANGED_CRIT_PERCENTAGE                 =    UNIT_END + 0x4EA	,   //Size:1  Type:Float  Flags:2
PLAYER_OFFHAND_CRIT_PERCENTAGE                =    UNIT_END + 0x4EB	,   //Size:1  Type:Float  Flags:2
PLAYER_SPELL_CRIT_PERCENTAGE1                 =    UNIT_END + 0x4EC	,   //Size:7  Type:Float  Flags:2
PLAYER_SPELL_CRIT_PERCENTAGE01                =    UNIT_END + 0x4ED	,   //Size:7  Type:Float  Flags:2
PLAYER_SPELL_CRIT_PERCENTAGE02                =    UNIT_END + 0x4EE	,   //Size:7  Type:Float  Flags:2
PLAYER_SPELL_CRIT_PERCENTAGE03                =    UNIT_END + 0x4EF	,   //Size:7  Type:Float  Flags:2
PLAYER_SPELL_CRIT_PERCENTAGE04                =    UNIT_END + 0x4F0	,   //Size:7  Type:Float  Flags:2
PLAYER_SPELL_CRIT_PERCENTAGE05                =    UNIT_END + 0x4F1	,   //Size:7  Type:Float  Flags:2
PLAYER_SPELL_CRIT_PERCENTAGE06                =    UNIT_END + 0x4F2	,   //Size:7  Type:Float  Flags:2
PLAYER_SHIELD_BLOCK                           =    UNIT_END + 0x4F3	,   //Size:1  Type:Int32  Flags:2
PLAYER_SHIELD_BLOCK_CRIT_PERCENTAGE           =    UNIT_END + 0x4F4	,   //Size:1  Type:Float  Flags:2
PLAYER_EXPLORED_ZONES_1                       =    UNIT_END + 0x4F5	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_01                      =    UNIT_END + 0x4F6	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_02                      =    UNIT_END + 0x4F7	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_03                      =    UNIT_END + 0x4F8	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_04                      =    UNIT_END + 0x4F9	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_05                      =    UNIT_END + 0x4FA	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_06                      =    UNIT_END + 0x4FB	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_07                      =    UNIT_END + 0x4FC	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_08                      =    UNIT_END + 0x4FD	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_09                      =    UNIT_END + 0x4FE	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_10                      =    UNIT_END + 0x4FF	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_11                      =    UNIT_END + 0x500	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_12                      =    UNIT_END + 0x501	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_13                      =    UNIT_END + 0x502	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_14                      =    UNIT_END + 0x503	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_15                      =    UNIT_END + 0x504	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_16                      =    UNIT_END + 0x505	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_17                      =    UNIT_END + 0x506	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_18                      =    UNIT_END + 0x507	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_19                      =    UNIT_END + 0x508	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_20                      =    UNIT_END + 0x509	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_21                      =    UNIT_END + 0x50A	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_22                      =    UNIT_END + 0x50B	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_23                      =    UNIT_END + 0x50C	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_24                      =    UNIT_END + 0x50D	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_25                      =    UNIT_END + 0x50E	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_26                      =    UNIT_END + 0x50F	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_27                      =    UNIT_END + 0x510	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_28                      =    UNIT_END + 0x511	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_29                      =    UNIT_END + 0x512	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_30                      =    UNIT_END + 0x513	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_31                      =    UNIT_END + 0x514	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_32                      =    UNIT_END + 0x515	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_33                      =    UNIT_END + 0x516	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_34                      =    UNIT_END + 0x517	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_35                      =    UNIT_END + 0x518	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_36                      =    UNIT_END + 0x519	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_37                      =    UNIT_END + 0x51A	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_38                      =    UNIT_END + 0x51B	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_39                      =    UNIT_END + 0x51C	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_40                      =    UNIT_END + 0x51D	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_41                      =    UNIT_END + 0x51E	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_42                      =    UNIT_END + 0x51F	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_43                      =    UNIT_END + 0x520	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_44                      =    UNIT_END + 0x521	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_45                      =    UNIT_END + 0x522	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_46                      =    UNIT_END + 0x523	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_47                      =    UNIT_END + 0x524	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_48                      =    UNIT_END + 0x525	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_49                      =    UNIT_END + 0x526	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_50                      =    UNIT_END + 0x527	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_51                      =    UNIT_END + 0x528	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_52                      =    UNIT_END + 0x529	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_53                      =    UNIT_END + 0x52A	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_54                      =    UNIT_END + 0x52B	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_55                      =    UNIT_END + 0x52C	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_56                      =    UNIT_END + 0x52D	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_57                      =    UNIT_END + 0x52E	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_58                      =    UNIT_END + 0x52F	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_59                      =    UNIT_END + 0x530	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_60                      =    UNIT_END + 0x531	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_61                      =    UNIT_END + 0x532	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_62                      =    UNIT_END + 0x533	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_63                      =    UNIT_END + 0x534	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_64                      =    UNIT_END + 0x535	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_65                      =    UNIT_END + 0x536	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_66                      =    UNIT_END + 0x537	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_67                      =    UNIT_END + 0x538	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_68                      =    UNIT_END + 0x539	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_69                      =    UNIT_END + 0x53A	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_70                      =    UNIT_END + 0x53B	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_71                      =    UNIT_END + 0x53C	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_72                      =    UNIT_END + 0x53D	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_73                      =    UNIT_END + 0x53E	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_74                      =    UNIT_END + 0x53F	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_75                      =    UNIT_END + 0x540	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_76                      =    UNIT_END + 0x541	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_77                      =    UNIT_END + 0x542	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_78                      =    UNIT_END + 0x543	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_79                      =    UNIT_END + 0x544	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_80                      =    UNIT_END + 0x545	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_81                      =    UNIT_END + 0x546	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_82                      =    UNIT_END + 0x547	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_83                      =    UNIT_END + 0x548	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_84                      =    UNIT_END + 0x549	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_85                      =    UNIT_END + 0x54A	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_86                      =    UNIT_END + 0x54B	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_87                      =    UNIT_END + 0x54C	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_88                      =    UNIT_END + 0x54D	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_89                      =    UNIT_END + 0x54E	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_90                      =    UNIT_END + 0x54F	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_91                      =    UNIT_END + 0x550	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_92                      =    UNIT_END + 0x551	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_93                      =    UNIT_END + 0x552	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_94                      =    UNIT_END + 0x553	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_95                      =    UNIT_END + 0x554	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_96                      =    UNIT_END + 0x555	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_97                      =    UNIT_END + 0x556	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_98                      =    UNIT_END + 0x557	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_99                      =    UNIT_END + 0x558	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_100                     =    UNIT_END + 0x559	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_101                     =    UNIT_END + 0x55A	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_102                     =    UNIT_END + 0x55B	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_103                     =    UNIT_END + 0x55C	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_104                     =    UNIT_END + 0x55D	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_105                     =    UNIT_END + 0x55E	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_106                     =    UNIT_END + 0x55F	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_107                     =    UNIT_END + 0x560	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_108                     =    UNIT_END + 0x561	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_109                     =    UNIT_END + 0x562	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_110                     =    UNIT_END + 0x563	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_111                     =    UNIT_END + 0x564	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_112                     =    UNIT_END + 0x565	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_113                     =    UNIT_END + 0x566	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_114                     =    UNIT_END + 0x567	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_115                     =    UNIT_END + 0x568	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_116                     =    UNIT_END + 0x569	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_117                     =    UNIT_END + 0x56A	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_118                     =    UNIT_END + 0x56B	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_119                     =    UNIT_END + 0x56C	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_120                     =    UNIT_END + 0x56D	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_121                     =    UNIT_END + 0x56E	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_122                     =    UNIT_END + 0x56F	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_123                     =    UNIT_END + 0x570	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_124                     =    UNIT_END + 0x571	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_125                     =    UNIT_END + 0x572	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_126                     =    UNIT_END + 0x573	,   //Size:128  Type:Bytes  Flags:2
PLAYER_EXPLORED_ZONES_127                     =    UNIT_END + 0x574	,   //Size:128  Type:Bytes  Flags:2
PLAYER_REST_STATE_EXPERIENCE                  =    UNIT_END + 0x575	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_COINAGE                          =    UNIT_END + 0x576	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_POS              =    UNIT_END + 0x577	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_POS_01           =    UNIT_END + 0x578	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_POS_02           =    UNIT_END + 0x579	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_POS_03           =    UNIT_END + 0x57A	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_POS_04           =    UNIT_END + 0x57B	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_POS_05           =    UNIT_END + 0x57C	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_POS_06           =    UNIT_END + 0x57D	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_NEG              =    UNIT_END + 0x57E	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_01           =    UNIT_END + 0x57F	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_02           =    UNIT_END + 0x580	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_03           =    UNIT_END + 0x581	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_04           =    UNIT_END + 0x582	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_05           =    UNIT_END + 0x583	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_NEG_06           =    UNIT_END + 0x584	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_PCT              =    UNIT_END + 0x585	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_01           =    UNIT_END + 0x586	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_02           =    UNIT_END + 0x587	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_03           =    UNIT_END + 0x588	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_04           =    UNIT_END + 0x589	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_05           =    UNIT_END + 0x58A	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_DAMAGE_DONE_PCT_06           =    UNIT_END + 0x58B	,   //Size:7  Type:Int32  Flags:2
PLAYER_FIELD_MOD_HEALING_DONE_POS             =    UNIT_END + 0x58C	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_MOD_TARGET_RESISTANCE            =    UNIT_END + 0x58D	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_MOD_TARGET_PHYSICAL_RESISTANCE   =    UNIT_END + 0x58E	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_BYTES                            =    UNIT_END + 0x58F	,   //Size:1  Type:Bytes  Flags:2
PLAYER_AMMO_ID                                =    UNIT_END + 0x590	,   //Size:1  Type:Int32  Flags:2
PLAYER_SELF_RES_SPELL                         =    UNIT_END + 0x591	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_PVP_MEDALS                       =    UNIT_END + 0x592	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_1                  =    UNIT_END + 0x593	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_01                 =    UNIT_END + 0x594	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_02                 =    UNIT_END + 0x595	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_03                 =    UNIT_END + 0x596	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_04                 =    UNIT_END + 0x597	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_05                 =    UNIT_END + 0x598	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_06                 =    UNIT_END + 0x599	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_07                 =    UNIT_END + 0x59A	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_08                 =    UNIT_END + 0x59B	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_09                 =    UNIT_END + 0x59C	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_10                 =    UNIT_END + 0x59D	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_PRICE_11                 =    UNIT_END + 0x59E	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_1              =    UNIT_END + 0x59F	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_01             =    UNIT_END + 0x5A0	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_02             =    UNIT_END + 0x5A1	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_03             =    UNIT_END + 0x5A2	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_04             =    UNIT_END + 0x5A3	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_05             =    UNIT_END + 0x5A4	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_06             =    UNIT_END + 0x5A5	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_07             =    UNIT_END + 0x5A6	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_08             =    UNIT_END + 0x5A7	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_09             =    UNIT_END + 0x5A8	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_10             =    UNIT_END + 0x5A9	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_BUYBACK_TIMESTAMP_11             =    UNIT_END + 0x5AA	,   //Size:12  Type:Int32  Flags:2
PLAYER_FIELD_KILLS                            =    UNIT_END + 0x5AB	,   //Size:1  Type:Chars?  Flags:2
PLAYER_FIELD_TODAY_CONTRIBUTION               =    UNIT_END + 0x5AC	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_YESTERDAY_CONTRIBUTION           =    UNIT_END + 0x5AD	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_LIFETIME_HONORBALE_KILLS         =    UNIT_END + 0x5AE	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_BYTES2                           =    UNIT_END + 0x5AF	,   //Size:1  Type:Bytes  Flags:2
PLAYER_FIELD_WATCHED_FACTION_INDEX            =    UNIT_END + 0x5B0	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_1                  =    UNIT_END + 0x5B1	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_01                 =    UNIT_END + 0x5B2	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_02                 =    UNIT_END + 0x5B3	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_03                 =    UNIT_END + 0x5B4	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_04                 =    UNIT_END + 0x5B5	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_05                 =    UNIT_END + 0x5B6	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_06                 =    UNIT_END + 0x5B7	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_07                 =    UNIT_END + 0x5B8	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_08                 =    UNIT_END + 0x5B9	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_09                 =    UNIT_END + 0x5BA	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_10                 =    UNIT_END + 0x5BB	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_11                 =    UNIT_END + 0x5BC	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_12                 =    UNIT_END + 0x5BD	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_13                 =    UNIT_END + 0x5BE	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_14                 =    UNIT_END + 0x5BF	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_15                 =    UNIT_END + 0x5C0	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_16                 =    UNIT_END + 0x5C1	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_17                 =    UNIT_END + 0x5C2	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_18                 =    UNIT_END + 0x5C3	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_19                 =    UNIT_END + 0x5C4	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_20                 =    UNIT_END + 0x5C5	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_21                 =    UNIT_END + 0x5C6	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_22                 =    UNIT_END + 0x5C7	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_23                 =    UNIT_END + 0x5C8	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_COMBAT_RATING_24                 =    UNIT_END + 0x5C9	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_1              =    UNIT_END + 0x5CA	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_01             =    UNIT_END + 0x5CB	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_02             =    UNIT_END + 0x5CC	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_03             =    UNIT_END + 0x5CD	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_04             =    UNIT_END + 0x5CE	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_05             =    UNIT_END + 0x5CF	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_06             =    UNIT_END + 0x5D0	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_07             =    UNIT_END + 0x5D1	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_08             =    UNIT_END + 0x5D2	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_09             =    UNIT_END + 0x5D3	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_10             =    UNIT_END + 0x5D4	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_11             =    UNIT_END + 0x5D5	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_12             =    UNIT_END + 0x5D6	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_13             =    UNIT_END + 0x5D7	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_14             =    UNIT_END + 0x5D8	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_15             =    UNIT_END + 0x5D9	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_16             =    UNIT_END + 0x5DA	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_TEAM_INFO_1_17             =    UNIT_END + 0x5DB	,   //Size:18  Type:Int32  Flags:2
PLAYER_FIELD_HONOR_CURRENCY                   =    UNIT_END + 0x5DC	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_ARENA_CURRENCY                   =    UNIT_END + 0x5DD	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_MAX_LEVEL                        =    UNIT_END + 0x5DE	,   //Size:1  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_1                   =    UNIT_END + 0x5DF	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_01                  =    UNIT_END + 0x5E0	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_02                  =    UNIT_END + 0x5E1	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_03                  =    UNIT_END + 0x5E2	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_04                  =    UNIT_END + 0x5E3	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_05                  =    UNIT_END + 0x5E4	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_06                  =    UNIT_END + 0x5E5	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_07                  =    UNIT_END + 0x5E6	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_08                  =    UNIT_END + 0x5E7	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_09                  =    UNIT_END + 0x5E8	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_10                  =    UNIT_END + 0x5E9	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_11                  =    UNIT_END + 0x5EA	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_12                  =    UNIT_END + 0x5EB	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_13                  =    UNIT_END + 0x5EC	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_14                  =    UNIT_END + 0x5ED	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_15                  =    UNIT_END + 0x5EE	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_16                  =    UNIT_END + 0x5EF	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_17                  =    UNIT_END + 0x5F0	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_18                  =    UNIT_END + 0x5F1	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_19                  =    UNIT_END + 0x5F2	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_20                  =    UNIT_END + 0x5F3	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_21                  =    UNIT_END + 0x5F4	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_22                  =    UNIT_END + 0x5F5	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_23                  =    UNIT_END + 0x5F6	,   //Size:25  Type:Int32  Flags:2
PLAYER_FIELD_DAILY_QUESTS_24                  =    UNIT_END + 0x5F7	,   //Size:25  Type:Int32  Flags:2
PLAYER_RUNE_REGEN_1                           =    UNIT_END + 0x5F8	,   //Size:4  Type:Float  Flags:2
PLAYER_RUNE_REGEN_01                          =    UNIT_END + 0x5F9	,   //Size:4  Type:Float  Flags:2
PLAYER_RUNE_REGEN_02                          =    UNIT_END + 0x5FA	,   //Size:4  Type:Float  Flags:2
PLAYER_RUNE_REGEN_03                          =    UNIT_END + 0x5FB	,   //Size:4  Type:Float  Flags:2
PLAYER_NO_REAGENT_COST_1                      =    UNIT_END + 0x5FC	,   //Size:3  Type:Int32  Flags:2
PLAYER_NO_REAGENT_COST_01                     =    UNIT_END + 0x5FD	,   //Size:3  Type:Int32  Flags:2
PLAYER_NO_REAGENT_COST_02                     =    UNIT_END + 0x5FE	,   //Size:3  Type:Int32  Flags:2
PLAYER_FIELD_GLYPH_SLOTS_1                    =    UNIT_END + 0x5FF	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPH_SLOTS_01                   =    UNIT_END + 0x600	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPH_SLOTS_02                   =    UNIT_END + 0x601	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPH_SLOTS_03                   =    UNIT_END + 0x602	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPH_SLOTS_04                   =    UNIT_END + 0x603	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPH_SLOTS_05                   =    UNIT_END + 0x604	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPH_SLOTS_06                   =    UNIT_END + 0x605	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPH_SLOTS_07                   =    UNIT_END + 0x606	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPHS_1                         =    UNIT_END + 0x607	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPHS_01                        =    UNIT_END + 0x608	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPHS_02                        =    UNIT_END + 0x609	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPHS_03                        =    UNIT_END + 0x60A	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPHS_04                        =    UNIT_END + 0x60B	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPHS_05                        =    UNIT_END + 0x60C	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPHS_06                        =    UNIT_END + 0x60D	,   //Size:8  Type:Int32  Flags:2
PLAYER_FIELD_GLYPHS_07                        =    UNIT_END + 0x60E	,   //Size:8  Type:Int32  Flags:2
PLAYER_GLYPHS_ENABLED                         =    UNIT_END + 0x60F	,   //Size:1  Type:Int32  Flags:2
PLAYER_END                                    =    UNIT_END + 0x610,

OBJECT_FIELD_CREATED_BY                        = OBJECT_END + 0x000	,   //Size:2  Type:GUID  Flags:1
OBJECT_FIELD_CREATED_BY_01                     = OBJECT_END + 0x001	,   //Size:2  Type:GUID  Flags:1

GAMEOBJECT_DISPLAYID                           = OBJECT_END + 0x002	,   //Size:1  Type:Int32  Flags:1
GAMEOBJECT_FLAGS                               = OBJECT_END + 0x003	,   //Size:1  Type:Chars?  Flags:1
GAMEOBJECT_ROTATION                            = OBJECT_END + 0x004	,   //Size:2  Type:GUID  Flags:1
GAMEOBJECT_ROTATION_01                         = OBJECT_END + 0x005	,   //Size:2  Type:GUID  Flags:1
GAMEOBJECT_PARENTROTATION                      = OBJECT_END + 0x006	,   //Size:4  Type:Float  Flags:1
GAMEOBJECT_PARENTROTATION_01                   = OBJECT_END + 0x007	,   //Size:4  Type:Float  Flags:1
GAMEOBJECT_PARENTROTATION_02                   = OBJECT_END + 0x008	,   //Size:4  Type:Float  Flags:1
GAMEOBJECT_PARENTROTATION_03                   = OBJECT_END + 0x009	,   //Size:4  Type:Float  Flags:1
GAMEOBJECT_POS_X                               = OBJECT_END + 0x00A	,   //Size:1  Type:Float  Flags:1
GAMEOBJECT_POS_Y                               = OBJECT_END + 0x00B	,   //Size:1  Type:Float  Flags:1
GAMEOBJECT_POS_Z                               = OBJECT_END + 0x00C	,   //Size:1  Type:Float  Flags:1
GAMEOBJECT_FACING                              = OBJECT_END + 0x00D	,   //Size:1  Type:Float  Flags:1
GAMEOBJECT_DYNAMIC                             = OBJECT_END + 0x00E	,   //Size:1  Type:Chars?  Flags:256
GAMEOBJECT_FACTION                             = OBJECT_END + 0x00F	,   //Size:1  Type:Int32  Flags:1
GAMEOBJECT_LEVEL                               = OBJECT_END + 0x010	,   //Size:1  Type:Int32  Flags:1
GAMEOBJECT_BYTES_1                             = OBJECT_END + 0x011	,   //Size:1  Type:Bytes  Flags:1
GAMEOBJECT_END                                 = OBJECT_END + 0x012

,   //DYNAMICOBJECT:
DYNAMICOBJECT_CASTER                           = OBJECT_END + 0x000	,   //Size:2  Type:GUID  Flags:1
DYNAMICOBJECT_CASTER_01                        = OBJECT_END + 0x001	,   //Size:2  Type:GUID  Flags:1
DYNAMICOBJECT_BYTES                            = OBJECT_END + 0x002	,   //Size:1  Type:Bytes  Flags:1
DYNAMICOBJECT_SPELLID                          = OBJECT_END + 0x003	,   //Size:1  Type:Int32  Flags:1
DYNAMICOBJECT_RADIUS                           = OBJECT_END + 0x004	,   //Size:1  Type:Float  Flags:1
DYNAMICOBJECT_POS_X                            = OBJECT_END + 0x005	,   //Size:1  Type:Float  Flags:1
DYNAMICOBJECT_POS_Y                            = OBJECT_END + 0x006	,   //Size:1  Type:Float  Flags:1
DYNAMICOBJECT_POS_Z                            = OBJECT_END + 0x007	,   //Size:1  Type:Float  Flags:1
DYNAMICOBJECT_FACING                           = OBJECT_END + 0x008	,   //Size:1  Type:Float  Flags:1
DYNAMICOBJECT_CASTTIME                         = OBJECT_END + 0x009	,   //Size:1  Type:Int32  Flags:1
DYNAMICOBJECT_END                              = OBJECT_END + 0x00A

,   //CORPSE:
CORPSE_FIELD_OWNER                             = OBJECT_END + 0x000	,   //Size:2  Type:GUID  Flags:1
CORPSE_FIELD_OWNER_01                          = OBJECT_END + 0x001	,   //Size:2  Type:GUID  Flags:1
CORPSE_FIELD_PARTY                             = OBJECT_END + 0x002	,   //Size:2  Type:GUID  Flags:1
CORPSE_FIELD_PARTY_01                          = OBJECT_END + 0x003	,   //Size:2  Type:GUID  Flags:1
CORPSE_FIELD_FACING                            = OBJECT_END + 0x004	,   //Size:1  Type:Float  Flags:1
CORPSE_FIELD_POS_X                             = OBJECT_END + 0x005	,   //Size:1  Type:Float  Flags:1
CORPSE_FIELD_POS_Y                             = OBJECT_END + 0x006	,   //Size:1  Type:Float  Flags:1
CORPSE_FIELD_POS_Z                             = OBJECT_END + 0x007	,   //Size:1  Type:Float  Flags:1
CORPSE_FIELD_DISPLAY_ID                        = OBJECT_END + 0x008	,   //Size:1  Type:Int32  Flags:1
CORPSE_FIELD_ITEM                              = OBJECT_END + 0x009	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_01                           = OBJECT_END + 0x00A	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_02                           = OBJECT_END + 0x00B	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_03                           = OBJECT_END + 0x00C	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_04                           = OBJECT_END + 0x00D	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_05                           = OBJECT_END + 0x00E	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_06                           = OBJECT_END + 0x00F	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_07                           = OBJECT_END + 0x010	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_08                           = OBJECT_END + 0x011	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_09                           = OBJECT_END + 0x012	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_10                           = OBJECT_END + 0x013	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_11                           = OBJECT_END + 0x014	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_12                           = OBJECT_END + 0x015	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_13                           = OBJECT_END + 0x016	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_14                           = OBJECT_END + 0x017	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_15                           = OBJECT_END + 0x018	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_16                           = OBJECT_END + 0x019	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_17                           = OBJECT_END + 0x01A	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_ITEM_18                           = OBJECT_END + 0x01B	,   //Size:19  Type:Int32  Flags:1
CORPSE_FIELD_BYTES_1                           = OBJECT_END + 0x01C	,   //Size:1  Type:Bytes  Flags:1
CORPSE_FIELD_BYTES_2                           = OBJECT_END + 0x01D	,   //Size:1  Type:Bytes  Flags:1
CORPSE_FIELD_GUILD                             = OBJECT_END + 0x01E	,   //Size:1  Type:Int32  Flags:1
CORPSE_FIELD_FLAGS                             = OBJECT_END + 0x01F	,   //Size:1  Type:Int32  Flags:1
CORPSE_FIELD_DYNAMIC_FLAGS                     = OBJECT_END + 0x020	,   //Size:1  Type:Int32  Flags:256
CORPSE_FIELD_PAD                               = OBJECT_END + 0x021	,   //Size:1  Type:Int32  Flags:0
CORPSE_END                                     = OBJECT_END + 0x022


    };


    public enum ObjectFields
    {
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        GUID = 0,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        GUID_2 = 1,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        TYPE = 2,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        ENTRY = 3,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Public
        /// </summary>
        SCALE_X = 4,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: None
        /// </summary>
        PADDING = 5,
    }

    public enum UnitFields
    {
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CHARM = 6,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CHARM_2 = 7,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        SUMMON = 8,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        SUMMON_2 = 9,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        CRITTER = 10,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        CRITTER_2 = 11,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CHARMEDBY = 12,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CHARMEDBY_2 = 13,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        SUMMONEDBY = 14,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        SUMMONEDBY_2 = 15,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CREATEDBY = 16,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CREATEDBY_2 = 17,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        TARGET = 18,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        TARGET_2 = 19,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CHANNEL_OBJECT = 20,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CHANNEL_OBJECT_2 = 21,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Public
        /// </summary>
        BYTES_0 = 22,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        HEALTH = 23,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        POWER1 = 24,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        POWER2 = 25,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        POWER3 = 26,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        POWER4 = 27,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        POWER5 = 28,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        POWER6 = 29,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        POWER7 = 30,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        MAXHEALTH = 31,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        MAXPOWER1 = 32,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        MAXPOWER2 = 33,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        MAXPOWER3 = 34,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        MAXPOWER4 = 35,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        MAXPOWER5 = 36,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        MAXPOWER6 = 37,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        MAXPOWER7 = 38,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_FLAT_MODIFIER = 39,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_FLAT_MODIFIER_2 = 40,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_FLAT_MODIFIER_3 = 41,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_FLAT_MODIFIER_4 = 42,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_FLAT_MODIFIER_5 = 43,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_FLAT_MODIFIER_6 = 44,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_FLAT_MODIFIER_7 = 45,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_INTERRUPTED_FLAT_MODIFIER = 46,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_2 = 47,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_3 = 48,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_4 = 49,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_5 = 50,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_6 = 51,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_REGEN_INTERRUPTED_FLAT_MODIFIER_7 = 52,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        LEVEL = 53,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        FACTIONTEMPLATE = 54,
        /// <summary>
        /// Size: 3 - Type: UInt32 - Flags: Public
        /// </summary>
        VIRTUAL_ITEM_SLOT_ID = 55,
        /// <summary>
        /// Size: 3 - Type: UInt32 - Flags: Public
        /// </summary>
        VIRTUAL_ITEM_SLOT_ID_2 = 56,
        /// <summary>
        /// Size: 3 - Type: UInt32 - Flags: Public
        /// </summary>
        VIRTUAL_ITEM_SLOT_ID_3 = 57,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        FLAGS = 58,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        FLAGS_2 = 59,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        AURASTATE = 60,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        BASEATTACKTIME = 61,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        BASEATTACKTIME_2 = 62,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        RANGEDATTACKTIME = 63,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Public
        /// </summary>
        BOUNDINGRADIUS = 64,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Public
        /// </summary>
        COMBATREACH = 65,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        DISPLAYID = 66,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        NATIVEDISPLAYID = 67,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        MOUNTDISPLAYID = 68,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        MINDAMAGE = 69,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        MAXDAMAGE = 70,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        MINOFFHANDDAMAGE = 71,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        MAXOFFHANDDAMAGE = 72,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Public
        /// </summary>
        BYTES_1 = 73,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        PETNUMBER = 74,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        PET_NAME_TIMESTAMP = 75,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: OwnerOnly
        /// </summary>
        PETEXPERIENCE = 76,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: OwnerOnly
        /// </summary>
        PETNEXTLEVELEXP = 77,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Dynamic
        /// </summary>
        DYNAMIC_FLAGS = 78,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        CHANNEL_SPELL = 79,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Public
        /// </summary>
        MOD_CAST_SPEED = 80,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        CREATED_BY_SPELL = 81,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Dynamic
        /// </summary>
        NPC_FLAGS = 82,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        NPC_EMOTESTATE = 83,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        STAT0 = 84,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        STAT1 = 85,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        STAT2 = 86,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        STAT3 = 87,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        STAT4 = 88,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POSSTAT0 = 89,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POSSTAT1 = 90,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POSSTAT2 = 91,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POSSTAT3 = 92,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POSSTAT4 = 93,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        NEGSTAT0 = 94,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        NEGSTAT1 = 95,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        NEGSTAT2 = 96,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        NEGSTAT3 = 97,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        NEGSTAT4 = 98,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        RESISTANCES = 99,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        RESISTANCES_2 = 100,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        RESISTANCES_3 = 101,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        RESISTANCES_4 = 102,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        RESISTANCES_5 = 103,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        RESISTANCES_6 = 104,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly, BeastLore
        /// </summary>
        RESISTANCES_7 = 105,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSPOSITIVE = 106,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSPOSITIVE_2 = 107,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSPOSITIVE_3 = 108,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSPOSITIVE_4 = 109,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSPOSITIVE_5 = 110,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSPOSITIVE_6 = 111,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSPOSITIVE_7 = 112,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSNEGATIVE = 113,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSNEGATIVE_2 = 114,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSNEGATIVE_3 = 115,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSNEGATIVE_4 = 116,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSNEGATIVE_5 = 117,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSNEGATIVE_6 = 118,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RESISTANCEBUFFMODSNEGATIVE_7 = 119,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        BASE_MANA = 120,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        BASE_HEALTH = 121,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Public
        /// </summary>
        BYTES_2 = 122,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        ATTACK_POWER = 123,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Private, OwnerOnly
        /// </summary>
        ATTACK_POWER_MODS = 124,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        ATTACK_POWER_MULTIPLIER = 125,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        RANGED_ATTACK_POWER = 126,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Private, OwnerOnly
        /// </summary>
        RANGED_ATTACK_POWER_MODS = 127,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        RANGED_ATTACK_POWER_MULTIPLIER = 128,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        MINRANGEDDAMAGE = 129,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        MAXRANGEDDAMAGE = 130,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MODIFIER = 131,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MODIFIER_2 = 132,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MODIFIER_3 = 133,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MODIFIER_4 = 134,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MODIFIER_5 = 135,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MODIFIER_6 = 136,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MODIFIER_7 = 137,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MULTIPLIER = 138,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MULTIPLIER_2 = 139,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MULTIPLIER_3 = 140,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MULTIPLIER_4 = 141,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MULTIPLIER_5 = 142,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MULTIPLIER_6 = 143,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        POWER_COST_MULTIPLIER_7 = 144,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private, OwnerOnly
        /// </summary>
        MAXHEALTHMODIFIER = 145,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Public
        /// </summary>
        HOVERHEIGHT = 146,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: None
        /// </summary>
        PADDING = 147,
    }

    public enum PlayerFields
    {
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        DUEL_ARBITER = 148,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        DUEL_ARBITER_2 = 149,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        FLAGS = 150,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        GUILDID = 151,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        GUILDRANK = 152,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Public
        /// </summary>
        BYTES = 153,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Public
        /// </summary>
        BYTES_2 = 154,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Public
        /// </summary>
        BYTES_3 = 155,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        DUEL_TEAM = 156,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        GUILD_TIMESTAMP = 157,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_1_1 = 158,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_1_2 = 159,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_1_3 = 160,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_1_4 = 161,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_2_1 = 162,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_2_2 = 163,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_2_3 = 164,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_2_4 = 165,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_3_1 = 166,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_3_2 = 167,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_3_3 = 168,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_3_4 = 169,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_4_1 = 170,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_4_2 = 171,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_4_3 = 172,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_4_4 = 173,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_5_1 = 174,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_5_2 = 175,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_5_3 = 176,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_5_4 = 177,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_6_1 = 178,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_6_2 = 179,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_6_3 = 180,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_6_4 = 181,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_7_1 = 182,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_7_2 = 183,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_7_3 = 184,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_7_4 = 185,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_8_1 = 186,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_8_2 = 187,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_8_3 = 188,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_8_4 = 189,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_9_1 = 190,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_9_2 = 191,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_9_3 = 192,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_9_4 = 193,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_10_1 = 194,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_10_2 = 195,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_10_3 = 196,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_10_4 = 197,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_11_1 = 198,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_11_2 = 199,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_11_3 = 200,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_11_4 = 201,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_12_1 = 202,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_12_2 = 203,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_12_3 = 204,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_12_4 = 205,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_13_1 = 206,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_13_2 = 207,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_13_3 = 208,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_13_4 = 209,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_14_1 = 210,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_14_2 = 211,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_14_3 = 212,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_14_4 = 213,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_15_1 = 214,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_15_2 = 215,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_15_3 = 216,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_15_4 = 217,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_16_1 = 218,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_16_2 = 219,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_16_3 = 220,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_16_4 = 221,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_17_1 = 222,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_17_2 = 223,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_17_3 = 224,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_17_4 = 225,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_18_1 = 226,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_18_2 = 227,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_18_3 = 228,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_18_4 = 229,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_19_1 = 230,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_19_2 = 231,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_19_3 = 232,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_19_4 = 233,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_20_1 = 234,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_20_2 = 235,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_20_3 = 236,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_20_4 = 237,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_21_1 = 238,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_21_2 = 239,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_21_3 = 240,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_21_4 = 241,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_22_1 = 242,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_22_2 = 243,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_22_3 = 244,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_22_4 = 245,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_23_1 = 246,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_23_2 = 247,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_23_3 = 248,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_23_4 = 249,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_24_1 = 250,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_24_2 = 251,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_24_3 = 252,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_24_4 = 253,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: GroupOnly
        /// </summary>
        QUEST_LOG_25_1 = 254,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_25_2 = 255,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        QUEST_LOG_25_3 = 256,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        QUEST_LOG_25_4 = 257,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_1_ENTRYID = 258,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_1_ENCHANTMENT = 259,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_2_ENTRYID = 260,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_2_ENCHANTMENT = 261,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_3_ENTRYID = 262,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_3_ENCHANTMENT = 263,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_4_ENTRYID = 264,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_4_ENCHANTMENT = 265,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_5_ENTRYID = 266,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_5_ENCHANTMENT = 267,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_6_ENTRYID = 268,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_6_ENCHANTMENT = 269,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_7_ENTRYID = 270,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_7_ENCHANTMENT = 271,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_8_ENTRYID = 272,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_8_ENCHANTMENT = 273,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_9_ENTRYID = 274,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_9_ENCHANTMENT = 275,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_10_ENTRYID = 276,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_10_ENCHANTMENT = 277,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_11_ENTRYID = 278,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_11_ENCHANTMENT = 279,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_12_ENTRYID = 280,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_12_ENCHANTMENT = 281,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_13_ENTRYID = 282,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_13_ENCHANTMENT = 283,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_14_ENTRYID = 284,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_14_ENCHANTMENT = 285,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_15_ENTRYID = 286,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_15_ENCHANTMENT = 287,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_16_ENTRYID = 288,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_16_ENCHANTMENT = 289,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_17_ENTRYID = 290,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_17_ENCHANTMENT = 291,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_18_ENTRYID = 292,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_18_ENCHANTMENT = 293,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_19_ENTRYID = 294,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        VISIBLE_ITEM_19_ENCHANTMENT = 295,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        CHOSEN_TITLE = 296,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        FAKE_INEBRIATION = 297,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD = 298,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_2 = 299,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_3 = 300,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_4 = 301,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_5 = 302,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_6 = 303,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_7 = 304,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_8 = 305,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_9 = 306,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_10 = 307,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_11 = 308,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_12 = 309,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_13 = 310,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_14 = 311,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_15 = 312,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_16 = 313,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_17 = 314,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_18 = 315,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_19 = 316,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_20 = 317,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_21 = 318,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_22 = 319,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_23 = 320,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_24 = 321,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_25 = 322,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_26 = 323,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_27 = 324,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_28 = 325,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_29 = 326,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_30 = 327,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_31 = 328,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_32 = 329,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_33 = 330,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_34 = 331,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_35 = 332,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_36 = 333,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_37 = 334,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_38 = 335,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_39 = 336,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_40 = 337,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_41 = 338,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_42 = 339,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_43 = 340,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_44 = 341,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_45 = 342,
        /// <summary>
        /// Size: 46 - Type: Guid - Flags: Private
        /// </summary>
        INV_SLOT_HEAD_46 = 343,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1 = 344,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_2 = 345,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_3 = 346,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_4 = 347,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_5 = 348,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_6 = 349,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_7 = 350,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_8 = 351,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_9 = 352,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_10 = 353,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_11 = 354,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_12 = 355,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_13 = 356,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_14 = 357,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_15 = 358,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_16 = 359,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_17 = 360,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_18 = 361,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_19 = 362,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_20 = 363,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_21 = 364,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_22 = 365,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_23 = 366,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_24 = 367,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_25 = 368,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_26 = 369,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_27 = 370,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_28 = 371,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_29 = 372,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_30 = 373,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_31 = 374,
        /// <summary>
        /// Size: 32 - Type: Guid - Flags: Private
        /// </summary>
        PACK_SLOT_1_32 = 375,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1 = 376,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_2 = 377,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_3 = 378,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_4 = 379,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_5 = 380,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_6 = 381,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_7 = 382,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_8 = 383,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_9 = 384,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_10 = 385,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_11 = 386,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_12 = 387,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_13 = 388,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_14 = 389,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_15 = 390,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_16 = 391,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_17 = 392,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_18 = 393,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_19 = 394,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_20 = 395,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_21 = 396,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_22 = 397,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_23 = 398,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_24 = 399,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_25 = 400,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_26 = 401,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_27 = 402,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_28 = 403,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_29 = 404,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_30 = 405,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_31 = 406,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_32 = 407,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_33 = 408,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_34 = 409,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_35 = 410,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_36 = 411,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_37 = 412,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_38 = 413,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_39 = 414,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_40 = 415,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_41 = 416,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_42 = 417,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_43 = 418,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_44 = 419,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_45 = 420,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_46 = 421,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_47 = 422,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_48 = 423,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_49 = 424,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_50 = 425,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_51 = 426,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_52 = 427,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_53 = 428,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_54 = 429,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_55 = 430,
        /// <summary>
        /// Size: 56 - Type: Guid - Flags: Private
        /// </summary>
        BANK_SLOT_1_56 = 431,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1 = 432,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_2 = 433,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_3 = 434,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_4 = 435,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_5 = 436,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_6 = 437,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_7 = 438,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_8 = 439,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_9 = 440,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_10 = 441,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_11 = 442,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_12 = 443,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_13 = 444,
        /// <summary>
        /// Size: 14 - Type: Guid - Flags: Private
        /// </summary>
        BANKBAG_SLOT_1_14 = 445,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1 = 446,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_2 = 447,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_3 = 448,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_4 = 449,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_5 = 450,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_6 = 451,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_7 = 452,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_8 = 453,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_9 = 454,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_10 = 455,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_11 = 456,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_12 = 457,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_13 = 458,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_14 = 459,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_15 = 460,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_16 = 461,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_17 = 462,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_18 = 463,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_19 = 464,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_20 = 465,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_21 = 466,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_22 = 467,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_23 = 468,
        /// <summary>
        /// Size: 24 - Type: Guid - Flags: Private
        /// </summary>
        VENDORBUYBACK_SLOT_1_24 = 469,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1 = 470,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_2 = 471,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_3 = 472,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_4 = 473,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_5 = 474,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_6 = 475,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_7 = 476,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_8 = 477,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_9 = 478,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_10 = 479,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_11 = 480,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_12 = 481,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_13 = 482,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_14 = 483,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_15 = 484,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_16 = 485,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_17 = 486,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_18 = 487,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_19 = 488,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_20 = 489,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_21 = 490,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_22 = 491,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_23 = 492,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_24 = 493,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_25 = 494,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_26 = 495,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_27 = 496,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_28 = 497,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_29 = 498,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_30 = 499,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_31 = 500,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_32 = 501,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_33 = 502,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_34 = 503,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_35 = 504,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_36 = 505,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_37 = 506,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_38 = 507,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_39 = 508,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_40 = 509,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_41 = 510,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_42 = 511,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_43 = 512,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_44 = 513,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_45 = 514,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_46 = 515,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_47 = 516,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_48 = 517,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_49 = 518,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_50 = 519,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_51 = 520,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_52 = 521,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_53 = 522,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_54 = 523,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_55 = 524,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_56 = 525,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_57 = 526,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_58 = 527,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_59 = 528,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_60 = 529,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_61 = 530,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_62 = 531,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_63 = 532,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        KEYRING_SLOT_1_64 = 533,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1 = 534,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_2 = 535,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_3 = 536,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_4 = 537,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_5 = 538,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_6 = 539,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_7 = 540,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_8 = 541,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_9 = 542,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_10 = 543,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_11 = 544,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_12 = 545,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_13 = 546,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_14 = 547,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_15 = 548,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_16 = 549,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_17 = 550,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_18 = 551,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_19 = 552,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_20 = 553,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_21 = 554,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_22 = 555,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_23 = 556,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_24 = 557,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_25 = 558,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_26 = 559,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_27 = 560,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_28 = 561,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_29 = 562,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_30 = 563,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_31 = 564,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_32 = 565,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_33 = 566,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_34 = 567,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_35 = 568,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_36 = 569,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_37 = 570,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_38 = 571,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_39 = 572,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_40 = 573,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_41 = 574,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_42 = 575,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_43 = 576,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_44 = 577,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_45 = 578,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_46 = 579,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_47 = 580,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_48 = 581,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_49 = 582,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_50 = 583,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_51 = 584,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_52 = 585,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_53 = 586,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_54 = 587,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_55 = 588,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_56 = 589,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_57 = 590,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_58 = 591,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_59 = 592,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_60 = 593,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_61 = 594,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_62 = 595,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_63 = 596,
        /// <summary>
        /// Size: 64 - Type: Guid - Flags: Private
        /// </summary>
        CURRENCYTOKEN_SLOT_1_64 = 597,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        FARSIGHT = 598,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        FARSIGHT_2 = 599,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        _FIELD_KNOWN_TITLES = 600,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        _FIELD_KNOWN_TITLES_2 = 601,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        _FIELD_KNOWN_TITLES1 = 602,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        _FIELD_KNOWN_TITLES1_2 = 603,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        _FIELD_KNOWN_TITLES2 = 604,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        _FIELD_KNOWN_TITLES2_2 = 605,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        KNOWN_CURRENCIES = 606,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Private
        /// </summary>
        KNOWN_CURRENCIES_2 = 607,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        XP = 608,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        NEXT_LEVEL_XP = 609,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1 = 610,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_2 = 611,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_3 = 612,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_4 = 613,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_5 = 614,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_6 = 615,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_7 = 616,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_8 = 617,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_9 = 618,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_10 = 619,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_11 = 620,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_12 = 621,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_13 = 622,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_14 = 623,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_15 = 624,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_16 = 625,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_17 = 626,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_18 = 627,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_19 = 628,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_20 = 629,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_21 = 630,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_22 = 631,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_23 = 632,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_24 = 633,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_25 = 634,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_26 = 635,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_27 = 636,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_28 = 637,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_29 = 638,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_30 = 639,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_31 = 640,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_32 = 641,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_33 = 642,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_34 = 643,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_35 = 644,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_36 = 645,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_37 = 646,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_38 = 647,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_39 = 648,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_40 = 649,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_41 = 650,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_42 = 651,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_43 = 652,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_44 = 653,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_45 = 654,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_46 = 655,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_47 = 656,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_48 = 657,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_49 = 658,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_50 = 659,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_51 = 660,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_52 = 661,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_53 = 662,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_54 = 663,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_55 = 664,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_56 = 665,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_57 = 666,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_58 = 667,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_59 = 668,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_60 = 669,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_61 = 670,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_62 = 671,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_63 = 672,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_64 = 673,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_65 = 674,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_66 = 675,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_67 = 676,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_68 = 677,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_69 = 678,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_70 = 679,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_71 = 680,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_72 = 681,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_73 = 682,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_74 = 683,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_75 = 684,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_76 = 685,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_77 = 686,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_78 = 687,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_79 = 688,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_80 = 689,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_81 = 690,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_82 = 691,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_83 = 692,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_84 = 693,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_85 = 694,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_86 = 695,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_87 = 696,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_88 = 697,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_89 = 698,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_90 = 699,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_91 = 700,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_92 = 701,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_93 = 702,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_94 = 703,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_95 = 704,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_96 = 705,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_97 = 706,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_98 = 707,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_99 = 708,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_100 = 709,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_101 = 710,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_102 = 711,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_103 = 712,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_104 = 713,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_105 = 714,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_106 = 715,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_107 = 716,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_108 = 717,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_109 = 718,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_110 = 719,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_111 = 720,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_112 = 721,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_113 = 722,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_114 = 723,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_115 = 724,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_116 = 725,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_117 = 726,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_118 = 727,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_119 = 728,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_120 = 729,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_121 = 730,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_122 = 731,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_123 = 732,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_124 = 733,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_125 = 734,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_126 = 735,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_127 = 736,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_128 = 737,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_129 = 738,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_130 = 739,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_131 = 740,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_132 = 741,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_133 = 742,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_134 = 743,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_135 = 744,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_136 = 745,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_137 = 746,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_138 = 747,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_139 = 748,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_140 = 749,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_141 = 750,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_142 = 751,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_143 = 752,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_144 = 753,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_145 = 754,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_146 = 755,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_147 = 756,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_148 = 757,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_149 = 758,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_150 = 759,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_151 = 760,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_152 = 761,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_153 = 762,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_154 = 763,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_155 = 764,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_156 = 765,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_157 = 766,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_158 = 767,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_159 = 768,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_160 = 769,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_161 = 770,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_162 = 771,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_163 = 772,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_164 = 773,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_165 = 774,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_166 = 775,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_167 = 776,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_168 = 777,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_169 = 778,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_170 = 779,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_171 = 780,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_172 = 781,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_173 = 782,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_174 = 783,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_175 = 784,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_176 = 785,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_177 = 786,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_178 = 787,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_179 = 788,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_180 = 789,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_181 = 790,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_182 = 791,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_183 = 792,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_184 = 793,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_185 = 794,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_186 = 795,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_187 = 796,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_188 = 797,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_189 = 798,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_190 = 799,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_191 = 800,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_192 = 801,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_193 = 802,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_194 = 803,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_195 = 804,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_196 = 805,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_197 = 806,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_198 = 807,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_199 = 808,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_200 = 809,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_201 = 810,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_202 = 811,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_203 = 812,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_204 = 813,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_205 = 814,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_206 = 815,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_207 = 816,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_208 = 817,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_209 = 818,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_210 = 819,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_211 = 820,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_212 = 821,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_213 = 822,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_214 = 823,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_215 = 824,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_216 = 825,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_217 = 826,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_218 = 827,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_219 = 828,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_220 = 829,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_221 = 830,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_222 = 831,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_223 = 832,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_224 = 833,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_225 = 834,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_226 = 835,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_227 = 836,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_228 = 837,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_229 = 838,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_230 = 839,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_231 = 840,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_232 = 841,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_233 = 842,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_234 = 843,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_235 = 844,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_236 = 845,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_237 = 846,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_238 = 847,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_239 = 848,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_240 = 849,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_241 = 850,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_242 = 851,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_243 = 852,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_244 = 853,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_245 = 854,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_246 = 855,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_247 = 856,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_248 = 857,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_249 = 858,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_250 = 859,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_251 = 860,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_252 = 861,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_253 = 862,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_254 = 863,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_255 = 864,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_256 = 865,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_257 = 866,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_258 = 867,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_259 = 868,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_260 = 869,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_261 = 870,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_262 = 871,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_263 = 872,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_264 = 873,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_265 = 874,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_266 = 875,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_267 = 876,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_268 = 877,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_269 = 878,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_270 = 879,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_271 = 880,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_272 = 881,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_273 = 882,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_274 = 883,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_275 = 884,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_276 = 885,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_277 = 886,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_278 = 887,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_279 = 888,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_280 = 889,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_281 = 890,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_282 = 891,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_283 = 892,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_284 = 893,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_285 = 894,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_286 = 895,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_287 = 896,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_288 = 897,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_289 = 898,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_290 = 899,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_291 = 900,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_292 = 901,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_293 = 902,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_294 = 903,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_295 = 904,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_296 = 905,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_297 = 906,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_298 = 907,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_299 = 908,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_300 = 909,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_301 = 910,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_302 = 911,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_303 = 912,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_304 = 913,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_305 = 914,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_306 = 915,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_307 = 916,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_308 = 917,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_309 = 918,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_310 = 919,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_311 = 920,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_312 = 921,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_313 = 922,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_314 = 923,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_315 = 924,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_316 = 925,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_317 = 926,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_318 = 927,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_319 = 928,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_320 = 929,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_321 = 930,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_322 = 931,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_323 = 932,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_324 = 933,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_325 = 934,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_326 = 935,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_327 = 936,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_328 = 937,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_329 = 938,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_330 = 939,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_331 = 940,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_332 = 941,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_333 = 942,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_334 = 943,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_335 = 944,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_336 = 945,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_337 = 946,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_338 = 947,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_339 = 948,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_340 = 949,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_341 = 950,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_342 = 951,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_343 = 952,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_344 = 953,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_345 = 954,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_346 = 955,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_347 = 956,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_348 = 957,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_349 = 958,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_350 = 959,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_351 = 960,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_352 = 961,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_353 = 962,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_354 = 963,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_355 = 964,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_356 = 965,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_357 = 966,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_358 = 967,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_359 = 968,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_360 = 969,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_361 = 970,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_362 = 971,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_363 = 972,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_364 = 973,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_365 = 974,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_366 = 975,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_367 = 976,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_368 = 977,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_369 = 978,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_370 = 979,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_371 = 980,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_372 = 981,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_373 = 982,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_374 = 983,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_375 = 984,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_376 = 985,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_377 = 986,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_378 = 987,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_379 = 988,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_380 = 989,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_381 = 990,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_382 = 991,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_383 = 992,
        /// <summary>
        /// Size: 384 - Type: TwoInt16 - Flags: Private
        /// </summary>
        SKILL_INFO_1_1_384 = 993,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        CHARACTER_POINTS1 = 994,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        CHARACTER_POINTS2 = 995,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        TRACK_CREATURES = 996,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        TRACK_RESOURCES = 997,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private
        /// </summary>
        BLOCK_PERCENTAGE = 998,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private
        /// </summary>
        DODGE_PERCENTAGE = 999,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private
        /// </summary>
        PARRY_PERCENTAGE = 1000,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        EXPERTISE = 1001,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        OFFHAND_EXPERTISE = 1002,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private
        /// </summary>
        CRIT_PERCENTAGE = 1003,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private
        /// </summary>
        RANGED_CRIT_PERCENTAGE = 1004,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private
        /// </summary>
        OFFHAND_CRIT_PERCENTAGE = 1005,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private
        /// </summary>
        SPELL_CRIT_PERCENTAGE1 = 1006,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private
        /// </summary>
        SPELL_CRIT_PERCENTAGE1_2 = 1007,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private
        /// </summary>
        SPELL_CRIT_PERCENTAGE1_3 = 1008,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private
        /// </summary>
        SPELL_CRIT_PERCENTAGE1_4 = 1009,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private
        /// </summary>
        SPELL_CRIT_PERCENTAGE1_5 = 1010,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private
        /// </summary>
        SPELL_CRIT_PERCENTAGE1_6 = 1011,
        /// <summary>
        /// Size: 7 - Type: Float - Flags: Private
        /// </summary>
        SPELL_CRIT_PERCENTAGE1_7 = 1012,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        SHIELD_BLOCK = 1013,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private
        /// </summary>
        SHIELD_BLOCK_CRIT_PERCENTAGE = 1014,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1 = 1015,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_2 = 1016,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_3 = 1017,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_4 = 1018,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_5 = 1019,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_6 = 1020,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_7 = 1021,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_8 = 1022,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_9 = 1023,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_10 = 1024,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_11 = 1025,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_12 = 1026,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_13 = 1027,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_14 = 1028,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_15 = 1029,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_16 = 1030,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_17 = 1031,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_18 = 1032,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_19 = 1033,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_20 = 1034,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_21 = 1035,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_22 = 1036,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_23 = 1037,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_24 = 1038,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_25 = 1039,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_26 = 1040,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_27 = 1041,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_28 = 1042,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_29 = 1043,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_30 = 1044,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_31 = 1045,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_32 = 1046,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_33 = 1047,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_34 = 1048,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_35 = 1049,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_36 = 1050,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_37 = 1051,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_38 = 1052,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_39 = 1053,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_40 = 1054,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_41 = 1055,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_42 = 1056,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_43 = 1057,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_44 = 1058,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_45 = 1059,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_46 = 1060,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_47 = 1061,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_48 = 1062,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_49 = 1063,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_50 = 1064,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_51 = 1065,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_52 = 1066,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_53 = 1067,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_54 = 1068,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_55 = 1069,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_56 = 1070,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_57 = 1071,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_58 = 1072,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_59 = 1073,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_60 = 1074,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_61 = 1075,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_62 = 1076,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_63 = 1077,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_64 = 1078,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_65 = 1079,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_66 = 1080,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_67 = 1081,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_68 = 1082,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_69 = 1083,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_70 = 1084,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_71 = 1085,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_72 = 1086,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_73 = 1087,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_74 = 1088,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_75 = 1089,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_76 = 1090,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_77 = 1091,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_78 = 1092,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_79 = 1093,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_80 = 1094,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_81 = 1095,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_82 = 1096,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_83 = 1097,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_84 = 1098,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_85 = 1099,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_86 = 1100,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_87 = 1101,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_88 = 1102,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_89 = 1103,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_90 = 1104,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_91 = 1105,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_92 = 1106,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_93 = 1107,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_94 = 1108,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_95 = 1109,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_96 = 1110,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_97 = 1111,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_98 = 1112,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_99 = 1113,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_100 = 1114,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_101 = 1115,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_102 = 1116,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_103 = 1117,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_104 = 1118,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_105 = 1119,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_106 = 1120,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_107 = 1121,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_108 = 1122,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_109 = 1123,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_110 = 1124,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_111 = 1125,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_112 = 1126,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_113 = 1127,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_114 = 1128,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_115 = 1129,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_116 = 1130,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_117 = 1131,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_118 = 1132,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_119 = 1133,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_120 = 1134,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_121 = 1135,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_122 = 1136,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_123 = 1137,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_124 = 1138,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_125 = 1139,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_126 = 1140,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_127 = 1141,
        /// <summary>
        /// Size: 128 - Type: ByteArray - Flags: Private
        /// </summary>
        EXPLORED_ZONES_1_128 = 1142,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        REST_STATE_EXPERIENCE = 1143,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        COINAGE = 1144,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_POS = 1145,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_POS_2 = 1146,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_POS_3 = 1147,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_POS_4 = 1148,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_POS_5 = 1149,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_POS_6 = 1150,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_POS_7 = 1151,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_NEG = 1152,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_NEG_2 = 1153,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_NEG_3 = 1154,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_NEG_4 = 1155,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_NEG_5 = 1156,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_NEG_6 = 1157,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_NEG_7 = 1158,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_PCT = 1159,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_PCT_2 = 1160,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_PCT_3 = 1161,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_PCT_4 = 1162,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_PCT_5 = 1163,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_PCT_6 = 1164,
        /// <summary>
        /// Size: 7 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_DAMAGE_DONE_PCT_7 = 1165,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_HEALING_DONE_POS = 1166,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private
        /// </summary>
        MOD_HEALING_PCT = 1167,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Private
        /// </summary>
        MOD_HEALING_DONE_PCT = 1168,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_TARGET_RESISTANCE = 1169,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        MOD_TARGET_PHYSICAL_RESISTANCE = 1170,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Private
        /// </summary>
        PLAYER_FIELD_BYTES = 1171,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        AMMO_ID = 1172,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        SELF_RES_SPELL = 1173,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        PVP_MEDALS = 1174,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1 = 1175,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_2 = 1176,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_3 = 1177,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_4 = 1178,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_5 = 1179,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_6 = 1180,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_7 = 1181,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_8 = 1182,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_9 = 1183,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_10 = 1184,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_11 = 1185,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_PRICE_1_12 = 1186,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1 = 1187,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_2 = 1188,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_3 = 1189,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_4 = 1190,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_5 = 1191,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_6 = 1192,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_7 = 1193,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_8 = 1194,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_9 = 1195,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_10 = 1196,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_11 = 1197,
        /// <summary>
        /// Size: 12 - Type: UInt32 - Flags: Private
        /// </summary>
        BUYBACK_TIMESTAMP_1_12 = 1198,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Private
        /// </summary>
        KILLS = 1199,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        TODAY_CONTRIBUTION = 1200,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        YESTERDAY_CONTRIBUTION = 1201,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        LIFETIME_HONORBALE_KILLS = 1202,
        /// <summary>
        /// Size: 1 - Type: Unk322 - Flags: Private
        /// </summary>
        PLAYER_FIELD_BYTES2 = 1203,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        WATCHED_FACTION_INDEX = 1204,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1 = 1205,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_2 = 1206,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_3 = 1207,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_4 = 1208,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_5 = 1209,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_6 = 1210,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_7 = 1211,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_8 = 1212,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_9 = 1213,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_10 = 1214,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_11 = 1215,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_12 = 1216,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_13 = 1217,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_14 = 1218,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_15 = 1219,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_16 = 1220,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_17 = 1221,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_18 = 1222,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_19 = 1223,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_20 = 1224,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_21 = 1225,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_22 = 1226,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_23 = 1227,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_24 = 1228,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        COMBAT_RATING_1_25 = 1229,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1 = 1230,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_2 = 1231,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_3 = 1232,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_4 = 1233,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_5 = 1234,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_6 = 1235,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_7 = 1236,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_8 = 1237,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_9 = 1238,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_10 = 1239,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_11 = 1240,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_12 = 1241,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_13 = 1242,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_14 = 1243,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_15 = 1244,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_16 = 1245,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_17 = 1246,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_18 = 1247,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_19 = 1248,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_20 = 1249,
        /// <summary>
        /// Size: 21 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_TEAM_INFO_1_1_21 = 1250,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        HONOR_CURRENCY = 1251,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        ARENA_CURRENCY = 1252,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        MAX_LEVEL = 1253,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1 = 1254,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_2 = 1255,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_3 = 1256,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_4 = 1257,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_5 = 1258,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_6 = 1259,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_7 = 1260,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_8 = 1261,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_9 = 1262,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_10 = 1263,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_11 = 1264,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_12 = 1265,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_13 = 1266,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_14 = 1267,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_15 = 1268,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_16 = 1269,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_17 = 1270,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_18 = 1271,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_19 = 1272,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_20 = 1273,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_21 = 1274,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_22 = 1275,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_23 = 1276,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_24 = 1277,
        /// <summary>
        /// Size: 25 - Type: UInt32 - Flags: Private
        /// </summary>
        DAILY_QUESTS_1_25 = 1278,
        /// <summary>
        /// Size: 4 - Type: Float - Flags: Private
        /// </summary>
        RUNE_REGEN_1 = 1279,
        /// <summary>
        /// Size: 4 - Type: Float - Flags: Private
        /// </summary>
        RUNE_REGEN_1_2 = 1280,
        /// <summary>
        /// Size: 4 - Type: Float - Flags: Private
        /// </summary>
        RUNE_REGEN_1_3 = 1281,
        /// <summary>
        /// Size: 4 - Type: Float - Flags: Private
        /// </summary>
        RUNE_REGEN_1_4 = 1282,
        /// <summary>
        /// Size: 3 - Type: UInt32 - Flags: Private
        /// </summary>
        NO_REAGENT_COST_1 = 1283,
        /// <summary>
        /// Size: 3 - Type: UInt32 - Flags: Private
        /// </summary>
        NO_REAGENT_COST_1_2 = 1284,
        /// <summary>
        /// Size: 3 - Type: UInt32 - Flags: Private
        /// </summary>
        NO_REAGENT_COST_1_3 = 1285,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPH_SLOTS_1 = 1286,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPH_SLOTS_1_2 = 1287,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPH_SLOTS_1_3 = 1288,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPH_SLOTS_1_4 = 1289,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPH_SLOTS_1_5 = 1290,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPH_SLOTS_1_6 = 1291,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPHS_1 = 1292,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPHS_1_2 = 1293,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPHS_1_3 = 1294,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPHS_1_4 = 1295,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPHS_1_5 = 1296,
        /// <summary>
        /// Size: 6 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPHS_1_6 = 1297,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Private
        /// </summary>
        GLYPHS_ENABLED = 1298,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: None
        /// </summary>
        PADDING = 1299,
    }

    public enum ItemFields
    {
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        OWNER = 6,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        OWNER_2 = 7,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CONTAINED = 8,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CONTAINED_2 = 9,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CREATOR = 10,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CREATOR_2 = 11,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        GIFTCREATOR = 12,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        GIFTCREATOR_2 = 13,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: OwnerOnly, ItemOwner
        /// </summary>
        STACK_COUNT = 14,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: OwnerOnly, ItemOwner
        /// </summary>
        DURATION = 15,
        /// <summary>
        /// Size: 5 - Type: UInt32 - Flags: OwnerOnly, ItemOwner
        /// </summary>
        SPELL_CHARGES = 16,
        /// <summary>
        /// Size: 5 - Type: UInt32 - Flags: OwnerOnly, ItemOwner
        /// </summary>
        SPELL_CHARGES_2 = 17,
        /// <summary>
        /// Size: 5 - Type: UInt32 - Flags: OwnerOnly, ItemOwner
        /// </summary>
        SPELL_CHARGES_3 = 18,
        /// <summary>
        /// Size: 5 - Type: UInt32 - Flags: OwnerOnly, ItemOwner
        /// </summary>
        SPELL_CHARGES_4 = 19,
        /// <summary>
        /// Size: 5 - Type: UInt32 - Flags: OwnerOnly, ItemOwner
        /// </summary>
        SPELL_CHARGES_5 = 20,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        FLAGS = 21,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_1_1 = 22,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_1_1_2 = 23,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_1_3 = 24,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_2_1 = 25,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_2_1_2 = 26,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_2_3 = 27,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_3_1 = 28,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_3_1_2 = 29,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_3_3 = 30,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_4_1 = 31,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_4_1_2 = 32,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_4_3 = 33,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_5_1 = 34,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_5_1_2 = 35,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_5_3 = 36,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_6_1 = 37,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_6_1_2 = 38,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_6_3 = 39,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_7_1 = 40,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_7_1_2 = 41,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_7_3 = 42,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_8_1 = 43,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_8_1_2 = 44,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_8_3 = 45,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_9_1 = 46,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_9_1_2 = 47,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_9_3 = 48,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_10_1 = 49,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_10_1_2 = 50,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_10_3 = 51,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_11_1 = 52,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_11_1_2 = 53,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_11_3 = 54,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_12_1 = 55,
        /// <summary>
        /// Size: 2 - Type: UInt32 - Flags: Public
        /// </summary>
        ENCHANTMENT_12_1_2 = 56,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Public
        /// </summary>
        ENCHANTMENT_12_3 = 57,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        PROPERTY_SEED = 58,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        RANDOM_PROPERTIES_ID = 59,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: OwnerOnly
        /// </summary>
        ITEM_TEXT_ID = 60,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: OwnerOnly, ItemOwner
        /// </summary>
        DURABILITY = 61,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: OwnerOnly, ItemOwner
        /// </summary>
        MAXDURABILITY = 62,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        CREATE_PLAYED_TIME = 63,
    }

    public enum ContainerFields
    {
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        NUM_SLOTS = 64,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: None
        /// </summary>
        ALIGN_PAD = 65,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1 = 66,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_2 = 67,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_3 = 68,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_4 = 69,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_5 = 70,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_6 = 71,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_7 = 72,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_8 = 73,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_9 = 74,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_10 = 75,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_11 = 76,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_12 = 77,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_13 = 78,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_14 = 79,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_15 = 80,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_16 = 81,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_17 = 82,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_18 = 83,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_19 = 84,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_20 = 85,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_21 = 86,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_22 = 87,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_23 = 88,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_24 = 89,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_25 = 90,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_26 = 91,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_27 = 92,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_28 = 93,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_29 = 94,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_30 = 95,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_31 = 96,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_32 = 97,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_33 = 98,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_34 = 99,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_35 = 100,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_36 = 101,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_37 = 102,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_38 = 103,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_39 = 104,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_40 = 105,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_41 = 106,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_42 = 107,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_43 = 108,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_44 = 109,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_45 = 110,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_46 = 111,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_47 = 112,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_48 = 113,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_49 = 114,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_50 = 115,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_51 = 116,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_52 = 117,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_53 = 118,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_54 = 119,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_55 = 120,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_56 = 121,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_57 = 122,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_58 = 123,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_59 = 124,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_60 = 125,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_61 = 126,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_62 = 127,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_63 = 128,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_64 = 129,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_65 = 130,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_66 = 131,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_67 = 132,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_68 = 133,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_69 = 134,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_70 = 135,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_71 = 136,
        /// <summary>
        /// Size: 72 - Type: Guid - Flags: Public
        /// </summary>
        SLOT_1_72 = 137,
    }

    public enum DynamicObjectFields
    {
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CASTER = 6,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        CASTER_2 = 7,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Public
        /// </summary>
        BYTES = 8,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        SPELLID = 9,
        /// <summary>
        /// Size: 1 - Type: Float - Flags: Public
        /// </summary>
        RADIUS = 10,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        CASTTIME = 11,
    }

    public enum GameObjectFields
    {
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        OBJECT_FIELD_CREATED_BY = 6,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        OBJECT_FIELD_CREATED_BY_2 = 7,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        DISPLAYID = 8,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        FLAGS = 9,
        /// <summary>
        /// Size: 4 - Type: Float - Flags: Public
        /// </summary>
        PARENTROTATION = 10,
        /// <summary>
        /// Size: 4 - Type: Float - Flags: Public
        /// </summary>
        PARENTROTATION_2 = 11,
        /// <summary>
        /// Size: 4 - Type: Float - Flags: Public
        /// </summary>
        PARENTROTATION_3 = 12,
        /// <summary>
        /// Size: 4 - Type: Float - Flags: Public
        /// </summary>
        PARENTROTATION_4 = 13,
        /// <summary>
        /// Size: 1 - Type: TwoInt16 - Flags: Dynamic
        /// </summary>
        DYNAMIC = 14,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        FACTION = 15,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        LEVEL = 16,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Public
        /// </summary>
        BYTES_1 = 17,
    }

    public enum CorpseFields
    {
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        OWNER = 6,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        OWNER_2 = 7,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        PARTY = 8,
        /// <summary>
        /// Size: 2 - Type: Guid - Flags: Public
        /// </summary>
        PARTY_2 = 9,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        DISPLAY_ID = 10,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM = 11,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_2 = 12,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_3 = 13,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_4 = 14,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_5 = 15,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_6 = 16,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_7 = 17,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_8 = 18,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_9 = 19,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_10 = 20,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_11 = 21,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_12 = 22,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_13 = 23,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_14 = 24,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_15 = 25,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_16 = 26,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_17 = 27,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_18 = 28,
        /// <summary>
        /// Size: 19 - Type: UInt32 - Flags: Public
        /// </summary>
        ITEM_19 = 29,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Public
        /// </summary>
        BYTES_1 = 30,
        /// <summary>
        /// Size: 1 - Type: ByteArray - Flags: Public
        /// </summary>
        BYTES_2 = 31,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        GUILD = 32,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Public
        /// </summary>
        FLAGS = 33,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: Dynamic
        /// </summary>
        DYNAMIC_FLAGS = 34,
        /// <summary>
        /// Size: 1 - Type: UInt32 - Flags: None
        /// </summary>
        PAD = 35,
    }

}
