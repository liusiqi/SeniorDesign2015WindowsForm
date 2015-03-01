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
        private long countDown = 256;

        string[] RLSarray = new string[256];

        double[] RLSx = new double[256];
        double[] RLSy = new double[256];
        double[] RLSz = new double[256];

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
           
            myport.BaudRate = 9600;
            myport.PortName = "COM6";
            myport.Open();

            //string data_rx = myport.ReadLine();
            //file.WriteLine(data_rx);
            //file.Close();

            label.Location = new Point(100, 200);
            label.AutoSize = true;
            label.Font = new Font("Time New Roman", 18, FontStyle.Bold);
            label.Text = String.Empty;

            this.Controls.Add(label);

            while(countDown != 0)
            {
                string data_rx = myport.ReadLine();
                label.Text = data_rx.ToString();
                RLSarray[256 - countDown] = data_rx;
                countDown--;
            }

            //DFT();
            this.Hide();
            HomePage backhome = new HomePage();
            backhome.ShowDialog();
            this.Close();
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
                        string[] xyz = RLSarray[n].Split(',');
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
        }
    }
}
