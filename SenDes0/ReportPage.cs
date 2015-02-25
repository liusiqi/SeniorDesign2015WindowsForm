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
    public partial class ReportPage : Form
    {
        string test_report;
        int start_flag = 0;

        List<KeyValuePair<int, double>> RLSx_Peak;
        List<KeyValuePair<int, double>> RLSy_Peak;
        List<KeyValuePair<int, double>> RLSz_Peak;

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int countDown = 1000;

        string[] COMParray = new string[1000];

        double[] COMPx = new double[256];
        double[] COMPy = new double[256];
        double[] COMPz = new double[256];

        static string infile = @"C:\Users\bigrp17\Documents\Visual Studio 2013\Projects\SenDes0\RLS in y direction.csv";
        static string outfile = @"C:\Users\bigrp17\Documents\Visual Studio 2013\Projects\SenDes0\RLS REPORT.csv";
        StreamReader sr = new StreamReader(infile);
        StreamWriter sw = new StreamWriter(outfile);
        SerialPort myport = new SerialPort();

        bool xd = false;
        bool yd = false;
        bool zd = false;

        public ReportPage(string in_test_report, List<KeyValuePair<int, double>> iRLSx_Peak, List<KeyValuePair<int, double>> iRLSy_Peak, List<KeyValuePair<int, double>> iRLSz_Peak)//double[] iRLSx, double[] iRLSy, double[] iRLSz, double[] iRUNx, double[] iRUNy, double[] iRUNz, double[] iRESTx, double[] iRESTy, double[] iRESTz, double[] iWALKx, double[] iWALKy, double[] iWALKz, double[] iDRIVEx, double[] iDRIVEy, double[] iDRIVEz)
        {
            test_report = in_test_report;
            InitializeComponent();
            RLSx_Peak = iRLSx_Peak;
            RLSy_Peak = iRLSy_Peak;
            RLSz_Peak = iRLSz_Peak;

            //myport.BaudRate = 9600;
            //myport.PortName = "COM6";
            //myport.Open();

            //string data_rx = myport.ReadLine();
            //file.WriteLine(data_rx);
            //file.Close();
        }

        private void HOMEPAGE_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage HOMEPAGE = new HomePage();
            //TESTPAGE.FormClosed += (sender, args) => this.Close();
            HOMEPAGE.ShowDialog();
            this.Close();
        }

        private void Start_Comp_Click(object sender, EventArgs e)
        {
            this.Stop_Comp.Visible = true;
            this.Start_Comp.Visible = false;
            xd = false;
            yd = false;
            zd = false;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //string data_rx = myport.ReadLine();
            countDown--;
            if (countDown == 0)
            {
                //sw.Close();
                //fs.Close();
                sr.Close();
                //timer.Stop(); // Not sure if it needs to be stop yet
                DFT(RLSx_Peak, RLSy_Peak, RLSz_Peak);
                countDown = 1000;
                xd = false;
                yd = false;
                zd = false;
            }
            //string data_rx = myport.ReadLine();
            string data_rx = sr.ReadLine();
            //sw.WriteLine(data_rx);
            //sw.Flush();
            //label.Text = RLSarray[1000 - countDown];
            COMParray[1000 - countDown] = data_rx;
        }

        private void DFT(List<KeyValuePair<int, double>> iRLSx_Peak, List<KeyValuePair<int, double>> iRLSy_Peak, List<KeyValuePair<int, double>> iRLSz_Peak)
        {
            for (int k = 0; k < 256; k++)
            {
                double xfreal = 0;
                double xfimag = 0;
                double xfmag = 0;
                double yfreal = 0;
                double yfimag = 0;
                double yfmag = 0;
                double zfreal = 0;
                double zfimag = 0;
                double zfmag = 0;
                for (int n = 0; n < 256; n++)
                {
                    string[] xyz = COMParray[400 + n].Split(',');
                    double x = Convert.ToDouble(xyz[0]);
                    double y = Convert.ToDouble(xyz[1]);
                    double z = Convert.ToDouble(xyz[2]);
                    xfreal = xfreal + x * Math.Cos(2 * Math.PI * n * k / 256);
                    xfimag = xfimag + x * Math.Cos(2 * Math.PI * n * k / 256);
                    yfreal = yfreal + y * Math.Cos(2 * Math.PI * n * k / 256);
                    yfimag = yfimag + y * Math.Cos(2 * Math.PI * n * k / 256);
                    zfreal = zfreal + z * Math.Cos(2 * Math.PI * n * k / 256);
                    zfimag = zfimag + z * Math.Cos(2 * Math.PI * n * k / 256);
                }
                xfmag = Math.Sqrt(xfreal * xfreal + xfimag * xfimag);
                COMPx[k] = xfmag;
                yfmag = Math.Sqrt(yfreal * yfreal + yfimag * yfimag);
                COMPy[k] = yfmag;
                zfmag = Math.Sqrt(zfreal * zfreal + zfimag * zfimag);
                COMPz[k] = zfmag;
            }


            foreach (var pair in RLSx_Peak)
            {
                for (int i = pair.Key - 5; i < pair.Key + 5; i++)
                {
                    if (pair.Value - 100 <= COMPx[i] && COMPx[i] <= pair.Value + 100)
                    {
                        xd = true;
                    }
                }
            }
            foreach (var pair in RLSy_Peak)
            {
                for (int i = pair.Key - 5; i < pair.Key + 5; i++)
                {
                    if (pair.Value - 100 <= COMPy[i] && COMPy[i] <= pair.Value + 100)
                    {
                        yd = true;
                    }
                }
            }
            foreach (var pair in RLSz_Peak)
            {
                for (int i = pair.Key - 5; i < pair.Key + 5; i++)
                {
                    if (pair.Value - 100 <= COMPz[i] && COMPz[i] <= pair.Value + 100)
                    {
                        zd = true;
                    }
                }
            }

            if (xd == true && yd == true && zd == true)
            {
                //start_flag++;
                //MessageBox.Show("WARNING, the patient is in RLS situation.");
                this.Lable_Waming.Text = "WARNING, the user is under RLS condition!";
                this.Lable_Waming.Visible = true;

                if (start_flag == 0)
                {
                    DateTime current_time = DateTime.Now;
                    sw.WriteLine("ON " + current_time.ToString() + " : the user starts doing RLS movement.");
                    start_flag++;
                }
            }
            if (xd == false && yd == false && zd == false)
            {
                this.Lable_Waming.Visible = false;
                this.Lable_Waming.Text = "";
                if (start_flag > 0)
                {
                    DateTime current_time = DateTime.Now;
                    sw.WriteLine("OFF " + current_time.ToString() + " : the user ends doing RLS movement.");
                    start_flag = 0;
                }
                if (start_flag > Int32.MaxValue)
                    start_flag = 0;
            }
        }

        private void Stop_Comp_Click(object sender, EventArgs e)
        {
            timer.Stop();
            sw.Close();
        }

        private void Lable_Warming_Click(object sender, EventArgs e)
        {

        }
    }
}
