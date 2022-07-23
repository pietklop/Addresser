using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard.Input
{
    public partial class frmListInput : Form
    {
        public int MemberIndex { get; private set; } = -1;
        public Font CmbListFont => cmbMember.Font;
        public int CmbWidth => cmbMember.Right;

        public frmListInput(string caption, List<string> listMembers, int? defaultIndex = null)
        {
            InitializeComponent();
            lblInputT.Text = caption;
            cmbMember.DataSource = listMembers;
            cmbMember.SelectedIndex = defaultIndex ?? -1;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cmbMember.SelectedIndex < 0) return;

            MemberIndex = cmbMember.SelectedIndex;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmListInput_FormClosed(object sender, FormClosedEventArgs e) => Owner?.Focus();
        private void frmListInput_FormClosing(object sender, FormClosingEventArgs e) => Owner?.Focus();
    }
}
