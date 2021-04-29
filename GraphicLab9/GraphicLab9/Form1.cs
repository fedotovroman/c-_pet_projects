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
namespace GraphicLab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(this.BackColor);
            gr.DrawString("Зачтите эту программу", new Font("Calibri", 50, FontStyle.Bold), Brushes.Black, new Point(60, 60));
            gr.DrawString("Зачтите эту программу", new Font("Calibri", 50, FontStyle.Bold), Brushes.LightGray, new Point(62, 62));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(this.BackColor);
            gr.DrawString("Зачтите эту программу", new Font("Calibri", 50, FontStyle.Bold), Brushes.Black, new Point(60, 60));
            gr.DrawString("Зачтите эту программу", new Font("Calibri", 50, FontStyle.Bold), Brushes.LightGray, new Point(58, 58));
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(this.BackColor);
            GraphicsPath myPath = new GraphicsPath();

            // Set up all the string parameters.
            string stringText = "Примите эту работу";
            FontFamily family = new FontFamily("Calibri");
            int fontStyle = (int)FontStyle.Regular;
            int emSize = 70;
            Point origin = new Point(40, 40);
            StringFormat format = StringFormat.GenericDefault;

            // Add the string to the path.
            myPath.AddString(stringText,
                family,
                fontStyle,
                emSize,
                origin,
                format);
            gr.SmoothingMode = SmoothingMode.AntiAlias;
            gr.CompositingQuality = CompositingQuality.HighQuality;
            gr.CompositingMode = CompositingMode.SourceOver;
            //Draw the path to the screen.
            gr.DrawPath(Pens.Black, myPath);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(this.BackColor);
            
            gr.MultiplyTransform(new Matrix(-1, 0, 0, 1, 68, 50));

            gr.DrawString("Этот текст неотразим", new Font("Calibri", 50, FontStyle.Bold), Brushes.Black, -690, 40);
            gr.ResetTransform();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(this.BackColor);

            gr.RotateTransform(30);

            gr.DrawString("Текст упал", new Font("Comic Sans MS", 40, FontStyle.Bold), Brushes.Black, 240, 10);
            gr.ResetTransform();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(this.BackColor);

            for (int i= 0; i < 15; i++)
            {
                gr.TranslateTransform(400,200);
                gr.RotateTransform(30*i);
                
                gr.DrawString("Текст вращают", new Font("Comic Sans MS", 20, FontStyle.Bold), Brushes.Black, 0,0);
                gr.ResetTransform();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graphics gr = pictureBox1.CreateGraphics();
            gr.Clear(this.BackColor);
            for (int j = 0; j < 15; j++)
            {
                for (int i = 0; i < 20; i++)
                {
                    gr.TranslateTransform(100 * i - 10, j*20-10);
                    gr.DrawString("СмолГУ", new Font("Comic Sans MS", 20, FontStyle.Bold), Brushes.Black, 0, 0);
                    gr.ResetTransform();
                }
            }

        }
    }
}
