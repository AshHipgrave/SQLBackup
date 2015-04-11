using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Configuration
{
    public partial class frmEmail : Form
    {
        private bool testSuccessful;

        public frmEmail()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient(txtServer.Text, Int32.Parse(txtPort.Text));
            MailMessage mailMessage = new MailMessage(txtUsername.Text, txtUsername.Text, "SQL Backup Test Email", "Your Settings Are Correct");

            try
            {
                smtpClient.Send(mailMessage);
                testSuccessful = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error Sending Email:\r\n\r\n" + Ex, Ex.GetType() + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!testSuccessful)
            {
                DialogResult dialogResult = MessageBox.Show("Warning: The email test failed or hasn't been run. Are you sure you wish to continue to save these settings?", "Email Errors", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                    return;
            }

            SettingsManager.NotifyOnFail = "true";
            SettingsManager.SmtpServer = txtServer.Text;
            SettingsManager.SmtpUsername = txtUsername.Text;
            SettingsManager.SmtpPassword = txtPassword.Text;
            SettingsManager.SmtpPort = txtPort.Text;
            SettingsManager.UseSsl = chkUseSsl.Checked;
            SettingsManager.SendTo = txtUsername.Text;

            SettingsWriter.WriteSettings();
            Application.Exit();
        }
    }
}
