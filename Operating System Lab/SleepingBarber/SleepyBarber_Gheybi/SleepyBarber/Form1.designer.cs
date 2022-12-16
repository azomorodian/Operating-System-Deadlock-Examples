namespace SleepyBarber
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomersCount = new System.Windows.Forms.TextBox();
            this.trackBarHairCutTime = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBarbersCount = new System.Windows.Forms.TextBox();
            this.listBoxReport = new System.Windows.Forms.ListBox();
            this.txtMinHaircutTime = new System.Windows.Forms.TextBox();
            this.txtMinLongHairTime = new System.Windows.Forms.TextBox();
            this.trackBarLongHairTime = new System.Windows.Forms.TrackBar();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxDurationOfHaircutTime = new System.Windows.Forms.TextBox();
            this.txtMaxDurationOfLongHairTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmptyChairs = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHairCutTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLongHairTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NM Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NM Barber";
            // 
            // txtCustomersCount
            // 
            this.txtCustomersCount.Location = new System.Drawing.Point(117, 15);
            this.txtCustomersCount.Name = "txtCustomersCount";
            this.txtCustomersCount.Size = new System.Drawing.Size(46, 20);
            this.txtCustomersCount.TabIndex = 2;
            this.txtCustomersCount.Text = "10";
            // 
            // trackBarHairCutTime
            // 
            this.trackBarHairCutTime.Location = new System.Drawing.Point(12, 161);
            this.trackBarHairCutTime.Maximum = 400;
            this.trackBarHairCutTime.Name = "trackBarHairCutTime";
            this.trackBarHairCutTime.Size = new System.Drawing.Size(151, 45);
            this.trackBarHairCutTime.TabIndex = 3;
            this.trackBarHairCutTime.Value = 200;
            this.trackBarHairCutTime.ValueChanged += new System.EventHandler(this.trackBarHairCutTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Min Haircut Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Min Long Hair Time";
            // 
            // txtBarbersCount
            // 
            this.txtBarbersCount.Location = new System.Drawing.Point(117, 44);
            this.txtBarbersCount.Name = "txtBarbersCount";
            this.txtBarbersCount.Size = new System.Drawing.Size(46, 20);
            this.txtBarbersCount.TabIndex = 7;
            this.txtBarbersCount.Text = "2";
            // 
            // listBoxReport
            // 
            this.listBoxReport.FormattingEnabled = true;
            this.listBoxReport.Location = new System.Drawing.Point(178, 12);
            this.listBoxReport.Name = "listBoxReport";
            this.listBoxReport.Size = new System.Drawing.Size(244, 329);
            this.listBoxReport.TabIndex = 8;
            // 
            // txtMinHaircutTime
            // 
            this.txtMinHaircutTime.Location = new System.Drawing.Point(117, 108);
            this.txtMinHaircutTime.Name = "txtMinHaircutTime";
            this.txtMinHaircutTime.Size = new System.Drawing.Size(46, 20);
            this.txtMinHaircutTime.TabIndex = 9;
            this.txtMinHaircutTime.Text = "900";
            // 
            // txtMinLongHairTime
            // 
            this.txtMinLongHairTime.Location = new System.Drawing.Point(117, 211);
            this.txtMinLongHairTime.Name = "txtMinLongHairTime";
            this.txtMinLongHairTime.Size = new System.Drawing.Size(46, 20);
            this.txtMinLongHairTime.TabIndex = 10;
            this.txtMinLongHairTime.Text = "4500";
            // 
            // trackBarLongHairTime
            // 
            this.trackBarLongHairTime.Location = new System.Drawing.Point(15, 264);
            this.trackBarLongHairTime.Maximum = 2000;
            this.trackBarLongHairTime.Name = "trackBarLongHairTime";
            this.trackBarLongHairTime.Size = new System.Drawing.Size(148, 45);
            this.trackBarLongHairTime.TabIndex = 11;
            this.trackBarLongHairTime.Value = 1000;
            this.trackBarLongHairTime.ValueChanged += new System.EventHandler(this.trackBarLongHairTime_ValueChanged);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(15, 308);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(148, 37);
            this.btnStartStop.TabIndex = 12;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Max Duration";
            // 
            // txtMaxDurationOfHaircutTime
            // 
            this.txtMaxDurationOfHaircutTime.Location = new System.Drawing.Point(117, 134);
            this.txtMaxDurationOfHaircutTime.Name = "txtMaxDurationOfHaircutTime";
            this.txtMaxDurationOfHaircutTime.Size = new System.Drawing.Size(46, 20);
            this.txtMaxDurationOfHaircutTime.TabIndex = 14;
            this.txtMaxDurationOfHaircutTime.Text = "200";
            // 
            // txtMaxDurationOfLongHairTime
            // 
            this.txtMaxDurationOfLongHairTime.Location = new System.Drawing.Point(117, 238);
            this.txtMaxDurationOfLongHairTime.Name = "txtMaxDurationOfLongHairTime";
            this.txtMaxDurationOfLongHairTime.Size = new System.Drawing.Size(46, 20);
            this.txtMaxDurationOfLongHairTime.TabIndex = 16;
            this.txtMaxDurationOfLongHairTime.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Max Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Empty Chairs";
            // 
            // txtEmptyChairs
            // 
            this.txtEmptyChairs.Location = new System.Drawing.Point(117, 72);
            this.txtEmptyChairs.Name = "txtEmptyChairs";
            this.txtEmptyChairs.Size = new System.Drawing.Size(46, 20);
            this.txtEmptyChairs.TabIndex = 19;
            this.txtEmptyChairs.Text = "5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 351);
            this.Controls.Add(this.txtEmptyChairs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaxDurationOfLongHairTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxDurationOfHaircutTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.trackBarLongHairTime);
            this.Controls.Add(this.txtMinLongHairTime);
            this.Controls.Add(this.txtMinHaircutTime);
            this.Controls.Add(this.listBoxReport);
            this.Controls.Add(this.txtBarbersCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarHairCutTime);
            this.Controls.Add(this.txtCustomersCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sleeping Barber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHairCutTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLongHairTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomersCount;
        private System.Windows.Forms.TrackBar trackBarHairCutTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBarbersCount;
        private System.Windows.Forms.ListBox listBoxReport;
        private System.Windows.Forms.TextBox txtMinHaircutTime;
        private System.Windows.Forms.TextBox txtMinLongHairTime;
        private System.Windows.Forms.TrackBar trackBarLongHairTime;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaxDurationOfHaircutTime;
        private System.Windows.Forms.TextBox txtMaxDurationOfLongHairTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmptyChairs;
        private System.Windows.Forms.Timer timer1;
    }
}

