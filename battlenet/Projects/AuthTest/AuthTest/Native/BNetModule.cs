using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace AuthTest.Native
{
    class BNetModule
    {



        public static void DownloadModule(string moduleHash)
        {
            const string DownloadSite = @"http://auth.us.depot.battle.net/{0}.auth"; // {0} is the hash
            // http://auth.us.depot.battle.net/<hash>.auth
            var client = new WebClient();
            client.DownloadFile(String.Format(DownloadSite, moduleHash), String.Format("{0}.auth", moduleHash));
        }

        public static byte[] UPXUnpack(string upxPackedFile)
        {
            string unpackedName = Path.GetFileNameWithoutExtension(upxPackedFile) + "_Unpacked.dll";
            var startInfo = new ProcessStartInfo("upx.exe")
                                {
                                    Arguments = String.Format("-d -o{0} {1}", unpackedName, upxPackedFile)
                                };
            var process = Process.Start(startInfo);
            process.WaitForExit();

            return File.ReadAllBytes(unpackedName);
        }
    }
}
