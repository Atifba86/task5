namespace Sendmailz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.TBHour = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TBMinu = new System.Windows.Forms.TextBox();
            this.TBSeco = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NUDHor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDSec = new System.Windows.Forms.NumericUpDown();
            this.AlarmTog = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBLSC = new System.Windows.Forms.CheckBox();
            this.TBSMTP = new System.Windows.Forms.TextBox();
            this.TBPORT = new System.Windows.Forms.TextBox();
            this.TBID = new System.Windows.Forms.TextBox();
            this.MBTPASS = new System.Windows.Forms.MaskedTextBox();
            this.CBSSL = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RTBBODY = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TBSUBJECT = new System.Windows.Forms.TextBox();
            this.TBFROM = new System.Windows.Forms.TextBox();
            this.TBTO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TBAKA = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSec)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBHour
            // 
            this.TBHour.Location = new System.Drawing.Point(6, 19);
            this.TBHour.Name = "TBHour";
            this.TBHour.Size = new System.Drawing.Size(29, 21);
            this.TBHour.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TBMinu
            // 
            this.TBMinu.Location = new System.Drawing.Point(50, 19);
            this.TBMinu.Name = "TBMinu";
            this.TBMinu.Size = new System.Drawing.Size(29, 21);
            this.TBMinu.TabIndex = 2;
            // 
            // TBSeco
            // 
            this.TBSeco.Location = new System.Drawing.Point(96, 19);
            this.TBSeco.Name = "TBSeco";
            this.TBSeco.Size = new System.Drawing.Size(29, 21);
            this.TBSeco.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBHour);
            this.groupBox1.Controls.Add(this.TBSeco);
            this.groupBox1.Controls.Add(this.TBMinu);
            this.groupBox1.Location = new System.Drawing.Point(4, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 50);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = ":";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NUDHor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NUDMin);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NUDSec);
            this.groupBox2.Location = new System.Drawing.Point(140, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 50);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Timer";
            // 
            // NUDHor
            // 
            this.NUDHor.Location = new System.Drawing.Point(10, 19);
            this.NUDHor.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NUDHor.Name = "NUDHor";
            this.NUDHor.Size = new System.Drawing.Size(47, 21);
            this.NUDHor.TabIndex = 5;
            this.NUDHor.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // NUDMin
            // 
            this.NUDMin.Location = new System.Drawing.Point(71, 18);
            this.NUDMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUDMin.Name = "NUDMin";
            this.NUDMin.Size = new System.Drawing.Size(47, 21);
            this.NUDMin.TabIndex = 6;
            this.NUDMin.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // NUDSec
            // 
            this.NUDSec.Location = new System.Drawing.Point(134, 18);
            this.NUDSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NUDSec.Name = "NUDSec";
            this.NUDSec.Size = new System.Drawing.Size(47, 21);
            this.NUDSec.TabIndex = 6;
            this.NUDSec.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // AlarmTog
            // 
            this.AlarmTog.AutoSize = true;
            this.AlarmTog.Location = new System.Drawing.Point(251, 4);
            this.AlarmTog.Name = "AlarmTog";
            this.AlarmTog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AlarmTog.Size = new System.Drawing.Size(79, 16);
            this.AlarmTog.TabIndex = 5;
            this.AlarmTog.Text = "Timer ON";
            this.AlarmTog.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBLSC);
            this.groupBox3.Controls.Add(this.TBSMTP);
            this.groupBox3.Controls.Add(this.TBPORT);
            this.groupBox3.Controls.Add(this.TBID);
            this.groupBox3.Controls.Add(this.MBTPASS);
            this.groupBox3.Controls.Add(this.CBSSL);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(4, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 196);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Configuration";
            // 
            // CBLSC
            // 
            this.CBLSC.AutoSize = true;
            this.CBLSC.Location = new System.Drawing.Point(122, 95);
            this.CBLSC.Name = "CBLSC";
            this.CBLSC.Size = new System.Drawing.Size(159, 16);
            this.CBLSC.TabIndex = 9;
            this.CBLSC.Text = "LOCK SERVER CONFIG";
            this.CBLSC.UseVisualStyleBackColor = true;
            // 
            // TBSMTP
            // 
            this.TBSMTP.Location = new System.Drawing.Point(122, 27);
            this.TBSMTP.Name = "TBSMTP";
            this.TBSMTP.Size = new System.Drawing.Size(195, 21);
            this.TBSMTP.TabIndex = 8;
            // 
            // TBPORT
            // 
            this.TBPORT.Location = new System.Drawing.Point(122, 57);
            this.TBPORT.Name = "TBPORT";
            this.TBPORT.Size = new System.Drawing.Size(195, 21);
            this.TBPORT.TabIndex = 7;
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(122, 127);
            this.TBID.Name = "TBID";
            this.TBID.Size = new System.Drawing.Size(195, 21);
            this.TBID.TabIndex = 6;
            // 
            // MBTPASS
            // 
            this.MBTPASS.Location = new System.Drawing.Point(122, 157);
            this.MBTPASS.Name = "MBTPASS";
            this.MBTPASS.Size = new System.Drawing.Size(195, 21);
            this.MBTPASS.TabIndex = 5;
            // 
            // CBSSL
            // 
            this.CBSSL.AutoSize = true;
            this.CBSSL.Location = new System.Drawing.Point(9, 95);
            this.CBSSL.Name = "CBSSL";
            this.CBSSL.Size = new System.Drawing.Size(90, 16);
            this.CBSSL.TabIndex = 4;
            this.CBSSL.Text = "SSL Enable";
            this.CBSSL.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "PASSWORD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "PORT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "SMTP SERVER";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RTBBODY);
            this.groupBox4.Location = new System.Drawing.Point(344, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 235);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Message body";
            // 
            // RTBBODY
            // 
            this.RTBBODY.Location = new System.Drawing.Point(6, 15);
            this.RTBBODY.Name = "RTBBODY";
            this.RTBBODY.Size = new System.Drawing.Size(389, 214);
            this.RTBBODY.TabIndex = 0;
            this.RTBBODY.Text = "";
           // this.RTBBODY.TextChanged += new System.EventHandler(this.RTBBODY_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "FROM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(342, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "TO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(342, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "SUBJECT";
            // 
            // TBSUBJECT
            // 
            this.TBSUBJECT.Location = new System.Drawing.Point(408, 64);
            this.TBSUBJECT.Name = "TBSUBJECT";
            this.TBSUBJECT.Size = new System.Drawing.Size(336, 21);
            this.TBSUBJECT.TabIndex = 11;
            // 
            // TBFROM
            // 
            this.TBFROM.Location = new System.Drawing.Point(408, 4);
            this.TBFROM.Name = "TBFROM";
            this.TBFROM.Size = new System.Drawing.Size(178, 21);
            this.TBFROM.TabIndex = 11;
            // 
            // TBTO
            // 
            this.TBTO.Location = new System.Drawing.Point(408, 36);
            this.TBTO.Name = "TBTO";
            this.TBTO.Size = new System.Drawing.Size(336, 21);
            this.TBTO.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(592, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 12;
            this.label12.Text = "AKA";
            // 
            // TBAKA
            // 
            this.TBAKA.Location = new System.Drawing.Point(627, 4);
            this.TBAKA.Name = "TBAKA";
            this.TBAKA.Size = new System.Drawing.Size(118, 21);
            this.TBAKA.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 338);
            this.Controls.Add(this.TBAKA);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TBTO);
            this.Controls.Add(this.TBFROM);
            this.Controls.Add(this.TBSUBJECT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AlarmTog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDSec)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBHour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TBMinu;
        private System.Windows.Forms.TextBox TBSeco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NUDSec;
        private System.Windows.Forms.NumericUpDown NUDMin;
        private System.Windows.Forms.NumericUpDown NUDHor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox AlarmTog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CBSSL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBSMTP;
        private System.Windows.Forms.TextBox TBPORT;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.MaskedTextBox MBTPASS;
        private System.Windows.Forms.CheckBox CBLSC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBSUBJECT;
        private System.Windows.Forms.RichTextBox RTBBODY;
        private System.Windows.Forms.TextBox TBFROM;
        private System.Windows.Forms.TextBox TBTO;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBAKA;
    }
}

