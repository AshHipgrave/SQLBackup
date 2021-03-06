﻿namespace Configuration
{
    partial class frmGoogleDrive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoogleDrive));
            this.webDrive = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webDrive
            // 
            this.webDrive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webDrive.Location = new System.Drawing.Point(0, 0);
            this.webDrive.MinimumSize = new System.Drawing.Size(20, 20);
            this.webDrive.Name = "webDrive";
            this.webDrive.Size = new System.Drawing.Size(784, 562);
            this.webDrive.TabIndex = 0;
            this.webDrive.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webDrive_DocumentCompleted);
            // 
            // frmGoogleDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.webDrive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGoogleDrive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to GoogleDrive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGoogleDrive_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webDrive;


    }
}