using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dashboard.Input
{
    public partial class frmInput : Form
    {
        private readonly InputType inputType;
        public string Input { get; private set; } = null;
        /// <summary>
        /// This list can be used to allow special inputs and skip validation
        /// </summary>
        public List<string> AllowedSpecialValues = new List<string>();

        public frmInput(string caption, InputType inputType, string defaultValue = null)
        {
            InitializeComponent();
            lblInputT.Text = caption;
            this.inputType = inputType;
            if (inputType == InputType.Confirmation)
            {
                txtInput.Visible = false;
                lblInputT.MaximumSize = new Size(txtInput.Width, 150);
            }
            else if (defaultValue != null)
            {
                txtInput.Text = defaultValue;
                txtInput.SelectionStart = 0;
                txtInput.SelectionLength = defaultValue.Length;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!AllowedSpecialValues.Contains(txtInput.Text))
            {
                switch (inputType)
                {
                    case InputType.Confirmation:
                        break;
                    case InputType.String:
                        if (string.IsNullOrEmpty(txtInput.Text))
                        {
                            Invalid();
                            return;
                        }
                        break;
                    case InputType.PositiveDouble:
                        txtInput.Text = txtInput.Text.Replace(",", ".");
                        if (!double.TryParse(txtInput.Text, out double value) || value < 0)
                        {
                            Invalid();
                            return;
                        }
                        break;
                    case InputType.Time:
                        txtInput.Text = txtInput.Text.Replace(",", ".");
                        txtInput.Text = txtInput.Text.Replace(":", ".");
                        // convert separator to '.' to support validation hack
                        if (!double.TryParse(txtInput.Text, out double _))
                        {
                            Invalid();
                            return;
                        }
                        txtInput.Text = txtInput.Text.Replace(".", ":"); // back to ':' separator
                        break;
                    default:
                        throw new ArgumentOutOfRangeException($"Unsupported inputType {inputType}");
                }

            }
            Input = txtInput.Text;

            DialogResult = DialogResult.OK;
            Close();

            void Invalid()
            {
                txtInput.Text = "Invalid";
                txtInput.SelectionStart = 0;
                txtInput.SelectionLength = txtInput.TextLength;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnOk_Click(this, EventArgs.Empty);
        }

        private void frmInput_FormClosed(object sender, FormClosedEventArgs e) => Owner?.Focus();
        private void frmInput_FormClosing(object sender, FormClosingEventArgs e) => Owner?.Focus();
    }
}
