using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CreateFile
{
    public class Create
    {
        public string FileName { get; set; }

        public Create()
        {
            FileName = "C:\\" + DateTime.Now.ToString("MMddHHmmss");
        }

        public void DoIt()
        {
            File.Create(FileName);
        }
    }
}
