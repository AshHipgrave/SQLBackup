using System;
using System.Windows.Forms;

namespace Configuration
{
    public partial class frmFtp : Form
    {
        public frmFtp()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtFtpAddress.Text.Equals("")) || (txtFtpUsername.Text.Equals("")) || (txtFtpPassword.Text.Equals("")))
            {
                MessageBox.Show("Error: You Must Specify an FTP Address, Username and Password Before Continuing", "SQL Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SettingsManager.FtpAddress = txtFtpAddress.Text;
            SettingsManager.FtpUsername = txtFtpUsername.Text;
            SettingsManager.FtpPassword = txtFtpPassword.Text;

            Close();
        }

        private void frmFtp_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSchedule scheduleForm = new frmSchedule();
            scheduleForm.Show();
        }
    }
}
