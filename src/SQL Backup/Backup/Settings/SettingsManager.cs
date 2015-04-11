namespace Backup
{
    public class SettingsManager
    {
        public static string ServerName { get { return SettingsReader.QuerySetting("ServerName");  } }
        public static string DatabaseName { get { return SettingsReader.QuerySetting("DatabaseName"); } }
        public static string SqlUsername { get { return SettingsReader.QuerySetting("SqlUsername"); } }
        public static string SqlPassword { get { return SettingsReader.QuerySetting("SqlPassword"); } }

        //Backup Info
        public static string BackupPath { get { return SettingsReader.QuerySetting("BackupToPath"); } }
        public static string CopyToPath { get { return SettingsReader.QuerySetting("CopyToPath"); } }
        public static string CompressBackup { get { return SettingsReader.QuerySetting("CompressDatabase"); } }
        public static string UseWindowsAuth { get { return SettingsReader.QuerySetting("UseWindowsAuth"); } }

        //Upload Info
        public static string UploadService { get { return SettingsReader.QuerySetting("UploadService"); } }
        public static string UploadAddress { get { return SettingsReader.QuerySetting("UploadAddress"); } }
        public static string UploadUserID { get { return SettingsReader.QuerySetting("UploadUserID"); } }
        public static string UploadPassword { get { return SettingsReader.QuerySetting("UploadPassword"); } }

        //API Specific Information
        public static string ApiUserKey { get { return SettingsReader.QuerySetting("APIUserKey"); } }
        public static string ApiUserSecret { get { return SettingsReader.QuerySetting("APIUserSecret"); } }

        //Email Info
        public static string NotifyOnFail { get { return SettingsReader.QuerySetting("NotifyOnFail"); } }

        public static string SmtpServer { get { return SettingsReader.QuerySetting("SmtpServer"); } }
        public static string SmtpPort { get { return SettingsReader.QuerySetting("SmtpPort"); } }

        public static string SmtpUsername { get { return SettingsReader.QuerySetting("SmtpUsername"); } }
        public static string SmtpPassword { get { return SettingsReader.QuerySetting("SmtpPassword"); } }

        public static string SendTo { get { return SettingsReader.QuerySetting("SendTo"); } }
        public static string CopyTo { get { return SettingsReader.QuerySetting("CopyTo"); } }
    }
}
