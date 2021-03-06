﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usart_tool
{
    class Chart
    {
        DataTable dt = new DataTable();
        public Datas[] chartdata = new Datas[100];
        bool creatflag = true;
        public void reflashChart(System.Windows.Forms.DataVisualization.Charting.Chart data, int time, int ID1, int ID2, int ID3, int ID4)
        {
            // Zoom into the X axis
            data.ChartAreas[0].AxisX.ScaleView.Zoom(1, 3);
            data.ChartAreas[0].AxisY.ScaleView.Zoom(1, 3);

            // Enable range selection and zooming end user interface
            data.ChartAreas[0].CursorX.IsUserEnabled = true;
            data.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            data.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            data.ChartAreas[0].CursorY.IsUserEnabled = true;
            data.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            data.ChartAreas[0].AxisY.ScaleView.Zoomable = true;

            //将滚动内嵌到坐标轴中
            data.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            data.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            // 设置滚动条的大小
            data.ChartAreas["ChartArea1"].AxisX.ScrollBar.Size = 20;
            data.ChartAreas["ChartArea1"].AxisY.ScrollBar.Size = 20;

            // 设置滚动条的按钮的风格，下面代码是将所有滚动条上的按钮都显示出来
            //data.ChartAreas["Default"].AxisX.ScrollBar.ButtonStyle //ScrollBarButtonStyle.All;

            // 设置自动放大与缩小的最小量
            data.ChartAreas["ChartArea1"].AxisX.ScaleView.SmallScrollSize = double.NaN;
            data.ChartAreas["ChartArea1"].AxisX.ScaleView.SmallScrollMinSize = 1;
            data.ChartAreas["ChartArea1"].AxisY.ScaleView.SmallScrollSize = double.NaN;
            data.ChartAreas["ChartArea1"].AxisY.ScaleView.SmallScrollMinSize = 1;

            dt = CreateDataTable(data, time, ID1, ID2, ID3, ID4);
            //设置图表的数据源
            data.DataSource = dt;

            //设置图表Y轴对应项
            data.Series[0].YValueMembers = "Volume1";
            data.Series[1].YValueMembers = "Volume2";
            data.Series[2].YValueMembers = "Volume3";
            data.Series[3].YValueMembers = "Volume4";

            //设置图表X轴对应项
            data.Series[0].XValueMember = "time";
            data.Series[1].XValueMember = "time";
            data.Series[2].XValueMember = "time";
            data.Series[3].XValueMember = "time";

            //绑定数据
            data.DataBind();
        }
        public DataTable CreateDataTable(System.Windows.Forms.DataVisualization.Charting.Chart data, int time,int ID1, int ID2, int ID3, int ID4)
        {
            if (creatflag)
            {
                dt.Columns.Add("time");
                dt.Columns.Add("Volume1");
                dt.Columns.Add("Volume2");
                dt.Columns.Add("Volume3");
                dt.Columns.Add("Volume4");
                creatflag = false;
            }

            
            DataRow dr;
            dr = dt.NewRow();
            dr["time"] = time;
            dr["Volume1"] = chartdata[ID1].num;
            dr["Volume2"] = chartdata[ID2].num;
            dr["Volume3"] = chartdata[ID3].num;
            dr["Volume4"] = chartdata[ID4].num;
            dt.Rows.Add(dr);
           
            return dt;
        }
    }
}
