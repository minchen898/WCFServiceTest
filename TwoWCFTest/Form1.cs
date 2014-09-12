using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TwoWCFTest.ServiceA;
using TwoWCFTest.ServiceB;

namespace TwoWCFTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceAClient client = new ServiceAClient();
            textBox1.Text = client.DoWork();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceBClient client = new ServiceBClient();
            textBox1.Text = client.DoWork();
        }
    }
}
