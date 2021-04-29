using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinProj
{
    public partial class Problem1 : Form
    {
        public Problem1()
        {
            InitializeComponent();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            float x1, x2, x3, x4;
            
            x1 = Convert.ToSingle(textBox1.Text);
            x2 = Convert.ToSingle(textBox2.Text);
            x3 = Convert.ToSingle(textBox3.Text);
            x4 = Convert.ToSingle(textBox4.Text);

            if (x1 > x2)
            {
                float temp = x1;
                x1 = x2;
                x2 = temp;
            }
            if (x3 > x4)
            {
                float temp = x3;
                x3 = x4;
                x4 = temp;
            }



            if ((x2 == x3) | (x1 == x4))
                l_ans.Text=" Отрезки пересекаются ровно в одной точке";
            else
                l_ans.Text = " Отрезки не пересекаются ровно в одной точке";



            
        }
    }
}
