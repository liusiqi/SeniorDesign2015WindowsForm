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
    public partial class ReportPage : Form
    {
        string test_report;
        public ReportPage(string in_test_report)
        {
            test_report = in_test_report;
            InitializeComponent();
        }

        private void HOMEPAGE_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage HOMEPAGE = new HomePage();
            //TESTPAGE.FormClosed += (sender, args) => this.Close();
            HOMEPAGE.ShowDialog();
            this.Close();
        }
    }
}
