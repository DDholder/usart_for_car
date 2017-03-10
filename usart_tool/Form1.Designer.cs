namespace usart_tool
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.enabledatashow = new System.Windows.Forms.CheckBox();
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
            this.Record = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.play_pause = new System.Windows.Forms.Button();
            this.ImgBox = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Record_timer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.play_bar = new System.Windows.Forms.TrackBar();
            this.record_pro = new System.Windows.Forms.Label();
            this.play_pro = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            this.comboBoxSerialPortName.Location = new System.Drawing.Point(70, 17);
            this.comboBoxSerialPortName.Name = "comboBoxSerialPortName";
            this.comboBoxSerialPortName.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSerialPortName.TabIndex = 1;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(70, 63);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(121, 23);
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
            this.Sendline.Location = new System.Drawing.Point(307, 475);
            this.Sendline.Name = "Sendline";
            this.Sendline.Size = new System.Drawing.Size(75, 23);
            this.Sendline.TabIndex = 3;
            this.Sendline.Text = "send";
            this.Sendline.UseVisualStyleBackColor = true;
            this.Sendline.Click += new System.EventHandler(this.Sendline_Click);
            // 
            // Sendbox
            // 
            this.Sendbox.Location = new System.Drawing.Point(15, 473);
            this.Sendbox.Name = "Sendbox";
            this.Sendbox.Size = new System.Drawing.Size(262, 25);
            this.Sendbox.TabIndex = 4;
            // 
            // receive_text
            // 
            this.receive_text.Location = new System.Drawing.Point(15, 92);
            this.receive_text.Multiline = true;
            this.receive_text.Name = "receive_text";
            this.receive_text.Size = new System.Drawing.Size(262, 358);
            this.receive_text.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "串口号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "波特率";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(388, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 477);
            this.tabControl1.TabIndex = 60;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(478, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 357);
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
            this.panel2.Location = new System.Drawing.Point(19, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 321);
            this.panel2.TabIndex = 57;
            // 
            // Senddata
            // 
            this.Senddata.Location = new System.Drawing.Point(266, 263);
            this.Senddata.Name = "Senddata";
            this.Senddata.Size = new System.Drawing.Size(75, 23);
            this.Senddata.TabIndex = 77;
            this.Senddata.Text = "send";
            this.Senddata.UseVisualStyleBackColor = true;
            this.Senddata.Click += new System.EventHandler(this.Senddata_Click);
            // 
            // Resenddata
            // 
            this.Resenddata.Location = new System.Drawing.Point(266, 199);
            this.Resenddata.Name = "Resenddata";
            this.Resenddata.Size = new System.Drawing.Size(75, 23);
            this.Resenddata.TabIndex = 76;
            this.Resenddata.Text = "refresh";
            this.Resenddata.UseVisualStyleBackColor = true;
            this.Resenddata.Click += new System.EventHandler(this.Resenddata_Click);
            // 
            // sendname4
            // 
            this.sendname4.Location = new System.Drawing.Point(38, 261);
            this.sendname4.Name = "sendname4";
            this.sendname4.Size = new System.Drawing.Size(72, 25);
            this.sendname4.TabIndex = 65;
            // 
            // sendnum4
            // 
            this.sendnum4.Location = new System.Drawing.Point(159, 260);
            this.sendnum4.Name = "sendnum4";
            this.sendnum4.Size = new System.Drawing.Size(72, 25);
            this.sendnum4.TabIndex = 75;
            // 
            // sendID4
            // 
            this.sendID4.AutoSize = true;
            this.sendID4.Location = new System.Drawing.Point(45, 301);
            this.sendID4.Name = "sendID4";
            this.sendID4.Size = new System.Drawing.Size(63, 15);
            this.sendID4.TabIndex = 56;
            this.sendID4.Text = "label11";
            // 
            // sendname0
            // 
            this.sendname0.Location = new System.Drawing.Point(38, 7);
            this.sendname0.Name = "sendname0";
            this.sendname0.Size = new System.Drawing.Size(72, 25);
            this.sendname0.TabIndex = 57;
            // 
            // sendnum3
            // 
            this.sendnum3.Location = new System.Drawing.Point(159, 197);
            this.sendnum3.Name = "sendnum3";
            this.sendnum3.Size = new System.Drawing.Size(72, 25);
            this.sendnum3.TabIndex = 73;
            // 
            // sendID0
            // 
            this.sendID0.AutoSize = true;
            this.sendID0.Location = new System.Drawing.Point(45, 46);
            this.sendID0.Name = "sendID0";
            this.sendID0.Size = new System.Drawing.Size(63, 15);
            this.sendID0.TabIndex = 58;
            this.sendID0.Text = "label13";
            // 
            // sendname1
            // 
            this.sendname1.Location = new System.Drawing.Point(38, 70);
            this.sendname1.Name = "sendname1";
            this.sendname1.Size = new System.Drawing.Size(72, 25);
            this.sendname1.TabIndex = 59;
            // 
            // sendnum2
            // 
            this.sendnum2.Location = new System.Drawing.Point(159, 134);
            this.sendnum2.Name = "sendnum2";
            this.sendnum2.Size = new System.Drawing.Size(72, 25);
            this.sendnum2.TabIndex = 71;
            // 
            // sendID1
            // 
            this.sendID1.AutoSize = true;
            this.sendID1.Location = new System.Drawing.Point(45, 110);
            this.sendID1.Name = "sendID1";
            this.sendID1.Size = new System.Drawing.Size(63, 15);
            this.sendID1.TabIndex = 60;
            this.sendID1.Text = "label15";
            // 
            // sendname2
            // 
            this.sendname2.Location = new System.Drawing.Point(38, 134);
            this.sendname2.Name = "sendname2";
            this.sendname2.Size = new System.Drawing.Size(72, 25);
            this.sendname2.TabIndex = 61;
            // 
            // sendnum1
            // 
            this.sendnum1.Location = new System.Drawing.Point(159, 71);
            this.sendnum1.Name = "sendnum1";
            this.sendnum1.Size = new System.Drawing.Size(72, 25);
            this.sendnum1.TabIndex = 69;
            // 
            // sendID2
            // 
            this.sendID2.AutoSize = true;
            this.sendID2.Location = new System.Drawing.Point(45, 173);
            this.sendID2.Name = "sendID2";
            this.sendID2.Size = new System.Drawing.Size(63, 15);
            this.sendID2.TabIndex = 62;
            this.sendID2.Text = "label17";
            // 
            // sendname3
            // 
            this.sendname3.Location = new System.Drawing.Point(38, 197);
            this.sendname3.Name = "sendname3";
            this.sendname3.Size = new System.Drawing.Size(72, 25);
            this.sendname3.TabIndex = 63;
            // 
            // sendnum0
            // 
            this.sendnum0.Location = new System.Drawing.Point(159, 7);
            this.sendnum0.Name = "sendnum0";
            this.sendnum0.Size = new System.Drawing.Size(72, 25);
            this.sendnum0.TabIndex = 67;
            // 
            // sendID3
            // 
            this.sendID3.AutoSize = true;
            this.sendID3.Location = new System.Drawing.Point(45, 237);
            this.sendID3.Name = "sendID3";
            this.sendID3.Size = new System.Drawing.Size(63, 15);
            this.sendID3.TabIndex = 64;
            this.sendID3.Text = "label19";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 357);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数显示";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.enabledatashow);
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
            this.panel1.Location = new System.Drawing.Point(6, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 323);
            this.panel1.TabIndex = 56;
            // 
            // enabledatashow
            // 
            this.enabledatashow.AutoSize = true;
            this.enabledatashow.Location = new System.Drawing.Point(270, 290);
            this.enabledatashow.Name = "enabledatashow";
            this.enabledatashow.Size = new System.Drawing.Size(61, 19);
            this.enabledatashow.TabIndex = 58;
            this.enabledatashow.Text = "show";
            this.enabledatashow.UseVisualStyleBackColor = true;
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
            this.comboBox1.Location = new System.Drawing.Point(270, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 56;
            // 
            // datatext4
            // 
            this.datatext4.Location = new System.Drawing.Point(39, 287);
            this.datatext4.Name = "datatext4";
            this.datatext4.Size = new System.Drawing.Size(72, 25);
            this.datatext4.TabIndex = 45;
            // 
            // datatext9
            // 
            this.datatext9.Location = new System.Drawing.Point(160, 286);
            this.datatext9.Name = "datatext9";
            this.datatext9.Size = new System.Drawing.Size(72, 25);
            this.datatext9.TabIndex = 55;
            // 
            // dataname0
            // 
            this.dataname0.AutoSize = true;
            this.dataname0.Location = new System.Drawing.Point(46, 9);
            this.dataname0.Name = "dataname0";
            this.dataname0.Size = new System.Drawing.Size(55, 15);
            this.dataname0.TabIndex = 27;
            this.dataname0.Text = "label1";
            // 
            // dataname9
            // 
            this.dataname9.AutoSize = true;
            this.dataname9.Location = new System.Drawing.Point(167, 262);
            this.dataname9.Name = "dataname9";
            this.dataname9.Size = new System.Drawing.Size(55, 15);
            this.dataname9.TabIndex = 54;
            this.dataname9.Text = "label9";
            // 
            // datatext0
            // 
            this.datatext0.Location = new System.Drawing.Point(39, 33);
            this.datatext0.Name = "datatext0";
            this.datatext0.Size = new System.Drawing.Size(72, 25);
            this.datatext0.TabIndex = 37;
            // 
            // datatext8
            // 
            this.datatext8.Location = new System.Drawing.Point(160, 223);
            this.datatext8.Name = "datatext8";
            this.datatext8.Size = new System.Drawing.Size(72, 25);
            this.datatext8.TabIndex = 53;
            // 
            // dataname1
            // 
            this.dataname1.AutoSize = true;
            this.dataname1.Location = new System.Drawing.Point(46, 72);
            this.dataname1.Name = "dataname1";
            this.dataname1.Size = new System.Drawing.Size(55, 15);
            this.dataname1.TabIndex = 38;
            this.dataname1.Text = "label2";
            // 
            // dataname8
            // 
            this.dataname8.AutoSize = true;
            this.dataname8.Location = new System.Drawing.Point(167, 199);
            this.dataname8.Name = "dataname8";
            this.dataname8.Size = new System.Drawing.Size(63, 15);
            this.dataname8.TabIndex = 52;
            this.dataname8.Text = "label10";
            // 
            // datatext1
            // 
            this.datatext1.Location = new System.Drawing.Point(39, 96);
            this.datatext1.Name = "datatext1";
            this.datatext1.Size = new System.Drawing.Size(72, 25);
            this.datatext1.TabIndex = 39;
            // 
            // datatext7
            // 
            this.datatext7.Location = new System.Drawing.Point(160, 160);
            this.datatext7.Name = "datatext7";
            this.datatext7.Size = new System.Drawing.Size(72, 25);
            this.datatext7.TabIndex = 51;
            // 
            // dataname2
            // 
            this.dataname2.AutoSize = true;
            this.dataname2.Location = new System.Drawing.Point(46, 136);
            this.dataname2.Name = "dataname2";
            this.dataname2.Size = new System.Drawing.Size(55, 15);
            this.dataname2.TabIndex = 40;
            this.dataname2.Text = "label4";
            // 
            // dataname7
            // 
            this.dataname7.AutoSize = true;
            this.dataname7.Location = new System.Drawing.Point(167, 136);
            this.dataname7.Name = "dataname7";
            this.dataname7.Size = new System.Drawing.Size(55, 15);
            this.dataname7.TabIndex = 50;
            this.dataname7.Text = "label5";
            // 
            // datatext2
            // 
            this.datatext2.Location = new System.Drawing.Point(39, 160);
            this.datatext2.Name = "datatext2";
            this.datatext2.Size = new System.Drawing.Size(72, 25);
            this.datatext2.TabIndex = 41;
            // 
            // datatext6
            // 
            this.datatext6.Location = new System.Drawing.Point(160, 97);
            this.datatext6.Name = "datatext6";
            this.datatext6.Size = new System.Drawing.Size(72, 25);
            this.datatext6.TabIndex = 49;
            // 
            // dataname3
            // 
            this.dataname3.AutoSize = true;
            this.dataname3.Location = new System.Drawing.Point(46, 199);
            this.dataname3.Name = "dataname3";
            this.dataname3.Size = new System.Drawing.Size(55, 15);
            this.dataname3.TabIndex = 42;
            this.dataname3.Text = "label3";
            // 
            // dataname6
            // 
            this.dataname6.AutoSize = true;
            this.dataname6.Location = new System.Drawing.Point(167, 73);
            this.dataname6.Name = "dataname6";
            this.dataname6.Size = new System.Drawing.Size(55, 15);
            this.dataname6.TabIndex = 48;
            this.dataname6.Text = "label6";
            // 
            // datatext3
            // 
            this.datatext3.Location = new System.Drawing.Point(39, 223);
            this.datatext3.Name = "datatext3";
            this.datatext3.Size = new System.Drawing.Size(72, 25);
            this.datatext3.TabIndex = 43;
            // 
            // datatext5
            // 
            this.datatext5.Location = new System.Drawing.Point(160, 33);
            this.datatext5.Name = "datatext5";
            this.datatext5.Size = new System.Drawing.Size(72, 25);
            this.datatext5.TabIndex = 47;
            // 
            // dataname4
            // 
            this.dataname4.AutoSize = true;
            this.dataname4.Location = new System.Drawing.Point(46, 263);
            this.dataname4.Name = "dataname4";
            this.dataname4.Size = new System.Drawing.Size(55, 15);
            this.dataname4.TabIndex = 44;
            this.dataname4.Text = "label8";
            // 
            // dataname5
            // 
            this.dataname5.AutoSize = true;
            this.dataname5.Location = new System.Drawing.Point(167, 9);
            this.dataname5.Name = "dataname5";
            this.dataname5.Size = new System.Drawing.Size(55, 15);
            this.dataname5.TabIndex = 46;
            this.dataname5.Text = "label7";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.play_pro);
            this.tabPage2.Controls.Add(this.record_pro);
            this.tabPage2.Controls.Add(this.play_bar);
            this.tabPage2.Controls.Add(this.Record);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.play_pause);
            this.tabPage2.Controls.Add(this.ImgBox);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "记录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(6, 404);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(81, 23);
            this.Record.TabIndex = 4;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(365, 26);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series5.Name = "Series1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series6.Name = "Series2";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series7.Name = "Series3";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Star4;
            series8.Name = "Series4";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(515, 372);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // play_pause
            // 
            this.play_pause.Location = new System.Drawing.Point(785, 404);
            this.play_pause.Name = "play_pause";
            this.play_pause.Size = new System.Drawing.Size(75, 23);
            this.play_pause.TabIndex = 2;
            this.play_pause.Text = "play";
            this.play_pause.UseVisualStyleBackColor = true;
            this.play_pause.Click += new System.EventHandler(this.play_pause_Click);
            // 
            // ImgBox
            // 
            this.ImgBox.Image = global::usart_tool.Properties.Resources.无标题;
            this.ImgBox.Location = new System.Drawing.Point(22, 26);
            this.ImgBox.Name = "ImgBox";
            this.ImgBox.Size = new System.Drawing.Size(337, 228);
            this.ImgBox.TabIndex = 1;
            this.ImgBox.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(93, 404);
            this.progressBar1.Maximum = 600;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(667, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // Record_timer
            // 
            this.Record_timer.Tick += new System.EventHandler(this.Record_timer_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 61;
            this.label3.Text = "label3";
            // 
            // play_bar
            // 
            this.play_bar.Location = new System.Drawing.Point(6, 308);
            this.play_bar.Name = "play_bar";
            this.play_bar.Size = new System.Drawing.Size(353, 56);
            this.play_bar.TabIndex = 5;
            this.play_bar.Scroll += new System.EventHandler(this.play_bar_Scroll);
            // 
            // record_pro
            // 
            this.record_pro.AutoSize = true;
            this.record_pro.Location = new System.Drawing.Point(362, 383);
            this.record_pro.Name = "record_pro";
            this.record_pro.Size = new System.Drawing.Size(55, 15);
            this.record_pro.TabIndex = 6;
            this.record_pro.Text = "label4";
            // 
            // play_pro
            // 
            this.play_pro.AutoSize = true;
            this.play_pro.Location = new System.Drawing.Point(153, 290);
            this.play_pro.Name = "play_pro";
            this.play_pro.Size = new System.Drawing.Size(55, 15);
            this.play_pro.TabIndex = 7;
            this.play_pro.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 583);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_bar)).EndInit();
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
        private System.Windows.Forms.CheckBox enabledatashow;
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
    }
}

