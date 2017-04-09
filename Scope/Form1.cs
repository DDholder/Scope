using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scope
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);//开启双缓冲
            this.SetStyle(ControlStyles.UserPaint, true);
            this.UpdateStyles();
            InitializeComponent();
        }
        private const float Unit_length = 10;//单位格大小
        private float DrawStep = 1;//默认绘制单位
        private const int Y_Max = 512;//Y轴最大数值
        private const int MaxStep = 65;//绘制单位最大值
        private const float MinStep = 0.001f;//绘制单位最小值
        private const int StartPrint = 32;//点坐标偏移量
        private Pen TablePen = new Pen(Color.FromArgb(50, 0x00, 0x00, 0x00));//轴线颜色
        private Pen TablePen2 = new Pen(Color.FromArgb(0x00, 0x00, 0x00));//轴线颜色
        private Pen TablePen3 = new Pen(Color.FromArgb(0x00, 0x00, 0xff));//轴线颜色
        private Pen LinesPen = new Pen(Color.FromArgb(0xaa, 0x00, 0x00));//波形颜色
        public List<float> data = new List<float>();
        public int x, y;
        float zoom = 1;
        bool enAutorun = false, enmove = false;
        int clickx, clicky, lastx, lasty;
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        private void 开启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enAutorun = true;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            if (enmove)
            {
                int gox = lastx + clickx - e.X, goy = lasty + clicky - e.Y;
                if (gox < hScrollBar1.Maximum && gox > 0)
                    hScrollBar1.Value = lastx + clickx - e.X;
                if (goy < vScrollBar1.Maximum && goy > 0)
                    vScrollBar1.Value = lasty + clicky - e.Y;

            }
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            enmove = false;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w' && zoom > 0.1)
            {
                zoom -= 0.1f;
                Invalidate();
            }
            if (e.KeyChar == 's' && zoom < 10)
            {
                zoom += 0.1f;
                Invalidate();
            }
        }
        float count = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            float n =100* (float)Math.Sin(count)+200;
            data.Add(n);
            count+=0.1f;
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 11; i++)
            //{
            //    data.Add(i * 100);
            //    Invalidate();
            //    Thread.Sleep(10);
            //}
            timer1.Enabled = !timer1.Enabled;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float time = (x + hScrollBar1.Value + 1 - StartPrint) / Unit_length * zoom, num = (((y+1)/zoom+7+ (int)(vScrollBar1.Value - vScrollBar1.Maximum * 0.75f)-Height)/-Unit_length)*10f+10;
            GraphicsPath gp = new GraphicsPath();
            int st = (int)(0.1 * hScrollBar1.Value * zoom);
            //if((int)(StartPrint + ((data.Count - 1) * Unit_length - 1) / zoom)>)

            for (int i = 0; i <= this.Width / Unit_length; i++)
            {
                if (i % 5 == 0)
                {
                    e.Graphics.DrawLine(TablePen2, StartPrint + i * Unit_length, StartPrint, StartPrint + i * Unit_length, StartPrint + Height);//画线
                    gp.AddString(((int)(0.1 * (i * (int)(Unit_length) + hScrollBar1.Value) * zoom)).ToString("F1"), this.Font.FontFamily, (int)FontStyle.Regular, 12, new RectangleF(StartPrint + i * Unit_length - 7, Height - StartPrint - 60, 400, 50), null);//添加文字
                }
                else
                    e.Graphics.DrawLine(TablePen, StartPrint + i * Unit_length, StartPrint, StartPrint + i * Unit_length, StartPrint + Height);//画线
            }
            //Draw Y 横向轴绘制
            for (int i = 0; i <= Height / Unit_length; i++)
            {
                if ((int)(Height / Unit_length - i) % 3 == 0)
                {
                    e.Graphics.DrawLine(TablePen2, StartPrint, (i + 1) * Unit_length, Width, (i + 1) * Unit_length);//画线
                    gp.AddString((((Height / Unit_length - i) * Unit_length - (int)(vScrollBar1.Value - vScrollBar1.Maximum * 0.75f) - 7) * zoom - 1).ToString("F1"), this.Font.FontFamily, (int)FontStyle.Regular, 14, new RectangleF(0, (i + 1) * Unit_length - 8, 400, 50), null);//添加文字
                }
                else
                    e.Graphics.DrawLine(TablePen, StartPrint, (i + 1) * Unit_length, Width, (i + 1) * Unit_length);//画线
            }
            //gp.AddString(((int)time).ToString("F1"), this.Font.FontFamily, (int)FontStyle.Regular, 12, new RectangleF(x - 35, y - 10, 400, 50), null);//添加文字
            //gp.AddString(num.ToString("F1"), this.Font.FontFamily, (int)FontStyle.Regular, 12, new RectangleF(x + 5, y, 400, 50), null);//添加文字
            e.Graphics.DrawPath(Pens.Black, gp);
            e.Graphics.DrawLine(TablePen3, x, 0, x, Height);//画线
            e.Graphics.DrawLine(TablePen3, 0, y, Width, y);//画线
            if (st < 0) st = 0;
            int ys = 0;
            if (data.Count > 1)
            {
                hScrollBar1.Maximum = (int)(StartPrint + ((data.Count - 1) * Unit_length - 1) / zoom);
                int max = vScrollBar1.Maximum - (int)(((float)vScrollBar1.Maximum - ((int)data[data.Count - 1] / 10.0) * Unit_length + 2) / zoom + vScrollBar1.Maximum * (1 - 1 / zoom) -  vScrollBar1.Maximum * 0.25f);
                if (max > vScrollBar1.Maximum) vScrollBar1.Maximum = max;
                ys = vScrollBar1.Maximum - (int)(((data[data.Count - 1] / 10.0) * Unit_length + 2) / zoom + Height * (1 - 1 / zoom)) + 10;

            }
            for (int i = 0; st + 1 + i < data.Count - 1; i++)//绘制
            {
                e.Graphics.FillRectangle(Brushes.Red, new Rectangle((int)(StartPrint + (i * Unit_length - 1) / zoom), (int)(((float)Height - ((int)data[st + i] / 10.0) * Unit_length + 2) / zoom + Height * (1 - 1 / zoom)) - (int)(vScrollBar1.Value - vScrollBar1.Maximum * 0.75f), 3, 3));
                e.Graphics.DrawLine(LinesPen, StartPrint + (i * Unit_length - 1) / zoom, (float)((float)Height - ((int)data[st + i] / 10.0) * Unit_length + 4) / zoom + Height * (1 - 1 / zoom) - (vScrollBar1.Value - vScrollBar1.Maximum * 0.75f), StartPrint + ((i + 1) * Unit_length - 1) / zoom, (float)(Height - ((int)data[st + 1 + i] / 10.0) * Unit_length + 4) / zoom + Height * (1 - 1 / zoom) - (vScrollBar1.Value - vScrollBar1.Maximum * 0.75f));
            }
            if (enAutorun)
            {
                ys += 200;
                if (hScrollBar1.Maximum - Width > 0)
                    hScrollBar1.Value = hScrollBar1.Maximum - Width / 2;
                if (ys * zoom  > 0 && ys * zoom  < vScrollBar1.Maximum)
                    vScrollBar1.Value = (int)(ys *zoom);
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enAutorun = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            clickx = e.X;
            clicky = e.Y;
            lastx = hScrollBar1.Value;
            lasty = vScrollBar1.Value;
            enmove = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
