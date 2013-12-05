using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;

namespace ConfigByAppConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            var nhconfig = new Configuration().Configure();
            var sessionFactory = nhconfig.BuildSessionFactory();
            Console.WriteLine("NHibernate Configured");
            Console.ReadKey();
        }
    }
}
