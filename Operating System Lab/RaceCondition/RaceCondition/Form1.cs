using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RaceCondition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t1 = new Thread(f1);
            Thread t2 = new Thread(f2);
            t1.Start();
            t2.Start();
            while (t1.IsAlive || t2.IsAlive)
                Thread.Sleep(20);
            showStg();
        }

        Random r = new Random();
        string s = "";
        void f1()
        {
            for (int i = 1; i < 100; i+=2)
            {
                Thread.Sleep(r.Next(2));
                s += "s";
                Thread.Sleep(r.Next(2));
                s += "T1";
                Thread.Sleep(r.Next(2));
                s += " " + i.ToString();
                Thread.Sleep(r.Next(2));
                s += " " + i.ToString();
                Thread.Sleep(r.Next(2));
                s += " " + i.ToString();
                Thread.Sleep(r.Next(2));
            }

        }

        void f2()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Thread.Sleep(r.Next(2));
                s += "s";
                Thread.Sleep(r.Next(2));
                s += "T2";
                Thread.Sleep(r.Next(2));
                s += " " + i.ToString();
                Thread.Sleep(r.Next(2));
                s += " " + i.ToString();
                Thread.Sleep(r.Next(2));
                s += " " + i.ToString();
                Thread.Sleep(r.Next(2));
            }
        }

        void showStg()
        {
            for (int i = 0; i < s.Length; i++)
                if (s[i] == 's')
                    listBox1.Items.Add("");
                else
                    listBox1.Items[listBox1.Items.Count - 1] += s[i].ToString();
        }
    }
}
