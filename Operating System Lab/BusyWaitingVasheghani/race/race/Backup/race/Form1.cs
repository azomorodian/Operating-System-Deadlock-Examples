using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace race
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int[] in_stage = new int[4];
        int[] last_p = new int[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        string s = "";
        void f0()
        {
            Thread.Sleep(r.Next(2));
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(r.Next(2));
                for(int j=0;j<=3;j++)
                {
                    Thread.Sleep(r.Next(2));
                    in_stage[0]=j;
                    Thread.Sleep(r.Next(2));
                    last_p[j] = 0;
                    Thread.Sleep(r.Next(2));
                    for(int k=0;k<=3;k++)
                    {
                        Thread.Sleep(r.Next(2));
                        if (k!=0)
                        {
                            Thread.Sleep(r.Next(2));
                            while((in_stage[k]>= in_stage[0]) && (last_p[j]==0))
                            {
                                Thread.Sleep(r.Next(2));
                            }
                        }
                    }
                }            
                Thread.Sleep(r.Next(2));
                s += "s";
                Thread.Sleep(r.Next(2));
                s += "T0  ";
                Thread.Sleep(r.Next(2));
                s += " " + 0;
                Thread.Sleep(r.Next(2));
                s += " " + 0;
                Thread.Sleep(r.Next(2));
                s += " " + 0;
                Thread.Sleep(r.Next(2));
                //l1 = false;
                in_stage[0] = -1;
                Thread.Sleep(r.Next(2));

            }

        }

        void f1()
        {
            Thread.Sleep(r.Next(2));
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(r.Next(2));
                for (int j = 0; j <= 3; j++)
                {
                    Thread.Sleep(r.Next(2));
                    in_stage[1] = j;
                    Thread.Sleep(r.Next(2));
                    last_p[j] = 1;
                    Thread.Sleep(r.Next(2));
                    for (int k = 0; k <= 3; k++)
                    {
                        Thread.Sleep(r.Next(2));
                        if (k != 1)
                        {
                            Thread.Sleep(r.Next(2));
                            while ((in_stage[k] >= in_stage[1]) && (last_p[j] == 1))
                            {
                                Thread.Sleep(r.Next(2));
                            }
                        }
                    }
                }                    
                Thread.Sleep(r.Next(2));
                s += "s";
                Thread.Sleep(r.Next(2));
                s += "T1  ";
                Thread.Sleep(r.Next(2));
                s += " " + 1;
                Thread.Sleep(r.Next(2));
                s += " " + 1;
                Thread.Sleep(r.Next(2));
                s += " " + 1;
                Thread.Sleep(r.Next(2));
                //l2 = false;
                in_stage[1] = -1;
                Thread.Sleep(r.Next(2));

            }
        }

        void f2()
        {
            Thread.Sleep(r.Next(2));
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(r.Next(2));
                for (int j = 0; j <= 3; j++)
                {
                    Thread.Sleep(r.Next(2));
                    in_stage[2] = j;
                    Thread.Sleep(r.Next(2));
                    last_p[j] = 2;
                    Thread.Sleep(r.Next(2));
                    for (int k = 0; k <= 3; k++)
                    {
                        Thread.Sleep(r.Next(2));
                        if (k != 2)
                        {
                            Thread.Sleep(r.Next(2));
                            while ((in_stage[k] >= in_stage[2]) && (last_p[j] == 2))
                            {
                                Thread.Sleep(r.Next(2));
                            }
                        }
                    }
                }
                Thread.Sleep(r.Next(2));
                s += "s";
                Thread.Sleep(r.Next(2));
                s += "T2  ";
                Thread.Sleep(r.Next(2));
                s += " " + 2;
                Thread.Sleep(r.Next(2));
                s += " " + 2;
                Thread.Sleep(r.Next(2));
                s += " " + 2;
                Thread.Sleep(r.Next(2));
                //l2 = false;
                in_stage[2] = -1;
                Thread.Sleep(r.Next(2));

            }
        }
        void f3()
        {
            Thread.Sleep(r.Next(2));
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(r.Next(2));
                for (int j = 0; j <= 3; j++)
                {
                    Thread.Sleep(r.Next(2));
                    in_stage[3] = j;
                    Thread.Sleep(r.Next(2));
                    last_p[j] = 3;
                    Thread.Sleep(r.Next(2));
                    for (int k = 0; k <= 3; k++)
                    {
                        Thread.Sleep(r.Next(2));
                        if (k != 3)
                        {
                            Thread.Sleep(r.Next(2));
                            while ((in_stage[k] >= in_stage[3]) && (last_p[j] == 3))
                            {
                                Thread.Sleep(r.Next(2));
                            }
                        }
                    }
                }
                Thread.Sleep(r.Next(2));
                s += "s";
                Thread.Sleep(r.Next(2));
                s += "T3  ";
                Thread.Sleep(r.Next(2));
                s += " " + 3;
                Thread.Sleep(r.Next(2));
                s += " " + 3;
                Thread.Sleep(r.Next(2));
                s += " " + 3;
                Thread.Sleep(r.Next(2));
                //l2 = false;
                in_stage[3] = -1;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t0 = new Thread(f0);
            Thread t1 = new Thread(f1);
            Thread t2 = new Thread(f2);
            Thread t3 = new Thread(f3);
            t0.Start();
            t1.Start();
            t2.Start();
            t3.Start();
            while (t0.IsAlive || t1.IsAlive || t2.IsAlive||t3.IsAlive )
                Thread.Sleep(20);
            showStg();
        }



    }
}