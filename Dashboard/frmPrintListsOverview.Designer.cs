
namespace Dashboard
{
    partial class frmPrintListsOverview
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
            this.dgvPrintLists = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintLists)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrintLists
            // 
            this.dgvPrintLists.AllowUserToAddRows = false;
            this.dgvPrintLists.AllowUserToDeleteRows = false;
            this.dgvPrintLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrintLists.Location = new System.Drawing.Point(58, 64);
            this.dgvPrintLists.Name = "dgvPrintLists";
            this.dgvPrintLists.ReadOnly = true;
            this.dgvPrintLists.RowTemplate.Height = 25;
            this.dgvPrintLists.Size = new System.Drawing.Size(492, 328);
            this.dgvPrintLists.TabIndex = 1;
            this.dgvPrintLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrintLists_CellClick);
            this.dgvPrintLists.SelectionChanged += new System.EventHandler(this.dgvPrintLists_SelectionChanged);
            // 
            // frmPrintListsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPrintLists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrintListsOverview";
            this.Text = "frmPrintListsOverview";
            this.Load += new System.EventHandler(this.frmPrintListsOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrintLists)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrintLists;
    }
}