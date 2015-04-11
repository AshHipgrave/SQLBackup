using System;
using System.IO;

using DropNet;
using DropNet.Models;

namespace Backup.Services
{
    public class Dropbox
    {
        private const string APP_KEY = "APP-KEY-HERE";
        private const string APP_SECRET = "APP-SECRET-HERE";

        private const string uploadFolder = "/SQLBackup";

        private static DropNetClient _client;

        public static void UploadDatabase(string DatabaseFilePath)
        {
            _client = new DropNetClient(APP_KEY, APP_SECRET)
            {
                UserLogin = new UserLogin { Token = SettingsManager.ApiUserKey, Secret = SettingsManager.ApiUserSecret }
            };

            byte[] fileContents = File.ReadAllBytes(DatabaseFilePath);

            try
            {
                _client.UploadFile(uploadFolder, SettingsManager.DatabaseName, fileContents);
            }
            catch (Exception Ex)
            {
                LogEvent.Error("Failed to Upload the Database to Dropbox:\r\n\r\n" + Ex);
                Environment.Exit(1);
            }
        }
    }
}
