using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Castle.Core.Internal;
using Messages.UI.Dto;
using Services;

namespace Dashboard
{
    public partial class frmPrintList : Form
    {
        private readonly frmMain frmMain;
        private readonly FamilyService familyService;
        private readonly PrintListService printListService;
        private readonly PrintService printService;
        private readonly StickerConfigService stickerConfigService;
        private HashSet<string> dstNames = new HashSet<string>();

        public frmPrintList(frmMain frmMain, FamilyService familyService, PrintListService printListService, PrintService printService, StickerConfigService stickerConfigService, string name = null)
        {
            this.frmMain = frmMain;
            this.familyService = familyService;
            this.printListService = printListService;
            this.printService = printService;
            this.stickerConfigService = stickerConfigService;
            InitializeComponent();

            if (!name.IsNullOrEmpty()) UpdateControls(name);
            PopulateLstSource("");
        }

        private void UpdateControls(string name)
        {
            txtName.Text = name;
            var dstList = printListService.GetBy(name);

            foreach (var item in dstList.Families)
                AddDestinationItem(item);
        }

        private void AddDestinationItem(FamilyDto dto)
        {
            lstDestination.Items.Add(dto);
            dstNames.Add(dto.ToString());
        }

        private void RemoveDestinationItem(FamilyDto dto)
        {
            lstDestination.Items.Remove(dto);
            dstNames.Remove(dto.ToString());
        }

        private void PopulateLstSource(string filter)
        {
            var fams = familyService.GetList(filter);

            lstSource.DataSource = fams.Where(f => !dstNames.Contains(f.ToString())).ToList();
        }

        private void txtFilter_TextChanged(object sender, System.EventArgs e)
        {
            if (txtFilter.TextLength == 1) return;

            PopulateLstSource(txtFilter.Text);
        }

        private void btnSrcToDest_Click(object sender, System.EventArgs e)
        {
            foreach (var item in lstSource.SelectedItems)
                AddUniqueItemToLstDest((FamilyDto)item);

            PopulateLstSource("");

            ValidateInput();

            void AddUniqueItemToLstDest(FamilyDto toAdd)
            {
                foreach (var dstItem in lstDestination.Items)
                    if (dstItem.ToString() == toAdd.ToString()) return;

                AddDestinationItem(toAdd);
            }
        }

        private void btnDelFromDest_Click(object sender, System.EventArgs e)
        {
            var toRemove = new List<FamilyDto>();
            foreach (var item in lstDestination.SelectedItems)
                toRemove.Add((FamilyDto)item);

            foreach (var dto in toRemove)
                RemoveDestinationItem(dto);

            PopulateLstSource("");

            ValidateInput();
        }

        private void txtName_TextChanged(object sender, System.EventArgs e) => ValidateInput();

        private void ValidateInput()
        {
            btnSave.Visible = false;

            if (txtName.Text.IsNullOrEmpty()) return;
            if (lstDestination.Items.Count == 0) return;

            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var printList = new PrintListDto
            {
                Name = txtName.Text,
                Families = new List<FamilyDto>(lstDestination.Items.Count),
            };

            foreach (var item in lstDestination.Items)
                printList.Families.Add((FamilyDto)item);

            printListService.Save(printList);

            Close();
            frmMain.ShowPrintListOverview();
        }

        private void txtFilter_MouseClick(object sender, MouseEventArgs e) => SelectTxtFilterContent();

        private void txtFilter_Enter(object sender, System.EventArgs e)
        {
            if (txtFilter.TextLength <= 0) return;
            txtFilter.ForeColor = DefaultForeColor;
            SelectTxtFilterContent();
        }

        private void SelectTxtFilterContent()
        {
            txtFilter.SelectionStart = 0;
            txtFilter.SelectionLength = txtFilter.TextLength;
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            printListService.Delete(txtName.Text);

            Close();
            frmMain.ShowPrintListOverview();
        }

        private void btnPrintPreview_Click(object sender, System.EventArgs e)
        {
            var list = new List<FamilyDto>();
            foreach (var item in lstDestination.Items)
                list.Add((FamilyDto)item);

            int.TryParse(txtStickersToSkip.Text, out int nStickersToSkip);
            printService.PrintPreview(list, stickerConfigService.GetDefault(), nStickersToSkip);
        }

        private void lstSource_DoubleClick(object sender, System.EventArgs e)
        {
            bool allSelected = lstSource.SelectedItems.Count == lstSource.Items.Count;

            for (int i = 0; i < lstSource.Items.Count; i++)
                lstSource.SetSelected(i, !allSelected);
        }

        private void lstDestination_DoubleClick(object sender, System.EventArgs e)
        {
            bool allSelected = lstDestination.SelectedItems.Count == lstDestination.Items.Count;

            for (int i = 0; i < lstDestination.Items.Count; i++)
                lstDestination.SetSelected(i, !allSelected);
        }
    }
}
