﻿namespace chu_ki_rsa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSHA1 = new System.Windows.Forms.TextBox();
            this.txtSHA2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtq = new System.Windows.Forms.TextBox();
            this.txte = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btntaokhoa = new System.Windows.Forms.Button();
            this.btntaokhoamoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_banma = new System.Windows.Forms.TextBox();
            this.txt_banro = new System.Windows.Forms.TextBox();
            this.txt_ma_ban_ma = new System.Windows.Forms.TextBox();
            this.btnmahoa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ma_ban_ro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_banro2 = new System.Windows.Forms.TextBox();
            this.txt_giaima = new System.Windows.Forms.TextBox();
            this.txt_banma2 = new System.Windows.Forms.TextBox();
            this.btngiaima = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_ma_giai_ma = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnmahoamoi = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.btnkhoatudongmoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFile.ForeColor = System.Drawing.Color.Black;
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFile.Location = new System.Drawing.Point(92, 28);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(86, 33);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Open File";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "HashFuntion (sha1)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSHA1
            // 
            this.txtSHA1.Location = new System.Drawing.Point(163, 25);
            this.txtSHA1.Multiline = true;
            this.txtSHA1.Name = "txtSHA1";
            this.txtSHA1.Size = new System.Drawing.Size(100, 20);
            this.txtSHA1.TabIndex = 2;
            this.txtSHA1.TextChanged += new System.EventHandler(this.txtSHA1_TextChanged);
            // 
            // txtSHA2
            // 
            this.txtSHA2.Location = new System.Drawing.Point(377, 25);
            this.txtSHA2.Name = "txtSHA2";
            this.txtSHA2.Size = new System.Drawing.Size(100, 20);
            this.txtSHA2.TabIndex = 2;
            this.txtSHA2.TextChanged += new System.EventHandler(this.txtSHA2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(298, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "===>";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(79, 28);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 18);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tùy Chọn";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(249, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 18);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tự Động";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(79, 75);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(76, 21);
            this.txtp.TabIndex = 4;
            this.txtp.TextChanged += new System.EventHandler(this.txtp_TextChanged);
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(79, 123);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(76, 21);
            this.txtn.TabIndex = 4;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(79, 173);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(76, 21);
            this.txtn2.TabIndex = 4;
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(258, 75);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(76, 21);
            this.txtq.TabIndex = 4;
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(258, 123);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(76, 21);
            this.txte.TabIndex = 4;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(258, 173);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(76, 21);
            this.txtd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "p =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "n =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "phi-n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(197, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "q =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(197, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "e =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(197, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "d =";
            // 
            // btntaokhoa
            // 
            this.btntaokhoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntaokhoa.Image = ((System.Drawing.Image)(resources.GetObject("btntaokhoa.Image")));
            this.btntaokhoa.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btntaokhoa.Location = new System.Drawing.Point(68, 210);
            this.btntaokhoa.Name = "btntaokhoa";
            this.btntaokhoa.Size = new System.Drawing.Size(87, 30);
            this.btntaokhoa.TabIndex = 5;
            this.btntaokhoa.Text = "Tạo Khóa";
            this.btntaokhoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntaokhoa.UseVisualStyleBackColor = true;
            this.btntaokhoa.Click += new System.EventHandler(this.btntaokhoa_Click);
            // 
            // btntaokhoamoi
            // 
            this.btntaokhoamoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntaokhoamoi.Image = ((System.Drawing.Image)(resources.GetObject("btntaokhoamoi.Image")));
            this.btntaokhoamoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaokhoamoi.Location = new System.Drawing.Point(220, 210);
            this.btntaokhoamoi.Name = "btntaokhoamoi";
            this.btntaokhoamoi.Size = new System.Drawing.Size(114, 30);
            this.btntaokhoamoi.TabIndex = 5;
            this.btntaokhoamoi.Text = "Nhập khóa mới";
            this.btntaokhoamoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntaokhoamoi.UseVisualStyleBackColor = true;
            this.btntaokhoamoi.Click += new System.EventHandler(this.btntaokhoamoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtq);
            this.groupBox1.Controls.Add(this.btntaokhoamoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnkhoatudongmoi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btntaokhoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtn2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txte);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtn);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.txtp);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 271);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo Khóa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.groupBox2.Controls.Add(this.txt_banma);
            this.groupBox2.Controls.Add(this.txt_banro);
            this.groupBox2.Controls.Add(this.txt_ma_ban_ma);
            this.groupBox2.Controls.Add(this.btnmahoa);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_ma_ban_ro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btnFile);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(401, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 271);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã hóa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_banma
            // 
            this.txt_banma.Location = new System.Drawing.Point(92, 127);
            this.txt_banma.Name = "txt_banma";
            this.txt_banma.Size = new System.Drawing.Size(102, 21);
            this.txt_banma.TabIndex = 4;
            // 
            // txt_banro
            // 
            this.txt_banro.Location = new System.Drawing.Point(92, 75);
            this.txt_banro.Name = "txt_banro";
            this.txt_banro.Size = new System.Drawing.Size(102, 21);
            this.txt_banro.TabIndex = 4;
            // 
            // txt_ma_ban_ma
            // 
            this.txt_ma_ban_ma.Enabled = false;
            this.txt_ma_ban_ma.Location = new System.Drawing.Point(92, 154);
            this.txt_ma_ban_ma.Name = "txt_ma_ban_ma";
            this.txt_ma_ban_ma.Size = new System.Drawing.Size(102, 21);
            this.txt_ma_ban_ma.TabIndex = 4;
            // 
            // btnmahoa
            // 
            this.btnmahoa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnmahoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmahoa.ForeColor = System.Drawing.Color.Black;
            this.btnmahoa.Image = ((System.Drawing.Image)(resources.GetObject("btnmahoa.Image")));
            this.btnmahoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmahoa.Location = new System.Drawing.Point(92, 212);
            this.btnmahoa.Name = "btnmahoa";
            this.btnmahoa.Size = new System.Drawing.Size(86, 33);
            this.btnmahoa.TabIndex = 5;
            this.btnmahoa.Text = "Mã hóa";
            this.btnmahoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmahoa.UseVisualStyleBackColor = false;
            this.btnmahoa.Click += new System.EventHandler(this.btnmahoa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 14);
            this.label10.TabIndex = 1;
            this.label10.Text = "Bản Mã Hóa";
            // 
            // txt_ma_ban_ro
            // 
            this.txt_ma_ban_ro.Enabled = false;
            this.txt_ma_ban_ro.Location = new System.Drawing.Point(92, 100);
            this.txt_ma_ban_ro.Name = "txt_ma_ban_ro";
            this.txt_ma_ban_ro.Size = new System.Drawing.Size(102, 21);
            this.txt_ma_ban_ro.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 14);
            this.label9.TabIndex = 1;
            this.label9.Text = "Bản Rõ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txt_banro2);
            this.groupBox3.Controls.Add(this.txt_giaima);
            this.groupBox3.Controls.Add(this.txt_banma2);
            this.groupBox3.Controls.Add(this.btngiaima);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txt_ma_giai_ma);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(726, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 271);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giải Mã";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(106, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Open File";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_banro2
            // 
            this.txt_banro2.Location = new System.Drawing.Point(106, 70);
            this.txt_banro2.Name = "txt_banro2";
            this.txt_banro2.Size = new System.Drawing.Size(102, 21);
            this.txt_banro2.TabIndex = 4;
            // 
            // txt_giaima
            // 
            this.txt_giaima.Location = new System.Drawing.Point(106, 175);
            this.txt_giaima.Name = "txt_giaima";
            this.txt_giaima.Size = new System.Drawing.Size(102, 21);
            this.txt_giaima.TabIndex = 4;
            // 
            // txt_banma2
            // 
            this.txt_banma2.Location = new System.Drawing.Point(106, 123);
            this.txt_banma2.Name = "txt_banma2";
            this.txt_banma2.Size = new System.Drawing.Size(102, 21);
            this.txt_banma2.TabIndex = 4;
            // 
            // btngiaima
            // 
            this.btngiaima.BackColor = System.Drawing.Color.Transparent;
            this.btngiaima.ForeColor = System.Drawing.Color.Black;
            this.btngiaima.Image = ((System.Drawing.Image)(resources.GetObject("btngiaima.Image")));
            this.btngiaima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngiaima.Location = new System.Drawing.Point(106, 210);
            this.btngiaima.Name = "btngiaima";
            this.btngiaima.Size = new System.Drawing.Size(90, 36);
            this.btngiaima.TabIndex = 5;
            this.btngiaima.Text = "Giải Mã";
            this.btngiaima.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btngiaima.UseVisualStyleBackColor = false;
            this.btngiaima.Click += new System.EventHandler(this.btngiaima_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 14);
            this.label11.TabIndex = 1;
            this.label11.Text = "Bản Mã Hóa";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 14);
            this.label21.TabIndex = 1;
            this.label21.Text = "Bản Rõ";
            // 
            // txt_ma_giai_ma
            // 
            this.txt_ma_giai_ma.Enabled = false;
            this.txt_ma_giai_ma.Location = new System.Drawing.Point(208, 175);
            this.txt_ma_giai_ma.Name = "txt_ma_giai_ma";
            this.txt_ma_giai_ma.Size = new System.Drawing.Size(102, 21);
            this.txt_ma_giai_ma.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 182);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 14);
            this.label12.TabIndex = 1;
            this.label12.Text = "Giải Mã";
            // 
            // btnmahoamoi
            // 
            this.btnmahoamoi.BackColor = System.Drawing.Color.Transparent;
            this.btnmahoamoi.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmahoamoi.ForeColor = System.Drawing.Color.Black;
            this.btnmahoamoi.Image = ((System.Drawing.Image)(resources.GetObject("btnmahoamoi.Image")));
            this.btnmahoamoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmahoamoi.Location = new System.Drawing.Point(547, 12);
            this.btnmahoamoi.Name = "btnmahoamoi";
            this.btnmahoamoi.Size = new System.Drawing.Size(80, 33);
            this.btnmahoamoi.TabIndex = 9;
            this.btnmahoamoi.Text = "Reset";
            this.btnmahoamoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmahoamoi.UseVisualStyleBackColor = false;
            this.btnmahoamoi.Click += new System.EventHandler(this.btnmahoamoi_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(378, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "Chữ kí điện tử RSA";
            this.label13.MouseHover += new System.EventHandler(this.label13_MouseHover);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(28, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(178, 15);
            this.label14.TabIndex = 11;
            this.label14.Text = "GVHD: PGS.TS Đỗ Trọng Tuấn";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(289, 383);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "SV Thực Hiện:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(421, 418);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 15);
            this.label16.TabIndex = 11;
            this.label16.Text = "Nguyễn Long Thủy";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(421, 453);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "Nguyễn Văn Tuấn";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(421, 490);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 15);
            this.label18.TabIndex = 11;
            this.label18.Text = "Nguyễn Đình Cảnh";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(421, 526);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 15);
            this.label19.TabIndex = 11;
            this.label19.Text = "Lê Công Thịnh";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(421, 383);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 15);
            this.label20.TabIndex = 13;
            this.label20.Text = "Đỗ Vũ Thanh Hiền";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(957, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exit";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Snow;
            this.label22.Location = new System.Drawing.Point(388, 9);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 16);
            this.label22.TabIndex = 15;
            this.label22.Text = "Hashcode";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // btnkhoatudongmoi
            // 
            this.btnkhoatudongmoi.ForeColor = System.Drawing.Color.Black;
            this.btnkhoatudongmoi.Location = new System.Drawing.Point(240, 210);
            this.btnkhoatudongmoi.Name = "btnkhoatudongmoi";
            this.btnkhoatudongmoi.Size = new System.Drawing.Size(94, 23);
            this.btnkhoatudongmoi.TabIndex = 5;
            this.btnkhoatudongmoi.Text = "Lấy khóa mới";
            this.btnkhoatudongmoi.UseVisualStyleBackColor = true;
            this.btnkhoatudongmoi.Click += new System.EventHandler(this.btnkhoatudongmoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 548);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnmahoamoi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSHA2);
            this.Controls.Add(this.txtSHA1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mã Hóa RSA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSHA1;
        private System.Windows.Forms.TextBox txtSHA2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btntaokhoa;
        private System.Windows.Forms.Button btntaokhoamoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_banma;
        private System.Windows.Forms.TextBox txt_banro;
        private System.Windows.Forms.TextBox txt_ma_ban_ma;
        private System.Windows.Forms.Button btnmahoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_ma_ban_ro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_giaima;
        private System.Windows.Forms.TextBox txt_banma2;
        private System.Windows.Forms.Button btngiaima;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ma_giai_ma;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnmahoamoi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_banro2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnkhoatudongmoi;
    }
}

