using System;
using System.Reflection;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Configuration
{
    class SettingsWriter
    {
        private static readonly string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\SQL Backup\\";
        private static readonly string dataFilePath = appDataPath + "SxSettings.sdf";

        public static void WriteSettings()
        {
            string connectionString = String.Format("Data Source={0};Persist Security Info=False;", dataFilePath);
            string updateString = "UPDATE TH_SETTINGS SET SET_VALUE = @pisSetValue WHERE SET_NAME = @pisSetName";

            Type mType = (typeof(SettingsManager));
            PropertyInfo[] propertyInfo = mType.GetProperties();
            
            SqlCeConnection sqlConnection = new SqlCeConnection(connectionString);

            try
            {
                sqlConnection.Open();

                foreach (PropertyInfo property in propertyInfo)
                {
                    var settingName = property.Name;
                    var settingValue = property.GetValue(null, null);

                    if (settingValue != null && settingName.ToString().Contains("Password"))
                        settingValue = ToBase64((string)settingValue);
                    
                    SqlCeCommand sqlCommand = new SqlCeCommand(updateString, sqlConnection);

                    sqlCommand.Parameters.Add("@pisSetValue", System.Data.SqlDbType.NVarChar);
                    sqlCommand.Parameters.Add("@pisSetName", System.Data.SqlDbType.NVarChar);

                    sqlCommand.Parameters["@pisSetValue"].Value = settingValue ?? DBNull.Value;
                    sqlCommand.Parameters["@pisSetName"].Value = settingName;

                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Failed to Update Settings Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            sqlConnection.Close();
        }

        public static string ToBase64(string input)
        {
            if (!String.IsNullOrWhiteSpace(input))
                return Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(input));

            return input;
        }
    }
}
