using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Core;
using Services.UI;

namespace Services.DI
{
    public class ServicesInstaller : IWindsorInstaller
    {
        private readonly Settings settings;

        public ServicesInstaller(Settings settings)
        {
            this.settings = settings;
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<Settings>().Instance(settings));

            container.Register(Component.For<FamilyService>().LifestyleTransient());
            container.Register(Component.For<FamilyOverviewService>().LifestyleTransient());
            container.Register(Component.For<PrintListOverviewService>().LifestyleTransient());
            container.Register(Component.For<PrintListService>().LifestyleTransient());
        }

    }
}