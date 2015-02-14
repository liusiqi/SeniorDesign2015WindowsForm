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
        private int countDown = 10;

        public Timer()
        {
            InitializeComponent();
            //timer.Tick += new EventHandler(timer1_Tick); // Everytime timer ticks, timer_Tick will be called
            //timer.Interval = (1000) * (1);              // Timer will tick evert second
            //timer.Enabled = true;                       // Enable the timer
            //timer.Start();                              // Start the timer

            label.Location = new Point(100, 100);
            label.AutoSize = true;
            label.Text = String.Empty;

            this.Controls.Add(label);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Interval = 1000;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label.Text = DateTime.Now.ToString();
            countDown--;
            if (countDown < 1)
            {
                countDown = 10;
            }
            label.Text = countDown.ToString();
        }
    }
}
