using System;
using System.Windows.Forms;
using Dashboard.Helpers;
using Messages.UI.Overview;
using Services.UI;

namespace Dashboard
{
    public partial class frmStickerConfigOverview : Form
    {
        private readonly frmMain frmMain;
        private readonly StickerConfigOverviewService stickerConfigOverviewService;

        public frmStickerConfigOverview(frmMain frmMain, StickerConfigOverviewService stickerConfigOverviewService)
        {
            this.frmMain = frmMain;
            this.stickerConfigOverviewService = stickerConfigOverviewService;
            InitializeComponent();
        }

        private void frmStickerConfigOverview_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            var famList = stickerConfigOverviewService.GetConfigs();
            dgvStickerConfigs.DataSource = famList;

            // column configuration
            dgvStickerConfigs.ApplyColumnDisplayFormatAttributes();
            dgvStickerConfigs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            var nameColumn = dgvStickerConfigs.GetColumn(nameof(StickerConfigViewModel.Name));
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvStickerConfigs.SetReadOnly();
            dgvStickerConfigs.SetVisualStyling();
        }

        private void dgvFamList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var nameColumn = dgvStickerConfigs.GetColumn(nameof(StickerConfigViewModel.Name));
            var name = dgvStickerConfigs[nameColumn.Index, e.RowIndex].Value.ToString();

            Close();

            frmMain.ShowStickerConfigDetails(name);
        }

        private void dgvFamList_SelectionChanged(object sender, EventArgs e) => dgvStickerConfigs.ClearSelection();
    }
}
