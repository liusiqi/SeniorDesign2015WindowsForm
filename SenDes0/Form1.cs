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
        List<KeyValuePair<int, double>> RLSx_Peak;
        List<KeyValuePair<int, double>> RLSy_Peak;
        List<KeyValuePair<int, double>> RLSz_Peak;

        public HomePage()
        {
            InitializeComponent();
        }

        private void TEST_BUTTON_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage TESTPAGE = new TestPage("test", RLSx_Peak, RLSy_Peak, RLSz_Peak); 
            TESTPAGE.ShowDialog();
            this.Close();
        }

        private void REPORTS_BUTTON_Click(object sender, EventArgs e)
        {
            if (RLSx_Peak == null || RLSy_Peak == null || RLSz_Peak == null)
            {
                MessageBox.Show("Please go to TEST option and make your own standards.");
            }
            else
            {
                MessageBox.Show("If you haven't make your own standards from TEST option, please go for it.");
                this.Hide();
                ReportPage REPORTPAGE = new ReportPage("report", RLSx_Peak, RLSy_Peak, RLSz_Peak);
                REPORTPAGE.ShowDialog();
                this.Close();
            }
        }
    }
}
