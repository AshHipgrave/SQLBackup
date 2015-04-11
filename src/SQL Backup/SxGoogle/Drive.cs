using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Authentication;

namespace SxGoogle
{
    public class Drive
    {
        private const string FileDescription = "MS SQL Server Database Backup";
        private const string FileMimeType = "application/octet-stream";

        public static void UploadFile(string FilePath, string FileName, string AccessToken, string RefreshToken)
        {
            DriveAuthentication.SavedRefreshToken = RefreshToken;

            IAuthenticator auth = DriveAuthentication.UseSavedAuthentication();
            DriveService service = new DriveService(auth);

            File body = new File
            {
                Title = FileName, 
                Description = FileDescription, 
                MimeType = FileMimeType
            };

            FilesResource.InsertMediaUpload request = service.Files.Insert(body, System.IO.File.OpenRead(FilePath), FileMimeType);
            request.ChunkSize = 256 * 1024;
            request.Upload();
        }
    }
}
