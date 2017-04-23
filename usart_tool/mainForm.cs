using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace usart_tool
{

    public struct Datas
    {
        public string name;
        public float num;
    }
    public struct Points
    {
        public float[] value;
        public byte[] img;
        public float elecnum1;
        public float elecnum2;
    }
    public partial class mainForm : Form
    {

        public mainForm()
        {

            InitializeComponent();
        }
        //// //////////////////变量声明/////////////////////////////////////
        Datas[] data = new Datas[102];//变量数值
        Points[] fps = new Points[6000];//6000帧数据
        //10个记录变量ID
        int ID1 = 0, ID2 = 0, ID3 = 0, ID4 = 0, ID5 = 0, ID6 = 0, ID7 = 0, ID8 = 0, ID9 = 0, ID10 = 0;
        byte[] buff = new byte[600];//串口读出的图像
        int[,] map = new int[80, 60];//解压后图像
        public int time = 0, retime = 0;//记录时间和回放时间
        float elec1 = 10, elec2 = 20;//两个电感值
        int area = 1000;//电感范围
        string replaystate = "record";//记录状态
        long renum = 0;//接收到的字节数
        bool savestrflag = false, filestrflag = false;
        List<byte> strlist = new List<byte>();//串口读取缓存链表
        byte[] start = { 0xaa, 0xbb };//包头
        byte[] datastart = { 0xab, 0xba };//包头
        byte[] dataend = { 0xcc, 0xdd };//包头
        byte[] end = { 0xcc, 0xdd, 0xee };//包尾
        List<byte> readList = new List<byte>();//文件读取缓存链表
        Chart table = new Chart();//图表窗口
        Thread thread_sendnum;//线程：发送数据
        img_player.Form1 player = new img_player.Form1();
        Scope.Form1 scoper = new Scope.Form1();
        /*****************************************************************/
        //////////////////////////调试变量/////////////////////////////////
        float kp = 0, ki = 0, kd = 0;
        /*****************************************************************/
        ////////////////////////ini所需函数////////////////////////////////
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        string inifilePath = AppDomain.CurrentDomain.BaseDirectory + "Config.ini";
        StringBuilder initemp = new StringBuilder(255);
        //**************************参数初始化与定义************************//
        //通过ini配置文件来初始化参数
        void Data_init()
        {
            for (int i = 0; i < 100; i++)
            {
                GetPrivateProfileString("ID." + i.ToString(), "name", "unnamed", initemp, 255, inifilePath);
                data[i].name = initemp.ToString();
                GetPrivateProfileString("ID." + i.ToString(), "value", "0", initemp, 255, inifilePath);
                data[i].num = float.Parse(initemp.ToString());
            }
        }
        //********************************************************************//

        //打开——关闭串口
        private void Button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    button1.Text = "打开串口";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    button1.Text = "关闭串口";
                }
            }
            else
            {
                try
                {
                    serialPort1.PortName = comboBoxSerialPortName.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                    serialPort1.Open();
                    button1.Text = "关闭串口";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    button1.Text = "打开串口";
                }
            }
        }
        int portNamesLength = 0;
        //**************************扫描串口*********************************//
        void ScanSerial()
        {
            try
            {
                string[] portNames = SerialPort.GetPortNames();
                if (portNames.Length != portNamesLength)
                {
                    comboBoxSerialPortName.Items.Clear();
                    comboBoxSerialPortName.Items.AddRange(portNames);
                    comboBoxSerialPortName.SelectedIndex = 0;


                    portNamesLength = portNames.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Timerscanserial_Tick(object sender, EventArgs e)
        {
            ScanSerial();
        }
        //***********************发送串口发送区内容***************************//
        private void Sendline_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine(Sendbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //**************************串口数据接受******************************************//

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = serialPort1.BytesToRead;
            byte[] portbyte = new byte[n];
            serialPort1.Read(portbyte, 0, n);
            string portRead = Encoding.UTF8.GetString(portbyte);
            if (label17.Text == "busy")
            {
                Action gggw = () =>
                {
                    label17.Text = "wait";
                };
                BeginInvoke(gggw);
            }
            for (int i = 0; i < n; i++)
            {
                if (i + 2 < n)
                {
                    if (portbyte[i] == 0xaa && portbyte[i + 1] == 0xbb)
                    {
                        savestrflag = true;
                        i += 2;
                    }
                }
                if (savestrflag)
                    strlist.Add(portbyte[i]);
                if (strlist.Count > 3)
                {
                    if (strlist[strlist.Count - 1] == 0xee && strlist[strlist.Count - 2] == 0xdd && strlist[strlist.Count - 3] == 0xcc)
                    {
                        savestrflag = false;
                        byte[] bytehandler = strlist.ToArray();
                        // Readstring(bytehandler, bytehandler.Length - 3);
                        if (!backgroundWorker1.IsBusy)
                            backgroundWorker1.RunWorkerAsync(bytehandler);
                        else if (!backgroundWorker3.IsBusy)
                            backgroundWorker3.RunWorkerAsync(bytehandler);
                        else if (!backgroundWorker4.IsBusy)
                            backgroundWorker4.RunWorkerAsync(bytehandler);
                        else if (!backgroundWorker5.IsBusy)
                            backgroundWorker5.RunWorkerAsync(bytehandler);
                        else
                        {
                            Action ggg = () =>
                             {
                                 label17.Text = "busy";
                             };
                            BeginInvoke(ggg);
                        }
                        strlist.Clear();
                        if (i + 2 < n)
                        {
                            if (portbyte[i] == 0xaa && portbyte[i + 1] == 0xbb)
                            {
                                savestrflag = true;
                                i += 2;
                            }
                        }
                    }
                }
            }
            if (checkConnect.Checked)
            {
                player.bConnect = true;
                for (int i = 0; i < 600; i++)
                {
                    player.fps[0].img[i] = buff[i];
                }
            }
            renum += portRead.Length;
            if (!savestrflag)
            {
                Action showReceive = () =>
                            {
                                receive_text.AppendText(portRead);
                                receive_text.ScrollToCaret();
                                label3.Text = renum.ToString();
                            };
                this.BeginInvoke(showReceive);
            }
        }
        bool flag_AddData = false;
        //解读参数
        //数据解读已能用
        //图像包头：0xcc,0xcd,0xdc
        //数据包头：0xab,0xba
        void Readstring(byte[] str, int n)
        {
            byte ID;
            flag_AddData = false;
            for (int s = 1; s < n; s++)
            {
                if (str[s] == 0xba && str[s - 1] == 0xab && s + 5 < str.Length)
                {
                    ID = str[s + 1];
                    byte[] ch = { str[s + 2], str[s + 3], str[s + 4], str[s + 5] };
                    unsafe
                    {
                        fixed (byte* pData = ch)   //正确，使用fixed固定 
                        {
                            if (ID < 100)
                            {
                                data[ID].num = *(float*)pData;
                                scoper.member[ID].num = data[ID].num;
                                if (scoper.enGo)
                                {
                                    flag_AddData = true;
                                }
                            }
                        }
                    }
                    s += 5;

                    //if (ID == 99)
                    //{
                    //    Action SendDataToSco = () =>
                    //    {
                    //        // if(ID==99)
                    //        scoper.data.Add(data[99].num);
                    //        scoper.Invalidate();
                    //    };
                    //    this.BeginInvoke(SendDataToSco);

                    //}
                }
                if (s - 2 >= 0)
                    if (str[s] == 0xdc && str[s - 1] == 0xcd && str[s - 2] == 0xcc)
                    {
                        Readpic(str, s);
                    }
            }
        }
        //串口解读图像
        void Readpic(byte[] str, int n)
        {
            for (int i = n + 1; i < n + 1 + 600; i++)
            {
                buff[i - n - 1] = str[i];
            }
        }
        //**********************刷新待发送参数*******************************//
        //刷新待发送参数
        //识别成功的参数名显示出参数ID
        //未识别成功的参数显示error
        private void Resenddata_Click(object sender, EventArgs e)
        {
            bool flag0 = true, flag1 = true, flag2 = true, flag3 = true, flag4 = true;
            for (int i = 0; i < 100; i++)
            {
                if (data[i].name == sendname0.Text)
                {
                    sendID0.Text = i.ToString();
                    sendnum0.Text = data[i].num.ToString();
                    flag0 = false;
                }
                if (data[i].name == sendname1.Text)
                {
                    sendID1.Text = i.ToString();
                    sendnum1.Text = data[i].num.ToString();
                    flag1 = false;
                }
                if (data[i].name == sendname2.Text)
                {
                    sendID2.Text = i.ToString();
                    sendnum2.Text = data[i].num.ToString();
                    flag2 = false;
                }
                if (data[i].name == sendname3.Text)
                {
                    sendID3.Text = i.ToString();
                    sendnum3.Text = data[i].num.ToString();
                    flag3 = false;
                }
                if (data[i].name == sendname4.Text)
                {
                    sendID4.Text = i.ToString();
                    sendnum4.Text = data[i].num.ToString();
                    flag4 = false;
                }

            }
            if (flag0) sendID0.Text = "error";
            if (flag1) sendID1.Text = "error";
            if (flag2) sendID2.Text = "error";
            if (flag3) sendID3.Text = "error";
            if (flag4) sendID4.Text = "error";
        }

        private void Senddata_Click(object sender, EventArgs e)
        {
            thread_sendnum = new Thread(new ThreadStart(Pro_sendnum));
            thread_sendnum.Start();
        }
        //解压图像
        void Changemap(byte[] imgbuff)
        {
            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        if ((imgbuff[i * 10 + j] & (1 << k)) != 0)
                        {
                            map[j * 8 + 7 - k, i] = 1;
                        }
                        else
                        {
                            map[j * 8 + 7 - k, i] = 0;
                        }
                    }
                }
            }

        }
        //*******************按格式整合参数******************************//
        //按格式整合发送参数
        //sendnum(ID, 数值)
        //例：ID为56数值为74
        //sendnum(56,74);
        //格式：包头+'$'+ID+'@'+数值+包尾


        void Sendnum(byte ID, float num)
        {
            byte[] ch = new byte[4];
            byte[] b = { ID, 0 };
            unsafe
            {
                fixed (byte* pData = ch)   //正确，使用fixed固定 
                {
                    *(float*)(pData) = num;
                }
            }
            try
            {
                serialPort1.Write(datastart, 0, 2);
                serialPort1.Write(b, 0, 1);
                serialPort1.Write(ch, 0, 4);
                serialPort1.Write(dataend, 0, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //********************发送电感值********************************//
        //发送电感值
        //send_elec(第一个值,第二个值);
        //例：第一个值15，第二个值68
        //send_elec(15,68);
        void Send_elec(float ad1, float ad2)
        {
            Sendnum(90, ad1);
            Thread.Sleep(10);
            Sendnum(91, ad2);
        }
        private void Play_pause_Click(object sender, EventArgs e)
        {
            if (Record_timer.Enabled == false)
            {
                if (Record.Text == "stop")
                {
                    MessageBox.Show("模式冲突", "error", MessageBoxButtons.OK);
                }
                else
                {
                    play_pause.Text = "pause";
                    replaystate = "play";
                    Record_timer.Enabled = true;
                }
            }
            else
            {
                play_pause.Text = "play";
                Record_timer.Enabled = false;
            }
        }

        private void Record_Click(object sender, EventArgs e)
        {
            if (Record_timer.Enabled == false)
            {
                if (play_pause.Text == "pause")
                {
                    MessageBox.Show("模式冲突", "error", MessageBoxButtons.OK);
                }
                else
                {
                    Record.Text = "stop";
                    replaystate = "record";
                    Record_timer.Enabled = true;
                }
            }
            else
            {
                Record.Text = "record";
                Record_timer.Enabled = false;
            }
        }
        //*********************更改参数//////////////////////////////////////
        //更改参数
        //待改参数=changenum(待改参数名）;
        //例：Speed_Kd=changenum("Speed_Kd");
        float Changenum(string name)
        {
            float n = 0;
            for (int i = 0; i < 102; i++)
            {
                if (data[i].name == name)
                {
                    n = data[i].num;
                    break;
                }
            }
            return n;
        }
        //****************************显示参数*****************************//
        //显示参数
        //只显示ID十位为下拉列表的参数
        void Showdatas()
        {
            int group = int.Parse(comboBox1.Text);
            dataname0.Text = data[group * 10].name;
            dataname1.Text = data[group * 10 + 1].name;
            dataname2.Text = data[group * 10 + 2].name;
            dataname3.Text = data[group * 10 + 3].name;
            dataname4.Text = data[group * 10 + 4].name;
            dataname5.Text = data[group * 10 + 5].name;
            dataname6.Text = data[group * 10 + 6].name;
            dataname7.Text = data[group * 10 + 7].name;
            dataname8.Text = data[group * 10 + 8].name;
            dataname9.Text = data[group * 10 + 9].name;
            datatext0.Text = data[group * 10].num.ToString();
            datatext1.Text = data[group * 10 + 1].num.ToString();
            datatext2.Text = data[group * 10 + 2].num.ToString();
            datatext3.Text = data[group * 10 + 3].num.ToString();
            datatext4.Text = data[group * 10 + 4].num.ToString();
            datatext5.Text = data[group * 10 + 5].num.ToString();
            datatext6.Text = data[group * 10 + 6].num.ToString();
            datatext7.Text = data[group * 10 + 7].num.ToString();
            datatext8.Text = data[group * 10 + 8].num.ToString();
            datatext9.Text = data[group * 10 + 9].num.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Data_init();
            comboBox1.SelectedItem = 0;
            for (int i = 0; i < 100; i++)
                table.chartdata[i].name = data[i].name;
            player.fps[0].img = new int[600];
            GetPrivateProfileString("data", "value2", "null", initemp, 255, inifilePath);
            comboBoxBaudRate.SelectedIndex = 1;
            PlayMode.SelectedIndex = 0;
            ImgEng.Checked = true;
            tabControl1.SelectedIndex = 1;        //选项卡默认设置为摄像头选项卡   
            comboBox1.SelectedIndex = 0;
        }
        void Pro_sendnum()
        {
            try
            {
                int id = 0; float n = 0;
                if (sendID0.Text != "error")
                {
                    id = int.Parse(sendID0.Text);
                    n = float.Parse(sendnum0.Text);
                    Sendnum((byte)id, n);
                    Thread.Sleep(200);
                }
                if (sendID1.Text != "error")
                {
                    id = int.Parse(sendID1.Text);
                    n = float.Parse(sendnum1.Text);
                    Sendnum((byte)id, n);
                    Thread.Sleep(200);
                }
                if (sendID2.Text != "error")
                {
                    id = int.Parse(sendID2.Text);
                    n = float.Parse(sendnum2.Text);
                    Sendnum((byte)id, n);
                    Thread.Sleep(200);
                }
                if (sendID3.Text != "error")
                {
                    id = int.Parse(sendID3.Text);
                    n = float.Parse(sendnum3.Text);
                    Sendnum((byte)id, n);
                    Thread.Sleep(200);
                }
                if (sendID4.Text != "error")
                {
                    id = int.Parse(sendID4.Text);
                    n = float.Parse(sendnum4.Text);
                    Sendnum((byte)id, n);
                    Thread.Sleep(200);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            thread_sendnum.Abort();
        }

        void Display(int[,] image_buff)
        {
            Graphics g = ImgBox.CreateGraphics();

            for (int i = 0; i < 60; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    if (image_buff[j, i] == 1)
                    {
                        Rectangle rect = new Rectangle(j * 3, i * 3, 3, 3);
                        g.FillRectangle(Brushes.Black, rect);
                    }
                    else
                    {
                        Rectangle rect = new Rectangle(j * 3, i * 3, 3, 3);
                        g.FillRectangle(Brushes.White, rect);
                    }
                }
            }
        }

        private void CreateNewDrawer()//创建ADC绘制窗口
        {
            //Displayer = new Scope();//创建新对象
            //Displayer.ShowMainWindow = new ShowWindow(ShowMe);//初始化类成员委托
            //Displayer.HideMainWindow = new HideWindow(HideMe);
            //Displayer.GetMainPos = new GetMainPos(GetMyPos);
            //Displayer.CloseSerialPort = new ClosePort(ClosePort);
            //Displayer.OpenSerialPort = new OpenPort(OpenPort);
            //Displayer.GetMainWidth = new GetMainWidth(GetMyWidth);
            //Displayer.Show();//显示窗口
        }
        private void CreateDisplayer()
        {
            this.Left = 0;
            CreateNewDrawer();
            Rectangle Rect = Screen.GetWorkingArea(this);
            //Displayer.SetWindow(Rect.Width - this.Width, new Point(this.Width, this.Top));//设置绘制窗口宽度，以及坐标
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            CreateDisplayer();
        }


        //**************************储存图像为txt文件**************************//
        public void Save_image(int fpsnum)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "txt文件|*.txt"//过滤文件。。。
            };
            string SaveFileName = string.Format("{0:MMddHHmm}", System.DateTime.Now);
            string localFilePath = saveFileDialog.FileName.ToString();
            saveFileDialog.FileName = localFilePath + "摄像头数据" + SaveFileName + ".txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFileName = saveFileDialog.FileName;
                byte[] imgstart = { 0xaa, 0xbb, (byte)'*' };
                FileStream fs = new FileStream(localFilePath + SaveFileName, FileMode.Create);
                for (int i = 0; i < fpsnum; i++)
                {
                    fs.Write(imgstart, 0, 3);
                    fs.Write(fps[i].img, 0, 600);
                    fs.Write(end, 0, 3);
                }
                //清空缓冲区、关闭流
                fs.Flush();
                fs.Close();
            }
        }
        //**************************读取txt图像文件****************************//
        public void Read()
        {

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Filter = "txt文件|*.txt"//过滤文件。。。
                };
                DialogResult result = openFileDialog.ShowDialog();
                string localFilePath = "";
                if (result == DialogResult.OK)
                {
                    //获得文件路径
                    localFilePath = openFileDialog.FileName.ToString();
                }
                FileStream file = new FileStream(localFilePath, FileMode.Open);
                byte[] readByte = new byte[file.Length];
                file.Seek(0, SeekOrigin.Begin);
                file.Read(readByte, 0, readByte.Length); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                receive_text.Text = System.Text.Encoding.ASCII.GetString(readByte);
                Read_imgFile(readByte, readByte.Length);
                file.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        //**************************解压txt图像文件****************************//
        void Read_imgFile(byte[] str, int fpsLength)
        {
            fps[time].img = new byte[600];
            fps[time].value = new float[102];
            for (int i = 0; i < fpsLength; i++)
            {
                if (str[i] == 0xaa && str[i + 1] == 0xbb)
                    if (str[i + 2] == '*' || str[i + 2] == '$') filestrflag = true;
                if (filestrflag)
                    readList.Add(str[i]);
                if (readList.Count > 3)
                    if (readList[readList.Count - 1] == 0xee && readList[readList.Count - 2] == 0xdd && readList[readList.Count - 3] == 0xcc)
                    {
                        filestrflag = false;
                        byte[] bytehandler = readList.ToArray();
                        Readstring(bytehandler, bytehandler.Length - 3);
                        for (int j = 0; j < 600; j++)
                        {
                            fps[time].img[j] = buff[j];
                        }
                        readList.Clear();
                        time++;
                        fps[time].img = new byte[600];
                        fps[time].value = new float[102];
                    }
            }
        }

        private void 打开配置文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(inifilePath);
        }

        private void 重新生成配置文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                WritePrivateProfileString("ID." + i.ToString(), "value", "0", inifilePath);
                WritePrivateProfileString("ID." + i.ToString(), "name", "unnamed", inifilePath);
            }
        }

        private void 保存记录文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save_image(time);
        }
        //********************************清空初始化图像***************************//
        void Imgdatainit()
        {
            for (int i = 0; i < time; i++)
            {
                for (int j = 0; j < 600; j++)
                {
                    fps[i].img[j] = 0;
                }
            }
            time = 0;
            retime = 0;
        }
        private void 打开记录文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imgdatainit();
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog()
                {
                    Filter = "txt文件|*.txt"//过滤文件。。。
                };
                //saveFileDialog.FileName = "Lanny.raw";//默认文件名

                DialogResult result = openFileDialog.ShowDialog();
                string localFilePath = "";
                if (result == DialogResult.OK)
                {
                    //获得文件路径
                    localFilePath = openFileDialog.FileName.ToString();
                }
                FileStream file = new FileStream(localFilePath, FileMode.Open);
                byte[] readByte = new byte[file.Length];
                file.Seek(0, SeekOrigin.Begin);
                file.Read(readByte, 0, readByte.Length); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
                receive_text.Text = System.Text.Encoding.ASCII.GetString(readByte);
                Read_imgFile(readByte, readByte.Length);
                file.Close();
            }
            catch (IOException err)
            {
                Console.WriteLine(err.ToString());
            }
        }
        private void CheckConnect_CheckedChanged(object sender, EventArgs e)
        {
            player.bConnect = checkConnect.Checked;
        }

        private void 工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player = new img_player.Form1();
            player.fps[0].img = new int[600];
            player.Show();
        }
        bool flag_key = false;
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) flag_key = true;
            if (flag_key)
                if (e.KeyCode == Keys.Space) Sendnum(0, 0);
        }

        private void 示波器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scoper = new Scope.Form1();
            scoper.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            serialPort1.Close();
            thread_sendnum = new Thread(new ThreadStart(Pro_sendnum));
            thread_sendnum.Abort();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
            thread_sendnum.Abort();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Readstring((byte[])e.Argument, ((byte[])e.Argument).Length);
            if (flag_AddData)
            {
                if (!backgroundWorker2.IsBusy)
                {
                    backgroundWorker2.RunWorkerAsync();
                }
                flag_AddData = false;
            }
        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Action SendDataToSco = () =>
            {
                scoper.Add_data();
                scoper.Invalidate();
            };
            if (!scoper.IsDisposed)
                this.Invoke(SendDataToSco);
        }

        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Readstring((byte[])e.Argument, ((byte[])e.Argument).Length);
            if (flag_AddData)
            {
                if (!backgroundWorker6.IsBusy)
                {
                    backgroundWorker6.RunWorkerAsync();
                }
                flag_AddData = false;
            }
        }

        private void backgroundWorker4_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Readstring((byte[])e.Argument, ((byte[])e.Argument).Length);
            if (flag_AddData)
            {
                if (!backgroundWorker7.IsBusy)
                {
                    backgroundWorker7.RunWorkerAsync();
                }
                flag_AddData = false;
            }
        }

        private void backgroundWorker5_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Readstring((byte[])e.Argument, ((byte[])e.Argument).Length);
            if (flag_AddData)
            {
                if (!backgroundWorker8.IsBusy)
                {
                    backgroundWorker8.RunWorkerAsync();
                }
                flag_AddData = false;
            }
        }

        private void backgroundWorker6_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Action SendDataToSco = () =>
            {
                scoper.Add_data();
                scoper.Invalidate();
            };
            if (!scoper.IsDisposed)
                this.Invoke(SendDataToSco);
        }

        private void backgroundWorker7_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Action SendDataToSco = () =>
            {
                scoper.Add_data();
                scoper.Invalidate();
            };
            if (!scoper.IsDisposed)
                this.Invoke(SendDataToSco);
        }

        private void backgroundWorker8_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Action SendDataToSco = () =>
            {
                scoper.Add_data();
                scoper.Invalidate();
            };
            if (!scoper.IsDisposed)
                this.Invoke(SendDataToSco);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (Control myControls in groupBox3.Controls)
            {
                if (myControls.ToString().IndexOf("TextBox") > 0)
                {
                     
                    myControls.Text = i.ToString();
                    i++;
                }
            }
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control) flag_key = false;
        }

        private void TimerUpdate_Tick(object sender, EventArgs e)
        {
            kp = data[10].num;
            ki = data[11].num;
            kd = data[12].num;
        }

        private void 更新配置文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_init();
            for (int i = 0; i < 100; i++)
                table.chartdata[i].name = data[i].name;
        }
        //*****************************初始化图像********************************//
        private void Button5_Click(object sender, EventArgs e)
        {
            Imgdatainit();
            progressBar1.Value = 0;
        }
        //****************************记录，播放用定时器**************************//
        private void Record_timer_Tick(object sender, EventArgs e)
        {

            if (replaystate == "record")
            {
                if (time < 6000)
                {
                    record_pro.Text = time.ToString() + "/" + (time / 600 * 600 + 600).ToString();
                    if (time >= progressBar1.Maximum) progressBar1.Maximum += 600;
                    progressBar1.Value = time;
                    // buff[time] = 1;
                    //data[11].num += 20f;
                    //data[12].num += 10f;
                    //data[21].num -= 20f;
                    //data[22].num -= 10f;
                    elec1 += 10;
                    elec2 -= 10;
                    // Displayer.AddData(elec1);
                }
                Recorddata(time);
                time++;
            }
            else if (replaystate == "play")
            {
                if (retime < time)
                {
                    Play(retime);
                    if (ChartEng.Checked)
                        Reflashchartdata(retime);
                    retime++;
                }
            }

        }
        //***************************记录数据************************************//
        void Recorddata(int num)
        {
            fps[time].img = new byte[600];
            fps[time].value = new float[100];
            for (int i = 0; i < 100; i++)
            {
                fps[num].value[i] = data[i].num;
            }
            if (PlayMode.Text == "摄像头")
                for (int i = 0; i < 600; i++)
                {
                    fps[time].img[i] = buff[i];
                }
            if (PlayMode.Text == "电感")
            {
                fps[time].elecnum1 = elec1;
                fps[time].elecnum2 = elec2;
            }
        }
        //******************************播放****************************************//
        void Play(int num)
        {
            if (ImgEng.Checked)
            {
                play_bar.Maximum = time;
                play_bar.Value = retime;
                play_pro.Text = retime.ToString() + "/" + time.ToString();
                if (PlayMode.Text == "摄像头")
                {
                    Changemap(fps[num].img);
                    Display(map);
                }
                if (PlayMode.Text == "电感")
                {
                    if (fps[num].elecnum1 < area && fps[num].elecnum1 > -area)
                        ElecTrack1.Value = (int)fps[num].elecnum1 + area;
                    if (fps[num].elecnum2 < area && fps[num].elecnum2 > -area)
                        ElecTrack2.Value = (int)fps[num].elecnum2 + area;
                }
            }
            DataReplay(num);
        }
        //****************************拖动进度条*********************************//
        private void Play_bar_Scroll(object sender, EventArgs e)
        {
            retime = play_bar.Value;
            if (play_pause.Text == "play" && retime < time)
            {
                play_pro.Text = retime.ToString() + "/" + time.ToString();
                Play(retime);
            }
        }
        //****************************上一帧*************************************//
        private void PnUp_Click(object sender, EventArgs e)
        {

            if (play_pause.Text == "play" && retime > 0)
            {
                retime--;
                Play(retime);
            }
        }
        //*******************************下一帧********************************//
        private void UgDn_Click(object sender, EventArgs e)
        {

            if (play_pause.Text == "play" && retime < time)
            {
                retime++;
                Play(retime);
            }
        }
        //*****************************定时器——更新显示数据**********************//
        //将想显示的参数添加到此定时器内
        //例：想显示speed
        //添加speed=changenum("speed");
        private void Datatimer_Tick(object sender, EventArgs e)
        {
            kp = Changenum("kp");
            Showdatas();
        }


        private void Enabledatashow_CheckedChanged(object sender, EventArgs e)
        {
            if (Enabledatashow.Checked) Datatimer.Enabled = true;
            else Datatimer.Enabled = false;
        }
        //***************************更新图表数据*****************************//
        void Reflashchartdata(int num)
        {
            string name1 = textBox11.Text;
            string name2 = textBox12.Text;
            string name3 = textBox13.Text;
            string name4 = textBox14.Text;
            int cID1 = 0, cID2 = 0, cID3 = 0, cID4 = 0;
            for (int i = 0; i < 100; i++)
            {
                table.chartdata[i].num = fps[num].value[i];
                if (data[i].name == name1) cID1 = i;
                if (data[i].name == name2) cID2 = i;
                if (data[i].name == name3) cID3 = i;
                if (data[i].name == name4) cID4 = i;
            }
            if (textBox1.Text != "")
                chart1.Series[0].Name = data[cID1].name;
            if (textBox2.Text != "")
                chart1.Series[1].Name = data[cID2].name;
            if (textBox3.Text != "")
                chart1.Series[2].Name = data[cID3].name;
            if (textBox4.Text != "")
                chart1.Series[3].Name = data[cID4].name;
            table.reflashChart(chart1, num, cID1, cID2, cID3, cID4);
        }
        //****************************更新显示图表数据***********************//
        void DataReplay(int num)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            string s3 = textBox3.Text;
            string s4 = textBox4.Text;
            string s5 = textBox5.Text;
            string s6 = textBox6.Text;
            string s7 = textBox7.Text;
            string s8 = textBox8.Text;
            string s9 = textBox9.Text;
            string s10 = textBox10.Text;
            for (int i = 0; i < 100; i++)
            {
                table.chartdata[i].num = fps[num].value[i];
                if (data[i].name == s1) ID1 = i;
                if (data[i].name == s2) ID2 = i;
                if (data[i].name == s3) ID3 = i;
                if (data[i].name == s4) ID4 = i;
                if (data[i].name == s5) ID5 = i;
                if (data[i].name == s6) ID6 = i;
                if (data[i].name == s7) ID7 = i;
                if (data[i].name == s8) ID8 = i;
                if (data[i].name == s9) ID9 = i;
                if (data[i].name == s10) ID10 = i;

            }
            label4.Text = fps[num].value[ID1].ToString();
            label5.Text = fps[num].value[ID2].ToString();
            label6.Text = fps[num].value[ID3].ToString();
            label7.Text = fps[num].value[ID4].ToString();
            label8.Text = fps[num].value[ID5].ToString();
            label9.Text = fps[num].value[ID6].ToString();
            label10.Text = fps[num].value[ID7].ToString();
            label11.Text = fps[num].value[ID8].ToString();
            label12.Text = fps[num].value[ID9].ToString();
            label13.Text = fps[num].value[ID10].ToString();
        }

    }
}
