using System;
using System.Net.Mail;
using System.Diagnostics;

namespace Backup.Tools
{
    public class EmailErrors
    {
        public static void EmailError(string ErrorMessage)
        {
            MailMessage message = new MailMessage(SettingsManager.SmtpUsername, SettingsManager.SendTo);
            SmtpClient mailClient = new SmtpClient(SettingsManager.SmtpServer, Int32.Parse(SettingsManager.SmtpPort))
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false
            };

            message.Priority = MailPriority.High;
            message.Subject = "Your SQL Backup Has Failed";

            message.Body = string.Format("This is an automated message to inform you that your SQL database backup has failed. The error returned was:\r\n\r\n " 
                + "{0} \r\n\r\nPlease run the backup manually or contact your support provider\r\n\r\nRegards,\r\n\r\nSQL Backup", ErrorMessage);

            try
            {
                mailClient.Send(message);
            }
            catch (Exception Ex)
            {
                const string exceptionSrc = "SQL Backup Failure Notifications";
                string exceptionMsg = String.Format("Failed to Send Email to Inform of the Failure of the SQL Backup - The Error Returned Was\r\nr\n{0}", Ex);

                EventLog.WriteEntry(exceptionSrc, exceptionMsg, EventLogEntryType.Error);
            }
            finally
            {
                Environment.Exit(1);
            }
        }
    }
}