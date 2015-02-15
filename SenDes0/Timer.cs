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
        static int countDown = 4;

        public Timer()
        {
            InitializeComponent();

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
                this.Hide();
                ACTION action = new ACTION();
                action.ShowDialog();
                this.Close();
                timer.Stop();
            }
            label.Text = countDown.ToString();
        }
    }
}
