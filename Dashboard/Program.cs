using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using DAL;
using Dashboard.DI;
using log4net;
using log4net.Config;
using Microsoft.EntityFrameworkCore;
using Services.DI;

namespace Dashboard
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            XmlConfigurator.Configure(new FileInfo(@"log4net.config"));
            log.Info($"Start program");

            try
            {
                using (var db = AddressDbContextHelper.CreateDbContext())
                {
                    log.Info($"Migrate when necessary");
                    db.Database.Migrate();
                    db.SaveChanges();
                }

                var container = CastleContainer.Instance;
                var installer = DependencyInstaller.CreateInstaller(new FormInstaller());
                container.AddFacilities().Install(installer);

                var mainForm = CastleContainer.Resolve<frmMain>();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                log.Error($"Exception occurred during program start", ex);
            }
        }
    }
}