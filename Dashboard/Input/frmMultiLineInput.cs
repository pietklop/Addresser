using System;
using System.Windows.Forms;

namespace Dashboard.Input
{
    public partial class frmMultiLineInput : Form
    {
        public string Input { get; private set; } = null;

        public frmMultiLineInput(string caption, string defaultValue)
        {
            InitializeComponent();
            lblInputT.Text = caption;
            txtInput.Text = defaultValue;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Input = txtInput.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmMultiLineInput_FormClosed(object sender, FormClosedEventArgs e) => Owner?.Focus();
        private void frmMultiLineInput_FormClosing(object sender, FormClosingEventArgs e) => Owner?.Focus();
    }
}
