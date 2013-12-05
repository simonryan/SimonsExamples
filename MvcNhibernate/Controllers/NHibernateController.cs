using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using Environment = System.Environment;

namespace MvcNhibernate.Controllers
{
    public class NHibernateController : Controller
    {
        /*	 Session Factory
		 *	 - Manage the life time of connection to db
		 *	 - Connection String
		 *	 - Mapping - what tables to what objects?
		 *	 - What db are we working on (sql, oracle, mysql)
		 *	 - End point for creating sessions
		 *	 - Singleton!
		 *	 - Expensive to create
		 *	 - Thread safe
		 *	 - Exception safe
		 *	
		 *	 Session 
		 *	 - Similar to a db connection
		 *	 - Limited life scope
		 *	 - Single threaded
		 *	 - NOT exception safe
		 *	 - Cheap to create
		 *	 - Unit of Work
		 */

        private Lazy<ISessionFactory> sessionFactory = new Lazy<ISessionFactory>(
            CreateSessionFactory
            );

        private static ISessionFactory CreateSessionFactory()
        {
            Configuration cfg = new Configuration()
                .DataBaseIntegration(db =>
                {
                    db.Dialect<MsSql2008Dialect>();
                    db.ConnectionStringName = Environment.MachineName;
                    db.SchemaAction = SchemaAutoAction.Update;
                    db.BatchSize = 250;
                })
                .AddAssembly("MvcNhibernate"); // loads all .hbm.xml mapping files

            return cfg.BuildSessionFactory();
        }

        private ISession session;
        private ITransaction tx;

        public ISessionFactory SessionFactory
        {
            get { return sessionFactory.Value; }
        }

        public new ISession Session
        {
            get
            {
                if (session == null)
                {
                    session = SessionFactory.OpenSession();
                    tx = session.BeginTransaction();
                }
                return session;
            }
        }

        protected bool DoNotCommit { get; set; }

        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding,
                                           JsonRequestBehavior behavior)
        {
            return base.Json(data, contentType, contentEncoding, JsonRequestBehavior.AllowGet);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            using (session)
            using (tx)
            {
                if (filterContext.Exception != null)
                    return;

                if (DoNotCommit)
                    return;
                if (tx != null)
                    tx.Commit();
            }
        }
    }
}
