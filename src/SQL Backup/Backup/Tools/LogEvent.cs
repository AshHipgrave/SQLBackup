using System.Diagnostics;

namespace Backup
{
    public class LogEvent
    {
        public static void Info(string Message)
        {
            EventLog.WriteEntry("SQL Backup", Message, EventLogEntryType.Information);
        }

        public static void Warning(string Message)
        {
            EventLog.WriteEntry("SQL Backup", Message, EventLogEntryType.Warning);
        }

        public static void Error(string Message)
        {
            EventLog.WriteEntry("SQL Backup", Message, EventLogEntryType.Error);

            //TODO: Keep an eye on this - (GitHub Issue #3 - Was unable to reproduce).
            if (SettingsManager.NotifyOnFail == "true")
                Tools.EmailErrors.EmailError(Message);
        }
    }
}
