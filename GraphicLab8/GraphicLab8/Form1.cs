using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GraphicLab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }
        Pen blackPen = new Pen(Color.Black, 1);
        public void ClearAndDraw()
        {
            Graphics gr = pictureBox1.CreateGraphics();
            
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen blackPen = new Pen(Color.Black, 3);
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(10, 10, 400, 400), Color.Gray, Color.White, LinearGradientMode.Horizontal);
            gr.DrawLine(blackPen, new Point(220, 20), new Point(220, 420));
            gr.DrawLine(blackPen, new Point(20, 220), new Point(420, 220));

            gr.DrawLine(blackPen, new Point(220, 20), new Point(210, 30));
            gr.DrawLine(blackPen, new Point(220, 20), new Point(230, 30));

            gr.DrawLine(blackPen, new Point(410, 210), new Point(420, 220));
            gr.DrawLine(blackPen, new Point(410, 230), new Point(420, 220));

            gr.DrawString("y", new Font("Arial", 15), Brushes.Black, new Point(230, 20));
            gr.DrawString("x", new Font("Arial", 15), Brushes.Black, new Point(430, 220));

            gr.DrawEllipse(blackPen, 180, 180, 80, 80);
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Graphics gr = pictureBox1.CreateGraphics();
                gr.Clear(Color.White);
                ClearAndDraw();
                double t = 0;
                for (int i = 0; i < 5000; i++)
                {
                    t = i * 0.005;
                    gr.DrawRectangle(blackPen, Convert.ToSingle(40 * (t - Math.Sin(t))), 220 - Convert.ToSingle(40 * (1 - Math.Cos(t))), 3, 3);
                }
            } 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Graphics gr = pictureBox1.CreateGraphics();
                gr.Clear(Color.White);
                ClearAndDraw();
                double t = 0;
                for (int i = 0; i < 5000; i++)
                {
                    t = i * 0.005;
                    gr.DrawRectangle(blackPen,220+ Convert.ToSingle(40 * (1 - Math.Cos(t))),  Convert.ToSingle(40 * (t - Math.Sin(t))), 3, 3);
                }
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Graphics gr = pictureBox1.CreateGraphics();
                gr.Clear(Color.White);
                ClearAndDraw();
                double t = 0;
                for (int i = 0; i < 5000; i++)
                {
                    t = i * 0.005;
                    gr.DrawRectangle(blackPen, 200+Convert.ToSingle(20+40 * Math.Pow(Math.Cos(t),3)), 220+Convert.ToSingle(40 * Math.Pow(Math.Sin(t), 3)), 3, 3);
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                Graphics gr = pictureBox1.CreateGraphics();
                gr.Clear(Color.White);
                ClearAndDraw();
                double t = 0;
                for (int i = 0; i < 5000; i++)
                {
                    t = i * 0.005;
                    gr.DrawRectangle(blackPen, Convert.ToSingle(220+40 * (2*Math.Cos(t) - Math.Cos(2*t) )),220+ Convert.ToSingle(40 * (2*Math.Sin(t) - Math.Sin(2*t))), 3, 3);
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.Clear(Color.White);
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen blackPen = new Pen(Color.Black, 3);
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(10, 10, 400, 400), Color.Gray, Color.White, LinearGradientMode.Horizontal);
            gr.DrawLine(blackPen, new Point(220, 20), new Point(220, 420));
            gr.DrawLine(blackPen, new Point(20, 220), new Point(420, 220));

            gr.DrawLine(blackPen, new Point(220, 20), new Point(210, 30));
            gr.DrawLine(blackPen, new Point(220, 20), new Point(230, 30));

            gr.DrawLine(blackPen, new Point(410, 210), new Point(420, 220));
            gr.DrawLine(blackPen, new Point(410, 230), new Point(420, 220));

            gr.DrawString("y", new Font("Arial", 15), Brushes.Black, new Point(230, 20));
            gr.DrawString("x", new Font("Arial", 15), Brushes.Black, new Point(430, 220));

        }



        //private void UpdateTimer()
        //{


        //    for (int i = 0; i < 12; i++)
        //    {
        //        float x_h = Convert.ToSingle(205 + 185 * Math.Cos(i * Math.PI / 6));
        //        float y_h = Convert.ToSingle(205 + 185 * Math.Sin(i * Math.PI / 6));
        //        gr.FillRectangle(Brushes.Black, x_h, y_h, 7, 7);
        //    }
        //    for (int i = 0; i < 60; i++)
        //    {
        //        float x_m = Convert.ToSingle(205 + 185 * Math.Cos(i * Math.PI / 30));
        //        float y_m = Convert.ToSingle(205 + 185 * Math.Sin(i * Math.PI / 30));
        //        gr.FillRectangle(Brushes.Black, x_m, y_m, 3, 3);
        //    }


        //    int hour = 0;
        //    int sec = DateTime.Now.Second;
        //    int min = DateTime.Now.Minute;
        //    if (DateTime.Now.Hour >= 12)
        //    {
        //        hour = DateTime.Now.Hour - 12;
        //    }
        //    else
        //    {
        //        hour = DateTime.Now.Hour;
        //    }


        //    float cord_sec_x = Convert.ToSingle(205 + 185 * Math.Cos(sec * Math.PI / 30 - Math.PI / 2));
        //    float cord_sec_y = Convert.ToSingle(205 + 185 * Math.Sin(sec * Math.PI / 30 - Math.PI / 2));
        //    Pen secpen = new Pen(Brushes.Black, 2.5f);
        //    gr.DrawLine(secpen, 205, 205, cord_sec_x, cord_sec_y);

        //    float cord_min_x = Convert.ToSingle(205 + 160 * Math.Cos(min * Math.PI / 30 - Math.PI / 2));
        //    float cord_min_y = Convert.ToSingle(205 + 160 * Math.Sin(min * Math.PI / 30 - Math.PI / 2));
        //    Pen minpen = new Pen(Brushes.Gray, 7f);
        //    gr.DrawLine(minpen, 205, 205, cord_min_x, cord_min_y);

        //    float cord_h_x = Convert.ToSingle(205 + 100 * Math.Cos(hour * Math.PI / 6 - Math.PI / 2));
        //    float cord_h_y = Convert.ToSingle(205 + 100 * Math.Sin(hour * Math.PI / 6 - Math.PI / 2));
        //    Pen hpen = new Pen(Brushes.Black, 10f);
        //    gr.DrawLine(hpen, 205, 205, cord_h_x, cord_h_y);

        //    gr.FillEllipse(Brushes.LightGray, 200, 197, 20, 20);

        //    gr.DrawString(DateTime.Now.Hour.ToString() + " ч. " + DateTime.Now.Minute.ToString() + " мин. " + DateTime.Now.Second.ToString() + " сек. ", new Font("Arial", 20), Brushes.Black, 90, 100);
        //}


    }
}
