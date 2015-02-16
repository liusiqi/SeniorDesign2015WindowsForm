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
    public partial class HomePage : Form
    {
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

        public HomePage()
        {
            InitializeComponent();
        }

        private void TEST_BUTTON_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage TESTPAGE = new TestPage("test", RLSx, RLSy, RLSz, RUNx, RUNy, RUNz, RESTx, RESTy, RESTz, WALKx, WALKy, WALKz, DRIVEx, DRIVEy, DRIVEz);
            TESTPAGE.ShowDialog();
            this.Close();
        }

        private void REPORTS_BUTTON_Click(object sender, EventArgs e)
        {
            if (RLSx == null || RLSy == null || RLSy == null || RUNx == null || RUNy == null || RUNz == null || RESTx == null || RESTy == null || RESTz == null || WALKx == null || WALKy == null || WALKz == null || DRIVEx == null || DRIVEy == null || DRIVEz == null)
            {
                MessageBox.Show("Please go to TEST option and make your own standards.");
            }
            else
            {
                MessageBox.Show("If you haven't make your own standards from TEST option, please go for it.");
                this.Hide();
                ReportPage REPORTPAGE = new ReportPage("report", RLSx, RLSy, RLSz, RUNx, RUNy, RUNz, RESTx, RESTy, RESTz, WALKx, WALKy, WALKz, DRIVEx, DRIVEy, DRIVEz);
                REPORTPAGE.ShowDialog();
                this.Close();
            }
        }
    }
}
