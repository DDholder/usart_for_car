﻿namespace usart_tool
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxSerialPortName = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.Timerscanserial = new System.Windows.Forms.Timer(this.components);
            this.Sendline = new System.Windows.Forms.Button();
            this.Sendbox = new System.Windows.Forms.TextBox();
            this.receive_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Senddata = new System.Windows.Forms.Button();
            this.Resenddata = new System.Windows.Forms.Button();
            this.sendname4 = new System.Windows.Forms.TextBox();
            this.sendnum4 = new System.Windows.Forms.TextBox();
            this.sendID4 = new System.Windows.Forms.Label();
            this.sendname0 = new System.Windows.Forms.TextBox();
            this.sendnum3 = new System.Windows.Forms.TextBox();
            this.sendID0 = new System.Windows.Forms.Label();
            this.sendname1 = new System.Windows.Forms.TextBox();
            this.sendnum2 = new System.Windows.Forms.TextBox();
            this.sendID1 = new System.Windows.Forms.Label();
            this.sendname2 = new System.Windows.Forms.TextBox();
            this.sendnum1 = new System.Windows.Forms.TextBox();
            this.sendID2 = new System.Windows.Forms.Label();
            this.sendname3 = new System.Windows.Forms.TextBox();
            this.sendnum0 = new System.Windows.Forms.TextBox();
            this.sendID3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Enabledatashow = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.datatext4 = new System.Windows.Forms.TextBox();
            this.datatext9 = new System.Windows.Forms.TextBox();
            this.dataname0 = new System.Windows.Forms.Label();
            this.dataname9 = new System.Windows.Forms.Label();
            this.datatext0 = new System.Windows.Forms.TextBox();
            this.datatext8 = new System.Windows.Forms.TextBox();
            this.dataname1 = new System.Windows.Forms.Label();
            this.dataname8 = new System.Windows.Forms.Label();
            this.datatext1 = new System.Windows.Forms.TextBox();
            this.datatext7 = new System.Windows.Forms.TextBox();
            this.dataname2 = new System.Windows.Forms.Label();
            this.dataname7 = new System.Windows.Forms.Label();
            this.datatext2 = new System.Windows.Forms.TextBox();
            this.datatext6 = new System.Windows.Forms.TextBox();
            this.dataname3 = new System.Windows.Forms.Label();
            this.dataname6 = new System.Windows.Forms.Label();
            this.datatext3 = new System.Windows.Forms.TextBox();
            this.datatext5 = new System.Windows.Forms.TextBox();
            this.dataname4 = new System.Windows.Forms.Label();
            this.dataname5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkConnect = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PlayMode = new System.Windows.Forms.ComboBox();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ElecTrack2 = new System.Windows.Forms.TrackBar();
            this.ElecTrack1 = new System.Windows.Forms.TrackBar();
            this.UgDn = new System.Windows.Forms.Button();
            this.PnUp = new System.Windows.Forms.Button();
            this.ChartEng = new System.Windows.Forms.CheckBox();
            this.ImgEng = new System.Windows.Forms.CheckBox();
            this.play_pro = new System.Windows.Forms.Label();
            this.record_pro = new System.Windows.Forms.Label();
            this.play_bar = new System.Windows.Forms.TrackBar();
            this.Record = new System.Windows.Forms.Button();
            this.play_pause = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Record_timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Datatimer = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新配置文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开配置文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新生成配置文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记录文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存记录文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开记录文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.示波器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.label17 = new System.Windows.Forms.Label();
            this.backgroundWorker5 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker6 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker7 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker8 = new System.ComponentModel.BackgroundWorker();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox58 = new System.Windows.Forms.TextBox();
            this.textBox59 = new System.Windows.Forms.TextBox();
            this.textBox60 = new System.Windows.Forms.TextBox();
            this.textBox61 = new System.Windows.Forms.TextBox();
            this.textBox62 = new System.Windows.Forms.TextBox();
            this.textBox63 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.textBox47 = new System.Windows.Forms.TextBox();
            this.textBox48 = new System.Windows.Forms.TextBox();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.textBox56 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElecTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElecTrack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "打开串口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // comboBoxSerialPortName
            // 
            this.comboBoxSerialPortName.FormattingEnabled = true;
            this.comboBoxSerialPortName.Location = new System.Drawing.Point(52, 25);
            this.comboBoxSerialPortName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSerialPortName.Name = "comboBoxSerialPortName";
            this.comboBoxSerialPortName.Size = new System.Drawing.Size(92, 20);
            this.comboBoxSerialPortName.TabIndex = 1;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(52, 50);
            this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(92, 20);
            this.comboBoxBaudRate.TabIndex = 2;
            // 
            // Timerscanserial
            // 
            this.Timerscanserial.Enabled = true;
            this.Timerscanserial.Interval = 1000;
            this.Timerscanserial.Tick += new System.EventHandler(this.Timerscanserial_Tick);
            // 
            // Sendline
            // 
            this.Sendline.Location = new System.Drawing.Point(217, 356);
            this.Sendline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sendline.Name = "Sendline";
            this.Sendline.Size = new System.Drawing.Size(56, 33);
            this.Sendline.TabIndex = 3;
            this.Sendline.Text = "发送";
            this.Sendline.UseVisualStyleBackColor = true;
            this.Sendline.Click += new System.EventHandler(this.Sendline_Click);
            // 
            // Sendbox
            // 
            this.Sendbox.Location = new System.Drawing.Point(11, 263);
            this.Sendbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sendbox.Multiline = true;
            this.Sendbox.Name = "Sendbox";
            this.Sendbox.Size = new System.Drawing.Size(198, 126);
            this.Sendbox.TabIndex = 4;
            // 
            // receive_text
            // 
            this.receive_text.Location = new System.Drawing.Point(11, 102);
            this.receive_text.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.receive_text.Multiline = true;
            this.receive_text.Name = "receive_text";
            this.receive_text.Size = new System.Drawing.Size(257, 135);
            this.receive_text.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "串口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "波特率";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(273, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(686, 447);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(678, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(358, 21);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(291, 286);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数调节";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Senddata);
            this.panel2.Controls.Add(this.Resenddata);
            this.panel2.Controls.Add(this.sendname4);
            this.panel2.Controls.Add(this.sendnum4);
            this.panel2.Controls.Add(this.sendID4);
            this.panel2.Controls.Add(this.sendname0);
            this.panel2.Controls.Add(this.sendnum3);
            this.panel2.Controls.Add(this.sendID0);
            this.panel2.Controls.Add(this.sendname1);
            this.panel2.Controls.Add(this.sendnum2);
            this.panel2.Controls.Add(this.sendID1);
            this.panel2.Controls.Add(this.sendname2);
            this.panel2.Controls.Add(this.sendnum1);
            this.panel2.Controls.Add(this.sendID2);
            this.panel2.Controls.Add(this.sendname3);
            this.panel2.Controls.Add(this.sendnum0);
            this.panel2.Controls.Add(this.sendID3);
            this.panel2.Location = new System.Drawing.Point(14, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 257);
            this.panel2.TabIndex = 57;
            // 
            // Senddata
            // 
            this.Senddata.Location = new System.Drawing.Point(200, 210);
            this.Senddata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Senddata.Name = "Senddata";
            this.Senddata.Size = new System.Drawing.Size(56, 18);
            this.Senddata.TabIndex = 77;
            this.Senddata.Text = "send";
            this.Senddata.UseVisualStyleBackColor = true;
            this.Senddata.Click += new System.EventHandler(this.Senddata_Click);
            // 
            // Resenddata
            // 
            this.Resenddata.Location = new System.Drawing.Point(200, 159);
            this.Resenddata.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Resenddata.Name = "Resenddata";
            this.Resenddata.Size = new System.Drawing.Size(56, 18);
            this.Resenddata.TabIndex = 76;
            this.Resenddata.Text = "refresh";
            this.Resenddata.UseVisualStyleBackColor = true;
            this.Resenddata.Click += new System.EventHandler(this.Resenddata_Click);
            // 
            // sendname4
            // 
            this.sendname4.Location = new System.Drawing.Point(28, 209);
            this.sendname4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendname4.Name = "sendname4";
            this.sendname4.Size = new System.Drawing.Size(55, 21);
            this.sendname4.TabIndex = 65;
            // 
            // sendnum4
            // 
            this.sendnum4.Location = new System.Drawing.Point(119, 208);
            this.sendnum4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendnum4.Name = "sendnum4";
            this.sendnum4.Size = new System.Drawing.Size(55, 21);
            this.sendnum4.TabIndex = 75;
            // 
            // sendID4
            // 
            this.sendID4.AutoSize = true;
            this.sendID4.Location = new System.Drawing.Point(34, 241);
            this.sendID4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sendID4.Name = "sendID4";
            this.sendID4.Size = new System.Drawing.Size(47, 12);
            this.sendID4.TabIndex = 56;
            this.sendID4.Text = "label11";
            // 
            // sendname0
            // 
            this.sendname0.Location = new System.Drawing.Point(28, 6);
            this.sendname0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendname0.Name = "sendname0";
            this.sendname0.Size = new System.Drawing.Size(55, 21);
            this.sendname0.TabIndex = 57;
            // 
            // sendnum3
            // 
            this.sendnum3.Location = new System.Drawing.Point(119, 158);
            this.sendnum3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendnum3.Name = "sendnum3";
            this.sendnum3.Size = new System.Drawing.Size(55, 21);
            this.sendnum3.TabIndex = 73;
            // 
            // sendID0
            // 
            this.sendID0.AutoSize = true;
            this.sendID0.Location = new System.Drawing.Point(34, 37);
            this.sendID0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sendID0.Name = "sendID0";
            this.sendID0.Size = new System.Drawing.Size(47, 12);
            this.sendID0.TabIndex = 58;
            this.sendID0.Text = "label13";
            // 
            // sendname1
            // 
            this.sendname1.Location = new System.Drawing.Point(28, 56);
            this.sendname1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendname1.Name = "sendname1";
            this.sendname1.Size = new System.Drawing.Size(55, 21);
            this.sendname1.TabIndex = 59;
            // 
            // sendnum2
            // 
            this.sendnum2.Location = new System.Drawing.Point(119, 107);
            this.sendnum2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendnum2.Name = "sendnum2";
            this.sendnum2.Size = new System.Drawing.Size(55, 21);
            this.sendnum2.TabIndex = 71;
            // 
            // sendID1
            // 
            this.sendID1.AutoSize = true;
            this.sendID1.Location = new System.Drawing.Point(34, 88);
            this.sendID1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sendID1.Name = "sendID1";
            this.sendID1.Size = new System.Drawing.Size(47, 12);
            this.sendID1.TabIndex = 60;
            this.sendID1.Text = "label15";
            // 
            // sendname2
            // 
            this.sendname2.Location = new System.Drawing.Point(28, 107);
            this.sendname2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendname2.Name = "sendname2";
            this.sendname2.Size = new System.Drawing.Size(55, 21);
            this.sendname2.TabIndex = 61;
            // 
            // sendnum1
            // 
            this.sendnum1.Location = new System.Drawing.Point(119, 57);
            this.sendnum1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendnum1.Name = "sendnum1";
            this.sendnum1.Size = new System.Drawing.Size(55, 21);
            this.sendnum1.TabIndex = 69;
            // 
            // sendID2
            // 
            this.sendID2.AutoSize = true;
            this.sendID2.Location = new System.Drawing.Point(34, 138);
            this.sendID2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sendID2.Name = "sendID2";
            this.sendID2.Size = new System.Drawing.Size(47, 12);
            this.sendID2.TabIndex = 62;
            this.sendID2.Text = "label17";
            // 
            // sendname3
            // 
            this.sendname3.Location = new System.Drawing.Point(28, 158);
            this.sendname3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendname3.Name = "sendname3";
            this.sendname3.Size = new System.Drawing.Size(55, 21);
            this.sendname3.TabIndex = 63;
            // 
            // sendnum0
            // 
            this.sendnum0.Location = new System.Drawing.Point(119, 6);
            this.sendnum0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sendnum0.Name = "sendnum0";
            this.sendnum0.Size = new System.Drawing.Size(55, 21);
            this.sendnum0.TabIndex = 67;
            // 
            // sendID3
            // 
            this.sendID3.AutoSize = true;
            this.sendID3.Location = new System.Drawing.Point(34, 190);
            this.sendID3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sendID3.Name = "sendID3";
            this.sendID3.Size = new System.Drawing.Size(47, 12);
            this.sendID3.TabIndex = 64;
            this.sendID3.Text = "label19";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(4, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(342, 286);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数显示";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Enabledatashow);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.datatext4);
            this.panel1.Controls.Add(this.datatext9);
            this.panel1.Controls.Add(this.dataname0);
            this.panel1.Controls.Add(this.dataname9);
            this.panel1.Controls.Add(this.datatext0);
            this.panel1.Controls.Add(this.datatext8);
            this.panel1.Controls.Add(this.dataname1);
            this.panel1.Controls.Add(this.dataname8);
            this.panel1.Controls.Add(this.datatext1);
            this.panel1.Controls.Add(this.datatext7);
            this.panel1.Controls.Add(this.dataname2);
            this.panel1.Controls.Add(this.dataname7);
            this.panel1.Controls.Add(this.datatext2);
            this.panel1.Controls.Add(this.datatext6);
            this.panel1.Controls.Add(this.dataname3);
            this.panel1.Controls.Add(this.dataname6);
            this.panel1.Controls.Add(this.datatext3);
            this.panel1.Controls.Add(this.datatext5);
            this.panel1.Controls.Add(this.dataname4);
            this.panel1.Controls.Add(this.dataname5);
            this.panel1.Location = new System.Drawing.Point(4, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 258);
            this.panel1.TabIndex = 56;
            // 
            // Enabledatashow
            // 
            this.Enabledatashow.AutoSize = true;
            this.Enabledatashow.Location = new System.Drawing.Point(265, 230);
            this.Enabledatashow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enabledatashow.Name = "Enabledatashow";
            this.Enabledatashow.Size = new System.Drawing.Size(48, 16);
            this.Enabledatashow.TabIndex = 58;
            this.Enabledatashow.Text = "show";
            this.Enabledatashow.UseVisualStyleBackColor = true;
            this.Enabledatashow.CheckedChanged += new System.EventHandler(this.Enabledatashow_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(265, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 20);
            this.comboBox1.TabIndex = 56;
            // 
            // datatext4
            // 
            this.datatext4.Location = new System.Drawing.Point(64, 225);
            this.datatext4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatext4.Name = "datatext4";
            this.datatext4.Size = new System.Drawing.Size(55, 21);
            this.datatext4.TabIndex = 45;
            // 
            // datatext9
            // 
            this.datatext9.Location = new System.Drawing.Point(184, 224);
            this.datatext9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatext9.Name = "datatext9";
            this.datatext9.Size = new System.Drawing.Size(55, 21);
            this.datatext9.TabIndex = 55;
            // 
            // dataname0
            // 
            this.dataname0.AutoSize = true;
            this.dataname0.Location = new System.Drawing.Point(2, 26);
            this.dataname0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataname0.Name = "dataname0";
            this.dataname0.Size = new System.Drawing.Size(41, 12);
            this.dataname0.TabIndex = 27;
            this.dataname0.Text = "label1";
            // 
            // dataname9
            // 
            this.dataname9.AutoSize = true;
            this.dataname9.Location = new System.Drawing.Point(131, 227);
            this.dataname9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataname9.Name = "dataname9";
            this.dataname9.Size = new System.Drawing.Size(41, 12);
            this.dataname9.TabIndex = 54;
            this.dataname9.Text = "label9";
            // 
            // datatext0
            // 
            this.datatext0.Location = new System.Drawing.Point(64, 22);
            this.datatext0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatext0.Name = "datatext0";
            this.datatext0.Size = new System.Drawing.Size(55, 21);
            this.datatext0.TabIndex = 37;
            // 
            // datatext8
            // 
            this.datatext8.Location = new System.Drawing.Point(184, 174);
            this.datatext8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatext8.Name = "datatext8";
            this.datatext8.Size = new System.Drawing.Size(55, 21);
            this.datatext8.TabIndex = 53;
            // 
            // dataname1
            // 
            this.dataname1.AutoSize = true;
            this.dataname1.Location = new System.Drawing.Point(2, 75);
            this.dataname1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataname1.Name = "dataname1";
            this.dataname1.Size = new System.Drawing.Size(41, 12);
            this.dataname1.TabIndex = 38;
            this.dataname1.Text = "label2";
            // 
            // dataname8
            // 
            this.dataname8.AutoSize = true;
            this.dataname8.Location = new System.Drawing.Point(131, 176);
            this.dataname8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataname8.Name = "dataname8";
            this.dataname8.Size = new System.Drawing.Size(47, 12);
            this.dataname8.TabIndex = 52;
            this.dataname8.Text = "label10";
            // 
            // datatext1
            // 
            this.datatext1.Location = new System.Drawing.Point(64, 72);
            this.datatext1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatext1.Name = "datatext1";
            this.datatext1.Size = new System.Drawing.Size(55, 21);
            this.datatext1.TabIndex = 39;
            // 
            // datatext7
            // 
            this.datatext7.Location = new System.Drawing.Point(184, 123);
            this.datatext7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatext7.Name = "datatext7";
            this.datatext7.Size = new System.Drawing.Size(55, 21);
            this.datatext7.TabIndex = 51;
            // 
            // dataname2
            // 
            this.dataname2.AutoSize = true;
            this.dataname2.Location = new System.Drawing.Point(2, 126);
            this.dataname2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataname2.Name = "dataname2";
            this.dataname2.Size = new System.Drawing.Size(41, 12);
            this.dataname2.TabIndex = 40;
            this.dataname2.Text = "label4";
            // 
            // dataname7
            // 
            this.dataname7.AutoSize = true;
            this.dataname7.Location = new System.Drawing.Point(131, 126);
            this.dataname7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataname7.Name = "dataname7";
            this.dataname7.Size = new System.Drawing.Size(41, 12);
            this.dataname7.TabIndex = 50;
            this.dataname7.Text = "label5";
            // 
            // datatext2
            // 
            this.datatext2.Location = new System.Drawing.Point(64, 123);
            this.datatext2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatext2.Name = "datatext2";
            this.datatext2.Size = new System.Drawing.Size(55, 21);
            this.datatext2.TabIndex = 41;
            // 
            // datatext6
            // 
            this.datatext6.Location = new System.Drawing.Point(184, 73);
            this.datatext6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatext6.Name = "datatext6";
            this.datatext6.Size = new System.Drawing.Size(55, 21);
            this.datatext6.TabIndex = 49;
            // 
            // dataname3
            // 
            this.dataname3.AutoSize = true;
            this.dataname3.Location = new System.Drawing.Point(2, 176);
            this.dataname3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataname3.Name = "dataname3";
            this.dataname3.Size = new System.Drawing.Size(41, 12);
            this.dataname3.TabIndex = 42;
            this.dataname3.Text = "label3";
            // 
            // dataname6
            // 
            this.dataname6.AutoSize = true;
            this.dataname6.Location = new System.Drawing.Point(131, 75);
            this.dataname6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataname6.Name = "dataname6";
            this.dataname6.Size = new System.Drawing.Size(41, 12);
            this.dataname6.TabIndex = 48;
            this.dataname6.Text = "label6";
            // 
            // datatext3
            // 
            this.datatext3.Location = new System.Drawing.Point(64, 174);
            this.datatext3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatext3.Name = "datatext3";
            this.datatext3.Size = new System.Drawing.Size(55, 21);
            this.datatext3.TabIndex = 43;
            // 
            // datatext5
            // 
            this.datatext5.Location = new System.Drawing.Point(184, 22);
            this.datatext5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatext5.Name = "datatext5";
            this.datatext5.Size = new System.Drawing.Size(55, 21);
            this.datatext5.TabIndex = 47;
            // 
            // dataname4
            // 
            this.dataname4.AutoSize = true;
            this.dataname4.Location = new System.Drawing.Point(2, 227);
            this.dataname4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataname4.Name = "dataname4";
            this.dataname4.Size = new System.Drawing.Size(41, 12);
            this.dataname4.TabIndex = 44;
            this.dataname4.Text = "label8";
            // 
            // dataname5
            // 
            this.dataname5.AutoSize = true;
            this.dataname5.Location = new System.Drawing.Point(131, 26);
            this.dataname5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataname5.Name = "dataname5";
            this.dataname5.Size = new System.Drawing.Size(41, 12);
            this.dataname5.TabIndex = 46;
            this.dataname5.Text = "label7";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkConnect);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.PlayMode);
            this.tabPage2.Controls.Add(this.tabControl3);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.UgDn);
            this.tabPage2.Controls.Add(this.PnUp);
            this.tabPage2.Controls.Add(this.ChartEng);
            this.tabPage2.Controls.Add(this.ImgEng);
            this.tabPage2.Controls.Add(this.play_pro);
            this.tabPage2.Controls.Add(this.record_pro);
            this.tabPage2.Controls.Add(this.play_bar);
            this.tabPage2.Controls.Add(this.Record);
            this.tabPage2.Controls.Add(this.play_pause);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(678, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkConnect
            // 
            this.checkConnect.AutoSize = true;
            this.checkConnect.Checked = true;
            this.checkConnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkConnect.Location = new System.Drawing.Point(117, 283);
            this.checkConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkConnect.Name = "checkConnect";
            this.checkConnect.Size = new System.Drawing.Size(84, 16);
            this.checkConnect.TabIndex = 18;
            this.checkConnect.Text = "连接播放器";
            this.checkConnect.UseVisualStyleBackColor = true;
            this.checkConnect.CheckedChanged += new System.EventHandler(this.CheckConnect_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(74, 373);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 25);
            this.button5.TabIndex = 17;
            this.button5.Text = "清空";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(526, 365);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 18);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // PlayMode
            // 
            this.PlayMode.FormattingEnabled = true;
            this.PlayMode.Items.AddRange(new object[] {
            "摄像头",
            "电感"});
            this.PlayMode.Location = new System.Drawing.Point(13, 260);
            this.PlayMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlayMode.Name = "PlayMode";
            this.PlayMode.Size = new System.Drawing.Size(92, 20);
            this.PlayMode.TabIndex = 14;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(274, 6);
            this.tabControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(402, 339);
            this.tabControl3.TabIndex = 13;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox14);
            this.tabPage5.Controls.Add(this.textBox13);
            this.tabPage5.Controls.Add(this.textBox12);
            this.tabPage5.Controls.Add(this.textBox11);
            this.tabPage5.Controls.Add(this.chart1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Size = new System.Drawing.Size(394, 313);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "图表";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(281, 285);
            this.textBox14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(76, 21);
            this.textBox14.TabIndex = 7;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(190, 285);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(76, 21);
            this.textBox13.TabIndex = 6;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(99, 285);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(76, 21);
            this.textBox12.TabIndex = 5;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(8, 285);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(76, 21);
            this.textBox11.TabIndex = 4;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(8, 7);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series4.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(386, 267);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.textBox6);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.textBox7);
            this.tabPage6.Controls.Add(this.textBox8);
            this.tabPage6.Controls.Add(this.textBox9);
            this.tabPage6.Controls.Add(this.textBox10);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.textBox5);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.label5);
            this.tabPage6.Controls.Add(this.label4);
            this.tabPage6.Controls.Add(this.textBox4);
            this.tabPage6.Controls.Add(this.textBox3);
            this.tabPage6.Controls.Add(this.textBox2);
            this.tabPage6.Controls.Add(this.textBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage6.Size = new System.Drawing.Size(394, 313);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "数值";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(202, 246);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 21);
            this.textBox6.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 201);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(326, 24);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "label13";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(202, 193);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(76, 21);
            this.textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(202, 138);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(76, 21);
            this.textBox8.TabIndex = 12;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(202, 75);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(76, 21);
            this.textBox9.TabIndex = 11;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(202, 18);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(76, 21);
            this.textBox10.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 246);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 21);
            this.textBox5.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 193);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 21);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 138);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 21);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 75);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 21);
            this.textBox1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(4, 6);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(265, 234);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ImgBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(257, 208);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "摄像头";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ImgBox
            // 
            this.ImgBox.Image = global::usart_tool.Properties.Resources.无标题;
            this.ImgBox.Location = new System.Drawing.Point(4, 6);
            this.ImgBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(253, 199);
            this.ImgBox.TabIndex = 1;
            this.ImgBox.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ElecTrack2);
            this.tabPage4.Controls.Add(this.ElecTrack1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(257, 208);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "电感";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ElecTrack2
            // 
            this.ElecTrack2.Location = new System.Drawing.Point(4, 150);
            this.ElecTrack2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ElecTrack2.Maximum = 2000;
            this.ElecTrack2.Name = "ElecTrack2";
            this.ElecTrack2.Size = new System.Drawing.Size(246, 45);
            this.ElecTrack2.TabIndex = 1;
            // 
            // ElecTrack1
            // 
            this.ElecTrack1.Location = new System.Drawing.Point(4, 36);
            this.ElecTrack1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ElecTrack1.Maximum = 2000;
            this.ElecTrack1.Name = "ElecTrack1";
            this.ElecTrack1.Size = new System.Drawing.Size(250, 45);
            this.ElecTrack1.TabIndex = 0;
            // 
            // UgDn
            // 
            this.UgDn.Location = new System.Drawing.Point(209, 349);
            this.UgDn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UgDn.Name = "UgDn";
            this.UgDn.Size = new System.Drawing.Size(56, 28);
            this.UgDn.TabIndex = 11;
            this.UgDn.Text = "下一帧";
            this.UgDn.UseVisualStyleBackColor = true;
            this.UgDn.Click += new System.EventHandler(this.UgDn_Click);
            // 
            // PnUp
            // 
            this.PnUp.Location = new System.Drawing.Point(12, 349);
            this.PnUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PnUp.Name = "PnUp";
            this.PnUp.Size = new System.Drawing.Size(56, 28);
            this.PnUp.TabIndex = 10;
            this.PnUp.Text = "上一帧";
            this.PnUp.UseVisualStyleBackColor = true;
            this.PnUp.Click += new System.EventHandler(this.PnUp_Click);
            // 
            // ChartEng
            // 
            this.ChartEng.AutoSize = true;
            this.ChartEng.Location = new System.Drawing.Point(195, 263);
            this.ChartEng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChartEng.Name = "ChartEng";
            this.ChartEng.Size = new System.Drawing.Size(72, 16);
            this.ChartEng.TabIndex = 9;
            this.ChartEng.Text = "查看图表";
            this.ChartEng.UseVisualStyleBackColor = true;
            // 
            // ImgEng
            // 
            this.ImgEng.AutoSize = true;
            this.ImgEng.Location = new System.Drawing.Point(117, 263);
            this.ImgEng.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ImgEng.Name = "ImgEng";
            this.ImgEng.Size = new System.Drawing.Size(72, 16);
            this.ImgEng.TabIndex = 8;
            this.ImgEng.Text = "查看图像";
            this.ImgEng.UseVisualStyleBackColor = true;
            // 
            // play_pro
            // 
            this.play_pro.AutoSize = true;
            this.play_pro.Location = new System.Drawing.Point(115, 359);
            this.play_pro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.play_pro.Name = "play_pro";
            this.play_pro.Size = new System.Drawing.Size(23, 12);
            this.play_pro.TabIndex = 7;
            this.play_pro.Text = "0/0";
            // 
            // record_pro
            // 
            this.record_pro.AutoSize = true;
            this.record_pro.Location = new System.Drawing.Point(276, 384);
            this.record_pro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.record_pro.Name = "record_pro";
            this.record_pro.Size = new System.Drawing.Size(23, 12);
            this.record_pro.TabIndex = 6;
            this.record_pro.Text = "0/0";
            // 
            // play_bar
            // 
            this.play_bar.Location = new System.Drawing.Point(4, 300);
            this.play_bar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.play_bar.Name = "play_bar";
            this.play_bar.Size = new System.Drawing.Size(265, 45);
            this.play_bar.TabIndex = 5;
            this.play_bar.Scroll += new System.EventHandler(this.Play_bar_Scroll);
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(12, 395);
            this.Record.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(56, 25);
            this.Record.TabIndex = 4;
            this.Record.Text = "记录";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // play_pause
            // 
            this.play_pause.Location = new System.Drawing.Point(593, 395);
            this.play_pause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.play_pause.Name = "play_pause";
            this.play_pause.Size = new System.Drawing.Size(56, 25);
            this.play_pause.TabIndex = 2;
            this.play_pause.Text = "播放";
            this.play_pause.UseVisualStyleBackColor = true;
            this.play_pause.Click += new System.EventHandler(this.Play_pause_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(74, 401);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Maximum = 600;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 18);
            this.progressBar1.TabIndex = 0;
            // 
            // Record_timer
            // 
            this.Record_timer.Tick += new System.EventHandler(this.Record_timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 403);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 61;
            this.label3.Text = "0";
            // 
            // Datatimer
            // 
            this.Datatimer.Tick += new System.EventHandler(this.Datatimer_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 400);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 64;
            this.label14.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.示波器ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(978, 25);
            this.menuStrip1.TabIndex = 65;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置文件ToolStripMenuItem,
            this.记录文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 配置文件ToolStripMenuItem
            // 
            this.配置文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新配置文件ToolStripMenuItem,
            this.打开配置文件ToolStripMenuItem,
            this.重新生成配置文件ToolStripMenuItem});
            this.配置文件ToolStripMenuItem.Name = "配置文件ToolStripMenuItem";
            this.配置文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.配置文件ToolStripMenuItem.Text = "配置文件";
            // 
            // 更新配置文件ToolStripMenuItem
            // 
            this.更新配置文件ToolStripMenuItem.Name = "更新配置文件ToolStripMenuItem";
            this.更新配置文件ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.更新配置文件ToolStripMenuItem.Text = "更新配置文件";
            this.更新配置文件ToolStripMenuItem.Click += new System.EventHandler(this.更新配置文件ToolStripMenuItem_Click);
            // 
            // 打开配置文件ToolStripMenuItem
            // 
            this.打开配置文件ToolStripMenuItem.Name = "打开配置文件ToolStripMenuItem";
            this.打开配置文件ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.打开配置文件ToolStripMenuItem.Text = "打开配置文件";
            this.打开配置文件ToolStripMenuItem.Click += new System.EventHandler(this.打开配置文件ToolStripMenuItem_Click);
            // 
            // 重新生成配置文件ToolStripMenuItem
            // 
            this.重新生成配置文件ToolStripMenuItem.Name = "重新生成配置文件ToolStripMenuItem";
            this.重新生成配置文件ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.重新生成配置文件ToolStripMenuItem.Text = "重新生成配置文件";
            this.重新生成配置文件ToolStripMenuItem.Click += new System.EventHandler(this.重新生成配置文件ToolStripMenuItem_Click);
            // 
            // 记录文件ToolStripMenuItem
            // 
            this.记录文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存记录文件ToolStripMenuItem,
            this.打开记录文件ToolStripMenuItem});
            this.记录文件ToolStripMenuItem.Name = "记录文件ToolStripMenuItem";
            this.记录文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.记录文件ToolStripMenuItem.Text = "记录文件";
            // 
            // 保存记录文件ToolStripMenuItem
            // 
            this.保存记录文件ToolStripMenuItem.Name = "保存记录文件ToolStripMenuItem";
            this.保存记录文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.保存记录文件ToolStripMenuItem.Text = "保存记录文件";
            this.保存记录文件ToolStripMenuItem.Click += new System.EventHandler(this.保存记录文件ToolStripMenuItem_Click);
            // 
            // 打开记录文件ToolStripMenuItem
            // 
            this.打开记录文件ToolStripMenuItem.Name = "打开记录文件ToolStripMenuItem";
            this.打开记录文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开记录文件ToolStripMenuItem.Text = "打开记录文件";
            this.打开记录文件ToolStripMenuItem.Click += new System.EventHandler(this.打开记录文件ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.工具ToolStripMenuItem.Text = "图像播放器";
            this.工具ToolStripMenuItem.Click += new System.EventHandler(this.工具ToolStripMenuItem_Click);
            // 
            // 示波器ToolStripMenuItem
            // 
            this.示波器ToolStripMenuItem.Name = "示波器ToolStripMenuItem";
            this.示波器ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.示波器ToolStripMenuItem.Text = "示波器";
            this.示波器ToolStripMenuItem.Click += new System.EventHandler(this.示波器ToolStripMenuItem_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 66;
            this.label15.Text = "串口接收";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 249);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 67;
            this.label16.Text = "串口发送";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker2_DoWork);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker3_DoWork);
            // 
            // backgroundWorker4
            // 
            this.backgroundWorker4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker4_DoWork);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(154, 434);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 68;
            this.label17.Text = "label17";
            // 
            // backgroundWorker5
            // 
            this.backgroundWorker5.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker5_DoWork);
            // 
            // backgroundWorker6
            // 
            this.backgroundWorker6.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker6_DoWork);
            // 
            // backgroundWorker7
            // 
            this.backgroundWorker7.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker7_DoWork);
            // 
            // backgroundWorker8
            // 
            this.backgroundWorker8.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker8_DoWork);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox3);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(678, 421);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "模糊控制计算";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.textBox57);
            this.groupBox3.Controls.Add(this.textBox58);
            this.groupBox3.Controls.Add(this.textBox59);
            this.groupBox3.Controls.Add(this.textBox60);
            this.groupBox3.Controls.Add(this.textBox61);
            this.groupBox3.Controls.Add(this.textBox62);
            this.groupBox3.Controls.Add(this.textBox63);
            this.groupBox3.Controls.Add(this.textBox64);
            this.groupBox3.Controls.Add(this.textBox65);
            this.groupBox3.Controls.Add(this.textBox66);
            this.groupBox3.Controls.Add(this.textBox47);
            this.groupBox3.Controls.Add(this.textBox48);
            this.groupBox3.Controls.Add(this.textBox49);
            this.groupBox3.Controls.Add(this.textBox50);
            this.groupBox3.Controls.Add(this.textBox51);
            this.groupBox3.Controls.Add(this.textBox52);
            this.groupBox3.Controls.Add(this.textBox53);
            this.groupBox3.Controls.Add(this.textBox54);
            this.groupBox3.Controls.Add(this.textBox55);
            this.groupBox3.Controls.Add(this.textBox56);
            this.groupBox3.Controls.Add(this.textBox32);
            this.groupBox3.Controls.Add(this.textBox33);
            this.groupBox3.Controls.Add(this.textBox34);
            this.groupBox3.Controls.Add(this.textBox35);
            this.groupBox3.Controls.Add(this.textBox36);
            this.groupBox3.Controls.Add(this.textBox37);
            this.groupBox3.Controls.Add(this.textBox38);
            this.groupBox3.Controls.Add(this.textBox39);
            this.groupBox3.Controls.Add(this.textBox40);
            this.groupBox3.Controls.Add(this.textBox41);
            this.groupBox3.Controls.Add(this.textBox42);
            this.groupBox3.Controls.Add(this.textBox43);
            this.groupBox3.Controls.Add(this.textBox44);
            this.groupBox3.Controls.Add(this.textBox45);
            this.groupBox3.Controls.Add(this.textBox46);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.textBox27);
            this.groupBox3.Controls.Add(this.textBox28);
            this.groupBox3.Controls.Add(this.textBox29);
            this.groupBox3.Controls.Add(this.textBox30);
            this.groupBox3.Controls.Add(this.textBox31);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.textBox22);
            this.groupBox3.Controls.Add(this.textBox23);
            this.groupBox3.Controls.Add(this.textBox24);
            this.groupBox3.Controls.Add(this.textBox25);
            this.groupBox3.Controls.Add(this.textBox26);
            this.groupBox3.Controls.Add(this.textBox21);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.textBox20);
            this.groupBox3.Controls.Add(this.textBox19);
            this.groupBox3.Controls.Add(this.textBox18);
            this.groupBox3.Controls.Add(this.textBox17);
            this.groupBox3.Controls.Add(this.textBox16);
            this.groupBox3.Controls.Add(this.textBox15);
            this.groupBox3.Location = new System.Drawing.Point(19, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(460, 339);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数设置";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(360, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 61);
            this.button2.TabIndex = 56;
            this.button2.Text = "更新参数";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(21, 137);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 12);
            this.label20.TabIndex = 55;
            this.label20.Text = "规则表";
            // 
            // textBox57
            // 
            this.textBox57.Location = new System.Drawing.Point(300, 298);
            this.textBox57.Name = "textBox57";
            this.textBox57.Size = new System.Drawing.Size(41, 21);
            this.textBox57.TabIndex = 54;
            // 
            // textBox58
            // 
            this.textBox58.Location = new System.Drawing.Point(253, 298);
            this.textBox58.Name = "textBox58";
            this.textBox58.Size = new System.Drawing.Size(41, 21);
            this.textBox58.TabIndex = 53;
            // 
            // textBox59
            // 
            this.textBox59.Location = new System.Drawing.Point(206, 298);
            this.textBox59.Name = "textBox59";
            this.textBox59.Size = new System.Drawing.Size(41, 21);
            this.textBox59.TabIndex = 52;
            // 
            // textBox60
            // 
            this.textBox60.Location = new System.Drawing.Point(159, 298);
            this.textBox60.Name = "textBox60";
            this.textBox60.Size = new System.Drawing.Size(41, 21);
            this.textBox60.TabIndex = 51;
            // 
            // textBox61
            // 
            this.textBox61.Location = new System.Drawing.Point(112, 298);
            this.textBox61.Name = "textBox61";
            this.textBox61.Size = new System.Drawing.Size(41, 21);
            this.textBox61.TabIndex = 50;
            // 
            // textBox62
            // 
            this.textBox62.Location = new System.Drawing.Point(300, 271);
            this.textBox62.Name = "textBox62";
            this.textBox62.Size = new System.Drawing.Size(41, 21);
            this.textBox62.TabIndex = 49;
            // 
            // textBox63
            // 
            this.textBox63.Location = new System.Drawing.Point(253, 271);
            this.textBox63.Name = "textBox63";
            this.textBox63.Size = new System.Drawing.Size(41, 21);
            this.textBox63.TabIndex = 48;
            // 
            // textBox64
            // 
            this.textBox64.Location = new System.Drawing.Point(206, 271);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(41, 21);
            this.textBox64.TabIndex = 47;
            // 
            // textBox65
            // 
            this.textBox65.Location = new System.Drawing.Point(159, 271);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(41, 21);
            this.textBox65.TabIndex = 46;
            // 
            // textBox66
            // 
            this.textBox66.Location = new System.Drawing.Point(112, 271);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(41, 21);
            this.textBox66.TabIndex = 45;
            // 
            // textBox47
            // 
            this.textBox47.Location = new System.Drawing.Point(300, 244);
            this.textBox47.Name = "textBox47";
            this.textBox47.Size = new System.Drawing.Size(41, 21);
            this.textBox47.TabIndex = 44;
            // 
            // textBox48
            // 
            this.textBox48.Location = new System.Drawing.Point(253, 244);
            this.textBox48.Name = "textBox48";
            this.textBox48.Size = new System.Drawing.Size(41, 21);
            this.textBox48.TabIndex = 43;
            // 
            // textBox49
            // 
            this.textBox49.Location = new System.Drawing.Point(206, 244);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(41, 21);
            this.textBox49.TabIndex = 42;
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(159, 244);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(41, 21);
            this.textBox50.TabIndex = 41;
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(112, 244);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(41, 21);
            this.textBox51.TabIndex = 40;
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(300, 217);
            this.textBox52.Name = "textBox52";
            this.textBox52.Size = new System.Drawing.Size(41, 21);
            this.textBox52.TabIndex = 39;
            // 
            // textBox53
            // 
            this.textBox53.Location = new System.Drawing.Point(253, 217);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(41, 21);
            this.textBox53.TabIndex = 38;
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(206, 217);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(41, 21);
            this.textBox54.TabIndex = 37;
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(159, 217);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(41, 21);
            this.textBox55.TabIndex = 36;
            // 
            // textBox56
            // 
            this.textBox56.Location = new System.Drawing.Point(112, 217);
            this.textBox56.Name = "textBox56";
            this.textBox56.Size = new System.Drawing.Size(41, 21);
            this.textBox56.TabIndex = 35;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(300, 190);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(41, 21);
            this.textBox32.TabIndex = 34;
            // 
            // textBox33
            // 
            this.textBox33.Location = new System.Drawing.Point(253, 190);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(41, 21);
            this.textBox33.TabIndex = 33;
            // 
            // textBox34
            // 
            this.textBox34.Location = new System.Drawing.Point(206, 190);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(41, 21);
            this.textBox34.TabIndex = 32;
            // 
            // textBox35
            // 
            this.textBox35.Location = new System.Drawing.Point(159, 190);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(41, 21);
            this.textBox35.TabIndex = 31;
            // 
            // textBox36
            // 
            this.textBox36.Location = new System.Drawing.Point(112, 190);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(41, 21);
            this.textBox36.TabIndex = 30;
            // 
            // textBox37
            // 
            this.textBox37.Location = new System.Drawing.Point(300, 163);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(41, 21);
            this.textBox37.TabIndex = 29;
            // 
            // textBox38
            // 
            this.textBox38.Location = new System.Drawing.Point(253, 163);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(41, 21);
            this.textBox38.TabIndex = 28;
            // 
            // textBox39
            // 
            this.textBox39.Location = new System.Drawing.Point(206, 163);
            this.textBox39.Name = "textBox39";
            this.textBox39.Size = new System.Drawing.Size(41, 21);
            this.textBox39.TabIndex = 27;
            // 
            // textBox40
            // 
            this.textBox40.Location = new System.Drawing.Point(159, 163);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(41, 21);
            this.textBox40.TabIndex = 26;
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(112, 163);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(41, 21);
            this.textBox41.TabIndex = 25;
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(300, 137);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(41, 21);
            this.textBox42.TabIndex = 24;
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(253, 137);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(41, 21);
            this.textBox43.TabIndex = 23;
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(206, 137);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(41, 21);
            this.textBox44.TabIndex = 22;
            // 
            // textBox45
            // 
            this.textBox45.Location = new System.Drawing.Point(159, 137);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(41, 21);
            this.textBox45.TabIndex = 21;
            // 
            // textBox46
            // 
            this.textBox46.Location = new System.Drawing.Point(112, 137);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(41, 21);
            this.textBox46.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(19, 98);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 12);
            this.label19.TabIndex = 19;
            this.label19.Text = "D语言特征值";
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(300, 94);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(41, 21);
            this.textBox27.TabIndex = 18;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(253, 94);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(41, 21);
            this.textBox28.TabIndex = 17;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(206, 94);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(41, 21);
            this.textBox29.TabIndex = 16;
            // 
            // textBox30
            // 
            this.textBox30.Location = new System.Drawing.Point(159, 94);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(41, 21);
            this.textBox30.TabIndex = 15;
            // 
            // textBox31
            // 
            this.textBox31.Location = new System.Drawing.Point(112, 94);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(41, 21);
            this.textBox31.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(19, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 12);
            this.label18.TabIndex = 13;
            this.label18.Text = "D语言特征值";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(300, 60);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(41, 21);
            this.textBox22.TabIndex = 12;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(253, 60);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(41, 21);
            this.textBox23.TabIndex = 11;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(206, 60);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(41, 21);
            this.textBox24.TabIndex = 10;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(159, 60);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(41, 21);
            this.textBox25.TabIndex = 9;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(112, 60);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(41, 21);
            this.textBox26.TabIndex = 8;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(394, 26);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(41, 21);
            this.textBox21.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(19, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 12);
            this.label21.TabIndex = 7;
            this.label21.Text = "P语言特征值";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(347, 26);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(41, 21);
            this.textBox20.TabIndex = 5;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(300, 26);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(41, 21);
            this.textBox19.TabIndex = 4;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(253, 26);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(41, 21);
            this.textBox18.TabIndex = 3;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(206, 26);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(41, 21);
            this.textBox17.TabIndex = 2;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(159, 26);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(41, 21);
            this.textBox16.TabIndex = 1;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(112, 26);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(41, 21);
            this.textBox15.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 466);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.receive_text);
            this.Controls.Add(this.Sendbox);
            this.Controls.Add(this.Sendline);
            this.Controls.Add(this.comboBoxBaudRate);
            this.Controls.Add(this.comboBoxSerialPortName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "mainForm";
            this.Text = "中国民航大学智能车队";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ElecTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElecTrack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxSerialPortName;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Timer Timerscanserial;
        private System.Windows.Forms.Button Sendline;
        private System.Windows.Forms.TextBox Sendbox;
        private System.Windows.Forms.TextBox receive_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Senddata;
        private System.Windows.Forms.Button Resenddata;
        private System.Windows.Forms.TextBox sendname4;
        private System.Windows.Forms.TextBox sendnum4;
        private System.Windows.Forms.Label sendID4;
        private System.Windows.Forms.TextBox sendname0;
        private System.Windows.Forms.TextBox sendnum3;
        private System.Windows.Forms.Label sendID0;
        private System.Windows.Forms.TextBox sendname1;
        private System.Windows.Forms.TextBox sendnum2;
        private System.Windows.Forms.Label sendID1;
        private System.Windows.Forms.TextBox sendname2;
        private System.Windows.Forms.TextBox sendnum1;
        private System.Windows.Forms.Label sendID2;
        private System.Windows.Forms.TextBox sendname3;
        private System.Windows.Forms.TextBox sendnum0;
        private System.Windows.Forms.Label sendID3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Enabledatashow;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox datatext4;
        private System.Windows.Forms.TextBox datatext9;
        private System.Windows.Forms.Label dataname0;
        private System.Windows.Forms.Label dataname9;
        private System.Windows.Forms.TextBox datatext0;
        private System.Windows.Forms.TextBox datatext8;
        private System.Windows.Forms.Label dataname1;
        private System.Windows.Forms.Label dataname8;
        private System.Windows.Forms.TextBox datatext1;
        private System.Windows.Forms.TextBox datatext7;
        private System.Windows.Forms.Label dataname2;
        private System.Windows.Forms.Label dataname7;
        private System.Windows.Forms.TextBox datatext2;
        private System.Windows.Forms.TextBox datatext6;
        private System.Windows.Forms.Label dataname3;
        private System.Windows.Forms.Label dataname6;
        private System.Windows.Forms.TextBox datatext3;
        private System.Windows.Forms.TextBox datatext5;
        private System.Windows.Forms.Label dataname4;
        private System.Windows.Forms.Label dataname5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox ImgBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button play_pause;
        private System.Windows.Forms.Timer Record_timer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label record_pro;
        private System.Windows.Forms.TrackBar play_bar;
        private System.Windows.Forms.Label play_pro;
        private System.Windows.Forms.CheckBox ChartEng;
        private System.Windows.Forms.CheckBox ImgEng;
        private System.Windows.Forms.Button UgDn;
        private System.Windows.Forms.Button PnUp;
        private System.Windows.Forms.Timer Datatimer;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TrackBar ElecTrack2;
        private System.Windows.Forms.TrackBar ElecTrack1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox PlayMode;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开配置文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新生成配置文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记录文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存记录文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开记录文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新配置文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkConnect;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem 示波器ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
        private System.Windows.Forms.Label label17;
        private System.ComponentModel.BackgroundWorker backgroundWorker5;
        private System.ComponentModel.BackgroundWorker backgroundWorker6;
        private System.ComponentModel.BackgroundWorker backgroundWorker7;
        private System.ComponentModel.BackgroundWorker backgroundWorker8;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.TextBox textBox58;
        private System.Windows.Forms.TextBox textBox59;
        private System.Windows.Forms.TextBox textBox60;
        private System.Windows.Forms.TextBox textBox61;
        private System.Windows.Forms.TextBox textBox62;
        private System.Windows.Forms.TextBox textBox63;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox65;
        private System.Windows.Forms.TextBox textBox66;
        private System.Windows.Forms.TextBox textBox47;
        private System.Windows.Forms.TextBox textBox48;
        private System.Windows.Forms.TextBox textBox49;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox54;
        private System.Windows.Forms.TextBox textBox55;
        private System.Windows.Forms.TextBox textBox56;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox39;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox textBox42;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox45;
        private System.Windows.Forms.TextBox textBox46;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
    }
}

