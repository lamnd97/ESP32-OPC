namespace WindowsFormsApp1
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
            this.btCon = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.btLed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbbutton = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.vscroll1 = new System.Windows.Forms.VScrollBar();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.btOff1 = new System.Windows.Forms.Button();
            this.btOn1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btOff = new System.Windows.Forms.Button();
            this.btOn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.btDis = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCon
            // 
            this.btCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCon.ForeColor = System.Drawing.Color.Green;
            this.btCon.Location = new System.Drawing.Point(14, 15);
            this.btCon.Margin = new System.Windows.Forms.Padding(2);
            this.btCon.Name = "btCon";
            this.btCon.Size = new System.Drawing.Size(100, 34);
            this.btCon.TabIndex = 0;
            this.btCon.Text = "Connect";
            this.btCon.UseVisualStyleBackColor = false;
            this.btCon.Click += new System.EventHandler(this.bt1_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(143, 73);
            this.tb1.Margin = new System.Windows.Forms.Padding(2);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(52, 20);
            this.tb1.TabIndex = 1;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(143, 104);
            this.tb2.Margin = new System.Windows.Forms.Padding(2);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(52, 20);
            this.tb2.TabIndex = 2;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(103, 136);
            this.tb3.Margin = new System.Windows.Forms.Padding(2);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(10, 20);
            this.tb3.TabIndex = 3;
            this.tb3.Visible = false;
            // 
            // btLed
            // 
            this.btLed.ForeColor = System.Drawing.Color.Green;
            this.btLed.Location = new System.Drawing.Point(143, 133);
            this.btLed.Margin = new System.Windows.Forms.Padding(2);
            this.btLed.Name = "btLed";
            this.btLed.Size = new System.Drawing.Size(66, 25);
            this.btLed.TabIndex = 4;
            this.btLed.Text = "On";
            this.btLed.UseVisualStyleBackColor = true;
            this.btLed.Click += new System.EventHandler(this.btLed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Automation Lab - MSST2021";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(310, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 111);
            this.panel2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(169, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Duong Quoc Anh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nguyen Dong Lam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Le Duy Can";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Group member:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lecturer:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.lbbutton);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.tb1);
            this.panel3.Controls.Add(this.tb2);
            this.panel3.Controls.Add(this.btLed);
            this.panel3.Controls.Add(this.tb3);
            this.panel3.Location = new System.Drawing.Point(3, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 211);
            this.panel3.TabIndex = 9;
            // 
            // lbbutton
            // 
            this.lbbutton.AutoSize = true;
            this.lbbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbutton.ForeColor = System.Drawing.Color.Red;
            this.lbbutton.Location = new System.Drawing.Point(139, 165);
            this.lbbutton.Name = "lbbutton";
            this.lbbutton.Size = new System.Drawing.Size(18, 20);
            this.lbbutton.TabIndex = 13;
            this.lbbutton.Text = "0";
            this.lbbutton.TextChanged += new System.EventHandler(this.lbbutton_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(10, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Built-in Led";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(10, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "MB-Register1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(10, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "MB-Register0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(55, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "ESP32";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tb7);
            this.panel4.Controls.Add(this.tb6);
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.vscroll1);
            this.panel4.Controls.Add(this.tb5);
            this.panel4.Controls.Add(this.btOff1);
            this.panel4.Controls.Add(this.btOn1);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.pb1);
            this.panel4.Controls.Add(this.btOff);
            this.panel4.Controls.Add(this.btOn);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.tb4);
            this.panel4.Location = new System.Drawing.Point(250, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 211);
            this.panel4.TabIndex = 10;
            // 
            // tb7
            // 
            this.tb7.Location = new System.Drawing.Point(395, 97);
            this.tb7.Margin = new System.Windows.Forms.Padding(2);
            this.tb7.Name = "tb7";
            this.tb7.Size = new System.Drawing.Size(10, 20);
            this.tb7.TabIndex = 22;
            this.tb7.Visible = false;
            this.tb7.TextChanged += new System.EventHandler(this.tb7_TextChanged);
            // 
            // tb6
            // 
            this.tb6.Location = new System.Drawing.Point(395, 73);
            this.tb6.Margin = new System.Windows.Forms.Padding(2);
            this.tb6.Name = "tb6";
            this.tb6.Size = new System.Drawing.Size(24, 20);
            this.tb6.TabIndex = 21;
            this.tb6.Visible = false;
            this.tb6.TextChanged += new System.EventHandler(this.tb6_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(189, 73);
            this.progressBar1.Maximum = 28;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(180, 80);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 20;
            // 
            // vscroll1
            // 
            this.vscroll1.LargeChange = 2;
            this.vscroll1.Location = new System.Drawing.Point(372, 73);
            this.vscroll1.Maximum = 10;
            this.vscroll1.Name = "vscroll1";
            this.vscroll1.Size = new System.Drawing.Size(17, 80);
            this.vscroll1.TabIndex = 19;
            this.vscroll1.Value = 10;
            this.vscroll1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vscroll1_Scroll);
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(189, 48);
            this.tb5.Margin = new System.Windows.Forms.Padding(2);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(10, 20);
            this.tb5.TabIndex = 18;
            this.tb5.Visible = false;
            this.tb5.TextChanged += new System.EventHandler(this.tb5_TextChanged);
            // 
            // btOff1
            // 
            this.btOff1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btOff1.Location = new System.Drawing.Point(281, 158);
            this.btOff1.Margin = new System.Windows.Forms.Padding(2);
            this.btOff1.Name = "btOff1";
            this.btOff1.Size = new System.Drawing.Size(88, 27);
            this.btOff1.TabIndex = 17;
            this.btOff1.Text = "Off";
            this.btOff1.UseVisualStyleBackColor = true;
            this.btOff1.Click += new System.EventHandler(this.btOff1_Click);
            // 
            // btOn1
            // 
            this.btOn1.ForeColor = System.Drawing.Color.Green;
            this.btOn1.Location = new System.Drawing.Point(187, 158);
            this.btOn1.Margin = new System.Windows.Forms.Padding(2);
            this.btOn1.Name = "btOn1";
            this.btOn1.Size = new System.Drawing.Size(88, 27);
            this.btOn1.TabIndex = 16;
            this.btOn1.Text = "On";
            this.btOn1.UseVisualStyleBackColor = true;
            this.btOn1.Click += new System.EventHandler(this.btOn1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(230, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Water Pump";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(284, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 15;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(3, 73);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(180, 80);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 14;
            this.pb1.TabStop = false;
            // 
            // btOff
            // 
            this.btOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btOff.Location = new System.Drawing.Point(95, 160);
            this.btOff.Margin = new System.Windows.Forms.Padding(2);
            this.btOff.Name = "btOff";
            this.btOff.Size = new System.Drawing.Size(88, 27);
            this.btOff.TabIndex = 13;
            this.btOff.Text = "Off";
            this.btOff.UseVisualStyleBackColor = true;
            this.btOff.Click += new System.EventHandler(this.btOff_Click);
            // 
            // btOn
            // 
            this.btOn.ForeColor = System.Drawing.Color.Green;
            this.btOn.Location = new System.Drawing.Point(2, 160);
            this.btOn.Margin = new System.Windows.Forms.Padding(2);
            this.btOn.Name = "btOn";
            this.btOn.Size = new System.Drawing.Size(88, 27);
            this.btOn.TabIndex = 12;
            this.btOn.Text = "On";
            this.btOn.UseVisualStyleBackColor = true;
            this.btOn.Click += new System.EventHandler(this.btOn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(47, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "Seperator";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(138, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 37);
            this.label15.TabIndex = 0;
            this.label15.Text = "S7-300";
            // 
            // tb4
            // 
            this.tb4.Location = new System.Drawing.Point(2, 48);
            this.tb4.Margin = new System.Windows.Forms.Padding(2);
            this.tb4.Name = "tb4";
            this.tb4.Size = new System.Drawing.Size(10, 20);
            this.tb4.TabIndex = 1;
            this.tb4.Visible = false;
            this.tb4.TextChanged += new System.EventHandler(this.tb4_TextChanged);
            // 
            // btDis
            // 
            this.btDis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btDis.Location = new System.Drawing.Point(118, 15);
            this.btDis.Margin = new System.Windows.Forms.Padding(2);
            this.btDis.Name = "btDis";
            this.btDis.Size = new System.Drawing.Size(100, 34);
            this.btDis.TabIndex = 11;
            this.btDis.Text = "Disconnect";
            this.btDis.UseVisualStyleBackColor = false;
            this.btDis.Click += new System.EventHandler(this.btDis_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btCon);
            this.panel5.Controls.Add(this.btDis);
            this.panel5.Location = new System.Drawing.Point(3, 356);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(230, 103);
            this.panel5.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(118, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 92);
            this.label1.TabIndex = 5;
            this.label1.Text = "S7-300 communicate ESP32 \r\n              via Kepware\r\n";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(688, 254);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(10, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Push Button";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "OPC-UA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCon;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Button btLed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btDis;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btOff;
        private System.Windows.Forms.Button btOn;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Button btOff1;
        private System.Windows.Forms.Button btOn1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vscroll1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbbutton;
        private System.Windows.Forms.Label label16;
    }
}

