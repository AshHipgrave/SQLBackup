using System.Linq;
using System.Windows.Forms;

using SxGoogle;
using DotNetOpenAuth.OAuth2;

namespace Configuration
{
    //TODO: Look into improving this class where possible - See:
    //http://stackoverflow.com/questions/4002847/oauth-with-verification-in-net

    public partial class frmGoogleDrive : Form
    {
        private bool GoogleDriveSuccess;

        private static string token;

        public frmGoogleDrive()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            string authUrl = DriveAuthentication.GetAuthorisationUrl("", "");
            webDrive.Navigate(authUrl);
        }

        private void webDrive_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try
            {
                if (webDrive == null || webDrive.Document == null || webDrive.Document.Title == null) return;

                if ((webDrive.Document.Title.Trim().ToLower().Contains("success")) && webDrive.Document.Body != null)
                {
                        int num = webDrive.Document.Body.InnerHtml.LastIndexOf("value=");

                        if (num <= 0) return;

                        token = webDrive.Document.Body.InnerHtml.Substring(num).Replace("value=", string.Empty).Replace("\">", string.Empty).TrimStart(new[] { '"' });

                    if (token.Contains(" "))
                    {
                        token = token.Split(new[] { ' ' }).First();
                    }

                    GetCode();
                }
                else
                {
                    if (!webDrive.Document.Title.Trim().ToLower().Contains("access_denied") &&
                        !webDrive.Document.Title.Trim().ToLower().Contains("error")) return;

                    token = null;
                    Close();
                }
            }
            catch
            {
                token = null;
                Close();
            }
        }

        private void GetCode()
        {
            IAuthorizationState state = DriveAuthentication.ExchangeCode(token);

            SettingsManager.ApiUserKey = state.AccessToken;
            SettingsManager.ApiUserSecret = state.RefreshToken;

            GoogleDriveSuccess = true;
            Close();
        }

        private void frmGoogleDrive_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!GoogleDriveSuccess)
            {
                MessageBox.Show("Warning: Google Drive Has Not Been Configured - Your Database Backup Will Not Be Uploaded to Google Drive. If You Need to Configure Google Drive in the Future You Will Need to Re-Run This Configuration Wizard",
                    "SQL Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            frmSchedule scheduleForm = new frmSchedule();
            scheduleForm.Show();
        }
    }
}
