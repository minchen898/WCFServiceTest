using CreateFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;

namespace CreateFileService
{
    public partial class testCreateFile : ServiceBase, IRemoteCreate
    {
        internal static ServiceHost serviceHost = null;
        private Create create;

        public testCreateFile()
        {
            InitializeComponent();
            create = new Create();
            create.FileName += "Initial";
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }
            serviceHost = new ServiceHost(typeof(testCreateFile));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }

        public void DoWork()
        {
            create.DoIt();
        }


        public void ChangeFileName(string fileName)
        {
            create.FileName = fileName;
        }


        public string GetFileName()
        {
            return create.FileName;
        }
    }
}
