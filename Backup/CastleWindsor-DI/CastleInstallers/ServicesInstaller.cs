using System.Configuration;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CastleWindsor_DI.Services;

namespace CastleWindsor_DI.CastleInstallers
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public string Username {
            get { return ConfigurationManager.AppSettings["Username"]; } 
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IEmployeeService>()
                    .ImplementedBy<EmployeeService>()
                    .LifestyleTransient()
                    .Named("EmployeeService")
                    .DependsOn(Property.ForKey("Username").Eq(Username))
                    .DependsOn(Property.ForKey("password").Eq("password99"))
                    );
        }
    }
}