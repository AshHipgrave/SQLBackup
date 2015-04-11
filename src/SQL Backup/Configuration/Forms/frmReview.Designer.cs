namespace Configuration
{
    partial class frmReview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReview));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlReview = new PropertyGridEx.PropertyGridEx();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 409);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit Without Saving";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(330, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save All Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlReview
            // 
            // 
            // 
            // 
            this.pnlReview.DocCommentDescription.AccessibleName = "";
            this.pnlReview.DocCommentDescription.AutoEllipsis = true;
            this.pnlReview.DocCommentDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlReview.DocCommentDescription.Location = new System.Drawing.Point(3, 18);
            this.pnlReview.DocCommentDescription.Name = "";
            this.pnlReview.DocCommentDescription.Size = new System.Drawing.Size(455, 37);
            this.pnlReview.DocCommentDescription.TabIndex = 1;
            this.pnlReview.DocCommentImage = null;
            // 
            // 
            // 
            this.pnlReview.DocCommentTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlReview.DocCommentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.pnlReview.DocCommentTitle.Location = new System.Drawing.Point(3, 3);
            this.pnlReview.DocCommentTitle.Name = "";
            this.pnlReview.DocCommentTitle.Size = new System.Drawing.Size(455, 15);
            this.pnlReview.DocCommentTitle.TabIndex = 0;
            this.pnlReview.DocCommentTitle.UseMnemonic = false;
            this.pnlReview.Location = new System.Drawing.Point(0, 6);
            this.pnlReview.Name = "pnlReview";
            this.pnlReview.SelectedObject = ((object)(resources.GetObject("pnlReview.SelectedObject")));
            this.pnlReview.ShowCustomProperties = true;
            this.pnlReview.Size = new System.Drawing.Size(461, 397);
            this.pnlReview.TabIndex = 3;
            this.pnlReview.ToolbarVisible = false;
            // 
            // 
            // 
            this.pnlReview.ToolStrip.AccessibleName = "ToolBar";
            this.pnlReview.ToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.pnlReview.ToolStrip.AllowMerge = false;
            this.pnlReview.ToolStrip.AutoSize = false;
            this.pnlReview.ToolStrip.CanOverflow = false;
            this.pnlReview.ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.pnlReview.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.pnlReview.ToolStrip.Location = new System.Drawing.Point(0, 1);
            this.pnlReview.ToolStrip.Name = "";
            this.pnlReview.ToolStrip.Padding = new System.Windows.Forms.Padding(2, 0, 1, 0);
            this.pnlReview.ToolStrip.Size = new System.Drawing.Size(460, 25);
            this.pnlReview.ToolStrip.TabIndex = 1;
            this.pnlReview.ToolStrip.TabStop = true;
            this.pnlReview.ToolStrip.Text = "PropertyGridToolBar";
            this.pnlReview.ToolStrip.Visible = false;
            this.pnlReview.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pnlReview_PropertyValueChanged);
            // 
            // frmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 438);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlReview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Review Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReview_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private PropertyGridEx.PropertyGridEx pnlReview;
    }
}