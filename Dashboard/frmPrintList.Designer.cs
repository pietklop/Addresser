
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
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(310, 40);
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
            // frmPrintList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 534);
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
    }
}