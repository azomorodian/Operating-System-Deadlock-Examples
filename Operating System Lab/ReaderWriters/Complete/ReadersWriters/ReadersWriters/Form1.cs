using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ReadersWriters
{
    public partial class Form1 : Form
    {
        delegate void SetValueCallback(int val);
        delegate void AddData2ListBoxReaderN(string s);

        Thread[] AThreadReader, AThreadWriter;
        Thread ThreadReaderCreator;
        string sDataBase;
        Boolean bWriterMustAlive;
        string[] asReaderDataBase = new string[0];
        int alaki;

        int rc = 0;
        Semaphore mutRC = new Semaphore(1, 1);
        Semaphore mutDB = new Semaphore(1, 1);

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnRun_Click(object sender, EventArgs e)
        {            
            btnRun.Enabled = false;
            AThreadWriter = new Thread[Int16.Parse(txtBNMWriters.Text)];
            bWriterMustAlive = true;
            for (int i = 0; i < Int16.Parse(txtBNMWriters.Text); i++)
            {
                AThreadWriter[i] = new Thread(fThreadWriter);
                AThreadWriter[i].Name = i.ToString();
                AThreadWriter[i].IsBackground = true;
                AThreadWriter[i].Start();
            }
            ThreadReaderCreator = new Thread(fThreadCreator);
            ThreadReaderCreator.IsBackground = true;
            ThreadReaderCreator.Start();
        }

        void fThreadCreator()
        {
            Random r = new Random();
            AThreadReader = new Thread[Int16.Parse(txtBNMReaders.Text)];
            for (int i = 0; i < Int16.Parse(txtBNMReaders.Text); i++)
            {
                int IloopLength = Int16.Parse(txtBLowerBCReaders.Text) + r.Next(Int16.Parse(txtBUpperBCReaders.Text) - Int16.Parse(txtBLowerBCReaders.Text));
                for (int j = 0; j < IloopLength; j++) ;                
                AThreadReader[i] = new Thread(fThreadReader);
                AThreadReader[i].Name = i.ToString();
                AThreadReader[i].IsBackground = true;
                AThreadReader[i].Start();
            }
        }

        void fThreadWriter()
        {
            Random r = new Random();
            int ID = Int16.Parse(Thread.CurrentThread.Name);
            int news = ID;
            while (bWriterMustAlive)
            {
                int IloopLength = Int16.Parse(txtBLowerBCWriters.Text) + r.Next(Int16.Parse(txtBUpperBCWriters.Text) - Int16.Parse(txtBLowerBCReaders.Text));
                for (int i = 0; i < IloopLength; i++) ;

                mutDB.WaitOne();
                sDataBase = "";
                for (int i = 0; i < Int16.Parse(txtBNumbersInString.Text); i++)
                {
                    sDataBase += news.ToString() + " ";                    
                }
                mutDB.Release();
                
                news += Int16.Parse(txtBNMWriters.Text);
            }
        }

        void fThreadReader()
        {
            int ID = Int16.Parse(Thread.CurrentThread.Name);
            changeAmountOfProgressBar(ID+1);

            mutRC.WaitOne();
            rc++;
            if (rc==1)
                mutDB.WaitOne();
            mutRC.Release();
            for (int i = 0; i < sDataBase.Length; i++)
            {
                asReaderDataBase[ID] += sDataBase[i];                
            }
            mutRC.WaitOne();
            rc--;
            if (rc==0)
                mutDB.Release();
            mutRC.Release();

            if (ID == Int16.Parse(txtBNMReaders.Text) - 1)
            {
                bWriterMustAlive = false;
                changeAmountOfProgressBar(progressBar1.Minimum);
                report();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Array.Resize<string>(ref asReaderDataBase, Int16.Parse(txtBNMReaders.Text));
            progressBar1.Maximum = Int16.Parse(txtBNMReaders.Text);
        }

        private void txtBNMReaders_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtBNMReaders.Text, out alaki))
            {
                Array.Resize<string>(ref asReaderDataBase, Int16.Parse(txtBNMReaders.Text));
                progressBar1.Maximum = Int16.Parse(txtBNMReaders.Text);                
            }
        }

        void changeAmountOfProgressBar(int value)
        {
            if (progressBar1.InvokeRequired)
            {
                SetValueCallback OSV = new SetValueCallback(changeAmountOfProgressBar);
                this.Invoke(OSV, new object[] {value});
            }
            else
                progressBar1.Value = value;
        }

        void report()
        {
            //Find Failed Readers.
            textBDataReaderNth_TextChanged(this, null);
        }

        private void textBDataReaderNth_TextChanged(object sender, EventArgs e)
        {
            int iReader;
            string s = "";
            int iSpacesNM = 0;
            addData2ListBoxReaderN("0");            
            if (int.TryParse(txtBDataReaderNth.Text, out iReader))
            {
                if (iReader<Int16.Parse(txtBNMReaders.Text))
                {
                    for (int i = 0; i < asReaderDataBase[iReader].Length; i++)
                    {
                        s += asReaderDataBase[iReader][i];
                        if (asReaderDataBase[iReader][i] == ' ')
                            iSpacesNM++;
                        if (iSpacesNM == 6)
                        {
                            addData2ListBoxReaderN(s);
                            s = "";
                            iSpacesNM = 0;
                        }
                    }
                }
            }
        }

        void addData2ListBoxReaderN(string s)
        {
            if (listBDatsReaderNth.InvokeRequired)
            {
                AddData2ListBoxReaderN var = new AddData2ListBoxReaderN(addData2ListBoxReaderN);
                this.Invoke(var, new object[] { s });
            }
            else
                if (s == "0")
                    listBDatsReaderNth.Items.Clear();
                else
                    listBDatsReaderNth.Items.Add(s);
        }
    }
}
