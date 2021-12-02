using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Core;
using DAL;
using DAL.Entities;
using log4net;
using log4net.Config;
using Microsoft.EntityFrameworkCore;
using TestConsole.Infrastructure;

namespace TestConsole
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static async Task Main(string[] args)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            XmlConfigurator.Configure(new FileInfo(@"log4net.config"));
            log.Info("Start");

            var menu = new Menu();

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            menu.Add("Migrate", "Migrate", Migrate);
            menu.Add("Setup", "Setup", Setup);
            menu.Add("Exit", "Exit", () => cancellationTokenSource.Cancel());

            while (!cancellationTokenSource.Token.IsCancellationRequested)
                await menu.RunAsync();
        }

        public static void Migrate()
        {
            using (var db = new AddressDbContext())
            {
                log.Info($"Migrate...");
                db.Database.Migrate();

                db.SaveChanges();
            }
        }

        public static void Setup()
        {
            using (var db = new AddressDbContext())
            {
                log.Info($"Migrate and setup");
                db.Database.Migrate();

                db.Families.Add(new Family
                {
                    Title = Title.FirstName,
                    NameOverride = null,
                    FirstName = "Piet",
                    LastName = "Klop",
                    Street = "Valeriusrondeel 153",
                    ZipCode = "2902 CD",
                    City = "Capelle a/d IJssel",
                });

                db.StickerConfigs.Add(new StickerConfig
                {
                    Name = "Sticker 8x3",
                    RowCount = 8,
                    ColumnCount = 3,
                    RowOffset = 40,
                    ColumnOffset = 25,
                    RowPitch = 105,
                    ColumnPitch = 190,
                    FontSize = 12,
                    IsDefault = true,
                });

                db.SaveChanges();
            }

        }

    }
}



