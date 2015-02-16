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
        public HomePage()
        {
            InitializeComponent();
        }

        private void TEST_BUTTON_Click(object sender, EventArgs e)
        {
            this.Hide();
            TestPage TESTPAGE = new TestPage();
            TESTPAGE.ShowDialog();
            this.Close();
        }

        private void REPORTS_BUTTON_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportPage REPORTPAGE = new ReportPage();
            REPORTPAGE.ShowDialog();
            this.Close();
        }
    }
}
