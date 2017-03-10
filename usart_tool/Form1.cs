using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
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
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /******************************************************************/
        /// //////////////////变量声明/////////////////////////////////////
        Datas[] data = new Datas[100];
        points[] fps = new points[600];
        int[] buff = new int[600];
        int[,] map = new int[80, 60];
        int imgbuffnum = 0;
       public int time = 0, retime = 0;
        int[,] imgground = new int[600, 600];
        int n = 0;
        string replaystate = "record";
        Chart table = new Chart();
        /*****************************************************************/
        //参数初始化与定义
        //在这里设置参数的编号和显示值
        //例：设参数Speed_Kd为编号23的变量，
        //data[23].name="Speed_Kd";
        //data[23].num=Speed_Kd;
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
            string portRead = serialPort1.ReadLine();
            string[] portReadArr = portRead.Split('!');
            Action showReceive = () =>
            {
                receive_text.AppendText(portRead);
                receive_text.ScrollToCaret();
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
            else
            {
                Readpic(str, n);
            }

        }
        //串口解读图像
        void Readpic(byte[] str, int n)
        {
            int k = 1, start = 0, end = 0, sum = 0;
            for (int j = 0; j < n; j++)
            {
                if (str[j] == '!')
                {
                    if ((str[j + 1] == '#') || imgbuffnum == 640)
                        imgbuffnum = 0;
                    for (int i = j - 1; str[i] != '*'; i--)
                    {
                        sum += (str[i] - 48) * k;
                        k *= 10;
                    }
                    buff[imgbuffnum] = sum;
                    imgbuffnum++;
                    sum = 0;
                    k = 1;
                }
            }
        }
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
                serialPort1.Write(sendnum(id / 10, id % 10, n));
            }
            if (sendID1.Text != "error")
            {
                id = int.Parse(sendID1.Text);
                n = int.Parse(sendnum1.Text);
                serialPort1.Write(sendnum(id / 10, id % 10, n));
            }
            if (sendID2.Text != "error")
            {
                id = int.Parse(sendID2.Text);
                n = int.Parse(sendnum2.Text);
                serialPort1.Write(sendnum(id / 10, id % 10, n));
            }
            if (sendID3.Text != "error")
            {
                id = int.Parse(sendID3.Text);
                n = int.Parse(sendnum3.Text);
                serialPort1.Write(sendnum(id / 10, id % 10, n));
            }
            if (sendID4.Text != "error")
            {
                id = int.Parse(sendID4.Text);
                n = int.Parse(sendnum4.Text);
                serialPort1.Write(sendnum(id / 10, id % 10, n));
            }
        }

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
        //按格式整合参数
        //sendnum(ID十位, ID个位, 数值)
        //输出   "$ID十位.ID个位@数值! "
        //例：ID为56数值为74
        //sendnum(5,6,74);
        string sendnum(int group, int no, int num)
        {
            string str = "$" + group.ToString() + "." + no.ToString() + "@" + num.ToString() + "!";
            return str;
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

        //更改参数
        //待改参数=changenum(待改参数名）;
        //例：Speed_Kd=changenum("Speed_Kd");
        float changenum(string name)
        {
            float n = 0;
            for (int i = 0; i < 100; i++)
            {
                if (data[i].name == name)
                {
                    n = data[i].num;
                }
            }
            return n;
        }
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
            for (int i = 0; i < 600; i++)
            {
                buff[i] = 0;
            }
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

        private void Record_timer_Tick(object sender, EventArgs e)
        {
            if (replaystate == "record")
            {
                if (n < 600)
                {
                    progressBar1.Value = time;
                    buff[time] = 1;
                    data[11].num *= 1.5f;
                    data[12].num += 1f;
                    data[21].num /= 0.9f;
                    data[22].num -= 1.1f;
                }
                Recorddata(time);
                time++;
            }
            else if (replaystate == "play")
            {
                if (retime < time)
                {
                    progressBar1.Value = retime;
                    play(retime);
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
            for (int i = 0; i < 600; i++)
            {
                fps[time].img[i] = buff[i];
            }
        }
        void play(int num)
        {
            Changemap(fps[num].img);
            Display(map);
            table.reflashChart(chart1, num, fps[num].value[11], fps[num].value[12], fps[num].value[21], fps[num].value[22]);
        }
    }
}
