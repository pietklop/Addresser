using System.Collections.Generic;
using System.Windows.Forms;
using Castle.Core.Internal;
using Messages.UI.Dto;
using Services;
using Services.UI;

namespace Dashboard
{
    public partial class frmPrintList : Form
    {
        private readonly FamilyService familyService;
        private readonly PrintListService printListService;

        public frmPrintList(FamilyService familyService, PrintListService printListService)
        {
            this.familyService = familyService;
            this.printListService = printListService;
            InitializeComponent();

            PopulateLstSource("");
        }

        private void PopulateLstSource(string filter)
        {
            var fams = familyService.GetList(filter);
            lstSource.DataSource = fams;
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

            ValidateInput();

            void AddUniqueItemToLstDest(FamilyDto toAdd)
            {
                foreach (var dstItem in lstDestination.Items)
                    if (dstItem.ToString() == toAdd.ToString()) return;

                lstDestination.Items.Add(toAdd);
            }
        }

        private void btnDelFromDest_Click(object sender, System.EventArgs e)
        {
            var toRemove = new List<FamilyDto>();
            foreach (var item in lstDestination.SelectedItems)
                toRemove.Add((FamilyDto)item);

            toRemove.ForEach(lstDestination.Items.Remove);

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
        }
    }
}
