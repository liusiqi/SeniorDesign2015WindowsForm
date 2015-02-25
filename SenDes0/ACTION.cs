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
    public partial class ACTION : Form
    {
        SerialPort myport = new SerialPort();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Label label = new Label();
        Label indata = new Label();
        private int countDown = 1000;
        //static string outfile = @"C:\Users\bigrp17\Documents\Visual Studio 2013\Projects\SenDes0\test.txt";
        static string infile = @"C:\Users\bigrp17\Documents\Visual Studio 2013\Projects\SenDes0\RLS in y direction.csv";
        //StreamWriter file = new StreamWriter(file_name);
        //string data_rx; // = myport.ReadLine();

        //static FileStream fs = new FileStream(outfile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        //StreamWriter sw = new StreamWriter(fs);
        StreamReader sr = new StreamReader(infile);
        string[] RLSarray = new string[1000];
        //string[] RUNarray = new string[1000];
        //string[] RESTarray = new string[1000];
        //string[] WALKarray = new string[1000];
        //string[] DRIVEarray = new string[1000];

        double[] RLSx = new double[256];
        double[] RLSy = new double[256];
        double[] RLSz = new double[256];
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

        List<KeyValuePair<int, double>> RLSx_Peak;
        List<KeyValuePair<int, double>> RLSy_Peak;
        List<KeyValuePair<int, double>> RLSz_Peak;

        string test_report;
        string flags;

        public ACTION(string in_test_report, string inflag, List<KeyValuePair<int, double>> iRLSx_Peak, List<KeyValuePair<int, double>> iRLSy_Peak, List<KeyValuePair<int, double>> iRLSz_Peak)//double[] iRLSx, double[] iRLSy, double[] iRLSz, double[] iRUNx, double[] iRUNy, double[] iRUNz, double[] iRESTx, double[] iRESTy, double[] iRESTz, double[] iWALKx, double[] iWALKy, double[] iWALKz, double[] iDRIVEx, double[] iDRIVEy, double[] iDRIVEz)
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
            //myport.BaudRate = 9600;
            //myport.PortName = "COM6";
            //myport.Open();

            //string data_rx = myport.ReadLine();
            //file.WriteLine(data_rx);
            //file.Close();

            label.Location = new Point(100, 100);
            indata.Location = new Point(100, 300);
            label.AutoSize = true;
            indata.AutoSize = true;
            label.Font = new Font("Time New Roman", 18, FontStyle.Bold);
            indata.Font = new Font("Time New Roman", 18, FontStyle.Italic);
            label.Text = String.Empty;
            indata.Text = String.Empty;

            this.Controls.Add(label);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1;
            timer.Start();

            DFT();
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
                timer.Stop();
                this.Hide();
                HomePage backhome = new HomePage();
                backhome.ShowDialog(); 
                this.Close();
            }
           
            //string data_rx = myport.ReadLine();
            string data_rx = sr.ReadLine();
            //sw.WriteLine(data_rx);
            //sw.Flush();
            label.Text = RLSarray[1000 - countDown];
            if (test_report == "test" && flags == "RLS")
                RLSarray[1000 - countDown] = data_rx;
            //else if (test_report == "test" && flags == "RUN")
            //    RUNarray[1000 - countDown] = data_rx;
            //else if (test_report == "test" && flags == "REST")
            //    RESTarray[1000 - countDown] = data_rx;
            //else if (test_report == "test" && flags == "WALK")
            //    WALKarray[1000 - countDown] = data_rx;
            //else if (test_report == "test" && flags == "DRIVE")
            //    DRIVEarray[1000 - countDown] = data_rx;
        }

        private void DFT()
        {
            if (test_report == "test" && flags == "RLS")
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
                        string[] xyz = RLSarray[400 + n].Split(',');
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
                    RLSx[k] = xfmag;
                    yfmag = Math.Sqrt(yfreal * yfreal + yfimag * yfimag);
                    RLSy[k] = yfmag;
                    zfmag = Math.Sqrt(zfreal * zfreal + zfimag * zfimag);
                    RLSz[k] = zfmag;
                }
                for (int nx = 0; nx < 128; nx++)
                {
                    if (RLSx[nx] > 1800 && RLSx[nx] - RLSx[nx+1] < 0)
                    {
                        RLSx_Peak.Add(new KeyValuePair<int, double>(nx, RLSx[nx]));
                    }
                }
                for (int ny = 0; ny < 128; ny++)
                {
                    if (RLSy[ny] > 1800 && RLSy[ny] - RLSy[ny + 1] < 0)
                    {
                        RLSy_Peak.Add(new KeyValuePair<int,double>(ny, RLSy[ny]));
                    }
                }
                for (int nz = 0; nz < 128; nz++)
                {
                    if (RLSz[nz] > 1700 && RLSz[nz] - RLSz[nz + 1] < 0)
                    {
                        RLSz_Peak.Add(new KeyValuePair<int, double>(nz, RLSz[nz]));
                    }
                }
            }
            //else if (test_report == "test" && flags == "RUN")
            //{
            //    for (int k = 0; k < 256; k++)
            //    {
            //        double xfreal = 0;
            //        double xfimag = 0;
            //        double xfmag = 0;
            //        double yfreal = 0;
            //        double yfimag = 0;
            //        double yfmag = 0;
            //        double zfreal = 0;
            //        double zfimag = 0;
            //        double zfmag = 0;
            //        for (int n = 0; n < 256; n++)
            //        {
            //            string[] xyz = RUNarray[400 + n].Split(',');
            //            double x = Convert.ToDouble(xyz[0]);
            //            double y = Convert.ToDouble(xyz[1]);
            //            double z = Convert.ToDouble(xyz[2]);
            //            xfreal = xfreal + x * Math.Cos(2 * Math.PI * n * k / 256);
            //            xfimag = xfimag + x * Math.Cos(2 * Math.PI * n * k / 256);
            //            yfreal = yfreal + y * Math.Cos(2 * Math.PI * n * k / 256);
            //            yfimag = yfimag + y * Math.Cos(2 * Math.PI * n * k / 256);
            //            zfreal = zfreal + z * Math.Cos(2 * Math.PI * n * k / 256);
            //            zfimag = zfimag + z * Math.Cos(2 * Math.PI * n * k / 256);
            //        }
            //        xfmag = Math.Sqrt(xfreal * xfreal + xfimag * xfimag);
            //        RUNx[k] = xfmag;
            //        yfmag = Math.Sqrt(yfreal * yfreal + yfimag * yfimag);
            //        RUNy[k] = yfmag;
            //        zfmag = Math.Sqrt(zfreal * zfreal + zfimag * zfimag);
            //        RUNz[k] = zfmag;
            //    }
            //}
            //else if (test_report == "test" && flags == "REST")
            //{
            //    for (int k = 0; k < 256; k++)
            //    {
            //        double xfreal = 0;
            //        double xfimag = 0;
            //        double xfmag = 0;
            //        double yfreal = 0;
            //        double yfimag = 0;
            //        double yfmag = 0;
            //        double zfreal = 0;
            //        double zfimag = 0;
            //        double zfmag = 0;
            //        for (int n = 0; n < 256; n++)
            //        {
            //            string[] xyz = RESTarray[400 + n].Split(',');
            //            double x = Convert.ToDouble(xyz[0]);
            //            double y = Convert.ToDouble(xyz[1]);
            //            double z = Convert.ToDouble(xyz[2]);
            //            xfreal = xfreal + x * Math.Cos(2 * Math.PI * n * k / 256);
            //            xfimag = xfimag + x * Math.Cos(2 * Math.PI * n * k / 256);
            //            yfreal = yfreal + y * Math.Cos(2 * Math.PI * n * k / 256);
            //            yfimag = yfimag + y * Math.Cos(2 * Math.PI * n * k / 256);
            //            zfreal = zfreal + z * Math.Cos(2 * Math.PI * n * k / 256);
            //            zfimag = zfimag + z * Math.Cos(2 * Math.PI * n * k / 256);
            //        }
            //        xfmag = Math.Sqrt(xfreal * xfreal + xfimag * xfimag);
            //        RESTx[k] = xfmag;
            //        yfmag = Math.Sqrt(yfreal * yfreal + yfimag * yfimag);
            //        RESTy[k] = yfmag;
            //        zfmag = Math.Sqrt(zfreal * zfreal + zfimag * zfimag);
            //        RESTz[k] = zfmag;
            //    }
            //}
            //else if (test_report == "test" && flags == "WALK")
            //{
            //    for (int k = 0; k < 256; k++)
            //    {
            //        double xfreal = 0;
            //        double xfimag = 0;
            //        double xfmag = 0;
            //        double yfreal = 0;
            //        double yfimag = 0;
            //        double yfmag = 0;
            //        double zfreal = 0;
            //        double zfimag = 0;
            //        double zfmag = 0;
            //        for (int n = 0; n < 256; n++)
            //        {
            //            string[] xyz = WALKarray[400 + n].Split(',');
            //            double x = Convert.ToDouble(xyz[0]);
            //            double y = Convert.ToDouble(xyz[1]);
            //            double z = Convert.ToDouble(xyz[2]);
            //            xfreal = xfreal + x * Math.Cos(2 * Math.PI * n * k / 256);
            //            xfimag = xfimag + x * Math.Cos(2 * Math.PI * n * k / 256);
            //            yfreal = yfreal + y * Math.Cos(2 * Math.PI * n * k / 256);
            //            yfimag = yfimag + y * Math.Cos(2 * Math.PI * n * k / 256);
            //            zfreal = zfreal + z * Math.Cos(2 * Math.PI * n * k / 256);
            //            zfimag = zfimag + z * Math.Cos(2 * Math.PI * n * k / 256);
            //        }
            //        xfmag = Math.Sqrt(xfreal * xfreal + xfimag * xfimag);
            //        WALKx[k] = xfmag;
            //        yfmag = Math.Sqrt(yfreal * yfreal + yfimag * yfimag);
            //        WALKy[k] = yfmag;
            //        zfmag = Math.Sqrt(zfreal * zfreal + zfimag * zfimag);
            //        WALKz[k] = zfmag;
            //    }
            //}
            //else if (test_report == "test" && flags == "DRIVE")
            //{
            //    for (int k = 0; k < 256; k++)
            //    {
            //        double xfreal = 0;
            //        double xfimag = 0;
            //        double xfmag = 0;
            //        double yfreal = 0;
            //        double yfimag = 0;
            //        double yfmag = 0;
            //        double zfreal = 0;
            //        double zfimag = 0;
            //        double zfmag = 0;
            //        for (int n = 0; n < 256; n++)
            //        {
            //            string[] xyz = DRIVEarray[400 + n].Split(',');
            //            double x = Convert.ToDouble(xyz[0]);
            //            double y = Convert.ToDouble(xyz[1]);
            //            double z = Convert.ToDouble(xyz[2]);
            //            xfreal = xfreal + x * Math.Cos(2 * Math.PI * n * k / 256);
            //            xfimag = xfimag + x * Math.Cos(2 * Math.PI * n * k / 256);
            //            yfreal = yfreal + y * Math.Cos(2 * Math.PI * n * k / 256);
            //            yfimag = yfimag + y * Math.Cos(2 * Math.PI * n * k / 256);
            //            zfreal = zfreal + z * Math.Cos(2 * Math.PI * n * k / 256);
            //            zfimag = zfimag + z * Math.Cos(2 * Math.PI * n * k / 256);
            //        }
            //        xfmag = Math.Sqrt(xfreal * xfreal + xfimag * xfimag);
            //        DRIVEx[k] = xfmag;
            //        yfmag = Math.Sqrt(yfreal * yfreal + yfimag * yfimag);
            //        DRIVEy[k] = yfmag;
            //        zfmag = Math.Sqrt(zfreal * zfreal + zfimag * zfimag);
            //        DRIVEz[k] = zfmag;
            //    }
            //}
        }
    }
}
