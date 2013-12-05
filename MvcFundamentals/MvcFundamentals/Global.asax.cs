using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcFundamentals
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    /// <summary>
    /// Routes explained
    /// -----------------
    /// Routehandler follows these steps...
    /// 
    /// 1. check if static route and serve up file on disk
    /// 2. check if there is a custom route handler, if so hand of request to handler
    /// 3. request goes to default route handler
    /// </summary>

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            // http://localhost/Movie/Released/1-12-2010
            // mvc will attempt to convert this to datetime, if that is the actions input parameter type
            routes.MapRoute(
                "Released",
                "Movie/Released/{releaseDate}",
                new {Controller = "Movie", Action = "GetByReleaseDate", releaseDate = UrlParameter.Optional}
                );

            // http://localhost/Movie/Genre/Thriller
            routes.MapRoute(
                "Genre",
                "Movie/Genre/{genre}",
                new {Controller = "Movie", action = "GetByGenre", genre = UrlParameter.Optional}
                );
            
            // e.g http://localhost/Process
            routes.MapRoute(
                "Process", // Route name
                "Process/{action}/{id}", // URL with parameters
                new { controller = "Process", action = "List", id = UrlParameter.Optional } // Parameter defaults
            );

            // catch all route
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default
            Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}