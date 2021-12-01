
namespace Dashboard
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnMainOverview = new System.Windows.Forms.Button();
            this.btnNewFamily = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblSpv = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.metroStyleFormManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblViewName = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleFormManager)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlMenu.Controls.Add(this.tableLayoutPanel1);
            this.pnlMenu.Controls.Add(this.pnlInfo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 30);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(186, 747);
            this.pnlMenu.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnImport, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnMainOverview, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNewFamily, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 144);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 603);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnImport.Location = new System.Drawing.Point(3, 566);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(180, 34);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Visible = false;
            // 
            // btnMainOverview
            // 
            this.btnMainOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMainOverview.FlatAppearance.BorderSize = 0;
            this.btnMainOverview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainOverview.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMainOverview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMainOverview.Location = new System.Drawing.Point(3, 3);
            this.btnMainOverview.Name = "btnMainOverview";
            this.btnMainOverview.Size = new System.Drawing.Size(180, 34);
            this.btnMainOverview.TabIndex = 1;
            this.btnMainOverview.Text = "Address list";
            this.btnMainOverview.UseVisualStyleBackColor = true;
            this.btnMainOverview.Click += new System.EventHandler(this.btnMainOverview_Click);
            this.btnMainOverview.Leave += new System.EventHandler(this.btnMainOverview_Leave);
            // 
            // btnNewFamily
            // 
            this.btnNewFamily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewFamily.FlatAppearance.BorderSize = 0;
            this.btnNewFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFamily.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewFamily.Location = new System.Drawing.Point(3, 43);
            this.btnNewFamily.Name = "btnNewFamily";
            this.btnNewFamily.Size = new System.Drawing.Size(180, 34);
            this.btnNewFamily.TabIndex = 1;
            this.btnNewFamily.Text = "New family";
            this.btnNewFamily.UseVisualStyleBackColor = true;
            this.btnNewFamily.Click += new System.EventHandler(this.btnNewFamily_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPrint.Location = new System.Drawing.Point(3, 83);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(180, 34);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Dividends";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.lblSpv);
            this.pnlInfo.Controls.Add(this.lblVersion);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(186, 144);
            this.pnlInfo.TabIndex = 0;
            // 
            // lblSpv
            // 
            this.lblSpv.AutoSize = true;
            this.lblSpv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSpv.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSpv.Location = new System.Drawing.Point(3, 0);
            this.lblSpv.Name = "lblSpv";
            this.lblSpv.Size = new System.Drawing.Size(91, 20);
            this.lblSpv.TabIndex = 6;
            this.lblSpv.Text = "Addresser";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblVersion.Location = new System.Drawing.Point(3, 20);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(53, 13);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "version ...";
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormLoader.Location = new System.Drawing.Point(186, 100);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(965, 677);
            this.pnlFormLoader.TabIndex = 2;
            // 
            // metroStyleFormManager
            // 
            this.metroStyleFormManager.Owner = this;
            this.metroStyleFormManager.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleFormManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.pnlTitle.Controls.Add(this.lblViewName);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(186, 30);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(965, 70);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblViewName
            // 
            this.lblViewName.AutoSize = true;
            this.lblViewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViewName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblViewName.Location = new System.Drawing.Point(285, 16);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(188, 39);
            this.lblViewName.TabIndex = 4;
            this.lblViewName.Text = "View name";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1151, 777);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.pnlMenu);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Resizable = false;
            this.Text = "Addresser";
            this.pnlMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleFormManager)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMainOverview;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnNewFamily;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Button btnPrint;
        private MetroFramework.Components.MetroStyleManager metroStyleFormManager;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblViewName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSpv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnImport;
    }
}

