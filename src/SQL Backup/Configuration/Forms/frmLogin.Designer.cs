namespace Configuration
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.grpSqlInfo = new System.Windows.Forms.GroupBox();
            this.chkUseWindowsAuth = new System.Windows.Forms.CheckBox();
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lblSyrPass = new System.Windows.Forms.Label();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.txtSqlPassword = new System.Windows.Forms.TextBox();
            this.lblSyrUser = new System.Windows.Forms.Label();
            this.txtSqlUser = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.grpSqlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSqlInfo
            // 
            this.grpSqlInfo.Controls.Add(this.chkUseWindowsAuth);
            this.grpSqlInfo.Controls.Add(this.lblServerName);
            this.grpSqlInfo.Controls.Add(this.txtDatabase);
            this.grpSqlInfo.Controls.Add(this.lblSyrPass);
            this.grpSqlInfo.Controls.Add(this.lblDatabaseName);
            this.grpSqlInfo.Controls.Add(this.txtSqlPassword);
            this.grpSqlInfo.Controls.Add(this.lblSyrUser);
            this.grpSqlInfo.Controls.Add(this.txtSqlUser);
            this.grpSqlInfo.Controls.Add(this.txtServer);
            this.grpSqlInfo.Location = new System.Drawing.Point(11, 8);
            this.grpSqlInfo.Name = "grpSqlInfo";
            this.grpSqlInfo.Size = new System.Drawing.Size(288, 177);
            this.grpSqlInfo.TabIndex = 33;
            this.grpSqlInfo.TabStop = false;
            this.grpSqlInfo.Text = "SQL Connection Information";
            // 
            // chkUseWindowsAuth
            // 
            this.chkUseWindowsAuth.AutoSize = true;
            this.chkUseWindowsAuth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkUseWindowsAuth.Location = new System.Drawing.Point(108, 142);
            this.chkUseWindowsAuth.Name = "chkUseWindowsAuth";
            this.chkUseWindowsAuth.Size = new System.Drawing.Size(169, 17);
            this.chkUseWindowsAuth.TabIndex = 29;
            this.chkUseWindowsAuth.Text = "Use Windows Authentication?";
            this.chkUseWindowsAuth.UseVisualStyleBackColor = true;
            this.chkUseWindowsAuth.CheckedChanged += new System.EventHandler(this.chkUseWindowsAuth_CheckedChanged);
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblServerName.Location = new System.Drawing.Point(7, 28);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(72, 13);
            this.lblServerName.TabIndex = 21;
            this.lblServerName.Text = "Server Name:";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(100, 51);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(177, 20);
            this.txtDatabase.TabIndex = 24;
            // 
            // lblSyrPass
            // 
            this.lblSyrPass.AutoSize = true;
            this.lblSyrPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSyrPass.Location = new System.Drawing.Point(7, 119);
            this.lblSyrPass.Name = "lblSyrPass";
            this.lblSyrPass.Size = new System.Drawing.Size(56, 13);
            this.lblSyrPass.TabIndex = 27;
            this.lblSyrPass.Text = "Password:";
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.AutoSize = true;
            this.lblDatabaseName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDatabaseName.Location = new System.Drawing.Point(7, 54);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(87, 13);
            this.lblDatabaseName.TabIndex = 23;
            this.lblDatabaseName.Text = "Database Name:";
            // 
            // txtSqlPassword
            // 
            this.txtSqlPassword.Location = new System.Drawing.Point(100, 116);
            this.txtSqlPassword.Name = "txtSqlPassword";
            this.txtSqlPassword.PasswordChar = '*';
            this.txtSqlPassword.Size = new System.Drawing.Size(177, 20);
            this.txtSqlPassword.TabIndex = 28;
            this.txtSqlPassword.UseSystemPasswordChar = true;
            // 
            // lblSyrUser
            // 
            this.lblSyrUser.AutoSize = true;
            this.lblSyrUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSyrUser.Location = new System.Drawing.Point(7, 93);
            this.lblSyrUser.Name = "lblSyrUser";
            this.lblSyrUser.Size = new System.Drawing.Size(71, 13);
            this.lblSyrUser.TabIndex = 25;
            this.lblSyrUser.Text = "Logon Name:";
            // 
            // txtSqlUser
            // 
            this.txtSqlUser.Location = new System.Drawing.Point(100, 90);
            this.txtSqlUser.Name = "txtSqlUser";
            this.txtSqlUser.Size = new System.Drawing.Size(177, 20);
            this.txtSqlUser.TabIndex = 26;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(100, 25);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(177, 20);
            this.txtServer.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(11, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(220, 189);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(79, 23);
            this.btnNext.TabIndex = 34;
            this.btnNext.Text = "Next >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 220);
            this.Controls.Add(this.grpSqlInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Login";
            this.grpSqlInfo.ResumeLayout(false);
            this.grpSqlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSqlInfo;
        private System.Windows.Forms.CheckBox chkUseWindowsAuth;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lblSyrPass;
        private System.Windows.Forms.Label lblDatabaseName;
        private System.Windows.Forms.TextBox txtSqlPassword;
        private System.Windows.Forms.Label lblSyrUser;
        private System.Windows.Forms.TextBox txtSqlUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;

    }
}

