using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Data
{
    /// <summary>WMO File. Parses and stores a World Model Object.</summary>
    public abstract class WMOFile
    {
        protected MVER mver;                  // WMO File Version

        public WMOFile(String filename)
        {
        }

        protected abstract void parseFile(string mpqfile);

        // MVER Chunk (WMO Version)
        protected struct MVER
        {
            public UInt32 version;
        }
    }
}
