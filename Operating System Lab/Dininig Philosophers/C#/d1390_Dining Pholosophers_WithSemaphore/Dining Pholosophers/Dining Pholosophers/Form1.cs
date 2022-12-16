﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Diagnostics;


namespace Dining_Pholosophers
{
    public partial class Form1 : Form
    {
        static int iNMPhil = 8;
        SolidBrush[] aPhilosopherColor = new SolidBrush[iNMPhil];
        SolidBrush SolidBrushOnTableFork = new SolidBrush(Color.FromArgb(120, 120, 120));
        SolidBrush[] aForkColor = new SolidBrush[iNMPhil];
        Semaphore[] aSemFork = new Semaphore[iNMPhil];
        struct structForkPos
        {
            public int iXPos;
            public int iYPos;
        }
        structForkPos[] aStructForkPos = new structForkPos[iNMPhil];
        Thread[] ThrdPhilosophers = new Thread[iNMPhil];

        bool bCloseForm = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            for (int i = 0; i < iNMPhil; i++)
            {
                aPhilosopherColor[i] = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
                aForkColor[i] = new SolidBrush(SolidBrushOnTableFork.Color);
            }
        }        

        private void Form1_Shown(object sender, EventArgs e)
        {
            putPlatesAndForks();
            
            for (int i = 0; i < iNMPhil; i++)
            {
                ThrdPhilosophers[i] = new Thread(ThreadPhilosopher);
                ThrdPhilosophers[i].Name = i.ToString();                

                aSemFork[i] = new Semaphore(1, 1);

                //Next line is Petty.
                semPhilStop4Resize[i] = new Semaphore(0, 1);
            }

            for (int i = 0; i < iNMPhil; i++)
                ThrdPhilosophers[i].Start();
        }

        Random r = new Random();
        void ThreadPhilosopher()
        {
            Thread.CurrentThread.IsBackground = true;
            int iID = Int16.Parse(Thread.CurrentThread.Name);
            while(!bCloseForm)
            {
                Graphics myGraphic = this.CreateGraphics();
                
                //think:
                Thread.Sleep(r.Next(5000));

                //Take first Fork:
                Boolean waitFork;
                do
                {
                    Thread.Sleep(r.Next(2));
                    //After Tanenbum's Code implementation, aSemFork should be removed
                    aSemFork[iID].WaitOne();
                    Thread.Sleep(r.Next(2));
                    waitFork = aForkColor[iID].Color != SolidBrushOnTableFork.Color;
                    Thread.Sleep(r.Next(2));
                    aSemFork[iID].Release();
                    Thread.Sleep(r.Next(2));
                } while (waitFork); //Wait Until the Fork is Released.
                
                Thread.Sleep(r.Next(2));
                //After Tanenbum's Code implementation, aSemFork should be removed
                aSemFork[iID].WaitOne();
                Thread.Sleep(r.Next(2));
                aForkColor[iID].Color= aPhilosopherColor[iID].Color; //The fork is seized.
                Thread.Sleep(r.Next(2));
                aSemFork[iID].Release();
                Thread.Sleep(r.Next(2));
                aSemFork[iID].WaitOne();
                Thread.Sleep(r.Next(2));
                myGraphic.FillRectangle(aForkColor[iID], aStructForkPos[iID].iXPos, aStructForkPos[iID].iYPos, shpWidth, shpHeight);
                Thread.Sleep(r.Next(2));
                aSemFork[iID].Release();
                Thread.Sleep(r.Next(2));

                //Uncomment next line to see the deadlock
                //Thread.Sleep(r.Next(5000)); 

                //Take Another Fork:
                int iIndex4NextFork = (iID - 1 + iNMPhil) % iNMPhil;                
                do
                {
                    //After Tanenbum's Code implementation, aSemFork should be removed
                    aSemFork[iIndex4NextFork].WaitOne();
                    Thread.Sleep(r.Next(2));
                    waitFork = aForkColor[iIndex4NextFork].Color != SolidBrushOnTableFork.Color;
                    Thread.Sleep(r.Next(2));
                    aSemFork[iIndex4NextFork].Release();
                    Thread.Sleep(r.Next(2));
                } while (waitFork); //Wait Until the Fork is Released.
                
                Thread.Sleep(r.Next(2));
                //After Tanenbum's Code implementation, aSemFork should be removed
                aSemFork[iIndex4NextFork].WaitOne();
                Thread.Sleep(r.Next(2));
                aForkColor[iIndex4NextFork].Color = aPhilosopherColor[iID].Color; //The fork is seized.
                Thread.Sleep(r.Next(2));
                aSemFork[iIndex4NextFork].Release();
                Thread.Sleep(r.Next(2));
                aSemFork[iIndex4NextFork].WaitOne();
                Thread.Sleep(r.Next(2));
                myGraphic.FillRectangle(aForkColor[iIndex4NextFork], aStructForkPos[iIndex4NextFork].iXPos, aStructForkPos[iIndex4NextFork].iYPos, shpWidth, shpHeight);
                Thread.Sleep(r.Next(2));
                aSemFork[iIndex4NextFork].Release();
                Thread.Sleep(r.Next(2));

                //Eat:
                Thread.Sleep(r.Next(1000));

                //Release First Fork
                Thread.Sleep(r.Next(2));
                //After Tanenbum's Code implementation, aSemFork should be removed
                aSemFork[iID].WaitOne();
                Thread.Sleep(r.Next(2));
                aForkColor[iID].Color= SolidBrushOnTableFork.Color;
                Thread.Sleep(r.Next(2));
                myGraphic.FillRectangle(aForkColor[iID], aStructForkPos[iID].iXPos, aStructForkPos[iID].iYPos, shpWidth, shpHeight);
                Thread.Sleep(r.Next(2));
                aSemFork[iID].Release();
                Thread.Sleep(r.Next(2));

                //Release Another Fork
                Thread.Sleep(r.Next(2));
                //After Tanenbum's Code implementation, aSemFork should be removed
                aSemFork[iIndex4NextFork].WaitOne();
                Thread.Sleep(r.Next(2));
                aForkColor[iIndex4NextFork].Color = SolidBrushOnTableFork.Color;
                Thread.Sleep(r.Next(2));
                myGraphic.FillRectangle(aForkColor[iIndex4NextFork], aStructForkPos[iIndex4NextFork].iXPos, aStructForkPos[iIndex4NextFork].iYPos, shpWidth, shpHeight);
                Thread.Sleep(r.Next(2));                
                aSemFork[iIndex4NextFork].Release();
                Thread.Sleep(r.Next(2));

                //Next if instruction is related to resize event and is unimportant.
                if (stop4Resize)
                {
                    iIStopped4Resize++;
                    if (iIStopped4Resize == iNMPhil)
                        semMainThrdWait4AllPhilStop.Release();
                    semPhilStop4Resize[iID].WaitOne();
                }
            }
        }

