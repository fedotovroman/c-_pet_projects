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
using System.Threading;


namespace GraphicLab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {



            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            timer1.Interval = 1000; // 500 миллисекунд
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
        }
        
        

        private void UpdateTimer()
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen blackPen = new Pen(Color.Black, 3);
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(10, 10, 400, 400), Color.Gray, Color.White, LinearGradientMode.Horizontal);
            gr.FillEllipse(brush, 10, 10, 400, 400);
            
            for (int i = 0; i < 12; i++)
            {
                float x_h = Convert.ToSingle(205 + 185 * Math.Cos(i * Math.PI / 6));
                float y_h = Convert.ToSingle(205 + 185 * Math.Sin(i * Math.PI / 6));
                gr.FillRectangle(Brushes.Black, x_h, y_h, 7, 7);
            }
            for (int i = 0; i < 60; i++)
            {
                float x_m = Convert.ToSingle(205 + 185 * Math.Cos(i * Math.PI / 30));
                float y_m = Convert.ToSingle(205 + 185 * Math.Sin(i * Math.PI / 30));
                gr.FillRectangle(Brushes.Black, x_m, y_m, 3, 3);
            }


            int hour = 0;
            int sec = DateTime.Now.Second;
            int min = DateTime.Now.Minute;
            if (DateTime.Now.Hour>=12)
            {
                hour = DateTime.Now.Hour-12;
            }
            else
            {
                hour = DateTime.Now.Hour;
            }
                

            float cord_sec_x = Convert.ToSingle(205 + 185 * Math.Cos(sec * Math.PI / 30  - Math.PI/2));
            float cord_sec_y = Convert.ToSingle(205 + 185 * Math.Sin(sec * Math.PI / 30 - Math.PI / 2 ));
            Pen secpen = new Pen(Brushes.Black,2.5f);
            gr.DrawLine(secpen, 205, 205, cord_sec_x, cord_sec_y);

            float cord_min_x = Convert.ToSingle(205 + 160 * Math.Cos(min * Math.PI / 30 - Math.PI / 2));
            float cord_min_y = Convert.ToSingle(205 + 160 * Math.Sin(min * Math.PI / 30 - Math.PI / 2));
            Pen minpen = new Pen(Brushes.Gray, 7f);
            gr.DrawLine(minpen, 205, 205, cord_min_x, cord_min_y);

            float cord_h_x = Convert.ToSingle(205 + 100 * Math.Cos(hour * Math.PI / 6 - Math.PI/2));
            float cord_h_y = Convert.ToSingle(205 + 100 * Math.Sin(hour * Math.PI / 6 - Math.PI / 2));
            Pen hpen = new Pen(Brushes.Black, 10f);
            gr.DrawLine(hpen, 205, 205, cord_h_x, cord_h_y);

            gr.FillEllipse(Brushes.LightGray, 200, 197, 20, 20);

            gr.DrawString(DateTime.Now.Hour.ToString()+" ч. " + DateTime.Now.Minute.ToString() + " мин. " + DateTime.Now.Second.ToString()+ " сек. ", new Font("Arial", 20), Brushes.Black, 90, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            UpdateTimer();
        }
    }
}
