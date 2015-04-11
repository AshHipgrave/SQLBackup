using System.Windows.Forms;

using DropNet;
using DropNet.Models;

namespace Configuration
{
    public partial class frmDropbox : Form
    {
        internal readonly string APP_KEY = "APP-KEY-HERE";
        internal readonly string APP_SECRET = "APP-SECRET-HERE";

        private readonly DropNetClient _client;
        private UserLogin _userLogin;

        private bool _dropboxSuccess;

        public frmDropbox()
        {
            InitializeComponent();

            _client = new DropNetClient(APP_KEY, APP_SECRET);

            AuthoriseDropbox();
        }

        private void AuthoriseDropbox()
        {
            var authoiseUrl = _client.GetTokenAndBuildUrl("http://www.google.co.uk");

            brwLogin.DocumentCompleted += brwLogin_DocumentCompleted;
            brwLogin.Navigate(authoiseUrl);
        }

        private void brwLogin_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.Host.Contains("google"))
            {
                _client.GetAccessTokenAsync(userLogin =>
                {
                    _userLogin = userLogin;
                    TestConnection();
                },
                    error => MessageBox.Show("Failed to Obtain Access Token:\r\n\r\n" + error.Response.Content, "SQL Backup - GetAccessTokenAsync"));
            }
        }

        private void TestConnection()
        {
            _client.GetMetaDataAsync("/", response =>
                {
                    _dropboxSuccess = true;

                    SettingsManager.ApiUserKey = _userLogin.Token;
                    SettingsManager.ApiUserSecret = _userLogin.Secret;
                },
                error =>
                {
                    MessageBox.Show("Failed to Verify Connection to Dropbox:\r\n\r\n" + error.ToString(), "Failed to Test Connection");

                    Close();
                });
        }

        private void frmDropbox_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_dropboxSuccess)
            {
                MessageBox.Show("Warning: Dropbox Has Not Been Configured - Your Database Backup Will Not Be Uploaded to Dropbox. If You Need to Configure Dropbox in the Future You Will Need to Re-Run This Configuration Wizard",
                    "SQL Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            frmSchedule scheduleForm = new frmSchedule();
            scheduleForm.Show();
        }
    }
}
