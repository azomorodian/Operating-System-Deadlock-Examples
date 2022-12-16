namespace ReadersWriters
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBNumbersInString = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBUpperBCWriters = new System.Windows.Forms.TextBox();
            this.txtBLowerBCWriters = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBNMWriters = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBNMReaders = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBUpperBCReaders = new System.Windows.Forms.TextBox();
            this.txtBLowerBCReaders = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPauseAll = new System.Windows.Forms.Button();
            this.btnPauseWriters = new System.Windows.Forms.Button();
            this.btnPauseReaders = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBDatsReaderNth = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtBDataReaderNth = new System.Windows.Forms.TextBox();
            this.listBFailedReaders = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialization";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtBNumbersInString);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtBUpperBCWriters);
            this.groupBox3.Controls.Add(this.txtBLowerBCWriters);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtBNMWriters);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 117);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Writers";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(152, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "times";
            // 
            // txtBNumbersInString
            // 
            this.txtBNumbersInString.Location = new System.Drawing.Point(153, 91);
            this.txtBNumbersInString.Name = "txtBNumbersInString";
            this.txtBNumbersInString.Size = new System.Drawing.Size(36, 20);
            this.txtBNumbersInString.TabIndex = 13;
            this.txtBNumbersInString.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "NM. of numbers in the string";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Max";
            // 
            // txtBUpperBCWriters
            // 
            this.txtBUpperBCWriters.Location = new System.Drawing.Point(107, 62);
            this.txtBUpperBCWriters.Name = "txtBUpperBCWriters";
            this.txtBUpperBCWriters.Size = new System.Drawing.Size(36, 20);
            this.txtBUpperBCWriters.TabIndex = 9;
            this.txtBUpperBCWriters.Text = "1100";
            // 
            // txtBLowerBCWriters
            // 
            this.txtBLowerBCWriters.Location = new System.Drawing.Point(35, 62);
            this.txtBLowerBCWriters.Name = "txtBLowerBCWriters";
            this.txtBLowerBCWriters.Size = new System.Drawing.Size(36, 20);
            this.txtBLowerBCWriters.TabIndex = 8;
            this.txtBLowerBCWriters.Text = "900";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Refresh data when loop is done";
            // 
            // txtBNMWriters
            // 
            this.txtBNMWriters.Location = new System.Drawing.Point(94, 13);
            this.txtBNMWriters.Name = "txtBNMWriters";
            this.txtBNMWriters.Size = new System.Drawing.Size(47, 20);
            this.txtBNMWriters.TabIndex = 4;
            this.txtBNMWriters.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NM. of Writers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtBNMReaders);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBUpperBCReaders);
            this.groupBox2.Controls.Add(this.txtBLowerBCReaders);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 91);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Readers";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(152, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "times";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Min";
            // 
            // txtBNMReaders
            // 
            this.txtBNMReaders.Location = new System.Drawing.Point(94, 13);
            this.txtBNMReaders.Name = "txtBNMReaders";
            this.txtBNMReaders.Size = new System.Drawing.Size(47, 20);
            this.txtBNMReaders.TabIndex = 6;
            this.txtBNMReaders.Text = "10";
            this.txtBNMReaders.TextChanged += new System.EventHandler(this.txtBNMReaders_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NM. of Readers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max";
            // 
            // txtBUpperBCReaders
            // 
            this.txtBUpperBCReaders.Location = new System.Drawing.Point(107, 64);
            this.txtBUpperBCReaders.Name = "txtBUpperBCReaders";
            this.txtBUpperBCReaders.Size = new System.Drawing.Size(36, 20);
            this.txtBUpperBCReaders.TabIndex = 2;
            this.txtBUpperBCReaders.Text = "600";
            // 
            // txtBLowerBCReaders
            // 
            this.txtBLowerBCReaders.Location = new System.Drawing.Point(35, 64);
            this.txtBLowerBCReaders.Name = "txtBLowerBCReaders";
            this.txtBLowerBCReaders.Size = new System.Drawing.Size(36, 20);
            this.txtBLowerBCReaders.TabIndex = 1;
            this.txtBLowerBCReaders.Text = "400";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Create new reader when loop is done";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnRun);
            this.groupBox4.Location = new System.Drawing.Point(231, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(122, 212);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control of Running";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPauseAll);
            this.groupBox5.Controls.Add(this.btnPauseWriters);
            this.groupBox5.Controls.Add(this.btnPauseReaders);
            this.groupBox5.Location = new System.Drawing.Point(7, 74);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(103, 133);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pause";
            // 
            // btnPauseAll
            // 
            this.btnPauseAll.Enabled = false;
            this.btnPauseAll.Location = new System.Drawing.Point(9, 95);
            this.btnPauseAll.Name = "btnPauseAll";
            this.btnPauseAll.Size = new System.Drawing.Size(88, 32);
            this.btnPauseAll.TabIndex = 3;
            this.btnPauseAll.Text = "All";
            this.btnPauseAll.UseVisualStyleBackColor = true;
            // 
            // btnPauseWriters
            // 
            this.btnPauseWriters.Enabled = false;
            this.btnPauseWriters.Location = new System.Drawing.Point(9, 57);
            this.btnPauseWriters.Name = "btnPauseWriters";
            this.btnPauseWriters.Size = new System.Drawing.Size(88, 32);
            this.btnPauseWriters.TabIndex = 2;
            this.btnPauseWriters.Text = "Writers";
            this.btnPauseWriters.UseVisualStyleBackColor = true;
            // 
            // btnPauseReaders
            // 
            this.btnPauseReaders.Enabled = false;
            this.btnPauseReaders.Location = new System.Drawing.Point(9, 17);
            this.btnPauseReaders.Name = "btnPauseReaders";
            this.btnPauseReaders.Size = new System.Drawing.Size(88, 32);
            this.btnPauseReaders.TabIndex = 0;
            this.btnPauseReaders.Text = "Readers";
            this.btnPauseReaders.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(10, 19);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 49);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBDatsReaderNth);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.txtBDataReaderNth);
            this.groupBox6.Controls.Add(this.listBFailedReaders);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(12, 258);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(341, 125);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Report";
            // 
            // listBDatsReaderNth
            // 
            this.listBDatsReaderNth.FormattingEnabled = true;
            this.listBDatsReaderNth.Items.AddRange(new object[] {
            "harchi"});
            this.listBDatsReaderNth.Location = new System.Drawing.Point(211, 36);
            this.listBDatsReaderNth.Name = "listBDatsReaderNth";
            this.listBDatsReaderNth.Size = new System.Drawing.Size(122, 82);
            this.listBDatsReaderNth.TabIndex = 21;
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(198, 8);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(8, 109);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // txtBDataReaderNth
            // 
            this.txtBDataReaderNth.Location = new System.Drawing.Point(295, 13);
            this.txtBDataReaderNth.Name = "txtBDataReaderNth";
            this.txtBDataReaderNth.Size = new System.Drawing.Size(36, 20);
            this.txtBDataReaderNth.TabIndex = 19;
            this.txtBDataReaderNth.Text = "0";
            this.txtBDataReaderNth.TextChanged += new System.EventHandler(this.textBDataReaderNth_TextChanged);
            // 
            // listBFailedReaders
            // 
            this.listBFailedReaders.FormattingEnabled = true;
            this.listBFailedReaders.Location = new System.Drawing.Point(6, 61);
            this.listBFailedReaders.Name = "listBFailedReaders";
            this.listBFailedReaders.Size = new System.Drawing.Size(189, 56);
            this.listBFailedReaders.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Failed Readers";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Data of Reader";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "NM. of failed Readers";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(231, 230);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(122, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 387);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.Name = "Form1";
            this.Text = "Readers Writers";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBNMWriters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBUpperBCReaders;
        private System.Windows.Forms.TextBox txtBLowerBCReaders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBNMReaders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPauseReaders;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBUpperBCWriters;
        private System.Windows.Forms.TextBox txtBLowerBCWriters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPauseAll;
        private System.Windows.Forms.Button btnPauseWriters;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBNumbersInString;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBFailedReaders;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBDataReaderNth;
        private System.Windows.Forms.ListBox listBDatsReaderNth;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

