using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point[] p = {new Point(100,0),new Point(500,100), new Point(200,300) };


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            gr.FillPolygon(new SolidBrush(SystemColors.ControlDark), p);
            TransparencyKey = SystemColors.ControlDark;
        }
    }
}
