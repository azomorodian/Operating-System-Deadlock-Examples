using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace RaceCondtion4nThread
{
    public partial class Form1 : Form
    {
        Thread[] aThread = new Thread[10];
        string s="";        
        short iNMBuiltThreads;
        Random r = new Random();
        int killThread = -1;

        public Form1()
        {
            InitializeComponent();
        }        
        
        private void btnRemoveThread_Click(object sender, EventArgs e)
        {
            for (int i = iNMBuiltThreads-1; (i >= 0)&&(killThread==-1); i--)
            {
                if (aThread[i].IsAlive)
                    killThread = i;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Int16.TryParse(txtBoxNMThreads.Text, out iNMBuiltThreads))
                if (iNMBuiltThreads<=10)
                {
                    for (int i = 0; i < iNMBuiltThreads; i++)
                    {
                        aThread[i]=new Thread(f);
                        aThread[i].Name = i.ToString();
                        aThread[i].Start();
                    }
                    int iAliveThreads = 5;
                    btnStart.Enabled=false;
                    while (iAliveThreads>0)
                    {
                        iAliveThreads=0;                
                        for (int i = 0; i < iNMBuiltThreads; i++)
                        {
                            if (aThread[i].IsAlive)
                                iAliveThreads++;
                        }
                        lblNMThreads.Text = iAliveThreads.ToString();
                        Thread.Sleep(50);
                        Application.DoEvents();
                    }
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == 'n')
                            listBox1.Items.Add("");
                        else
                            listBox1.Items[listBox1.Items.Count - 1] += s[i].ToString();
                    }
                    btnAddThread.Enabled=false;
                    btnRemoveThread.Enabled=false;
                }
        }

        void f()
        {
            int ID = Int16.Parse(Thread.CurrentThread.Name);
            bool mustAlive = true;
            for (int i = ID; (i <= 1000)&&mustAlive; i+=10)
            {
                Thread.Sleep(r.Next(2));
                s += "n";
                Thread.Sleep(r.Next(2));
                s += ((char)(65 + ID)).ToString();
                Thread.Sleep(r.Next(2));
                s += " ";
                Thread.Sleep(r.Next(2));
                s += i.ToString();
                Thread.Sleep(r.Next(2));
                s += " ";
                Thread.Sleep(r.Next(2));
                s += i.ToString();
                Thread.Sleep(r.Next(2));
                s += " ";
                Thread.Sleep(r.Next(2));
                s += i.ToString();
                Thread.Sleep(r.Next(2));
                if (killThread == ID)
                {
                    mustAlive = false;
                    killThread = -1;
                }
            }
        }

        private void btnAddThread_Click(object sender, EventArgs e)
        {
            if (iNMBuiltThreads < 10)
            {
                aThread[iNMBuiltThreads] = new Thread(f);
                aThread[iNMBuiltThreads].Name = iNMBuiltThreads.ToString();
                aThread[iNMBuiltThreads].Start();
                iNMBuiltThreads++;                
            }
        }
    }
}
