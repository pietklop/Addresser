using System;
using System.Windows.Forms;
using Castle.Core.Internal;
using Core;
using Messages.UI.Dto;
using Services;

namespace Dashboard
{
    public partial class frmFamily : Form
    {
        private FamilyDto famDto;
        private readonly frmMain frmMain;
        private readonly FamilyService familyService;

        public frmFamily(frmMain frmMain, FamilyService familyService, string firstName = null, string lastName = null)
        {
            this.frmMain = frmMain;
            this.familyService = familyService;
            InitializeComponent();
            cmbTitle.DataSource = Enum.GetValues(typeof(Title));
            cmbTitle.SelectedIndex = 0;

            if (!lastName.IsNullOrEmpty()) UpdateControls(firstName, lastName);
        }

        private void UpdateControls(string firstName, string lastName)
        {
            famDto = familyService.GetBy(firstName, lastName);

            cmbTitle.SelectedIndex = (int)famDto.Title;
            txtNameOverride.Text = famDto.NameOverride;
            txtFirstName.Text = famDto.FirstName;
            txtLastName.Text = famDto.LastName;
            txtZipCode.Text = famDto.ZipCode;
            txtStreet.Text = famDto.Street;
            txtCity.Text = famDto.City;

            btnDelete.Visible = true;
        }

        private void ValidateInput()
        {
            btnSave.Visible = false;

            if (txtLastName.Text == "") return;
            if (txtZipCode.Text == "") return;
            if (txtStreet.Text == "") return;
            if (txtCity.Text == "") return;

            btnSave.Visible = true;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e) => ValidateInput();

        private void txtZipCode_TextChanged(object sender, EventArgs e) => ValidateInput();

        private void txtStreet_TextChanged(object sender, EventArgs e) => ValidateInput();

        private void txtCity_TextChanged(object sender, EventArgs e) => ValidateInput();

        private void btnSave_Click(object sender, EventArgs e)
        {
            famDto ??= new FamilyDto();
            famDto.Title =(Title)cmbTitle.SelectedIndex;
            famDto.NameOverride = txtNameOverride.Text;
            famDto.FirstName = txtFirstName.Text;
            famDto.LastName = txtLastName.Text;
            famDto.ZipCode = txtZipCode.Text;
            famDto.Street = txtStreet.Text;
            famDto.City = txtCity.Text;

            familyService.Save(famDto);

            Close();
            frmMain.ShowOverview();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (famDto?.Id <= 0) return;
            familyService.Delete(famDto);

            Close();
            frmMain.ShowOverview();
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            btnSave_Click(this, EventArgs.Empty);
        }
    }
}
