﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace usart_tool
{
    public struct Datas
    {
        public string name;
        public float num;
    }
    public struct points
    {
        public float[] value;
        public int[] img;
        public float elecnum1;
        public float elecnum2;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        /******************************************************************/
        /// //////////////////变量声明/////////////////////////////////////
        Datas[] data = new Datas[102];//变量数值
        points[] fps = new points[600];//600帧数据
        //10个记录变量ID
        int ID1 = 0, ID2 = 0, ID3 = 0, ID4 = 0, ID5 = 0, ID6 = 0, ID7 = 0, ID8 = 0, ID9 = 0, ID10 = 0;
        int[] buff = new int[600];//串口读出的图像
        int[,] map = new int[80, 60];//解压后图像
        int imgbuffnum = 0;//接受到的图像数组数
        public int time = 0, retime = 0;//记录时间和回放时间
        float elec1 = 10, elec2 = 20;//两个电感值
        int area = 1000;//电感范围
        string replaystate = "record";//记录状态
        long renum = 0;
        int imgnumn = 0;
        bool savestrflag = false;
        string portstr = "";
        char[] strend = { (char)0xaa, (char)0xbb, (char)0xcc };
        List<byte> strlist = new List<byte>();
        List<byte> strhandler = new List<byte>();
        Chart table = new Chart();
        /*****************************************************************/

        //**************************参数初始化与定义************************//
        //参数初始化与定义
        //在这里设置参数的编号和显示值
        //例：设参数Speed_Kd为编号23的变量，
        //data[23].name="Speed_Kd";
        //data[23].num=Speed_Kd;
        //！！！注意:90，91为两个电感专用ID
        void data_init()
        {
            data[11].name = "kp";
            data[11].num = -59;
            data[12].name = "ki";
            data[12].num = 20.56f;
            data[13].name = "kd";
            data[13].num = 57;
            data[21].name = "speed";
            data[21].num = 10;
            data[22].name = "power";
            data[22].num = 1000;
            data[90].name = "elec1";
            data[90].num = elec1;
            data[91].name = "elec2";
            data[91].num = elec2;
        }
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
            catch//(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
        }

        private void Timerscanserial_Tick(object sender, EventArgs e)
        {
            ScanSerial();
        }

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
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string portRead = serialPort1.ReadExisting();
            //string portRead = serialPort1.ReadLine();

            //for (int i = 0; i < portRead.Length; i++)
            //{

            //}
            int n = serialPort1.BytesToRead;
            byte[] portbyte = new byte[n];
            serialPort1.Read(portbyte, 0, n);
            string portRead = Encoding.UTF8.GetString(portbyte);
            for (int i = 0; i < n; i++)
            {
                if (portbyte[i] == '*' || portbyte[i] == '$') savestrflag = true;
                if (savestrflag)
                    strlist.Add(portbyte[i]);
                if (strlist.Count == 599)
                {
                    ;
                }
                if (strlist[strlist.Count - 1] == 0xcc && strlist[strlist.Count - 2] == 0xbb && strlist[strlist.Count - 3] == 0xaa)
                {
                    savestrflag = false;
                    byte[] bytehandler = strlist.ToArray();
                    Readstring(bytehandler, bytehandler.Length - 3);
                    strlist.Clear();
                    break;
                }
            }

            //string[] portReadArr = portRead.Split(strend);
            //if(savestrflag)
            //{
            //    portstr += portRead;
            //}
            //string[] portReadArr = portRead.Split('!');
            renum += portRead.Length;
            Action showReceive = () =>
            {
                receive_text.AppendText(portRead);
                receive_text.ScrollToCaret();
                label3.Text = renum.ToString();
            };
            this.Invoke(showReceive);



        }
        //解读参数
        void Readstring(byte[] str, int n)
        {
            int group, no, num = 0, k = 1, end = 0, start = 0, ID;
            if (str[0] == '$')
            {
                while (end < n - 5)
                {
                    for (int i = start; str[i] != '$'; i++)
                    {
                        start = i + 1;
                    }
                    group = str[start + 1] - 48;
                    no = str[start + 3] - 48;
                    num = 0; k = 1;
                    ID = group * 10 + no;
                    for (int i = end + 2; str[i] != '!'; i++)
                    {
                        end = i;
                        if (i >= n - 1) break;
                    }
                    for (int i = end; str[i] != '@'; i--)
                    {
                        if (str[i] == '-') num *= -1;
                        else
                        {
                            num += (str[i] - 48) * k;
                            k *= 10;
                        }
                    }
                    data[ID].num = num;
                    //switch (ID)
                    //{
                    //    case 11: kp = num; break;
                    //    case 12: ki = num; break;
                    //    case 21: kd = num; break;
                    //    default:
                    //        break;
                    //}
                    start++;
                }
            }
            else if (str[0] == '*')
            {
                Readpic(str, n);
            }

        }
        //串口解读图像
        void Readpic(byte[] str, int n)
        {
            for (int i = 0; i < n; i++)
            {
                //if (str[i] != 0xaa && str[i + 1] != 0xbb)
                // if(imgnumn+n<=600&&str[i]>=48&&str[i]<=57)
                if (i < 600)
                    buff[i] = str[i + 1] + 11;
                //else
                //    break;
            }
            imgnumn += n;
            if (imgnumn >= 600) imgnumn = 0;
            for (int i = 0; i < 600; i++)
            {
                buff[i] -= 11;
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
                    flag0 = false;
                }
                if (data[i].name == sendname1.Text)
                {
                    sendID1.Text = i.ToString();
                    flag1 = false;
                }
                if (data[i].name == sendname2.Text)
                {
                    sendID2.Text = i.ToString();
                    flag2 = false;
                }
                if (data[i].name == sendname3.Text)
                {
                    sendID3.Text = i.ToString();
                    flag3 = false;
                }
                if (data[i].name == sendname4.Text)
                {
                    sendID4.Text = i.ToString();
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
            int id = 0, n = 0;
            if (sendID0.Text != "error")
            {
                id = int.Parse(sendID0.Text);
                n = int.Parse(sendnum0.Text);
                serialPort1.WriteLine(sendnum(id / 10, id % 10, n));
            }
            if (sendID1.Text != "error")
            {
                id = int.Parse(sendID1.Text);
                n = int.Parse(sendnum1.Text);
                serialPort1.WriteLine(sendnum(id / 10, id % 10, n));
            }
            if (sendID2.Text != "error")
            {
                id = int.Parse(sendID2.Text);
                n = int.Parse(sendnum2.Text);
                serialPort1.WriteLine(sendnum(id / 10, id % 10, n));
            }
            if (sendID3.Text != "error")
            {
                id = int.Parse(sendID3.Text);
                n = int.Parse(sendnum3.Text);
                serialPort1.WriteLine(sendnum(id / 10, id % 10, n));
            }
            if (sendID4.Text != "error")
            {
                id = int.Parse(sendID4.Text);
                n = int.Parse(sendnum4.Text);
                serialPort1.WriteLine(sendnum(id / 10, id % 10, n));
            }
        }
        //解压图像
        void Changemap(int[] imgbuff)
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
        //按格式整合参数
        //sendnum(ID十位, ID个位, 数值)
        //输出   "$ID十位.ID个位@数值! "
        //例：ID为56数值为74
        //sendnum(5,6,74);
        string sendnum(int group, int no, float num)
        {
            string str = "$" + group.ToString() + "." + no.ToString() + "@" + num.ToString() + "!";
            return str;
        }
        //********************发送电感值********************************//
        //发送电感值
        //send_elec(第一个值,第二个值);
        //例：第一个值15，第二个值68
        //send_elec(15,68);
        void send_elec(float ad1, float ad2)
        {
            serialPort1.Write(sendnum(9, 0, ad1) + '\n');
            Thread.Sleep(10);
            serialPort1.Write(sendnum(9, 1, ad2) + '\n');
        }
        private void play_pause_Click(object sender, EventArgs e)
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
        float changenum(string name)
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
        void showdatas()
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
            //for (int i = 0; i < 600; i++)
            //{
            //    buff[i] = 0;
            //}
            data_init();
            for (int i = 0; i < 100; i++)
                table.chartdata[i].name = data[i].name;
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

        private void button2_Click(object sender, EventArgs e)
        {
            send_elec(30, 40);
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Changemap(buff);
            Display(map);
        }

        private void Record_timer_Tick(object sender, EventArgs e)
        {
            if (replaystate == "record")
            {
                if (time < 600)
                {
                    record_pro.Text = time.ToString() + "/600";
                    progressBar1.Value = time;
                    // buff[time] = 1;
                    data[11].num += 20f;
                    data[12].num += 10f;
                    data[21].num -= 20f;
                    data[22].num -= 10f;
                    elec1 += 10;
                    elec2 -= 10;
                }
                Recorddata(time);
                time++;
            }
            else if (replaystate == "play")
            {
                if (retime < time)
                {
                    play_bar.Maximum = time;
                    play_bar.Value = retime;
                    play_pro.Text = retime.ToString() + "/" + time.ToString();
                    play(retime);
                    if (ChartEng.Checked)
                        Reflashchartdata(retime);
                    retime++;
                }
            }
        }

        void Recorddata(int num)
        {
            fps[time].img = new int[600];
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
        void play(int num)
        {
            if (ImgEng.Checked)
            {
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
        private void play_bar_Scroll(object sender, EventArgs e)
        {
            retime = play_bar.Value;
            if (play_pause.Text == "play" && retime < time)
            {
                play_pro.Text = retime.ToString() + "/" + time.ToString();
                play(retime);
            }
        }

        private void PnUp_Click(object sender, EventArgs e)
        {
            retime--;
            if (play_pause.Text == "play" && retime < time && retime > 0)
            {
                play_pro.Text = retime.ToString() + "/" + time.ToString();
                play(retime);
            }
        }

        private void UgDn_Click(object sender, EventArgs e)
        {
            retime++;
            if (play_pause.Text == "play" && retime < time)
            {
                play_pro.Text = retime.ToString() + "/" + time.ToString();
                play(retime);
            }
        }

        private void Datatimer_Tick(object sender, EventArgs e)
        {
            showdatas();
        }

        private void Enabledatashow_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void Enabledatashow_CheckedChanged(object sender, EventArgs e)
        {
            if (Enabledatashow.Checked) Datatimer.Enabled = true;
            else Datatimer.Enabled = false;
        }

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
            chart1.Series[0].Name = data[cID1].name;
            chart1.Series[1].Name = data[cID2].name;
            chart1.Series[2].Name = data[cID3].name;
            chart1.Series[3].Name = data[cID4].name;
            table.reflashChart(chart1, num, cID1, cID2, cID3, cID4);
        }
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
