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
        private int countDown = 4;
        string flags;
        string test_report;
        int[] RLSx = new int[256];
        int[] RLSy = new int[256];
        int[] RLSz = new int[256];
        int[] RUNx = new int[256];
        int[] RUNy = new int[256];
        int[] RUNz = new int[256];
        int[] RESTx = new int[256];
        int[] RESTy = new int[256];
        int[] RESTz = new int[256];
        int[] WALKx = new int[256];
        int[] WALKy = new int[256];
        int[] WALKz = new int[256];
        int[] DRIVEx = new int[256];
        int[] DRIVEy = new int[256];
        int[] DRIVEz = new int[256];

        public Timer(string in_test_report, string inflag, int[] iRLSx, int[] iRLSy, int[] iRLSz, int[] iRUNx, int[] iRUNy, int[] iRUNz, int[] iRESTx, int[] iRESTy, int[] iRESTz, int[] iWALKx, int[] iWALKy, int[] iWALKz, int[] iDRIVEx, int[] iDRIVEy, int[] iDRIVEz)
        {
            InitializeComponent();
            flags = inflag;
            test_report = in_test_report;
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
                ACTION action = new ACTION(test_report, flags, RLSx, RLSy, RLSz, RUNx, RUNy, RUNz, RESTx, RESTy, RESTz, WALKx, WALKy, WALKz, DRIVEx, DRIVEy, DRIVEz);
                action.ShowDialog();
                this.Close();
            }
            label.Text = countDown.ToString();
        }
    }
}
