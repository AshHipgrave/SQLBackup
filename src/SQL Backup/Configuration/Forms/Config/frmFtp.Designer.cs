namespace Configuration
{
    partial class frmFtp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFtp));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFtpPassword = new System.Windows.Forms.TextBox();
            this.lblFtpPassword = new System.Windows.Forms.Label();
            this.txtFtpUsername = new System.Windows.Forms.TextBox();
            this.lblFtpUsername = new System.Windows.Forms.Label();
            this.txtFtpAddress = new System.Windows.Forms.TextBox();
            this.lblFtpServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFtpPassword
            // 
            this.txtFtpPassword.Location = new System.Drawing.Point(10, 113);
            this.txtFtpPassword.Name = "txtFtpPassword";
            this.txtFtpPassword.PasswordChar = '*';
            this.txtFtpPassword.Size = new System.Drawing.Size(313, 20);
            this.txtFtpPassword.TabIndex = 12;
            this.txtFtpPassword.UseSystemPasswordChar = true;
            // 
            // lblFtpPassword
            // 
            this.lblFtpPassword.AutoSize = true;
            this.lblFtpPassword.Location = new System.Drawing.Point(10, 97);
            this.lblFtpPassword.Name = "lblFtpPassword";
            this.lblFtpPassword.Size = new System.Drawing.Size(79, 13);
            this.lblFtpPassword.TabIndex = 11;
            this.lblFtpPassword.Text = "FTP Password:";
            // 
            // txtFtpUsername
            // 
            this.txtFtpUsername.Location = new System.Drawing.Point(10, 74);
            this.txtFtpUsername.Name = "txtFtpUsername";
            this.txtFtpUsername.Size = new System.Drawing.Size(313, 20);
            this.txtFtpUsername.TabIndex = 10;
            // 
            // lblFtpUsername
            // 
            this.lblFtpUsername.AutoSize = true;
            this.lblFtpUsername.Location = new System.Drawing.Point(10, 58);
            this.lblFtpUsername.Name = "lblFtpUsername";
            this.lblFtpUsername.Size = new System.Drawing.Size(81, 13);
            this.lblFtpUsername.TabIndex = 9;
            this.lblFtpUsername.Text = "FTP Username:";
            // 
            // txtFtpAddress
            // 
            this.txtFtpAddress.Location = new System.Drawing.Point(13, 25);
            this.txtFtpAddress.Name = "txtFtpAddress";
            this.txtFtpAddress.Size = new System.Drawing.Size(313, 20);
            this.txtFtpAddress.TabIndex = 8;
            // 
            // lblFtpServer
            // 
            this.lblFtpServer.AutoSize = true;
            this.lblFtpServer.Location = new System.Drawing.Point(13, 9);
            this.lblFtpServer.Name = "lblFtpServer";
            this.lblFtpServer.Size = new System.Drawing.Size(64, 13);
            this.lblFtpServer.TabIndex = 7;
            this.lblFtpServer.Text = "FTP Server:";
            // 
            // frmFtp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 171);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFtpPassword);
            this.Controls.Add(this.lblFtpPassword);
            this.Controls.Add(this.txtFtpUsername);
            this.Controls.Add(this.lblFtpUsername);
            this.Controls.Add(this.txtFtpAddress);
            this.Controls.Add(this.lblFtpServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFtp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFtp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFtp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFtpPassword;
        private System.Windows.Forms.Label lblFtpPassword;
        private System.Windows.Forms.TextBox txtFtpUsername;
        private System.Windows.Forms.Label lblFtpUsername;
        private System.Windows.Forms.TextBox txtFtpAddress;
        private System.Windows.Forms.Label lblFtpServer;
    }
}