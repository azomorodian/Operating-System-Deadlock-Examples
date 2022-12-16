using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SleepyBarber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int iNMWaitingChairs, NMCustomer, NMBarber;
        Thread[] TRDbarber, TRDcustomer;
        Boolean bErrInTXTs;

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            bErrInTXTs = false;
            
            if (!Int32.TryParse(txtNMBarbers.Text, out NMBarber))
                bErrInTXTs = true;
            if (!Int32.TryParse(txtNMCustomer.Text, out NMCustomer))
                bErrInTXTs = true;
            //Test other textBoxes.
            if (!bErrInTXTs)
            {
                btnStartStop.Enabled = false;
                TRDbarber = new Thread[NMBarber];
                for (int i = 0; i < NMBarber; i++)
                {
                    TRDbarber[i] = new Thread(FThreadBarber);
                }
                TRDcustomer = new Thread[NMCustomer];
                for (int i = 0; i < NMCustomer; i++)
                {
                    TRDcustomer[i] = new Thread(FThreadCustomer);
                }
            }            
        }

        void FThreadBarber()
        {
            
        }

        void FThreadCustomer()
        {
        }

    }
}
