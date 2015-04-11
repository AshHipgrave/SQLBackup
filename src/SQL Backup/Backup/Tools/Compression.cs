using System;

using ZLibNet;

namespace Backup
{
    public class Compression
    {
        public static string CompressFile(string BackupPath)
        {
            string zipPath = BackupPath.Remove(BackupPath.Length - 4) + ".zip";

            try
            {
                Zipper zipLib = new Zipper { ZipFile = zipPath };
                zipLib.ItemList.Add(BackupPath);
                
                zipLib.Zip();
            }
            catch (Exception Ex)
            {
                LogEvent.Error(String.Format("Failed to Compress the Database:\r\n {0} \r\nContinuing With the Backup", Ex));
                zipPath = BackupPath;
            }

            return zipPath;
        }
    }
}
