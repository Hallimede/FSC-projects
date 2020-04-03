using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class MainForm : Form
    {
        private Graphics graphics;

        int n = 10;
        double leng = 100;
        double th1= 30 * Math.PI / 180;  //右分支角度
        double th2= 30 * Math.PI / 180;  //左分支角度
        double per1 = 0.6;  //右分支长度倍数
        double per2 = 0.7;  //左分支长度倍数

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                n = int.Parse(txtN.Text);
                leng = double.Parse(txtLeng.Text);
                th1 = double.Parse(txtTh1.Text) * Math.PI / 180;
                th2 = double.Parse(txtTh2.Text) * Math.PI / 180;
                per1 = double.Parse(txtPer1.Text);
                per2 = double.Parse(txtPer2.Text);

                if (graphics == null)
                {
                    graphics = panelGraphics.CreateGraphics();
                }
                graphics.Clear(BackColor);
                drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("请输入正确的数据！");
            }
        }

        void drawCayleyTree(int n /*递归深度*/,
             double x0,double y0,double leng/*主干长度*/,double th/*初始角度*/)
        {
            if (n <= 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0, double y0, double x1, double y1){
            int n = cmbColor.SelectedIndex;
            if(n==-1) n++;
            Pen[] pens = 
            { 
                new Pen(Color.Blue),
                new Pen(Color.Red),
                new Pen(Color.Yellow),
                new Pen(Color.Black),
                new Pen(Color.Green),
            };
            graphics.DrawLine(pens[n],(int)x0, (int)y0, (int)x1, (int)y1);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (graphics == null) return;
            graphics.Clear(BackColor);
        }
    }
}
