namespace RaceCondtion4nThread
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBoxNMThreads = new System.Windows.Forms.TextBox();
            this.btnAddThread = new System.Windows.Forms.Button();
            this.btnRemoveThread = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNMThreads = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 303);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Threads in Begining";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(167, 313);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBoxNMThreads
            // 
            this.txtBoxNMThreads.Location = new System.Drawing.Point(11, 326);
            this.txtBoxNMThreads.Name = "txtBoxNMThreads";
            this.txtBoxNMThreads.Size = new System.Drawing.Size(50, 20);
            this.txtBoxNMThreads.TabIndex = 3;
            this.txtBoxNMThreads.Text = "5";
            // 
            // btnAddThread
            // 
            this.btnAddThread.Location = new System.Drawing.Point(11, 351);
            this.btnAddThread.Name = "btnAddThread";
            this.btnAddThread.Size = new System.Drawing.Size(94, 28);
            this.btnAddThread.TabIndex = 4;
            this.btnAddThread.Text = "Add Thread";
            this.btnAddThread.UseVisualStyleBackColor = true;
            this.btnAddThread.Click += new System.EventHandler(this.btnAddThread_Click);
            // 
            // btnRemoveThread
            // 
            this.btnRemoveThread.Location = new System.Drawing.Point(111, 352);
            this.btnRemoveThread.Name = "btnRemoveThread";
            this.btnRemoveThread.Size = new System.Drawing.Size(94, 26);
            this.btnRemoveThread.TabIndex = 5;
            this.btnRemoveThread.Text = "Remove Thread";
            this.btnRemoveThread.UseVisualStyleBackColor = true;
            this.btnRemoveThread.Click += new System.EventHandler(this.btnRemoveThread_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NM Threads";
            // 
            // lblNMThreads
            // 
            this.lblNMThreads.AutoSize = true;
            this.lblNMThreads.Location = new System.Drawing.Point(277, 359);
            this.lblNMThreads.Name = "lblNMThreads";
            this.lblNMThreads.Size = new System.Drawing.Size(13, 13);
            this.lblNMThreads.TabIndex = 7;
            this.lblNMThreads.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 388);
            this.Controls.Add(this.lblNMThreads);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRemoveThread);
            this.Controls.Add(this.btnAddThread);
            this.Controls.Add(this.txtBoxNMThreads);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBoxNMThreads;
        private System.Windows.Forms.Button btnAddThread;
        private System.Windows.Forms.Button btnRemoveThread;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNMThreads;
    }
}

