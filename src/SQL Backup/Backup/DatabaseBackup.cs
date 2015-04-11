using System;
using System.Data.SqlClient;

namespace Backup
{
    public class DatabaseBackup
    {
        public static void BackupDatabase()
        {
            string backupCommandString = "BACKUP DATABASE @pisDbName TO DISK = @pisBackupPath WITH INIT, NAME=@pisBackupName, NOSKIP, NOFORMAT";
            
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();

            connectionStringBuilder["Data Source"] = SettingsManager.ServerName;
            connectionStringBuilder["Initial Catalog"] = SettingsManager.DatabaseName;

            if (SettingsManager.UseWindowsAuth == "True")
            {
                connectionStringBuilder["Integrated Security"] = true;
            }
            else
            {
                connectionStringBuilder["User ID"] = SettingsManager.SqlUsername;
                connectionStringBuilder["Password"] = SettingsManager.SqlPassword;
            }

            SqlConnection sqlConnection = new SqlConnection(connectionStringBuilder.ConnectionString);
            SqlCommand backupCommand = new SqlCommand(backupCommandString, sqlConnection);
                                                                                                //Unlikely to need character limits this long however...:
            backupCommand.Parameters.Add("@pisDbName", System.Data.SqlDbType.VarChar, 128);     //128 Is Max DB Name Size in MS SQL Server
            backupCommand.Parameters.Add("@pisBackupPath", System.Data.SqlDbType.VarChar, 256); //256 Is Max NTFS File Path Length
            backupCommand.Parameters.Add("@pisBackupName", System.Data.SqlDbType.VarChar, 135); //135 Because: DBName + ' Backup'

            backupCommand.Parameters["@pisDbName"].Value = SettingsManager.DatabaseName;
            backupCommand.Parameters["@pisBackupPath"].Value = SettingsManager.BackupPath;
            backupCommand.Parameters["@pisBackupName"].Value = SettingsManager.DatabaseName + " Backup";

            try
            {
                sqlConnection.Open();
                backupCommand.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                LogEvent.Error(String.Format("Failed to Backup SQL Database:\r\n{0}", Ex));
                Environment.Exit(1);
            }

            sqlConnection.Close();
        }
    }
}
