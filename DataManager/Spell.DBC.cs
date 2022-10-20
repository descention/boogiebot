using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IcarusBot.Core;

namespace Data
{
    class SpellDBC
    {
        private DBCFile SpellDBCFile,SpellMechanicDBCFile,SpellDurationDBCFile,SpellRadiusDBCFile,SpellCastTimesDBCFile,SpellRangeDBCFile;
	
        
        public SpellDBC(string spellDBCPath, string spellDBCDuration, string spellDBCRadius, string spellDBCCastTimes, string spellDBCRange, string spellDBCMechanic)  //Full Spell DBC constructor
        {	
            SpellDBCFile = new DBCFile(spellDBCPath);
	        SpellDurationDBCFile = new DBCFile(spellDBCDuration);
	        SpellRadiusDBCFile = new DBCFile(spellDBCRadius);
	        SpellCastTimesDBCFile = new DBCFile(spellDBCCastTimes);
	        SpellRangeDBCFile = new DBCFile(spellDBCRange);
	        SpellMechanicDBCFile = new DBCFile(spellDBCMechanic);
        }

	    public SpellDBC(string spellDBCPath) //Single DBC Constructor (spell.dbc)
	    {
	        SpellDBCFile = new DBCFile(spellDBCPath);
	    }

        public void ParseSpellDBC()
        {
            SpellItem.Spells.Clear();
            for (uint i = 0; i < SpellDBCFile.getSizeofDBC(); i++)
            {
                try 
		        {
	                var spell = GetDBCData(i);
                	SpellItem.Spells.Add(spell.SpellID, spell); 
		        }
                catch 
		        { 
		
		        }
            }
        }

