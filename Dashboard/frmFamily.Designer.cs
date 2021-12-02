
namespace Dashboard
{
    partial class frmFamily
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
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.lblTitleT = new System.Windows.Forms.Label();
            this.lblNameOverrideT = new System.Windows.Forms.Label();
            this.lblFirstNameT = new System.Windows.Forms.Label();
            this.lblLastNameT = new System.Windows.Forms.Label();
            this.lblZipCodeT = new System.Windows.Forms.Label();
            this.lblStreetT = new System.Windows.Forms.Label();
            this.lblCityT = new System.Windows.Forms.Label();
            this.txtNameOverride = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTitle
            // 
            this.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(214, 50);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(94, 23);
            this.cmbTitle.TabIndex = 0;
            // 
            // lblTitleT
            // 
            this.lblTitleT.AutoSize = true;
            this.lblTitleT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleT.Location = new System.Drawing.Point(72, 50);
            this.lblTitleT.Name = "lblTitleT";
            this.lblTitleT.Size = new System.Drawing.Size(39, 21);
            this.lblTitleT.TabIndex = 1;
            this.lblTitleT.Text = "Title";
            // 
            // lblNameOverrideT
            // 
            this.lblNameOverrideT.AutoSize = true;
            this.lblNameOverrideT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameOverrideT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNameOverrideT.Location = new System.Drawing.Point(72, 100);
            this.lblNameOverrideT.Name = "lblNameOverrideT";
            this.lblNameOverrideT.Size = new System.Drawing.Size(113, 21);
            this.lblNameOverrideT.TabIndex = 2;
            this.lblNameOverrideT.Text = "Optional name";
            // 
            // lblFirstNameT
            // 
            this.lblFirstNameT.AutoSize = true;
            this.lblFirstNameT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstNameT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFirstNameT.Location = new System.Drawing.Point(72, 150);
            this.lblFirstNameT.Name = "lblFirstNameT";
            this.lblFirstNameT.Size = new System.Drawing.Size(83, 21);
            this.lblFirstNameT.TabIndex = 3;
            this.lblFirstNameT.Text = "First name";
            // 
            // lblLastNameT
            // 
            this.lblLastNameT.AutoSize = true;
            this.lblLastNameT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastNameT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLastNameT.Location = new System.Drawing.Point(72, 200);
            this.lblLastNameT.Name = "lblLastNameT";
            this.lblLastNameT.Size = new System.Drawing.Size(81, 21);
            this.lblLastNameT.TabIndex = 4;
            this.lblLastNameT.Text = "Last name";
            // 
            // lblZipCodeT
            // 
            this.lblZipCodeT.AutoSize = true;
            this.lblZipCodeT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblZipCodeT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblZipCodeT.Location = new System.Drawing.Point(72, 250);
            this.lblZipCodeT.Name = "lblZipCodeT";
            this.lblZipCodeT.Size = new System.Drawing.Size(69, 21);
            this.lblZipCodeT.TabIndex = 5;
            this.lblZipCodeT.Text = "Zip code";
            // 
            // lblStreetT
            // 
            this.lblStreetT.AutoSize = true;
            this.lblStreetT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStreetT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStreetT.Location = new System.Drawing.Point(72, 300);
            this.lblStreetT.Name = "lblStreetT";
            this.lblStreetT.Size = new System.Drawing.Size(50, 21);
            this.lblStreetT.TabIndex = 6;
            this.lblStreetT.Text = "Street";
            // 
            // lblCityT
            // 
            this.lblCityT.AutoSize = true;
            this.lblCityT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCityT.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCityT.Location = new System.Drawing.Point(72, 350);
            this.lblCityT.Name = "lblCityT";
            this.lblCityT.Size = new System.Drawing.Size(37, 21);
            this.lblCityT.TabIndex = 7;
            this.lblCityT.Text = "City";
            // 
            // txtNameOverride
            // 
            this.txtNameOverride.Location = new System.Drawing.Point(214, 98);
            this.txtNameOverride.Name = "txtNameOverride";
            this.txtNameOverride.Size = new System.Drawing.Size(158, 23);
            this.txtNameOverride.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(214, 152);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(158, 23);
            this.txtFirstName.TabIndex = 9;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(214, 202);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(158, 23);
            this.txtLastName.TabIndex = 10;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(214, 252);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(94, 23);
            this.txtZipCode.TabIndex = 11;
            this.txtZipCode.TextChanged += new System.EventHandler(this.txtZipCode_TextChanged);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(214, 300);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(158, 23);
            this.txtStreet.TabIndex = 12;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(214, 352);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(158, 23);
            this.txtCity.TabIndex = 13;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            this.txtCity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCity_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(214, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(400, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmFamily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtNameOverride);
            this.Controls.Add(this.lblCityT);
            this.Controls.Add(this.lblStreetT);
            this.Controls.Add(this.lblZipCodeT);
            this.Controls.Add(this.lblLastNameT);
            this.Controls.Add(this.lblFirstNameT);
            this.Controls.Add(this.lblNameOverrideT);
            this.Controls.Add(this.lblTitleT);
            this.Controls.Add(this.cmbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFamily";
            this.Text = "frmFamily";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.Label lblTitleT;
        private System.Windows.Forms.Label lblNameOverrideT;
        private System.Windows.Forms.Label lblFirstNameT;
        private System.Windows.Forms.Label lblLastNameT;
        private System.Windows.Forms.Label lblZipCodeT;
        private System.Windows.Forms.Label lblStreetT;
        private System.Windows.Forms.Label lblCityT;
        private System.Windows.Forms.TextBox txtNameOverride;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}