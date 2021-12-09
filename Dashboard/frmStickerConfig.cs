using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Castle.Core.Internal;
using Core;
using Messages.UI.Dto;
using Services;

namespace Dashboard
{
    public partial class frmStickerConfig : Form
    {
        private readonly frmMain frmMain;
        private readonly StickerConfigService stickerConfigService;
        private readonly PrintService printService;

        public frmStickerConfig(frmMain frmMain, StickerConfigService stickerConfigService, PrintService printService, string name = null)
        {
            this.frmMain = frmMain;
            this.stickerConfigService = stickerConfigService;
            this.printService = printService;
            InitializeComponent();

            if (!name.IsNullOrEmpty()) UpdateControls(name);
        }

        private void UpdateControls(string name)
        {
            btnDelete.Visible = true;

            var dto = stickerConfigService.GetBy(name);

            txtName.Text = dto.Name;
            chkIsDefault.Checked = dto.IsDefault;
            txtRowCount.Text = dto.RowCount.ToString();
            txtColCount.Text = dto.ColumnCount.ToString();
            txtRowOffset.Text = dto.RowOffset.ToString();
            txtColOffset.Text = dto.ColumnOffset.ToString();
            txtRowPitch.Text = dto.RowPitch.ToString();
            txtColPitch.Text = dto.ColumnPitch.ToString();
            numFontSize.Value = dto.FontSize;
        }

        private void ValidateInput()
        {
            btnSave.Visible = false;

            if (txtName.Text.IsNullOrEmpty()) return;

            if (!ValidNumInput(txtRowCount.Text)) return;
            if (!ValidNumInput(txtColCount.Text)) return;
            if (!ValidNumInput(txtRowOffset.Text)) return;
            if (!ValidNumInput(txtColOffset.Text)) return;
            if (!ValidNumInput(txtRowPitch.Text)) return;
            if (!ValidNumInput(txtColPitch.Text)) return;

            btnSave.Visible = true;
        }

        private bool ValidNumInput(string text)
        {
            if (text.IsNullOrEmpty()) return false;
            if (!int.TryParse(text, out int value)) return false;
            if (value <= 0) return false;

            return true;
        }

        private void txtName_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void txtRowCount_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void txtColCount_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void txtRowOffset_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void txtColOffset_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void txtRowPitch_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void txtColPitch_TextChanged(object sender, EventArgs e) => ValidateInput();
        private void numFontSize_ValueChanged(object sender, EventArgs e) => ValidateInput();

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dto = ControlInputToDto();

            stickerConfigService.Save(dto);

            Close();
            frmMain.ShowStickerConfigOverview();
        }

        private StickerConfigDto ControlInputToDto()
        {
            var dto = new StickerConfigDto();
            dto.Name = txtName.Text;
            dto.IsDefault = chkIsDefault.Checked;
            dto.RowCount = int.Parse(txtRowCount.Text);
            dto.ColumnCount = int.Parse(txtColCount.Text);
            dto.RowOffset = int.Parse(txtRowOffset.Text);
            dto.ColumnOffset = int.Parse(txtColOffset.Text);
            dto.RowPitch = int.Parse(txtRowPitch.Text);
            dto.ColumnPitch = int.Parse(txtColPitch.Text);
            dto.FontSize = (int)numFontSize.Value;
            return dto;
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            var stickerConfig = ControlInputToDto();

            var list = new List<FamilyDto>();
            for (int i = 0; i < stickerConfig.ColumnCount * stickerConfig.RowCount; i++)
            {
                list.Add(new FamilyDto
                {
                    Title = Title.Fam,
                    LastName = "Jansen",
                    Street = $"Willem van Oranjeplein {i+101}",
                    ZipCode = "1234 AA Capelle aan den IJssel",
                });
            }

            printService.PrintStickersPreview(list, stickerConfig);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtName.Text.IsNullOrEmpty()) return;
            stickerConfigService.Delete(txtName.Text);

            Close();
            frmMain.ShowStickerConfigOverview();
        }
    }
}
