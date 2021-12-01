using System;
using System.Windows.Forms;
using Dashboard.Helpers;
using Messages.UI.Overview;
using Services.UI;

namespace Dashboard
{
    public partial class frmOverview : Form
    {
        private readonly frmMain frmMain;
        private readonly FamilyOverviewService familyOverviewService;

        public frmOverview(frmMain frmMain, FamilyOverviewService familyOverviewService)
        {
            this.frmMain = frmMain;
            this.familyOverviewService = familyOverviewService;
            InitializeComponent();
        }

        private void frmOverview_Load(object sender, EventArgs e)
        {
            PopulateGrid(txtFilter.Text);
        }

        private void PopulateGrid(string searchFilter)
        {
            var famList = familyOverviewService.GetFamilies(searchFilter);
            dgvFamList.DataSource = famList;

            // column configuration
            dgvFamList.ApplyColumnDisplayFormatAttributes();
            dgvFamList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            var nameColumn = dgvFamList.GetColumn(nameof(FamilyViewModel.LastName));
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvFamList.SetReadOnly();
            dgvFamList.SetVisualStyling();
        }

        private void dgvFamList_SelectionChanged(object sender, EventArgs e) => dgvFamList.ClearSelection();

        private void dgvFamList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var lastNameColumn = dgvFamList.GetColumn(nameof(FamilyViewModel.LastName));
            var lastName = dgvFamList[lastNameColumn.Index, e.RowIndex].Value.ToString();
            var firstNameColumn = dgvFamList.GetColumn(nameof(FamilyViewModel.FirstName));
            var firstName = dgvFamList[firstNameColumn.Index, e.RowIndex].Value.ToString();

            Close();

            frmMain.ShowFamilyDetails(firstName, lastName);
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.TextLength == 1) return;

            PopulateGrid(txtFilter.Text);
        }
    }
}
