using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Castle.MicroKernel;
using Core;
using log4net;
using Services.DI;

namespace Dashboard
{
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        private readonly ILog log;
        private readonly Settings settings;
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public frmMain(ILog log, Settings settings)
        {
            this.log = log;
            this.settings = settings;
            InitializeComponent();
            SetWindowRoundCorners(25);
            LoadForm(btnMainOverview.Text, CastleContainer.Instance.Resolve<frmOverview>(new Arguments { { nameof(frmMain), this } }));

            void SetWindowRoundCorners(int radius) => Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius, radius));

            var version = Assembly.GetExecutingAssembly().GetName().Version;
            lblVersion.Text = $"v{version.Major}.{version.Minor}.{version.Build}";
        }

        public void ShowFamilyOverview() => btnMainOverview_Click(btnMainOverview, EventArgs.Empty);
        public void ShowPrintListOverview() => btnPrintListsOverview_Click(btnPrintListsOverview, EventArgs.Empty);
        public void ShowFamilyDetails(string firstName, string lastName) => LoadForm(lastName, CastleContainer.Instance.Resolve<frmFamily>(new Arguments {{"frmMain", this}, { "firstName", firstName }, {"lastName", lastName} }));
        public void ShowPrintList(string name) => LoadForm(name, CastleContainer.Instance.Resolve<frmPrintList>(new Arguments {{"frmMain", this}, { "name", name }}));

        private void btnMainOverview_Click(object sender, EventArgs e) => LoadForm(((Button)sender).Text, CastleContainer.Resolve<frmOverview>());
        private void btnNewFamily_Click(object sender, EventArgs e) => LoadForm(((Button)sender).Text, CastleContainer.Resolve<frmFamily>());
        private void btnPrintListsOverview_Click(object sender, EventArgs e) => LoadForm(((Button)sender).Text, CastleContainer.Resolve<frmPrintListsOverview>());
        private void btnNewPrintList_Click(object sender, EventArgs e) => LoadForm(((Button)sender).Text, CastleContainer.Resolve<frmPrintList>());

        private void btnMainOverview_Leave(object sender, EventArgs e) => SetDefaultButtonBackColor((Button)sender);
        private void btnTransactions_Leave(object sender, EventArgs e) => SetDefaultButtonBackColor((Button)sender);
        private void btnDividends_Leave(object sender, EventArgs e) => SetDefaultButtonBackColor((Button)sender);

        private void LoadForm(string viewName, Form form)
        {
            lblViewName.Text = viewName;
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            foreach (Control control in pnlFormLoader.Controls)
            {
                var frm = control as Form;
                frm?.Close();
                frm?.Dispose();
            }
            pnlFormLoader.Controls.Clear();
            pnlFormLoader.Controls.Add(form);
            form.Show();
        }

        private void SetDefaultButtonBackColor(Button button) => button.BackColor = Color.FromArgb(24, 30, 54);
    }
}
