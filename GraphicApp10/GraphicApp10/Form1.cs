using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GraphicApp10
{
    public partial class Form1 : Form
    {
        public double[] cv;
        public string[] questions;
        public int [] circle;
        public string mquestion;
        public SolidBrush[] rand;
        int len;
        public Form1()
        {
            InitializeComponent();
            string path = "MoneyInfo.txt";
            StreamReader sr = new StreamReader(path);

            cv = new double[Convert.ToInt16(sr.ReadLine())];
            int i = 0;

            string t = sr.ReadLine();
            
            while (t != null)
            {
                cv[i++] = Convert.ToDouble(t);
                t = sr.ReadLine();
            }
            sr.Close();

            StreamReader sr1 = new StreamReader("CircleInfo.txt");
            mquestion = sr1.ReadLine();
            len = Convert.ToInt32(sr1.ReadLine());

            questions = new string[len];
            circle = new int[len];
            rand = new SolidBrush[len];

            for (int j = 0; j < len; j++)
            {
                questions[j] = sr1.ReadLine();
            }
            for (int j = 0; j < len; j++)
            {
                circle[j] = Convert.ToInt32(sr1.ReadLine());
            }
            sr1.Close();

            

        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;


            double sw = (pictureBox1.Width-(cv.Length)*5)/cv.Length;
            double sh;
            double cvmax = cv.Max(), cvmin = cv.Min();
            double x, y;
            for (int i = 0; i < cv.Length; i++)
            {
                sh = ((this.pictureBox1.Height - 20) * (cv[i]) / cvmax);
                x = 5+i * (sw+5);
                y = this.ClientSize.Height - sh;

                gr.FillRectangle(Brushes.SeaGreen,Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(sw), Convert.ToSingle(sh));
                gr.DrawRectangle(Pens.Black, Convert.ToSingle(x), Convert.ToSingle(y), Convert.ToSingle(sw), Convert.ToSingle(sh));

                gr.DrawString(cv[i].ToString(),new Font("Calibri",15),Brushes.Black, Convert.ToSingle(x+5), Convert.ToSingle(y-22));
            }
            


        }

        private void onPaint1(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;


            double sw = (pictureBox1.Width - (cv.Length) * 5) / cv.Length;
            double sh,shpr;
            double cvmax = cv.Max(), cvmin = cv.Min();
            double x, y,xpr,ypr;
            
            for (int i =1; i < cv.Length; i++)
            {
                sh = ((this.pictureBox1.Height - 20) * (cv[i]) / cvmax);
                x = 5 + i * (sw + 5);
                y = this.ClientSize.Height - sh;
                shpr = ((this.pictureBox1.Height - 20) * (cv[i-1]) / cvmax);
                xpr= 5 + (i-1) * (sw + 5);
                ypr= this.ClientSize.Height - shpr;
                gr.DrawLine(new Pen(Brushes.Pink,2), Convert.ToSingle(xpr), Convert.ToSingle(ypr), Convert.ToSingle(x), Convert.ToSingle(y));
                
            }
            sh = ((this.pictureBox1.Height - 20) * (cv[0]) / cvmax);
            x = 5;
            y = this.ClientSize.Height - sh;
            gr.FillEllipse(Brushes.Red, Convert.ToSingle(x) - 5, Convert.ToSingle(y) - 5, 10, 10);
            gr.DrawString(cv[0].ToString(), new Font("Calibri", 12,FontStyle.Bold), Brushes.Black, Convert.ToSingle(x), Convert.ToSingle(y - 20));
            for (int i = 1; i < cv.Length; i++)
            {
                sh = ((this.pictureBox1.Height - 20) * (cv[i]) / cvmax);
                x = 5 + i * (sw + 5);
                y = this.ClientSize.Height - sh;
                shpr = ((this.pictureBox1.Height - 20) * (cv[i - 1]) / cvmax);
                xpr = 5 + (i - 1) * (sw + 5);
                ypr = this.ClientSize.Height - shpr;
                
                gr.DrawString(cv[i].ToString(), new Font("Calibri", 12,FontStyle.Bold), Brushes.Black, Convert.ToSingle(x), Convert.ToSingle(y - 20));
                gr.FillEllipse(Brushes.Red, Convert.ToSingle(x) - 5, Convert.ToSingle(y) - 5, 10, 10);
            }

        }

        private void onPaint2(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;

            Random rnd = new Random();
            for (int j = 0; j < len; j++)
            {
                int r, g, bl;
                r = rnd.Next(0, 255); g = rnd.Next(0, 255); bl = rnd.Next(0, 255);
                rand[j] = new SolidBrush(Color.FromArgb(r, g, bl));
                
            }

            int sum = circle.Sum();
            float curangle = 0;

            label1.Text = mquestion;
            for (int j = 0; j <len; j++)
            {

                gr.FillPie(rand[j],140,80,400,400, curangle, 360* ((float)circle[j] / sum));
                gr.DrawPie(Pens.Black, 140, 80, 400, 400, curangle, 360 * ((float)circle[j] / sum));

                curangle += 360*((float)circle[j]/sum);

                gr.FillRectangle(rand[j],700,100+j*40,30,30);
                gr.DrawRectangle(Pens.Black, 700, 100 + j * 40, 30, 30);

                gr.DrawString(questions[j]+" - " + Convert.ToString(100 * ((float)circle[j] / sum)).Substring(0,4) + " % ", new Font("Comic Sans MS",15),Brushes.Black, 750, 100 + j * 40);
            }
        }
    }
}
