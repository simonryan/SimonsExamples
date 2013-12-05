using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CastleWindsor_demo.Services;

namespace CastleWindsor_demo.Installers
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IEmployeeService>()
                                   .ImplementedBy<EmployeeService>()
                                   .DependsOn(Property.ForKey("username").Eq("ryansi")));
        }
    }
}