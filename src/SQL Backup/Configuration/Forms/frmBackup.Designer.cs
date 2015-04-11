namespace Configuration
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.grpBackupSettings = new System.Windows.Forms.GroupBox();
            this.lblBackupPath = new System.Windows.Forms.Label();
            this.chkCompress = new System.Windows.Forms.CheckBox();
            this.btnBrowseBackup = new System.Windows.Forms.Button();
            this.btnBrowseCopyTo = new System.Windows.Forms.Button();
            this.lblCopyBackup = new System.Windows.Forms.Label();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.txtCopyTo = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpBackupSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBackupSettings
            // 
            this.grpBackupSettings.Controls.Add(this.lblBackupPath);
            this.grpBackupSettings.Controls.Add(this.chkCompress);
            this.grpBackupSettings.Controls.Add(this.btnBrowseBackup);
            this.grpBackupSettings.Controls.Add(this.btnBrowseCopyTo);
            this.grpBackupSettings.Controls.Add(this.lblCopyBackup);
            this.grpBackupSettings.Controls.Add(this.txtBackupPath);
            this.grpBackupSettings.Controls.Add(this.txtCopyTo);
            this.grpBackupSettings.Location = new System.Drawing.Point(12, 11);
            this.grpBackupSettings.Name = "grpBackupSettings";
            this.grpBackupSettings.Size = new System.Drawing.Size(341, 182);
            this.grpBackupSettings.TabIndex = 35;
            this.grpBackupSettings.TabStop = false;
            this.grpBackupSettings.Text = "Database Backup Settings";
            // 
            // lblBackupPath
            // 
            this.lblBackupPath.AutoSize = true;
            this.lblBackupPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBackupPath.Location = new System.Drawing.Point(6, 26);
            this.lblBackupPath.Name = "lblBackupPath";
            this.lblBackupPath.Size = new System.Drawing.Size(97, 13);
            this.lblBackupPath.TabIndex = 17;
            this.lblBackupPath.Text = "Backup to Folder...";
            // 
            // chkCompress
            // 
            this.chkCompress.AutoSize = true;
            this.chkCompress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkCompress.Location = new System.Drawing.Point(6, 152);
            this.chkCompress.Name = "chkCompress";
            this.chkCompress.Size = new System.Drawing.Size(216, 17);
            this.chkCompress.TabIndex = 23;
            this.chkCompress.Text = "Compress Backup to Save Disk Space?";
            this.chkCompress.UseVisualStyleBackColor = true;
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowseBackup.Location = new System.Drawing.Point(253, 68);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseBackup.TabIndex = 19;
            this.btnBrowseBackup.Text = "Browse...";
            this.btnBrowseBackup.UseVisualStyleBackColor = true;
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // btnBrowseCopyTo
            // 
            this.btnBrowseCopyTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowseCopyTo.Location = new System.Drawing.Point(253, 148);
            this.btnBrowseCopyTo.Name = "btnBrowseCopyTo";
            this.btnBrowseCopyTo.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseCopyTo.TabIndex = 22;
            this.btnBrowseCopyTo.Text = "Browse...";
            this.btnBrowseCopyTo.UseVisualStyleBackColor = true;
            this.btnBrowseCopyTo.Click += new System.EventHandler(this.btnBrowseCopyTo_Click);
            // 
            // lblCopyBackup
            // 
            this.lblCopyBackup.AutoSize = true;
            this.lblCopyBackup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCopyBackup.Location = new System.Drawing.Point(6, 106);
            this.lblCopyBackup.Name = "lblCopyBackup";
            this.lblCopyBackup.Size = new System.Drawing.Size(124, 13);
            this.lblCopyBackup.TabIndex = 20;
            this.lblCopyBackup.Text = "Copy Backup to Folder...";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(6, 42);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(322, 20);
            this.txtBackupPath.TabIndex = 18;
            // 
            // txtCopyTo
            // 
            this.txtCopyTo.Location = new System.Drawing.Point(6, 122);
            this.txtCopyTo.Name = "txtCopyTo";
            this.txtCopyTo.Size = new System.Drawing.Size(322, 20);
            this.txtCopyTo.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 199);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(274, 199);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 23);
            this.btnNext.TabIndex = 36;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 232);
            this.Controls.Add(this.grpBackupSettings);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBackup_FormClosing);
            this.grpBackupSettings.ResumeLayout(false);
            this.grpBackupSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBackupSettings;
        private System.Windows.Forms.Label lblBackupPath;
        private System.Windows.Forms.CheckBox chkCompress;
        private System.Windows.Forms.Button btnBrowseBackup;
        private System.Windows.Forms.Button btnBrowseCopyTo;
        private System.Windows.Forms.Label lblCopyBackup;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.TextBox txtCopyTo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
    }
}