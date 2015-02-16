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
        double[] RLSx = new double[256];
        double[] RLSy = new double[256];
        double[] RLSz = new double[256];
        double[] RUNx = new double[256];
        double[] RUNy = new double[256];
        double[] RUNz = new double[256];
        double[] RESTx = new double[256];
        double[] RESTy = new double[256];
        double[] RESTz = new double[256];
        double[] WALKx = new double[256];
        double[] WALKy = new double[256];
        double[] WALKz = new double[256];
        double[] DRIVEx = new double[256];
        double[] DRIVEy = new double[256];
        double[] DRIVEz = new double[256];

        public TestPage(string in_test_report, double[] iRLSx, double[] iRLSy, double[] iRLSz, double[] iRUNx, double[] iRUNy, double[] iRUNz, double[] iRESTx, double[] iRESTy, double[] iRESTz, double[] iWALKx, double[] iWALKy, double[] iWALKz, double[] iDRIVEx, double[] iDRIVEy, double[] iDRIVEz)
        {
            test_report = in_test_report;
            InitializeComponent();
            RLSx = iRLSx;
            RLSy = iRLSy;
            RLSz = iRLSz; ;
            RUNx = iRUNx;
            RUNy = iRUNy;
            RUNz = iRUNz;
            RESTx = iRESTx;
            RESTy = iRESTy;
            RESTz = iRESTz;
            WALKx = iWALKx;
            WALKy = iWALKy;
            WALKz = iWALKz;
            DRIVEx = iDRIVEx;
            DRIVEy = iDRIVEy;
            DRIVEz = iDRIVEz;
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
            string RLS_flag = "RLS";
            this.Hide();
            Timer RLS_Timer = new Timer(test_report, RLS_flag, RLSx, RLSy, RLSz, RUNx, RUNy, RUNz, RESTx, RESTy, RESTz, WALKx, WALKy, WALKz, DRIVEx, DRIVEy, DRIVEz);
            RLS_Timer.ShowDialog();
            this.Close();
        }
    }
}
