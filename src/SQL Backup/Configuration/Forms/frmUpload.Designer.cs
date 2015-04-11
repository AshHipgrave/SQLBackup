namespace Configuration
{
    partial class frmUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpload));
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnUploadConfig = new System.Windows.Forms.Button();
            this.txtUploadTo = new System.Windows.Forms.Label();
            this.cmbUploadService = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblInfo.Location = new System.Drawing.Point(12, 97);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(339, 39);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // btnUploadConfig
            // 
            this.btnUploadConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUploadConfig.Location = new System.Drawing.Point(76, 53);
            this.btnUploadConfig.Name = "btnUploadConfig";
            this.btnUploadConfig.Size = new System.Drawing.Size(210, 23);
            this.btnUploadConfig.TabIndex = 10;
            this.btnUploadConfig.Text = "Launch Upload Configuration Wizard";
            this.btnUploadConfig.UseVisualStyleBackColor = true;
            this.btnUploadConfig.Click += new System.EventHandler(this.btnUploadConfig_Click);
            // 
            // txtUploadTo
            // 
            this.txtUploadTo.AutoSize = true;
            this.txtUploadTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUploadTo.Location = new System.Drawing.Point(42, 10);
            this.txtUploadTo.Name = "txtUploadTo";
            this.txtUploadTo.Size = new System.Drawing.Size(71, 13);
            this.txtUploadTo.TabIndex = 8;
            this.txtUploadTo.Text = "Upload Using";
            // 
            // cmbUploadService
            // 
            this.cmbUploadService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUploadService.FormattingEnabled = true;
            this.cmbUploadService.Items.AddRange(new object[] {
            "Dropbox",
            "Google Drive",
            "FTP"});
            this.cmbUploadService.Location = new System.Drawing.Point(45, 26);
            this.cmbUploadService.Name = "cmbUploadService";
            this.cmbUploadService.Size = new System.Drawing.Size(276, 21);
            this.cmbUploadService.TabIndex = 9;
            // 
            // frmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 147);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnUploadConfig);
            this.Controls.Add(this.txtUploadTo);
            this.Controls.Add(this.cmbUploadService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload Service";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnUploadConfig;
        private System.Windows.Forms.Label txtUploadTo;
        private System.Windows.Forms.ComboBox cmbUploadService;
    }
}