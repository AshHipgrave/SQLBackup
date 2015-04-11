using System;

namespace Backup
{
    class Program
    {
        private static string compressedBackupPath;

        static void Main()
        {
            Console.Title = "SQL Database Backup Utility";
            LogEvent.Info(String.Format("SQL Database Backup Started for Database: {0}. On Server: {1}", SettingsManager.DatabaseName, SettingsManager.ServerName));
            
            DatabaseBackup.BackupDatabase();
            compressedBackupPath = SettingsManager.CompressBackup.Equals("True") ? Compression.CompressFile(SettingsManager.BackupPath) : SettingsManager.BackupPath;

            if (!SettingsManager.CopyToPath.Equals("Not Found"))
                CopyDatabase();

            UploadDatabase();
            LogEvent.Info("SQL Database Backup Has Completed Successfully");
        }

        private static void CopyDatabase()
        {
            try
            {
                string ext = SettingsManager.CompressBackup.Equals("True") ? ".zip" : ".bak";

                string path = String.Format(SettingsManager.CopyToPath + "\\{0}{1}", SettingsManager.DatabaseName, ext);

                System.IO.File.Copy(compressedBackupPath, path, true);
            }
            catch (Exception Ex)
            {
                LogEvent.Error(String.Format("Failed to Copy the Database to the Path {0}. The Error Returned Was\r\n{1}\r\nContinuing With the Backup",
                    SettingsManager.CopyToPath, Ex));
            }
        }

        private static void UploadDatabase()
        {
            LogEvent.Info(String.Format("Uploading Database {0} via {1}", compressedBackupPath, SettingsManager.UploadService));

            switch (SettingsManager.UploadService)
            {
                case "FTP":
                    Services.FTP.UploadDatabase(compressedBackupPath);
                    break;
                case "Dropbox":
                    Services.Dropbox.UploadDatabase(compressedBackupPath);
                    break;
                case "Google Drive":
                    Services.GoogleDrive.UploadDatabase(compressedBackupPath, SettingsManager.DatabaseName);
                    break;
                default:
                    LogEvent.Info("Unknown or Unspecified Upload Service - Database Backup Has Not Been Uploaded to an External Web Source");
                    break;
            }
        }
    }
}
