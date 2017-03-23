using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace usart_tool
{
    public partial class Scope : Form
    {
        public Scope()
        {
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
                           ControlStyles.AllPaintingInWmPaint,
                           true);//开启双缓冲

            this.UpdateStyles();
            InitializeComponent();
        }
        int ystart = 0, xstart = 0;
        int clickx = 0, clicky = 0;
        bool picmove = false, clickflag = false;
        private const int Unit_length = 32;//单位格大小
        private float DrawStep = 8;//默认绘制单位
        private const int Y_Max = 512;//Y轴最大数值
        private const int MaxStep = 65;//绘制单位最大值
        private const float MinStep = 0.001f;//绘制单位最小值
        private const int StartPrint = 32;//点坐标偏移量
        private List<float> DataList = new List<float>();//数据结构----线性链表
        private Pen TablePen = new Pen(Color.FromArgb(0x00, 0x00, 0x00));//轴线颜色
        private Pen LinesPen = new Pen(Color.FromArgb(0xa0, 0x00, 0x00));//波形颜色
        //public ShowWindow ShowMainWindow;//定义显示主窗口委托访问权限为public
        //public HideWindow HideMainWindow;//定义隐藏主窗口委托
        //public OpenPort OpenSerialPort;//定义打开串口委托
        //public ClosePort CloseSerialPort;//定义关闭串口委托
        //public GetMainPos GetMainPos;//定义获取主窗口信息委托(自动对齐)
        //public GetMainWidth GetMainWidth;//定义获取主窗口宽度(自动对齐)
        private bool KeyShift, KeyShowMain, KeyHideMain, KeyExit, KeyOpen, KeyClose, KeyStepUp, KeyStepDown;

        private void Scope_Load(object sender, EventArgs e)
        {

        }

        private void Scope_MouseMove(object sender, MouseEventArgs e)
        {
            Invalidate();
            if (picmove && (e.X != clickx) && (e.Y != clicky)&&clickflag)
            {
                xstart -= ((int)((e.X - clickx) / DrawStep));
                ystart -= ((int)((e.Y - clicky) / DrawStep));
                clickx = e.X;
                clicky = e.Y;
                Invalidate();
                clickflag = false;
            }
        }

        private void Scope_MouseUp(object sender, MouseEventArgs e)
        {
            picmove = false;
            clickflag = false;
        }

        private void Scope_MouseDown(object sender, MouseEventArgs e)
        {
            clickx = e.X;
            clicky = e.Y;
            picmove = true;
        }

        private void Scope_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)//shift功能键按下
                KeyShift = true;//标志位置位
            switch (e.KeyCode)//功能标志置位
            {
                case Keys.S://显示主窗口
                    KeyShowMain = true;
                    break;
                case Keys.E://退出波形显示
                    KeyExit = true;
                    break;
                case Keys.O://打开串口
                    KeyOpen = true;
                    break;
                case Keys.C://关闭串口
                    KeyClose = true;
                    break;
                case Keys.Up://放大波形
                    KeyStepUp = true;
                    break;
                case Keys.H://隐藏主窗口
                    KeyHideMain = true;
                    break;
                case Keys.Down://缩小波形
                    KeyStepDown = true;
                    break;
                default:
                    break;
            }
        }

        private void Scope_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeyShift)
            {
                if (KeyShowMain)//显示主窗体快捷键
                {
                    //    ShowMainWindow();
                    Rectangle Rect = Screen.GetWorkingArea(this);
                    //     SetWindow(Rect.Width - GetMainWidth(), new Point(GetMainWidth(), GetMainPos().Y));//缩小自己
                    KeyShowMain = false;
                }
                else
                {
                    if (KeyOpen)
                    {
                        //  OpenSerialPort();//打开主窗口串口
                        KeyOpen = false;
                    }
                    else
                    {
                        if (KeyClose)
                        {
                            // CloseSerialPort();//关闭主窗口串口
                            KeyClose = false;
                        }
                        else
                        {
                            if (KeyExit)
                            {
                                KeyExit = false;//退出自己
                                Close();
                            }
                            else
                            {
                                if (KeyStepUp)
                                {
                                    if (DrawStep < MaxStep)//绘制单位递增
                                        DrawStep *= 2;
                                    Invalidate();
                                    KeyStepUp = false;
                                }
                                else
                                {
                                    if (KeyStepDown)
                                    {
                                        if (DrawStep > MinStep)//绘制单位递减
                                            DrawStep /= 2;
                                        Invalidate();
                                        KeyStepDown = false;
                                    }
                                    else
                                    {
                                        if (KeyHideMain)
                                        {
                                            // HideMainWindow();//隐藏主窗口并扩大自己
                                            Rectangle Rect = Screen.GetWorkingArea(this);
                                            //  SetWindow(Rect.Width, new Point(0, GetMainPos().Y));
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else//如果是其他按键，清空所有标志位
            {
                KeyClose = false;
                KeyOpen = false;
                KeyShowMain = false;
                KeyExit = false;
                KeyStepUp = false;
                KeyStepDown = false;
            }
            KeyShift = false;//清空shift标志位
        }
        private void Scope_Paint(object sender, PaintEventArgs e)
        {
            String Str = "";
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            e.Graphics.FillRectangle(Brushes.White, e.Graphics.ClipBounds);

            //Draw X 纵向轴绘制
            for (int i = 0; i <= this.ClientRectangle.Width / Unit_length; i++)
            {
                e.Graphics.DrawLine(TablePen, StartPrint + i * Unit_length, StartPrint, StartPrint + i * Unit_length, StartPrint + Y_Max);//画线

                gp.AddString(((int)(i * (Unit_length / DrawStep) + xstart / DrawStep)).ToString(), this.Font.FontFamily, (int)FontStyle.Regular, 12, new RectangleF(StartPrint + i * Unit_length - 7, this.ClientRectangle.Height - StartPrint + 4, 400, 50), null);//添加文字
            }
            //Draw Y 横向轴绘制
            for (int i = 0; i <= this.ClientRectangle.Height / Unit_length; i++)
            {
                e.Graphics.DrawLine(TablePen, StartPrint, (i + 1) * Unit_length, this.ClientRectangle.Width, (i + 1) * Unit_length);//画线
                //Str = ((16 - i) * 16).ToString("X");
                //Str = "0x" + (Str.Length == 1 ? Str + "0" : Str);
                //if (i == 0)
                //    Str = "0xFF";
                if (i == 17)
                    break;
                gp.AddString(((int)((this.ClientRectangle.Height / Unit_length - i) * (Unit_length / DrawStep) - ystart / DrawStep)).ToString(), this.Font.FontFamily, (int)FontStyle.Regular, 14, new RectangleF(0, StartPrint + i * Unit_length - 8, 400, 50), null);//添加文字
            }
            e.Graphics.DrawPath(Pens.Black, gp);//写文字
            if (DataList.Count - 1 >= (this.ClientRectangle.Width - StartPrint) / DrawStep)//如果数据量大于可容纳的数据量，即删除最左数据
            {
                for (int i = 0; i < (this.ClientRectangle.Width - StartPrint) / DrawStep; i++)//绘制
                {
                    if ((int)(DataList.Count - (this.ClientRectangle.Width - StartPrint) / DrawStep + xstart / DrawStep + i ) < DataList.Count && (int)(DataList.Count - (this.ClientRectangle.Width - StartPrint - xstart) / DrawStep + i) > 0)
                    {
                        e.Graphics.DrawLine(LinesPen, StartPrint + i * DrawStep, 17 * Unit_length - DrawStep * (DataList[(int)(DataList.Count - (this.ClientRectangle.Width - StartPrint) / DrawStep + xstart / DrawStep + i - 1)] * 2 + ystart / DrawStep), StartPrint + (i + 1) * DrawStep, 17 * Unit_length - DrawStep * (DataList[(int)(DataList.Count - (this.ClientRectangle.Width - StartPrint) / DrawStep + xstart / DrawStep + i)] * 2 + ystart / DrawStep));
                        clickflag = true;
                        
                    }
                    
                }
               // if(picmove)
               // xstart += (int)((Unit_length / DrawStep) + xstart / DrawStep);
                //DataList.RemoveRange(0, DataList.Count - (this.ClientRectangle.Width - StartPrint) / DrawStep - 1);
            }
            // = DataList.Count;
            else
                for (int i = 0; i < DataList.Count - 1; i++)//绘制
                {
                    e.Graphics.DrawLine(LinesPen, StartPrint + i * DrawStep, 17 * Unit_length - DataList[i] * 2, StartPrint + (i + 1) * DrawStep, 17 * Unit_length - DataList[i + 1] * 2);
                }
        }



        public void AddData(float Data)
        {
            for (int i = 0; i < Data; i++)
                DataList.Add(Data);//链表尾部添加数据
            Invalidate();//刷新显示
        }
        public void SetWindow(int width, Point Pt)//允许主窗口设置自己
        {
            int height = this.ClientRectangle.Height;
            height = this.Height - height;
            int BorderWeigh = this.Width - this.ClientRectangle.Width;
            this.Size = new Size(width - (width - BorderWeigh) % Unit_length, height + Y_Max + StartPrint + Unit_length);
            this.Location = Pt;
        }
    }
}
