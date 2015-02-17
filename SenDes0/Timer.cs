using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenDes0
{
    public partial class Timer : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Label label = new Label();
        private double countDown = 4;
        string flags;
        string test_report;
        List<KeyValuePair<int, double>> RLSx_Peak;
        List<KeyValuePair<int, double>> RLSy_Peak;
        List<KeyValuePair<int, double>> RLSz_Peak;
        //double[] RLSx = new double[256];
        //double[] RLSy = new double[256];
        //double[] RLSz = new double[256];
        //double[] RUNx = new double[256];
        //double[] RUNy = new double[256];
        //double[] RUNz = new double[256];
        //double[] RESTx = new double[256];
        //double[] RESTy = new double[256];
        //double[] RESTz = new double[256];
        //double[] WALKx = new double[256];
        //double[] WALKy = new double[256];
        //double[] WALKz = new double[256];
        //double[] DRIVEx = new double[256];
        //double[] DRIVEy = new double[256];
        //double[] DRIVEz = new double[256];

        public Timer(string in_test_report, string inflag, List<KeyValuePair<int, double>> iRLSx_Peak, List<KeyValuePair<int, double>> iRLSy_Peak, List<KeyValuePair<int, double>> iRLSz_Peak)//double[] iRLSx, double[] iRLSy, double[] iRLSz, double[] iRUNx, double[] iRUNy, double[] iRUNz, double[] iRESTx, double[] iRESTy, double[] iRESTz, double[] iWALKx, double[] iWALKy, double[] iWALKz, double[] iDRIVEx, double[] iDRIVEy, double[] iDRIVEz)
        {
            InitializeComponent();
            flags = inflag;
            test_report = in_test_report;
            RLSx_Peak = iRLSx_Peak;
            RLSy_Peak = iRLSy_Peak;
            RLSz_Peak = iRLSz_Peak;
            //RLSx = iRLSx;
            //RLSy = iRLSy;
            //RLSz = iRLSz; ;
            //RUNx = iRUNx;
            //RUNy = iRUNy;
            //RUNz = iRUNz;
            //RESTx = iRESTx;
            //RESTy = iRESTy;
            //RESTz = iRESTz;
            //WALKx = iWALKx;
            //WALKy = iWALKy;
            //WALKz = iWALKz;
            //DRIVEx = iDRIVEx;
            //DRIVEy = iDRIVEy;
            //DRIVEz = iDRIVEz;

            label.Location = new Point(100, 100);
            label.AutoSize = true;
            label.Font = new Font("Time New Roman", 24, FontStyle.Bold);
            label.Text = String.Empty;

            this.Controls.Add(label);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown--;
            if (countDown == 0)
            {
                timer.Stop();
                this.Hide();
                ACTION action = new ACTION(test_report, flags, RLSx_Peak, RLSy_Peak, RLSz_Peak);//RLSx, RLSy, RLSz, RUNx, RUNy, RUNz, RESTx, RESTy, RESTz, WALKx, WALKy, WALKz, DRIVEx, DRIVEy, DRIVEz);
                action.ShowDialog();
                this.Close();
            }
            label.Text = countDown.ToString();
        }
    }
}
