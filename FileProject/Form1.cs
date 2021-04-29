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
namespace FileProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StreamReader w;
        string text;
        public CircleInters cir;
        private void button1_Click(object sender, EventArgs e)
        {
            int x1, y1, x2, y2, r1, r2;
            string c1, c2;
            using (StreamReader sr = new StreamReader("text//circlein.txt", System.Text.Encoding.Default))
            {
                text = sr.ReadToEnd();     
            }
            cir = new CircleInters();
            c1 = text.Split('\n')[0];
            c2 = text.Split('\n')[1];

            label1.Text = "1я окр. с центром в т. ("+ c1.Split(' ')[0] + "," + c1.Split(' ')[1] + ") и радиусом " + c1.Split(' ')[2];
            label2.Text = "2я окр. с центром в т. (" + c2.Split(' ')[0] + "," + c2.Split(' ')[1] + ") и радиусом " + c2.Split(' ')[2];

            cir.x1 = Convert.ToDouble(c1.Split(' ')[0]);
            cir.y1 = Convert.ToDouble(c1.Split(' ')[1]);
            cir.rad1 = Convert.ToDouble(c1.Split(' ')[2]);
            cir.x2 = Convert.ToDouble(c2.Split(' ')[0]);
            cir.y2 = Convert.ToDouble(c2.Split(' ')[1]);
            cir.rad2 = Convert.ToDouble(c2.Split(' ')[2]);

            using (StreamWriter sr = new StreamWriter("text//circleout.txt",false, System.Text.Encoding.Default))
            {
                if (cir.GetIntersection()) sr.WriteLine("Yes");
                else sr.WriteLine("No");
            }
        }
        Literal l;
        private void button2_Click(object sender, EventArgs e)
        {
            
            using (StreamReader sr = new StreamReader("text//pr2in.txt", System.Text.Encoding.Default))
            {
                text = sr.ReadToEnd();
            }


            l = new Literal(text);

            using (StreamWriter sr = new StreamWriter("text//pr2out.txt", false,System.Text.Encoding.Default))
            {
                sr.WriteLine(l.GetStr());
            }
            
        }
        Divide7 d;

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("text//pr3in.txt", System.Text.Encoding.Default))
            {
                text = sr.ReadToEnd();
            }


            d = new Divide7();

            using (StreamWriter sr = new StreamWriter("text//pr3out.txt", false, System.Text.Encoding.Default))
            {
                sr.WriteLine(d.GetRemainder(text));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FindMult f = new FindMult();
           
            using (StreamReader sr = new StreamReader("text//pr4in.txt", System.Text.Encoding.Default))
            {
                text = sr.ReadToEnd();
            }


           

            using (StreamWriter sr = new StreamWriter("text//pr4out.txt", false, System.Text.Encoding.Default))
            {
                sr.WriteLine(Convert.ToString(f.GetMult(text)));
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FiveProblem f = new FiveProblem();

            using (StreamReader sr = new StreamReader("text//pr5in.txt", System.Text.Encoding.Default))
            {
                text = sr.ReadToEnd();
            }

            f.alph = text.Split('\n')[0];

            f.N = Convert.ToInt32(text.Split('\n')[1]);
            f.arr = new int[f.N];

            for (int i = 2; i < f.N; i++)
            {
                f.arr[i]= Convert.ToInt32(text.Split('\n')[i]);
            }

            using (StreamWriter sr = new StreamWriter("text//pr5out.txt", false, System.Text.Encoding.Default))
            {
                sr.WriteLine(Convert.ToString(f.GetWord()));
            }
        }
    }
}
