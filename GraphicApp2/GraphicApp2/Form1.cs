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

namespace GraphicApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();

            
        }

        Graphics g;
        private void Draw()
        {
            Pen p1 = new Pen(Color.Black, 3);
            Pen p = new Pen(Color.Black, 3);
            Font myFont = new Font("Times new Roman", 14, FontStyle.Underline);
            g = CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Color.White);
            g.DrawEllipse(p, 10, 30, 200, 100);
            //g.DrawEllipse(p, 10, 230, 200, 100);
            g.DrawLine(p, new Point(10,280), new Point(10, 80));
            g.DrawLine(p, new Point(210, 280), new Point(210, 80));
            g.DrawArc(p, 10, 230, 200, 100, 0, 180);
            p1.DashStyle = DashStyle.Dot;
            g.DrawArc(p1, 10, 230, 200, 100, 180, 180);
            g.DrawString("V = PI * R^2 * H",myFont,Brushes.Black,new Point(10,350));
            for (int i = 0; i < 4; i++)
            {
                Point[] pts = { new Point(300+200*i, 60), new Point(400 + 200 * i, 40), new Point(500 + 200 * i, 60), new Point(400 + 200 * i, 80) };
                g.DrawPolygon(p, pts);
            }

            Point[] romb = { new Point(100 , 460), new Point(200 , 440), new Point(300, 460), new Point(200 , 480) };
            g.DrawPolygon(p, romb);


            g.DrawLine(p1,new Point(100,460),new Point(300,460));
            g.DrawLine(p1, new Point(200, 440), new Point(200, 480));


            for (int i = 0; i < 5; i++)
            {
                g.DrawEllipse(p,500+100*i,500, 100,100);
                g.DrawEllipse(p, 525+ 100 * i, 525, 50, 50);
            }



            g.Dispose();
        }
        private void FormMain_Paint(object sender, PaintEventArgs e) { Draw(); }


    }
}
