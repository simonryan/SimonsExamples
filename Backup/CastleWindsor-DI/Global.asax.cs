using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using Castle.Windsor.Installer;
using CastleWindsor_DI.Castle;
using CastleWindsor_DI.CastleInstallers;

namespace CastleWindsor_DI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
        }

        static IWindsorContainer _container;

        public static IWindsorContainer Container
        {
            get { return _container; }
        }
        
        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);

            _container = new WindsorContainer()
                .Install(new ControllersInstaller())
                .Install(new ServicesInstaller());
                //.Install(FromAssembly.This());
            
            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        protected void Application_End()
        {
            _container.Dispose();
        }
    }
}