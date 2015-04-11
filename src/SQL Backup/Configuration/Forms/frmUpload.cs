using System;
using System.Windows.Forms;

namespace Configuration
{
    public partial class frmUpload : Form
    {
        public frmUpload()
        {
            InitializeComponent();
        }

        private void btnUploadConfig_Click(object sender, EventArgs e)
        {
            SettingsManager.UploadService = (string)cmbUploadService.SelectedItem;

            switch (SettingsManager.UploadService)
            {
                case "Dropbox":
                    frmDropbox dropboxForm = new frmDropbox();
                    dropboxForm.Show();
                    Close();
                    break;

                case "Google Drive":
                    frmGoogleDrive googleDriveForm = new frmGoogleDrive();
                    googleDriveForm.Show();
                    Close();
                    break;

                case "FTP":
                    frmFtp ftpForm = new frmFtp();
                    ftpForm.Show();
                    Close();
                    break;

                default:
                    frmSchedule scheduleForm = new frmSchedule();
                    scheduleForm.Show();
                    Close();
                    break;
            }
        }
    }
}
