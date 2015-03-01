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
        string test_report;
        List<KeyValuePair<int, double>> RLSx_Peak;
        List<KeyValuePair<int, double>> RLSy_Peak;
        List<KeyValuePair<int, double>> RLSz_Peak;

        public TestPage(string in_test_report, List<KeyValuePair<int, double>> iRLSx_Peak, List<KeyValuePair<int, double>> iRLSy_Peak, List<KeyValuePair<int, double>> iRLSz_Peak)//double[] iRLSx, double[] iRLSy, double[] iRLSz, double[] iRUNx, double[] iRUNy, double[] iRUNz, double[] iRESTx, double[] iRESTy, double[] iRESTz, double[] iWALKx, double[] iWALKy, double[] iWALKz, double[] iDRIVEx, double[] iDRIVEy, double[] iDRIVEz)
        {
            test_report = in_test_report;
            InitializeComponent();
            RLSx_Peak = iRLSx_Peak;
            RLSy_Peak = iRLSy_Peak;
            RLSz_Peak = iRLSz_Peak;

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
            string flag = "RLS";
            this.Hide();
            Timer RLS_Timer = new Timer(test_report, flag, RLSx_Peak, RLSy_Peak, RLSz_Peak);
            RLS_Timer.ShowDialog();
            this.Close();
        }
    }
}
