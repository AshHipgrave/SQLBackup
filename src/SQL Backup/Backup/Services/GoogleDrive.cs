using System;
using SxGoogle;

namespace Backup.Services
{
    public class GoogleDrive
    {
        public static void UploadDatabase(string LocalFilePath, string DatabaseName)
        {
            try
            {
                DatabaseName = (SettingsManager.CompressBackup.Equals("true")) ? DatabaseName + ".zip" : DatabaseName + ".bak";

                Drive.UploadFile(LocalFilePath, DatabaseName, SettingsManager.ApiUserKey, SettingsManager.ApiUserSecret);
            }
            catch (Exception Ex)
            {
                LogEvent.Error("Failed to Upload the Database to Google Drive:\r\n\r\n" + Ex);
                Environment.Exit(1);
            }
        }
    }
}
