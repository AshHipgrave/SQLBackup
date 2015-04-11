using System;
using System.Windows.Forms;

namespace Configuration
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            txtServer.Text = SettingsManager.ServerName;
            txtDatabase.Text = SettingsManager.DatabaseName;
            txtSqlUser.Text = SettingsManager.SqlUsername;
            txtSqlPassword.Text = SettingsManager.SqlPassword;

            chkUseWindowsAuth.Checked = SettingsManager.UseWindowsAuth;
        }

        private void SaveSettings()
        {
            SettingsManager.ServerName = txtServer.Text;
            SettingsManager.DatabaseName = txtDatabase.Text;
            SettingsManager.SqlUsername = txtSqlUser.Text;
            SettingsManager.SqlPassword = txtSqlPassword.Text;
            SettingsManager.UseWindowsAuth = chkUseWindowsAuth.Checked;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveSettings();

            frmBackup backupForm = new frmBackup();
            backupForm.Show();

            Hide();
        }

        private void chkUseWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUseWindowsAuth.Checked)
            {
                txtSqlUser.Enabled = false;
                txtSqlPassword.Enabled = false;
            }
            else
            {
                txtSqlUser.Enabled = true;
                txtSqlPassword.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
