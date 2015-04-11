namespace Configuration
{
    public static class SettingsManager
    {
        //SQL Settings
        public static string ServerName { get; set; }
        public static string DatabaseName { get; set; }
        public static string SqlUsername { get; set; }

        public static string SqlPassword { get; set; }
        public static bool UseWindowsAuth { get; set; }

        //Backup Settings
        public static string BackupToPath { get; set; }
        public static string CopyToPath { get; set; }
        public static bool CompressDatabase { get; set; }

        //Upload Settings
        public static string UploadService { get; set; }
        public static string FtpAddress { get; set; }
        public static string FtpUsername { get; set; }
        public static string FtpPassword { get; set; }

        //API Settings
        public static string ApiUserKey { get; set; }
        public static string ApiUserSecret { get; set; }

        //SMTP Settings
        public static string NotifyOnFail { get; set; }
        public static string SmtpServer { get; set; }
        public static string SmtpPort { get; set; }
        public static bool UseSsl { get; set; }

        public static string SmtpUsername { get; set; }
        public static string SmtpPassword { get; set; }
        public static string SendTo { get; set; }
    }
}
