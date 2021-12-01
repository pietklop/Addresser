
namespace Dashboard
{
    partial class frmOverview
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
            this.dgvFamList = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFamList
            // 
            this.dgvFamList.AllowUserToAddRows = false;
            this.dgvFamList.AllowUserToDeleteRows = false;
            this.dgvFamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamList.Location = new System.Drawing.Point(86, 41);
            this.dgvFamList.Name = "dgvFamList";
            this.dgvFamList.ReadOnly = true;
            this.dgvFamList.RowTemplate.Height = 25;
            this.dgvFamList.Size = new System.Drawing.Size(741, 622);
            this.dgvFamList.TabIndex = 0;
            this.dgvFamList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamList_CellClick);
            this.dgvFamList.SelectionChanged += new System.EventHandler(this.dgvFamList_SelectionChanged);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(86, 12);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(179, 23);
            this.txtFilter.TabIndex = 7;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // frmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(933, 677);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.dgvFamList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOverview";
            this.Text = "frmOverview";
            this.Load += new System.EventHandler(this.frmOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFamList;
        private System.Windows.Forms.TextBox txtFilter;
    }
}