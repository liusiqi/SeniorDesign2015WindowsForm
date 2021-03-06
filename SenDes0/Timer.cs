﻿using System;
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

        public Timer(string in_test_report, string inflag, List<KeyValuePair<int, double>> iRLSx_Peak, List<KeyValuePair<int, double>> iRLSy_Peak, List<KeyValuePair<int, double>> iRLSz_Peak)//double[] iRLSx, double[] iRLSy, double[] iRLSz, double[] iRUNx, double[] iRUNy, double[] iRUNz, double[] iRESTx, double[] iRESTy, double[] iRESTz, double[] iWALKx, double[] iWALKy, double[] iWALKz, double[] iDRIVEx, double[] iDRIVEy, double[] iDRIVEz)
        {
            InitializeComponent();
            flags = inflag;
            test_report = in_test_report;
            RLSx_Peak = iRLSx_Peak;
            RLSy_Peak = iRLSy_Peak;
            RLSz_Peak = iRLSz_Peak;

            label.Location = new Point(100, 300);
            label.AutoSize = true;
            label.Font = new Font("Time New Roman", 24, FontStyle.Bold);
            //label.ForeColor = System.Drawing.Color.GhostWhite;
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
                ACTION action = new ACTION(test_report, flags, RLSx_Peak, RLSy_Peak, RLSz_Peak);
                action.ShowDialog();
                this.Close();
            }
            label.Text = countDown.ToString();
        }
    }
}
