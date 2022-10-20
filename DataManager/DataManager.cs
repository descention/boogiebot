using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
//using Foole.Crypt;
using Microsoft.Win32;
using MpqReader;

namespace Data 
{
    /*public class WardenUpdate
    {
        private string [] files;

        public byte[] Sha1File(string File)
        {
            MpqStream ms = DataManager.MPQLoader.OpenFile(File);
            Sha1Hash tmp = new Sha1Hash();
            try
            {
                byte[] tmp2 = new byte[ms.Length];
                ms.Read(tmp2, 0, (int) ms.Length);
                tmp.Update(tmp2);
            }
            catch(Exception e)
            {
            }
            return tmp.Final();
        }

        public WardenUpdate(string[] files)
        {
            this.files = files;
        }

        string ByteString(byte[] buffer)
        {
            string tmp = "";
            for (int i = 0; i < buffer.Length; i++)
                tmp += "\\x" + buffer[i].ToString("X2").ToLower();
            return tmp;
        }

        public void WriteOut(string File)
        {
            StreamWriter sw = new StreamWriter(File);
            int i = 0;
                for (i = 0; i < files.Length; i++ )
                {
                    if (i == 0)
                        sw.WriteLine("\t\tif ( !stricmp( szFile, \"" + files[i].Replace("\\", "\\\\") + "\" ) )");
                    else
                        sw.WriteLine("\t\telse if ( !stricmp( szFile, \"" + files[i].Replace("\\","\\\\") + "\" ) )");
                    sw.WriteLine("\t\t\tszHash = (uchar*) \"" + ByteString(Sha1File(files[i])) + "\";");
                }
            sw.Close();
        }
    }*/

    public class DataManager
    {
        public static string MpqPath = GetGameDirFromReg();


        public static string GetGameDirFromReg()
        {
            //return @"D:\World of Warcraft\";
            //return @"C:\Users\Public\Games\World of Warcraft\";
            var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Blizzard Entertainment\World of Warcraft");

            if (key == null)
            {
                MessageBox.Show("Error", "We can't detect your wow directory.");
                return null;
            }

            var val = key.GetValue("InstallPath");
            //var val = @"C:\Users\Public\Games\World of Warcraft\";

            if (val == null)
                return null;

            return String.Format("{0}", val);
        }


        
        public static TerrainManager Terrainmanager { get; private set; }
        public static MPQManager MPQLoader { get; private set; }


        static DataManager()
        {
            MPQLoader = new MPQManager();
            Terrainmanager = new TerrainManager();
            new SpellDBC(@"DBFilesClient\Spell.dbc",
		                 @"DBFilesClient\SpellDuration.dbc",
		                 @"DBFilesClient\SpellRadius.dbc",
		                 @"DBFilesClient\SpellCastTimes.dbc",
		                 @"DBFilesClient\SpellRange.dbc",
		                 @"DBFilesClient\SpellMechanic.dbc").ParseSpellDBC();

            /*WardenUpdate wu = new WardenUpdate(new string[] {
                @"World\Maps\HellfireRampart\HellfireRampart_28_34.adt",
                @"World\Maps\PVPZone04\PVPZone04_30_29.adt",
                @"DBFilesClient\CreatureModelData.dbc",
                @"World\Maps\PVPZone04\PVPZone04_29_30.adt",
                @"World\Maps\PVPZone01\PVPZone01_32_29.adt",
                @"World\GENERIC\PassiveDoodads\ValentinesDay\ValentineBasket_01.m2",
                @"World\Expansion02\Doodads\Stormpeaks\IceShards\FrostGiantIceShard04.M2",
                @"World\AZEROTH\ELWYNN\PASSIVEDOODADS\Campfire\ElwynnCampfire.m2",
                @"World\Maps\PVPZone01\PVPZone01_32_30.adt",
                @"world\maps\stratholme\stratholme_38_25.adt",
                @"world\maps\stratholme\stratholme_38_24.adt",
                @"World\Maps\Kalimdor\Kalimdor_29_9.adt",
                @"world\goober\g_fishingbobber.blp",
                @"World\Generic\Human\Passive Doodads\BeerKegs\BeerKeg01_NoCollide.M2",
                @"World\Generic\PASSIVEDOODADS\DuelingFlag\DuelingFlag.m2",
                @"Interface\Addons\Blizzard_DebugTools\Dump.lua"
            });

            wu.WriteOut(@"c:\newout.txt");*/
            
            /*if (!Directory.Exists("Maps"))
                Directory.CreateDirectory("Maps");

            MpqStream ms = null;
            byte[] tmp2 = new byte[1];
            BinaryWriter bw = null;
            StreamWriter sw = null;
            foreach (var c in DataManager.MPQLoader.MPQArchives)
            {
                foreach (var c1 in c.Files)
                {
                    if (c1.Name.ToLower().Contains(".wdt"))
                    {
                        ms = MPQLoader.OpenFile(c1.Name);
                        tmp2 = new byte[ms.Length];
                        ms.Read(tmp2, 0, (int)ms.Length);
                        Directory.CreateDirectory(@"Maps\" + c1.Name.Substring(0, c1.Name.LastIndexOf('\\')));
                        bw = new BinaryWriter(new StreamWriter(@"Maps\" + c1.Name).BaseStream);
                        bw.Write(tmp2);
                        bw.Close();
                    }
                }
            }*/

            // ### new FactionDBC(@"DBFilesClient\Faction.dbc",
            //               @"DBFilesClient\FactionGroup.dbc",
            //               @"DBFilesClient\FactionTemplate.dbc");
			
        }

        private string ApplicationPath()
        {
            //return Path.GetDirectoryName([Assembly].GetExecutingAssembly().Location)
            return AppDomain.CurrentDomain.BaseDirectory;


        }

        // This is only used to ensure everything that needs to be pre-loaded, is.
        public static void Refresh()
        {
            // doesn't need to actually do anything :)
        }
    }
}
