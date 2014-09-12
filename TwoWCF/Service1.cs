using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;

namespace TwoWCF
{
    public partial class Service1 : ServiceBase
    {
        internal static ServiceHost serviceHostA = null;
        internal static ServiceHost serviceHostB = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHostA != null)
            {
                serviceHostA.Close();
            }
            serviceHostA = new ServiceHost(typeof(ServiceA));
            serviceHostA.Open();

            if (serviceHostB != null)
            {
                serviceHostB.Close();
            }
            serviceHostB = new ServiceHost(typeof(ServiceB));
            serviceHostB.Open();
        }

        protected override void OnStop()
        {
            if (serviceHostA != null)
            {
                serviceHostA.Close();
                serviceHostA = null;
            }

            if (serviceHostB != null)
            {
                serviceHostB.Close();
                serviceHostB = null;
            }
        }
    }
}
