using System;
using System.Windows.Forms;
using Dashboard.Helpers;
using Messages.UI.Overview;
using Services.UI;

namespace Dashboard
{
    public partial class frmPrintListsOverview : Form
    {
        private readonly frmMain frmMain;
        private readonly PrintListOverviewService printListsOverviewService;

        public frmPrintListsOverview(frmMain frmMain, PrintListOverviewService printListsOverviewService)
        {
            this.frmMain = frmMain;
            this.printListsOverviewService = printListsOverviewService;
            InitializeComponent();
        }

        private void frmPrintListsOverview_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            var famList = printListsOverviewService.GetLists();
            dgvPrintLists.DataSource = famList;

            // column configuration
            dgvPrintLists.ApplyColumnDisplayFormatAttributes();
            dgvPrintLists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            var nameColumn = dgvPrintLists.GetColumn(nameof(PrintListViewModel.Name));
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvPrintLists.SetReadOnly();
            dgvPrintLists.SetVisualStyling();
        }

        private void dgvPrintLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var nameColumn = dgvPrintLists.GetColumn(nameof(PrintListViewModel.Name));
            var name = dgvPrintLists[nameColumn.Index, e.RowIndex].Value.ToString();

            Close();

            frmMain.ShowPrintList(name);
        }

        private void dgvPrintLists_SelectionChanged(object sender, EventArgs e) => dgvPrintLists.ClearSelection();
    }
}
