
namespace Dashboard
{
    partial class frmPrintList
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNameT = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.btnSrcToDest = new System.Windows.Forms.Button();
            this.btnDelFromDest = new System.Windows.Forms.Button();
            this.lstDestination = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.txtStickersToSkip = new System.Windows.Forms.TextBox();
            this.lblStickersToSkipT = new System.Windows.Forms.Label();
            this.grpPrintMode = new System.Windows.Forms.GroupBox();
            this.rbtList = new System.Windows.Forms.RadioButton();
            this.rbtSticker = new System.Windows.Forms.RadioButton();
            this.grpPrintMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(158, 23);
            this.txtName.TabIndex = 11;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblNameT
            // 
            this.lblNameT.AutoSize = true;
            this.lblNameT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNameT.Location = new System.Drawing.Point(55, 38);
            this.lblNameT.Name = "lblNameT";
            this.lblNameT.Size = new System.Drawing.Size(52, 21);
            this.lblNameT.TabIndex = 10;
            this.lblNameT.Text = "Name";
            // 
            // txtFilter
            // 
            this.txtFilter.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFilter.Location = new System.Drawing.Point(55, 94);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(179, 23);
            this.txtFilter.TabIndex = 12;
            this.txtFilter.Text = "Filter";
            this.txtFilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFilter_MouseClick);
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.ItemHeight = 15;
            this.lstSource.Location = new System.Drawing.Point(55, 134);
            this.lstSource.Name = "lstSource";
            this.lstSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSource.Size = new System.Drawing.Size(179, 274);
            this.lstSource.TabIndex = 13;
            this.lstSource.DoubleClick += new System.EventHandler(this.lstSource_DoubleClick);
            // 
            // btnSrcToDest
            // 
            this.btnSrcToDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSrcToDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrcToDest.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSrcToDest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSrcToDest.Location = new System.Drawing.Point(268, 205);
            this.btnSrcToDest.Name = "btnSrcToDest";
            this.btnSrcToDest.Size = new System.Drawing.Size(45, 37);
            this.btnSrcToDest.TabIndex = 15;
            this.btnSrcToDest.Text = "è";
            this.btnSrcToDest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSrcToDest.UseVisualStyleBackColor = false;
            this.btnSrcToDest.Click += new System.EventHandler(this.btnSrcToDest_Click);
            // 
            // btnDelFromDest
            // 
            this.btnDelFromDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDelFromDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelFromDest.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelFromDest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelFromDest.Location = new System.Drawing.Point(268, 270);
            this.btnDelFromDest.Name = "btnDelFromDest";
            this.btnDelFromDest.Size = new System.Drawing.Size(45, 37);
            this.btnDelFromDest.TabIndex = 16;
            this.btnDelFromDest.Text = "ç";
            this.btnDelFromDest.UseVisualStyleBackColor = false;
            this.btnDelFromDest.Click += new System.EventHandler(this.btnDelFromDest_Click);
            // 
            // lstDestination
            // 
            this.lstDestination.FormattingEnabled = true;
            this.lstDestination.ItemHeight = 15;
            this.lstDestination.Location = new System.Drawing.Point(345, 134);
            this.lstDestination.Name = "lstDestination";
            this.lstDestination.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstDestination.Size = new System.Drawing.Size(179, 274);
            this.lstDestination.TabIndex = 17;
            this.lstDestination.DoubleClick += new System.EventHandler(this.lstDestination_DoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(438, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete list";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(345, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPreview.Font = new System.Drawing.Font("Wingdings 2", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrintPreview.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPrintPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintPreview.Location = new System.Drawing.Point(345, 13);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(56, 50);
            this.btnPrintPreview.TabIndex = 20;
            this.btnPrintPreview.Text = "6";
            this.btnPrintPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // txtStickersToSkip
            // 
            this.txtStickersToSkip.Location = new System.Drawing.Point(482, 80);
            this.txtStickersToSkip.Name = "txtStickersToSkip";
            this.txtStickersToSkip.Size = new System.Drawing.Size(42, 23);
            this.txtStickersToSkip.TabIndex = 21;
            this.txtStickersToSkip.Text = "0";
            // 
            // lblStickersToSkipT
            // 
            this.lblStickersToSkipT.AutoSize = true;
            this.lblStickersToSkipT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStickersToSkipT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStickersToSkipT.Location = new System.Drawing.Point(345, 78);
            this.lblStickersToSkipT.Name = "lblStickersToSkipT";
            this.lblStickersToSkipT.Size = new System.Drawing.Size(113, 21);
            this.lblStickersToSkipT.TabIndex = 22;
            this.lblStickersToSkipT.Text = "Stickers to skip";
            // 
            // grpPrintMode
            // 
            this.grpPrintMode.Controls.Add(this.rbtList);
            this.grpPrintMode.Controls.Add(this.rbtSticker);
            this.grpPrintMode.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpPrintMode.Location = new System.Drawing.Point(432, 4);
            this.grpPrintMode.Name = "grpPrintMode";
            this.grpPrintMode.Size = new System.Drawing.Size(92, 60);
            this.grpPrintMode.TabIndex = 23;
            this.grpPrintMode.TabStop = false;
            // 
            // rbtList
            // 
            this.rbtList.AutoSize = true;
            this.rbtList.Location = new System.Drawing.Point(16, 34);
            this.rbtList.Name = "rbtList";
            this.rbtList.Size = new System.Drawing.Size(43, 19);
            this.rbtList.TabIndex = 25;
            this.rbtList.Text = "List";
            this.rbtList.UseVisualStyleBackColor = true;
            // 
            // rbtSticker
            // 
            this.rbtSticker.AutoSize = true;
            this.rbtSticker.Checked = true;
            this.rbtSticker.Location = new System.Drawing.Point(16, 13);
            this.rbtSticker.Name = "rbtSticker";
            this.rbtSticker.Size = new System.Drawing.Size(65, 19);
            this.rbtSticker.TabIndex = 24;
            this.rbtSticker.TabStop = true;
            this.rbtSticker.Text = "Stickers";
            this.rbtSticker.UseVisualStyleBackColor = true;
            // 
            // frmPrintList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.grpPrintMode);
            this.Controls.Add(this.lblStickersToSkipT);
            this.Controls.Add(this.txtStickersToSkip);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstDestination);
            this.Controls.Add(this.btnDelFromDest);
            this.Controls.Add(this.btnSrcToDest);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNameT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrintList";
            this.Text = "frmPrintList";
            this.grpPrintMode.ResumeLayout(false);
            this.grpPrintMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNameT;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.Button btnSrcToDest;
        private System.Windows.Forms.Button btnDelFromDest;
        private System.Windows.Forms.ListBox lstDestination;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.TextBox txtStickersToSkip;
        private System.Windows.Forms.Label lblStickersToSkipT;
        private System.Windows.Forms.GroupBox grpPrintMode;
        private System.Windows.Forms.RadioButton rbtList;
        private System.Windows.Forms.RadioButton rbtSticker;
    }
}