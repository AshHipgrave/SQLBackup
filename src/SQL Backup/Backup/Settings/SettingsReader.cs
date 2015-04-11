using System;
using System.Data.SqlServerCe;

namespace Backup
{
    public class SettingsReader
    {
        private static readonly string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\SQL Backup\\";
        private static readonly string dataFilePath = appDataPath + "SxSettings.sdf";

        public static string QuerySetting(string SettingName)
        {
            string settingValue = null;
            
            string connectionString = String.Format("Data Source={0};Persist Security Info=False;", dataFilePath);
            string queryString = String.Format("SELECT SET_VALUE FROM TH_SETTINGS WHERE SET_NAME = '{0}'", SettingName);

            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);
            SqlCeCommand sqlCommand = new SqlCeCommand(queryString, sqlConnection);

            try
            {
                sqlConnection.Open();

                var cmdResult = sqlCommand.ExecuteScalar();

                if (cmdResult != DBNull.Value)
                    settingValue = (string) cmdResult;
            }
            catch (SqlCeException Ex)
            {
                LogEvent.Error(String.Format("Failed to access Settings Database. The error returned was:\r\n\r\n {0} \r\n\r\nThe backup will not continue", Ex));
                Environment.Exit(1);
            }

            sqlConnection.Close();

            if (SettingName.Contains("Password") && settingValue != null)
                return System.Text.Encoding.ASCII.GetString(Convert.FromBase64String(settingValue));

            return settingValue;
        }
    }
}
