using System;
using System.Windows.Forms;

namespace Configuration
{
    public partial class frmReview : Form
    {
        public frmReview()
        {
            InitializeComponent();

            pnlReview.ShowCustomProperties = true;
            PopulateSettings();
        }

        private void PopulateSettings()
        {
            pnlReview.Item.Add("Server Name", SettingsManager.ServerName, false, "SQL Settings", "Location of Your SQL Database", true);
            pnlReview.Item.Add("Database Name", SettingsManager.DatabaseName, false, "SQL Settings", "Name of Your SQL Database", true);
            pnlReview.Item.Add("SQL Username", SettingsManager.SqlUsername, false, "SQL Settings", "Username to Login to SQL", true);
            pnlReview.Item.Add("SQL Password", SettingsManager.SqlPassword, false, "SQL Settings", "Password to Connect to Your SQL Database", true);
            pnlReview.Item.Add("Use Windows Authentication", SettingsManager.UseWindowsAuth, false, "SQL Settings", "Sets Wether or Not the Backup Program Should" 
                + "Connect to the Server Using Your Username and Password Rather Than a SQL Account", true);

            pnlReview.Item.Add("Backup To Folder", SettingsManager.BackupToPath, false, "Backup Settings", "Folder to Backup Your SQL Database To", true);
            pnlReview.Item.Add("Copy to Folder", SettingsManager.CopyToPath, false, "Backup Settings", "Copies Your SQL Backup to the Specified Path", true);
            pnlReview.Item.Add("Compress Backup?", SettingsManager.CompressDatabase, false, "Backup Settings", "Sets Wether or Not Your Backup is Compressed to Save Disk Space", true);

            pnlReview.Item.Add("Upload Service", SettingsManager.UploadService, true, "Upload Settings", "Web Service Being Used to Upload Your Database", true);
            pnlReview.Item.Add("FTP Server Address", SettingsManager.FtpAddress, false, "Upload Settings", "FTP Server the Backup is to be Uploaded To", true);
            pnlReview.Item.Add("FTP Username", SettingsManager.FtpUsername, false, "Upload Settings", "Username Being Used to Connect to the Web Service", true);
            pnlReview.Item.Add("FTP Password", SettingsManager.FtpPassword, false, "Upload Settings", "Password Used to Connect to the Web Service", true);

            pnlReview.Item.Add("API User Key", SettingsManager.ApiUserKey, true, "API Specific Settings", "User Key to Connect to the Upload API", true);
            pnlReview.Item.Add("API User Secret Key", SettingsManager.ApiUserSecret, true, "API Specific Settings", "User Secret Key to Connect to the Upload API", true);
        }

        private void pnlReview_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            switch (e.ChangedItem.Label)
            {
                case "Server Name":
                    SettingsManager.ServerName = e.ChangedItem.Value.ToString();
                    break;
                case "Database Name":
                    SettingsManager.DatabaseName = e.ChangedItem.Value.ToString();
                    break;
                case "SQL Username":
                    SettingsManager.SqlUsername = e.ChangedItem.Value.ToString();
                    break;
                case "SQL Password":
                    SettingsManager.SqlPassword = e.ChangedItem.Value.ToString();
                    break;
                case "Use Windows Authentication":
                    SettingsManager.UseWindowsAuth = e.ChangedItem.Value.ToString().ToLower() == "true";
                    break;
                case "Backup To Folder":
                    SettingsManager.BackupToPath = e.ChangedItem.Value.ToString();
                    break;
                case "Copy to Folder":
                    SettingsManager.CopyToPath = e.ChangedItem.Value.ToString();
                    break;
                case "Compress Backup?":
                    SettingsManager.CompressDatabase = e.ChangedItem.Value.ToString().ToLower() == "true";
                    break;
                case "FTP Server Address":
                    SettingsManager.FtpAddress = e.ChangedItem.Value.ToString();
                    break;
                case "FTP Username":
                    SettingsManager.FtpUsername = e.ChangedItem.Value.ToString();
                    break;
                case "FTP Password":
                    SettingsManager.FtpPassword = e.ChangedItem.Value.ToString();
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Wish To Be Notified Via Email When The Backup Fails?", "Setup Email Notifications", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmEmail emailForm = new frmEmail();
                emailForm.Show();
            }
            else
            {
                SettingsWriter.WriteSettings();
                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Wish to Exit Without Saving Your Settings?", "Settings Will Not Be Saved", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void frmReview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
