using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Dashboard.DI
{
    public class FormInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<frmMain>().LifestyleSingleton());

            container.Register(Component.For<frmFamily>().LifestyleTransient());
            container.Register(Component.For<frmOverview>().LifestyleTransient());
            container.Register(Component.For<frmPrintList>().LifestyleTransient());
            container.Register(Component.For<frmPrintListsOverview>().LifestyleTransient());
            container.Register(Component.For<frmStickerConfig>().LifestyleTransient());
            container.Register(Component.For<frmStickerConfigOverview>().LifestyleTransient());
        }
    }
}