
namespace Dashboard
{
    partial class frmStickerConfigOverview
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
            this.dgvStickerConfigs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStickerConfigs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFamList
            // 
            this.dgvStickerConfigs.AllowUserToAddRows = false;
            this.dgvStickerConfigs.AllowUserToDeleteRows = false;
            this.dgvStickerConfigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStickerConfigs.Location = new System.Drawing.Point(57, 42);
            this.dgvStickerConfigs.Name = "dgvStickerConfigs";
            this.dgvStickerConfigs.ReadOnly = true;
            this.dgvStickerConfigs.RowTemplate.Height = 25;
            this.dgvStickerConfigs.Size = new System.Drawing.Size(232, 361);
            this.dgvStickerConfigs.TabIndex = 1;
            this.dgvStickerConfigs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamList_CellClick);
            this.dgvStickerConfigs.SelectionChanged += new System.EventHandler(this.dgvFamList_SelectionChanged);
            // 
            // frmStickerConfigOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStickerConfigs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStickerConfigOverview";
            this.Text = "frmStickerConfigOverview";
            this.Load += new System.EventHandler(this.frmStickerConfigOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStickerConfigs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStickerConfigs;
    }
}