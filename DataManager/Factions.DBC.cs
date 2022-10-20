using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IcarusBot.Core;

namespace Data
{
    class FactionDBC
    {

       // private DBCFile FactionDBCFile, FactionGroupDBCFile, FactionTemplateDBCFile;
       // public FactionDBC(string FactionDBCPath, string FactionGroupDBCDuration, string FactionTemplateDBC)  //Full Spell DBC constructor
       // {	
       //     FactionDBCFile = new DBCFile(FactionDBCPath);
        //    FactionGroupDBCFile = new DBCFile(FactionGroupDBCDuration);
        //    FactionTemplateDBCFile = new DBCFile(FactionTemplateDBC);
       // }

    }

    #region Faction.dbc
    public struct FactionEntry
    {
        public FactionId Id;
        /// <summary>
        /// m_reputationIndex
        /// </summary>
        public FactionReputationIndex FactionIndex;
        public RaceMask[] RaceMask;
        public ClassMask[] ClassMask;
        public int[] BaseRepValue;
        public int[] BaseFlags;
        public FactionId ParentId;
        public string Name;
    }

    public class FactionConverter : DBCRecordConverter<FactionEntry>
    {
        public override FactionEntry ConvertTo(byte[] rawData, ref int id)
        {
            var entry = new FactionEntry();
            id = (int)(entry.Id = (FactionId)GetUInt32(rawData, 0));
            entry.FactionIndex = (FactionReputationIndex)GetInt32(rawData, 1);

            entry.RaceMask = new RaceMask[4];
            for (uint i = 0; i < entry.RaceMask.Length; i++)
            {
                entry.RaceMask[i] = (RaceMask)GetUInt32(rawData, 2 + i);
            }

            entry.ClassMask = new ClassMask[4];
            for (uint i = 0; i < entry.ClassMask.Length; i++)
            {
                entry.ClassMask[i] = (ClassMask)GetUInt32(rawData, 6 + i);
            }

            entry.BaseRepValue = new int[4];
            for (uint i = 0; i < entry.BaseRepValue.Length; i++)
            {
                entry.BaseRepValue[i] = GetInt32(rawData, 10 + i);
            }

            entry.BaseFlags = new int[4];
            for (uint i = 0; i < entry.BaseFlags.Length; i++)
            {
                entry.BaseFlags[i] = GetInt32(rawData, 14 + i);
            }

            entry.ParentId = (FactionId)GetUInt32(rawData, 18);
            entry.Name = GetString(rawData, 19);

            return entry;
        }
    }
    #endregion

    #region FactionTemplate.dbc
    public struct FactionTemplateEntry
    {
        public uint Id;
        public FactionId FactionId;
        public uint Flags;
        /// <summary>
        /// The Faction-Group mask of this faction.
        /// </summary>
        public FactionGroupMask FactionGroup;
        /// <summary>
        /// Mask of Faction-Groups this faction is friendly towards
        /// </summary>
        public FactionGroupMask FriendGroup;
        /// <summary>
        /// Mask of Faction-Groups this faction is hostile towards
        /// </summary>
        public FactionGroupMask EnemyGroup;
        public FactionId[] EnemyFactions;
        public FactionId[] FriendlyFactions;
    }

    public class FactionTemplateConverter : DBCRecordConverter<FactionTemplateEntry>
    {
        public override FactionTemplateEntry ConvertTo(byte[] rawData, ref int id)
        {
            var entry = new FactionTemplateEntry();
            uint x = 0;
            id = (int)(entry.Id = GetUInt32(rawData, x++));
            entry.FactionId = (FactionId)GetUInt32(rawData, x++);
            entry.Flags = GetUInt32(rawData, x++);
            entry.FactionGroup = (FactionGroupMask)GetUInt32(rawData, x++);
            entry.FriendGroup = (FactionGroupMask)GetUInt32(rawData, x++);
            entry.EnemyGroup = (FactionGroupMask)GetUInt32(rawData, x++);

            entry.EnemyFactions = new FactionId[4];
            for (uint i = 0; i < entry.EnemyFactions.Length; i++)
            {
                entry.EnemyFactions[i] = (FactionId)GetUInt32(rawData, x++);
            }

            entry.FriendlyFactions = new FactionId[4];
            for (uint i = 0; i < entry.FriendlyFactions.Length; i++)
            {
                entry.FriendlyFactions[i] = (FactionId)GetUInt32(rawData, x++);
            }

            return entry;
        }
    }
    #endregion


    public class DBCRecordConverter<T> : IDisposable
    {
        private byte[] m_stringTable;

        public void Init(byte[] stringTable)
        {
            m_stringTable = stringTable;
        }

        public virtual T ConvertTo(byte[] rawData, ref int id)
        {
            id = int.MinValue;
            return default(T);
        }

        protected static unsafe uint GetUInt32(byte[] data, uint field)
        {
            uint startIndex = field * 4;
            if (startIndex + 4 > data.Length)
                return uint.MaxValue;

            fixed (byte* pData = &data[startIndex])
            {
                return *(uint*)pData;
            }
        }

        protected static unsafe int GetInt32(byte[] data, uint field)
        {
            uint startIndex = field * 4;
            if (startIndex + 4 > data.Length)
                return int.MaxValue;

            fixed (byte* pData = &data[startIndex])
            {
                return *(int*)pData;
            }
        }

        protected static unsafe float GetFloat(byte[] data, uint field)
        {
            uint startIndex = field * 4;
            if (startIndex + 4 > data.Length)
                return float.NaN;

            fixed (byte* pData = &data[startIndex])
            {
                return *(float*)pData;
            }
        }

        protected static unsafe ulong GetUInt64(byte[] data, uint startingField)
        {
            uint startIndex = startingField * 4;
            if (startIndex + 8 > data.Length)
                return ulong.MaxValue;

            fixed (byte* pData = &data[startIndex])
            {
                return *(ulong*)pData;
            }
        }


        public string GetString(byte[] data, uint stringOffset)
        {
            return GetString(data, Utility.DefaultLocale, stringOffset);
        }

        public string GetString(byte[] data, ref uint offset)
        {
            var ret = GetString(data, offset);
            offset += 17;
            return ret;
        }

        public string GetString(byte[] data, ClientLocale locale, uint stringOffset)
        {
            var startOffset = GetInt32(data, stringOffset + (uint)locale);
            var len = 0;

            while (m_stringTable[(startOffset + len++)] != 0)
            {
            }

            return Utility.DefaultEncoding.GetString(m_stringTable, startOffset, len - 1);
        }


        public void Dispose()
        {
            m_stringTable = null;
        }
    }



}
