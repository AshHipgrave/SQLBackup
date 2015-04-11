using System;
using System.Windows.Forms;

using Microsoft.Win32;

namespace Configuration
{
    public partial class frmBackup : Form
    {
        private bool ExitOnClose = true;

        public frmBackup()
        {
            InitializeComponent();

            LoadSettings();
            ExitOnClose = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveSettings();

            frmUpload uploadForm = new frmUpload();
            uploadForm.Show();

            ExitOnClose = false;
            Close();
        }

        private void LoadSettings()
        {
            txtBackupPath.Text = SettingsManager.BackupToPath;
            txtCopyTo.Text = SettingsManager.CopyToPath;
            chkCompress.Checked = SettingsManager.CompressDatabase;
        }

        private void SaveSettings()
        {
            SettingsManager.BackupToPath = txtBackupPath.Text;
            SettingsManager.CopyToPath = txtCopyTo.Text;
            SettingsManager.CompressDatabase = chkCompress.Checked;
        }

        private void btnBrowseBackup_Click(object sender, EventArgs e)
        {
            txtBackupPath.Text = BrowseFolder() + "\\" + SettingsManager.DatabaseName + ".bak";
        }

        private void btnBrowseCopyTo_Click(object sender, EventArgs e)
        {
            txtCopyTo.Text = BrowseFolder();
        }

        private static string BrowseFolder()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            return folderBrowser.ShowDialog() == DialogResult.OK ? folderBrowser.SelectedPath : "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();

            ExitOnClose = false;
            Close();
        }

        private void frmBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitOnClose)
                Application.Exit();
        }
    }
}