        private SpellItem GetDBCData(uint record)
        {
            SpellItem spells = new SpellItem();
            spells.SpellID = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.SpellID);
            spells.CooldownTime = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.CooldownTime);
            spells.MaxLevel = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.MaxLevel);
            spells.Effect_DiePerLevel_A = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_DiePerLevel_A);
            spells.Effect_DiePerLevel_B = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_DiePerLevel_B);
            spells.Effect_DiePerLevel_C = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_DiePerLevel_C);
            spells.Effect_PointsPerCombo_A = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_PointsPerCombo_A);
            spells.Effect_PointsPerCombo_B = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_PointsPerCombo_B);
            spells.Effect_PointsPerCombo_C = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_PointsPerCombo_C);
            spells.Effect_ProcValue_A = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_ProcValue_A);
            spells.Effect_ProcValue_B = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_ProcValue_B);
            spells.Effect_ProcValue_C = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_ProcValue_C);
            spells.Effect_RealPointsPerLevel_A = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_RealPointsPerLevel_A);
            spells.Effect_RealPointsPerLevel_B = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_RealPointsPerLevel_B);
            spells.Effect_RealPointsPerLevel_C = SpellDBCFile.getFieldAsFloat(record, (uint)SpellDBCFieldID.Effect_RealPointsPerLevel_C);
            spells.BaseLevel = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.BaseLevel);
            spells.Effect_BasePoints_A = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_BasePoints_A);
            spells.Effect_BasePoints_B = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_BasePoints_B);
            spells.Effect_BasePoints_C = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_BasePoints_C);
            spells.Effect_DiceCount_A = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_DiceCount_A);
            spells.Effect_DiceCount_B = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_DiceCount_B);
            spells.Effect_DiceCount_C = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_DiceCount_C);
            spells.Effect_DiceSides_A = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_DiceSides_A);
            spells.Effect_DiceSides_B = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_DiceSides_B);
            spells.Effect_DiceSides_C = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_DiceSides_C);
            spells.Effect_MiscValueA_A = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_MiscValueA_A);
            spells.Effect_MiscValueA_B = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_MiscValueA_B);
            spells.Effect_MiscValueA_C = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_MiscValueA_C);
            spells.Effect_MiscValueB_A = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_MiscValueB_A);
            spells.Effect_MiscValueB_B = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_MiscValueB_B);
            spells.Effect_MiscValueB_C = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_MiscValueB_C);
            spells.Effect_RaduisIndex_A = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_RaduisIndex_A);
            spells.Effect_RaduisIndex_B = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_RaduisIndex_B);
            spells.Effect_RaduisIndex_C = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Effect_RaduisIndex_C);
            spells.Level = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.Level);
            spells.MaxLevel = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.MaxLevel);
            spells.StartRecoveryCategory = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.StartRecoveryCategory);
            spells.StartRecoveryTime = SpellDBCFile.getFieldAsInt32(record, (uint)SpellDBCFieldID.StartRecoveryTime);
            spells.Description = SpellDBCFile.getStringForField(record, (uint)SpellDBCFieldID.Description);
            spells.Name = SpellDBCFile.getStringForField(record, (uint)SpellDBCFieldID.Name);
            spells.Rank = SpellDBCFile.getStringForField(record, (uint)SpellDBCFieldID.Rank);
            spells.BuffIconID = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.BuffIconID);
            spells.DurationIndex = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.DurationIndex);
            spells.CastTimeIndex = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.CastTimeIndex);
            spells.Effect_Amplitude_A = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_Amplitude_A);
            spells.Effect_Amplitude_B = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_Amplitude_B);
            spells.Effect_Amplitude_C = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_Amplitude_C);
            spells.Effect_AuraType_A = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_AuraType_A);
            spells.Effect_AuraType_B = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_AuraType_B);
            spells.Effect_AuraType_C = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_AuraType_C);
            spells.Effect_ChainTarget_A = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ChainTarget_A);
            spells.Effect_ChainTarget_B = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ChainTarget_B);
            spells.Effect_ChainTarget_C = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ChainTarget_C);
            spells.Effect_ImplicitTargetA_A = (ImplicitTargetType)SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ImplicitTargetA_A);
            spells.Effect_ImplicitTargetA_B = (ImplicitTargetType)SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ImplicitTargetA_B);
            spells.Effect_ImplicitTargetA_C = (ImplicitTargetType)SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ImplicitTargetA_C);
            spells.Effect_ImplicitTargetB_A = (ImplicitTargetType)SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ImplicitTargetB_A);
            spells.Effect_ImplicitTargetB_B = (ImplicitTargetType)SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ImplicitTargetB_B);
            spells.Effect_ImplicitTargetB_C = (ImplicitTargetType)SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ImplicitTargetB_C);
            spells.Effect_ItemID_A = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ItemID_A);
            spells.Effect_ItemID_B = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ItemID_B);
            spells.Effect_ItemID_C = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_ItemID_C);
            spells.Effect_Mechanic_A = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_Mechanic_A);
            spells.Effect_Mechanic_B = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_Mechanic_B);
            spells.Effect_Mechanic_C = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_Mechanic_C);
            spells.Effect_TriggerSpellID_A = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_TriggerSpellID_A);
            spells.Effect_TriggerSpellID_B = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_TriggerSpellID_B);
            spells.Effect_TriggerSpellID_C = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_TriggerSpellID_C);
            spells.Effect_Type_A = (SpellEffectType)SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_Type_A);
            spells.Effect_Type_B = (SpellEffectType)SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_Type_B);
            spells.Effect_Type_C = (SpellEffectType)SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Effect_Type_C);
            spells.MaxTargets = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.MaxTargets);
            spells.PowerCost = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.PowerCost);
            spells.PowerCostPercentage = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.PowerCostPercentage);
            spells.PowerCostPerLevel = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.PowerCostPerLevel);
            spells.PowerType = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.PowerType);
            spells.Priority = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.Priority);
            spells.RangeIndex = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.RangeIndex);
            spells.RuneCostID = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.RuneCostID);
            spells.SpellBookIconID = SpellDBCFile.getFieldAsUint32(record, (uint)SpellDBCFieldID.SpellBookIconID);


            

            //Populate Duration Data

            for (uint i = 0; i < SpellDurationDBCFile.getSizeofDBC(); i++)
            {
                if (spells.DurationIndex == i)
                {
                    spells.DurationMin = SpellDurationDBCFile.getFieldAsInt32(i, 1);
                    spells.DurationLevelDelta = SpellDurationDBCFile.getFieldAsInt32(i, 2);
                    spells.DurationMax = SpellDurationDBCFile.getFieldAsInt32(i, 3);
                }
            }


            //Populate Cast Time Data

            for (uint i = 0; i < SpellCastTimesDBCFile.getSizeofDBC(); i++)
            {
                if (spells.CastTimeIndex == i)
                {
                    spells.CastTime = SpellDurationDBCFile.getFieldAsInt32(i, 1);
                }
            }

            return spells;
        }
    }
}
