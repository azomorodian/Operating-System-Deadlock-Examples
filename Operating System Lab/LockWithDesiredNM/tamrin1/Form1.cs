using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Thread t1;
        public Thread t2;
        public int numLocks;
        Boolean[] tLock ;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numLocks = int.Parse(textBox1.Text);
                tLock = new Boolean[numLocks];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void job1()
        {
            for (int i = 0; i <= 100; i += 2)
            {
                for (int j = 0; j< tLock.Length; j++)
                {
                    while (tLock[j] == true)
                        Thread.Sleep(10);
                    Thread.Sleep(rand.Next(2));
                    tLock[j] = true;
                    if (j>0) tLock[j-1] = false;
                }
                try
                {
                    Thread.Sleep(rand.Next(10));
                    listBox1.Items.Add("A ");
                    Thread.Sleep(rand.Next(10));
                    listBox1.Items[listBox1.Items.Count - 1] += i.ToString() + " ";
                    Thread.Sleep(rand.Next(10));
                    listBox1.Items[listBox1.Items.Count - 1] += i.ToString() + " ";
                    Thread.Sleep(rand.Next(10));
                    listBox1.Items[listBox1.Items.Count - 1] += i.ToString() + " ";
                    Thread.Sleep(rand.Next(10));
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }

                tLock[tLock.Length - 1] = false;
            }
        }

        public void job2()
        {
            for (int i = 1; i <= 99; i += 2)
            {

                for (int j = 0; j < tLock.Length; j++)
                {
                    while (tLock[j] == true)
                        Thread.Sleep(10);
                    Thread.Sleep(rand.Next(2));
                    tLock[j] = true;
                    if (j > 0) tLock[j - 1] = false;
                }
                try
                {
                    Thread.Sleep(rand.Next(10));

                    Thread.Sleep(rand.Next(10));
                    listBox1.Items.Add("B ");
                    Thread.Sleep(rand.Next(10));
                    listBox1.Items[listBox1.Items.Count - 1] += i.ToString() + " ";
                    Thread.Sleep(rand.Next(10));
                    listBox1.Items[listBox1.Items.Count - 1] += i.ToString() + " ";
                    Thread.Sleep(rand.Next(10));
                    listBox1.Items[listBox1.Items.Count - 1] += i.ToString() + " ";
                    Thread.Sleep(rand.Next(10));

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }

                tLock[tLock.Length - 1] = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            t1 = new Thread(job1);
            t1.Name = "0";
            t1.Start();

            t2 = new Thread(job2);
            t2.Name = "1";
            t2.Start();
        }

    }
}