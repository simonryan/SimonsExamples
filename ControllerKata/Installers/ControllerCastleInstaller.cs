using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using ControllerKata.Repository;

namespace ControllerKata.Castle
{
    public class ControllerCastleInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ICustomerRepository>()
                                        .ImplementedBy<CustomerRepository>());
        }
    }
}