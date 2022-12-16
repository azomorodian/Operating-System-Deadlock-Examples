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

        string s;
        Thread t1, t2;
        static object locker = new object();

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = new Thread(f1);
            t2 = new Thread(f2);
            t1.Start();
            t2.Start();
            while (t1.IsAlive||t2.IsAlive)
            {
                Thread.Sleep(50);
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]=='n')
                {
                    listBox1.Items.Add("");
                }
                else
	            {
                    listBox1.Items[listBox1.Items.Count-1]+=s[i].ToString();
	            }
            }
        }

        Random r = new Random();
        void f1()
        {
            Thread.Sleep(r.Next(2));
            for (int i = 1; i <= 100; i+=2)
             {
                 Thread.Sleep(r.Next(2));
            Monitor.Enter (locker);
            Thread.Sleep(r.Next(2));
                 try 
                 {
                    Thread.Sleep(r.Next(2));
                    s += 'n';
                    Thread.Sleep(r.Next(2));
                    s += "T1 ";
                    Thread.Sleep(r.Next(2));
                    s += i.ToString() + "  ";
                    Thread.Sleep(r.Next(2));
                    s += i.ToString() + "  ";
                    Thread.Sleep(r.Next(2));
                    s += i.ToString() + "  ";
                    Thread.Sleep(r.Next(2));
                  }
                
                 finally
                 {
                     Thread.Sleep(r.Next(2));
                    Monitor.Exit(locker);
                    Thread.Sleep(r.Next(2));
                 } 
            }
        }

        void f2()
        {
            Thread.Sleep(r.Next(2));
            for (int i = 2; i <= 100; i += 2)
            {
                Thread.Sleep(r.Next(2));
                Monitor.Enter(locker);
                Thread.Sleep(r.Next(2));
                 try
                 {
                    Thread.Sleep(r.Next(2));
                    s += 'n';
                    Thread.Sleep(r.Next(2));
                    s += "T2 ";
                    Thread.Sleep(r.Next(2));
                    s += i.ToString() + "  ";
                    Thread.Sleep(r.Next(2));
                    s += i.ToString() + "  ";
                    Thread.Sleep(r.Next(2));
                    s += i.ToString() + "  ";
                    Thread.Sleep(r.Next(2));
                 }
                
                 finally
                 {
                     Thread.Sleep(r.Next(2));
                    Monitor.Exit (locker);
                    Thread.Sleep(r.Next(2));
                 }  


                }

            }
        }
    }

