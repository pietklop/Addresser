using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public static class AddressDbContextHelper
    {
        public static AddressDbContext CreateDbContext()
        {
            var settings = SettingsHelper.GetSettings();
            return new AddressDbContext(Options());

            DbContextOptions<AddressDbContext> Options() => new DbContextOptionsBuilder<AddressDbContext>()
                .EnableSensitiveDataLogging()
                .UseSqlite(AddressDbContext.Connection(settings.DbFileNamePath)).Options;
        }

    }
}