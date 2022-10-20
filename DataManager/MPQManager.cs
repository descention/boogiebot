using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MpqReader;

namespace Data
{
    public class MPQManager
    {
        public List <MpqArchive> MPQArchives;

        public MPQManager()
        {
            MPQArchives = new List<MpqArchive>();

            var mpqs = new List<string>
            {
                "Data/patch-2.MPQ"
                ,"Data/patch.MPQ"
                ,"Data/lichking.MPQ"
                ,"Data/expansion.MPQ"
                ,"Data/common-2.MPQ"
                ,"Data/common.MPQ"
                ,"Data/enUS/patch-enUS-2.MPQ"
                ,"Data/enUS/patch-enUS.MPQ"
                ,"Data/enUS/lichking-locale-enUS.MPQ"
                ,"Data/enUS/expansion-locale-enUS.MPQ"
                ,"Data/enUS/locale-enUS.MPQ"
                ,"Data/enUS/base-enUS.MPQ"

            };

            foreach (var mpq in mpqs)
            {
                try
                {
                    MPQArchives.Add(new MpqArchive(String.Format("{0}/{1}", DataManager.MpqPath, mpq)));
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Failed to add MPQ: " + ex.Message);
                }
            }
        }

        public MpqStream OpenFile(string FileName)
        {
            foreach (MpqArchive archive in MPQArchives)
            {
                if (archive.FileExists(FileName))
                {
                    return archive.OpenFile(FileName);
                }
            }
            return null;
        }
    }
}
