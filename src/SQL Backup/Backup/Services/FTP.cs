using System;
using System.IO;
using System.Net;

namespace Backup.Services
{
    public class FTP
    {
        private static FtpWebRequest ftpRequest;
        private static Stream ftpStream;

        private const int bufferSize = 2048;

        public static void UploadDatabase(string LocalBackupPath)
        {
            string remoteBackupPath = LocalBackupPath.Remove(0, LocalBackupPath.Length - 12);

            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create(SettingsManager.UploadAddress + "/" + remoteBackupPath);
                ftpRequest.Credentials = new NetworkCredential(SettingsManager.UploadUserID, SettingsManager.UploadPassword);

                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;

                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpStream = ftpRequest.GetRequestStream();

                FileStream localFileStream = new FileStream(LocalBackupPath, FileMode.Create);

                byte[] byteBuffer = new byte[bufferSize];
                int bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize);

                try
                {
                    while (bytesSent != 0)
                    {
                        ftpStream.Write(byteBuffer, 0, bytesSent);
                        bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize);
                    }
                }
                catch (Exception Ex)
                {
                    LogEvent.Error("Failed to Upload the Database via FTP:\r\n\r\n" + Ex);
                    Environment.Exit(1);
                }

                localFileStream.Close();
                ftpStream.Close();
                ftpRequest = null;
            }
            catch (Exception Ex)
            {
                LogEvent.Error("Unpexpected Error Uploading Database via FTP:\r\n\r\n" + Ex);
                Environment.Exit(1);
            }
        }
    }
}
