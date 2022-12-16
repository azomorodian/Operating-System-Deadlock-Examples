using System;
using System.Windows.Forms;
using System.Threading;

namespace SleepyBarber
{
    public partial class Form1 : Form
    {
        #region Constructors
        
        public Form1()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Public Variables

        Semaphore smCustomers, smMutex, smBarbers;

        int WaitingChairsCount, CustomersCount, BarbersCount, TotalChairsCount;
        int MinHaircutTime, MaxDurationOfHaircutTime, MinLongHairTime, MaxDurationOfLongHairTime;
        Thread[] trdBarbers, trdCustomers;
        bool HasError;
        
        string[] states;
        Random rnd = new Random();

        #endregion /Public Variables

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            HasError = false;
            
            if (!Int32.TryParse(txtBarbersCount.Text, out BarbersCount))
                HasError = true;
            if (!Int32.TryParse(txtCustomersCount.Text, out CustomersCount))
                HasError = true;
            if (!Int32.TryParse(txtEmptyChairs.Text, out TotalChairsCount))
                HasError = true;
            if (!Int32.TryParse(txtMinHaircutTime.Text, out MinHaircutTime))
                HasError = true;
            if (!Int32.TryParse(txtMaxDurationOfHaircutTime.Text, out MaxDurationOfHaircutTime))
                HasError = true;
            if (!Int32.TryParse(txtMinLongHairTime.Text, out MinLongHairTime))
                HasError = true;
            if (!Int32.TryParse(txtMaxDurationOfLongHairTime.Text, out MaxDurationOfLongHairTime))
                HasError = true;

            for (int i = 0; i < BarbersCount + CustomersCount; i++)
            {
                listBoxReport.Items.Insert(i, String.Empty);
            }

            if (!HasError)
            {
                states = new string[BarbersCount + CustomersCount];

                for (int i = 0; i < BarbersCount; i++)
                {
                    states[i] = string.Format("Barber {0}: Is Not Active!", i);
                }
                for (int i = BarbersCount; i < BarbersCount + CustomersCount; i++)
                {
                    states[i] = string.Format("Customer {0}: Is Not Active!", i - BarbersCount);
                }

                timer1.Start();

                smBarbers = new Semaphore(0, BarbersCount);
                smCustomers = new Semaphore(0, CustomersCount);
                smMutex = new Semaphore(1, 1);

                btnStartStop.Enabled = false;
                
                trdBarbers = new Thread[BarbersCount];

                for (int i = 0; i < BarbersCount; i++)
                {
                    trdBarbers[i] = new Thread(FThreadBarber);
                    trdBarbers[i].Name = string.Format("{0}", i.ToString());
                    trdBarbers[i].Start();
                }

                trdCustomers = new Thread[CustomersCount];
                for (int i = 0; i < CustomersCount; i++)
                {
                    trdCustomers[i] = new Thread(FThreadCustomer);
                    trdCustomers[i].Name = string.Format("{0}", i.ToString());
                    trdCustomers[i].Start();
                    Thread.Sleep(rnd.Next(150));
                }
            }
        }

        private void trackBarHairCutTime_ValueChanged(object sender, EventArgs e)
        {
            txtMaxDurationOfHaircutTime.Text = trackBarHairCutTime.Value.ToString();
        }

        private void trackBarLongHairTime_ValueChanged(object sender, EventArgs e)
        {
            txtMaxDurationOfHaircutTime.Text = trackBarHairCutTime.Value.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(-1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ShowStates();
        }

        #endregion /Events

        #region Methods

        void FThreadBarber()
        {
            while (true)
            {
                int barberId = Int32.Parse(Thread.CurrentThread.Name);

                smCustomers.WaitOne();
                smMutex.WaitOne();

                WaitingChairsCount--;

                states[barberId] = string.Format("Barber {0}: Has a customer.", Thread.CurrentThread.Name);

                Thread.Sleep(MinHaircutTime + rnd.Next(MaxDurationOfHaircutTime));

                states[barberId] = string.Format("Barber {0}: Finished the hair cut.", Thread.CurrentThread.Name);
                smBarbers.Release();
                smMutex.Release();
            }
        }

        void FThreadCustomer()
        {
            while (true)
            {
                smMutex.WaitOne();
                int customerId = Int32.Parse(Thread.CurrentThread.Name);
                states[customerId + BarbersCount] = string.Format("Customer {0}: Enters the barber shop.", Thread.CurrentThread.Name);
                if (WaitingChairsCount < TotalChairsCount)
                {
                    states[customerId + BarbersCount] = string.Format("Customer {0}: Check the barber to be free and wait for it.", Thread.CurrentThread.Name);
                    WaitingChairsCount++;
                    smCustomers.Release();
                    smMutex.Release();
                    smBarbers.WaitOne();
                    states[customerId + BarbersCount] = string.Format("Customer {0}: Wait to hair cut is finished.", Thread.CurrentThread.Name);
                }
                else
                {
                    smMutex.Release();
                }
                states[customerId + BarbersCount] = string.Format("Customer {0}: Hair cut is done.", Thread.CurrentThread.Name);
                Thread.Sleep(MinLongHairTime + rnd.Next(MaxDurationOfLongHairTime));
            }
        }

        void ShowStates()
        {
            listBoxReport.Items.Clear();
            for (int i = 0; i < BarbersCount + CustomersCount; i++)
            {
                listBoxReport.Items.Insert(i, states[i]);
            }
        }

        #endregion /Methods
    }
}