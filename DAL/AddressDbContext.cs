using DAL.Entities;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    // Add-Migration Migration_Name -p DAL -s TestConsole
    // update-database -p DAL -s TestConsole
    public class AddressDbContext : DbContext
    {
        public DbSet<Family> Families { get; set; }
        public DbSet<PrintList> PrintLists { get; set; }
        public DbSet<StickerConfig> StickerConfigs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FamilyPrintListRelation>().HasKey(r => new { r.FamilyId, r.PrintListId });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var settings = SettingsHelper.GetSettings();
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = settings.DbFileNamePath };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);

            optionsBuilder.UseSqlite(connection);
        }
    }
}