        //Next varibales are related to resize event and are unimportant.
        int iIStopped4Resize;
        bool stop4Resize = false;
        Semaphore[] semPhilStop4Resize = new Semaphore[iNMPhil];
        Semaphore semMainThrdWait4AllPhilStop = new Semaphore(0, 1);


        int shpWidth = 30;
        int shpHeight = 30;
        void putPlatesAndForks()
        {
            Graphics myGraphic = this.CreateGraphics();            
            
            int rx = this.Width/2 - shpWidth - 30;
            int ry = this.Height/2 - shpHeight -30;
            for (int i = 1; i <= iNMPhil; i++)
            {
                double dPosX = System.Math.Cos(2*System.Math.PI * i / iNMPhil) * rx;
                double dPosY = System.Math.Sin(2*System.Math.PI * i / iNMPhil) * ry;
                int iXCenter = (this.Width / 2 -shpWidth/2 -5) + Convert.ToInt16(dPosX);
                int iYCenter = (this.Height / 2 -shpHeight/2 - 17) + Convert.ToInt16(dPosY);
                myGraphic.FillEllipse(aPhilosopherColor[i - 1], iXCenter, iYCenter, shpWidth, shpHeight);
                dPosX = System.Math.Cos(2 * System.Math.PI * (i+0.5) / iNMPhil) * rx;
                dPosY = System.Math.Sin(2 * System.Math.PI * (i+0.5) / iNMPhil) * ry;
                aStructForkPos[i-1].iXPos = (this.Width / 2 - shpWidth / 2 - 5) + Convert.ToInt16(dPosX);
                aStructForkPos[i-1].iYPos = (this.Height / 2 - shpHeight / 2 - 17) + Convert.ToInt16(dPosY);
                myGraphic.FillRectangle(SolidBrushOnTableFork, aStructForkPos[i-1].iXPos, aStructForkPos[i-1].iYPos, shpWidth, shpHeight);
            }            
        }
        
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Refresh();
            putPlatesAndForks();
            stop4Resize = false;
            for (int i = 0; i < iNMPhil; i++)
                semPhilStop4Resize[i].Release();   
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            iIStopped4Resize = 0;
            stop4Resize = true;

            semMainThrdWait4AllPhilStop.WaitOne();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bCloseForm = true;
            for (int i = 0; i < iNMPhil; i++)
            {
                ThrdPhilosophers[i].Join();
            }
        }
        
    }

}
