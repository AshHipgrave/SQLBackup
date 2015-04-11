namespace Configuration
{
    partial class frmSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.grpTaskSchedule = new System.Windows.Forms.GroupBox();
            this.lblDaysWeeks = new System.Windows.Forms.Label();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.lblEvery = new System.Windows.Forms.Label();
            this.dtBackupTime = new System.Windows.Forms.DateTimePicker();
            this.lblRun = new System.Windows.Forms.Label();
            this.lblAtTime = new System.Windows.Forms.Label();
            this.lblOnDay = new System.Windows.Forms.Label();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.cmbRunDay = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpTaskSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTaskSchedule
            // 
            this.grpTaskSchedule.Controls.Add(this.lblDaysWeeks);
            this.grpTaskSchedule.Controls.Add(this.txtFreq);
            this.grpTaskSchedule.Controls.Add(this.lblEvery);
            this.grpTaskSchedule.Controls.Add(this.dtBackupTime);
            this.grpTaskSchedule.Controls.Add(this.lblRun);
            this.grpTaskSchedule.Controls.Add(this.lblAtTime);
            this.grpTaskSchedule.Controls.Add(this.lblOnDay);
            this.grpTaskSchedule.Controls.Add(this.cmbSchedule);
            this.grpTaskSchedule.Controls.Add(this.cmbRunDay);
            this.grpTaskSchedule.Location = new System.Drawing.Point(11, 11);
            this.grpTaskSchedule.Name = "grpTaskSchedule";
            this.grpTaskSchedule.Size = new System.Drawing.Size(278, 178);
            this.grpTaskSchedule.TabIndex = 17;
            this.grpTaskSchedule.TabStop = false;
            this.grpTaskSchedule.Text = "Backup Schedule Settings";
            // 
            // lblDaysWeeks
            // 
            this.lblDaysWeeks.AutoSize = true;
            this.lblDaysWeeks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDaysWeeks.Location = new System.Drawing.Point(201, 94);
            this.lblDaysWeeks.Name = "lblDaysWeeks";
            this.lblDaysWeeks.Size = new System.Drawing.Size(31, 13);
            this.lblDaysWeeks.TabIndex = 15;
            this.lblDaysWeeks.Text = "Days";
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(127, 91);
            this.txtFreq.MaxLength = 3;
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(68, 20);
            this.txtFreq.TabIndex = 14;
            // 
            // lblEvery
            // 
            this.lblEvery.AutoSize = true;
            this.lblEvery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEvery.Location = new System.Drawing.Point(124, 75);
            this.lblEvery.Name = "lblEvery";
            this.lblEvery.Size = new System.Drawing.Size(43, 13);
            this.lblEvery.TabIndex = 13;
            this.lblEvery.Text = "Every...";
            // 
            // dtBackupTime
            // 
            this.dtBackupTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBackupTime.Location = new System.Drawing.Point(9, 91);
            this.dtBackupTime.Name = "dtBackupTime";
            this.dtBackupTime.Size = new System.Drawing.Size(90, 20);
            this.dtBackupTime.TabIndex = 12;
            // 
            // lblRun
            // 
            this.lblRun.AutoSize = true;
            this.lblRun.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRun.Location = new System.Drawing.Point(6, 25);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(76, 13);
            this.lblRun.TabIndex = 7;
            this.lblRun.Text = "Run Backup...";
            // 
            // lblAtTime
            // 
            this.lblAtTime.AutoSize = true;
            this.lblAtTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAtTime.Location = new System.Drawing.Point(6, 75);
            this.lblAtTime.Name = "lblAtTime";
            this.lblAtTime.Size = new System.Drawing.Size(58, 13);
            this.lblAtTime.TabIndex = 11;
            this.lblAtTime.Text = "At (Time)...";
            // 
            // lblOnDay
            // 
            this.lblOnDay.AutoSize = true;
            this.lblOnDay.Enabled = false;
            this.lblOnDay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOnDay.Location = new System.Drawing.Point(6, 126);
            this.lblOnDay.Name = "lblOnDay";
            this.lblOnDay.Size = new System.Drawing.Size(52, 13);
            this.lblOnDay.TabIndex = 9;
            this.lblOnDay.Text = "On Day...";
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Items.AddRange(new object[] {
            "Daily",
            "Weekly"});
            this.cmbSchedule.Location = new System.Drawing.Point(6, 41);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(262, 21);
            this.cmbSchedule.TabIndex = 8;
            this.cmbSchedule.SelectedIndexChanged += new System.EventHandler(this.cmbSchedule_SelectedIndexChanged);
            // 
            // cmbRunDay
            // 
            this.cmbRunDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRunDay.Enabled = false;
            this.cmbRunDay.FormattingEnabled = true;
            this.cmbRunDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Saturday",
            "Sunday"});
            this.cmbRunDay.Location = new System.Drawing.Point(6, 142);
            this.cmbRunDay.Name = "cmbRunDay";
            this.cmbRunDay.Size = new System.Drawing.Size(262, 21);
            this.cmbRunDay.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(11, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(167, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Review Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 228);
            this.Controls.Add(this.grpTaskSchedule);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Schedule";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSchedule_FormClosing);
            this.grpTaskSchedule.ResumeLayout(false);
            this.grpTaskSchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTaskSchedule;
        private System.Windows.Forms.Label lblDaysWeeks;
        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.Label lblEvery;
        private System.Windows.Forms.DateTimePicker dtBackupTime;
        private System.Windows.Forms.Label lblRun;
        private System.Windows.Forms.Label lblAtTime;
        private System.Windows.Forms.Label lblOnDay;
        private System.Windows.Forms.ComboBox cmbSchedule;
        private System.Windows.Forms.ComboBox cmbRunDay;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}