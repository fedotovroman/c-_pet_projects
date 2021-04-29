using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicApp12_3
{
    public partial class Form1 : Form
    {
        PointF[] PointsArray;
        bool control;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            control = false;
            var p0 = new PointF(50, 50);
            var p1 = new PointF(125, 125);
            var p2 = new PointF(125, 125);
            var p3 = new PointF(200.0f, 200.0f);
            PointsArray = new PointF[]{ p0, p1, p2, p3 };

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var gr = e.Graphics;
            var Pero = new Pen(Color.Blue, 3);
            gr.DrawEllipse(Pero, PointsArray[0].X - 2, PointsArray[0].Y - 2, 4.0F, 4.0F);
            gr.DrawEllipse(Pero, PointsArray[3].X - 2, PointsArray[3].Y - 2, 4.0F, 4.0F);
            Pero.Color = Color.Red;
            gr.DrawRectangle(Pero, PointsArray[1].X - 2, PointsArray[1].Y - 2, 4.0F, 4.0F);
            Pero.Color = Color.Blue;

            gr.DrawBeziers(Pero, PointsArray);
            gr.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Math.Abs(e.X - PointsArray[1].X) < 4.0F && Math.Abs(e.Y - PointsArray[1].Y) < 4.0F && control == true)
            {
                PointsArray[1].X = e.X;
                PointsArray[1].Y = e.Y;
                PointsArray[2].X = e.X;
                PointsArray[2].Y = e.Y;
                Invalidate();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            control = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            control = true;
        }
    }
}
