using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using WCF_firstService;

namespace WindowsServiceHost
{
    public partial class EmployeeServiceWindowsHost : ServiceBase
    {
        ServiceHost host = new ServiceHost(typeof(EmployeeService));
        public EmployeeServiceWindowsHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
