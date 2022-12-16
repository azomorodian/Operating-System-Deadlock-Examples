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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNMCustomer = new System.Windows.Forms.TextBox();
            this.trackBarHairCutTime = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNMBarbers = new System.Windows.Forms.TextBox();
            this.listBoxReport = new System.Windows.Forms.ListBox();
            this.TxtHairCutTime = new System.Windows.Forms.TextBox();
            this.txtLongHairTM = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmptyChairs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHairCutTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
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
            // txtNMCustomer
            // 
            this.txtNMCustomer.Location = new System.Drawing.Point(117, 15);
            this.txtNMCustomer.Name = "txtNMCustomer";
            this.txtNMCustomer.Size = new System.Drawing.Size(46, 20);
            this.txtNMCustomer.TabIndex = 2;
            this.txtNMCustomer.Text = "10";
            // 
            // trackBarHairCutTime
            // 
            this.trackBarHairCutTime.Location = new System.Drawing.Point(12, 161);
            this.trackBarHairCutTime.Maximum = 400;
            this.trackBarHairCutTime.Name = "trackBarHairCutTime";
            this.trackBarHairCutTime.Size = new System.Drawing.Size(151, 45);
            this.trackBarHairCutTime.TabIndex = 3;
            this.trackBarHairCutTime.Value = 200;
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
            // txtNMBarbers
            // 
            this.txtNMBarbers.Location = new System.Drawing.Point(117, 44);
            this.txtNMBarbers.Name = "txtNMBarbers";
            this.txtNMBarbers.Size = new System.Drawing.Size(46, 20);
            this.txtNMBarbers.TabIndex = 7;
            this.txtNMBarbers.Text = "2";
            // 
            // listBoxReport
            // 
            this.listBoxReport.FormattingEnabled = true;
            this.listBoxReport.Location = new System.Drawing.Point(178, 12);
            this.listBoxReport.Name = "listBoxReport";
            this.listBoxReport.Size = new System.Drawing.Size(137, 329);
            this.listBoxReport.TabIndex = 8;
            // 
            // TxtHairCutTime
            // 
            this.TxtHairCutTime.Location = new System.Drawing.Point(117, 108);
            this.TxtHairCutTime.Name = "TxtHairCutTime";
            this.TxtHairCutTime.Size = new System.Drawing.Size(46, 20);
            this.TxtHairCutTime.TabIndex = 9;
            this.TxtHairCutTime.Text = "900";
            // 
            // txtLongHairTM
            // 
            this.txtLongHairTM.Location = new System.Drawing.Point(117, 211);
            this.txtLongHairTM.Name = "txtLongHairTM";
            this.txtLongHairTM.Size = new System.Drawing.Size(46, 20);
            this.txtLongHairTM.TabIndex = 10;
            this.txtLongHairTM.Text = "4500";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(15, 264);
            this.trackBar1.Maximum = 2000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(148, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 1000;
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
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(117, 134);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(46, 20);
            this.txtDuration.TabIndex = 14;
            this.txtDuration.Text = "200";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "1000";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 351);
            this.Controls.Add(this.txtEmptyChairs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtLongHairTM);
            this.Controls.Add(this.TxtHairCutTime);
            this.Controls.Add(this.listBoxReport);
            this.Controls.Add(this.txtNMBarbers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarHairCutTime);
            this.Controls.Add(this.txtNMCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sleeping Barber";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHairCutTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNMCustomer;
        private System.Windows.Forms.TrackBar trackBarHairCutTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNMBarbers;
        private System.Windows.Forms.ListBox listBoxReport;
        private System.Windows.Forms.TextBox TxtHairCutTime;
        private System.Windows.Forms.TextBox txtLongHairTM;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmptyChairs;
    }
}

