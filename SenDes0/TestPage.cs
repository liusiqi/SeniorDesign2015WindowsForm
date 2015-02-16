using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace SenDes0
{
    public partial class TestPage : Form
    {
        //SerialPort myport = new SerialPort();
        public TestPage()
        {
            InitializeComponent();
            //myport.BaudRate = 9600;
            //myport.PortName = "COM5";
            //myport.Open();
        }

        private void HOMEPAGE_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage HOMEPAGE = new HomePage();
            HOMEPAGE.ShowDialog();
            this.Close();
        }

        private void RLS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Timer RLS_Timer = new Timer();
            RLS_Timer.ShowDialog();
            this.Close();
        }
    }
}
