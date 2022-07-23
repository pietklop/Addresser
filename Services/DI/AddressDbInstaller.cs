using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Core;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace Services.DI
{
    public class AddressDbInstaller : IWindsorInstaller
    {
        private readonly Settings settings;

        public AddressDbInstaller(Settings settings)
        {
            this.settings = settings;
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<AddressDbContext>()
                //.LifestyleTransient()
                .ImplementedBy<AddressDbContext>()
                .UsingFactoryMethod(() =>
                    new AddressDbContext(new DbContextOptionsBuilder<AddressDbContext>().UseSqlite(AddressDbContext.Connection(settings.DbFileNamePath)).Options)));
        }
    }
}