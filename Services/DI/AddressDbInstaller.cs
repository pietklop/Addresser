﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using DAL;

namespace Services.DI
{
    public class AddressDbInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<AddressDbContext>()
                //.LifestyleTransient()
                .ImplementedBy<AddressDbContext>()
                .UsingFactoryMethod(() =>
                    new AddressDbContext()));
        }
    }
}