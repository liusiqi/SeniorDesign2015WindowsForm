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
        static int countDown = 10;
        static string file_name = @"C:\Users\bigrp17\Documents\Visual Studio 2013\Projects\SenDes0\test.txt";
        //StreamWriter file = new StreamWriter(file_name);
        //string data_rx; // = myport.ReadLine();

        static FileStream fs = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        static StreamWriter sw = new StreamWriter(fs);
        public ACTION()
        {
            InitializeComponent();
            myport.BaudRate = 9600;
            myport.PortName = "COM6";
            myport.Open();

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
            timer.Interval = 1000;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //string data_rx = myport.ReadLine();
            countDown--;
            if (countDown == 0)
            {
                this.Hide();
                HomePage backhome = new HomePage();
                backhome.ShowDialog();
                this.Close();
                timer.Stop();
                sw.Close();
                fs.Close();
            }
            label.Text = countDown.ToString();
            string data_rx = myport.ReadLine();
            sw.WriteLine(data_rx);
            sw.Flush();
        }
    }
}
