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
        static string outfile = @"C:\Users\bigrp17\Documents\Visual Studio 2013\Projects\SenDes0\test.txt";
        static string infile = @"C:\Users\bigrp17\Documents\Visual Studio 2013\Projects\SenDes0\RLS in y direction.csv";
        //StreamWriter file = new StreamWriter(file_name);
        //string data_rx; // = myport.ReadLine();

        //static FileStream fs = new FileStream(outfile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        //StreamWriter sw = new StreamWriter(fs);
        StreamReader sr = new StreamReader(infile);
        string[] testarray = new string[1000];

        public ACTION()
        {
            InitializeComponent();
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
            testarray[1000 - countDown] = data_rx;
            label.Text = testarray[1000-countDown];
        }
    }
}
