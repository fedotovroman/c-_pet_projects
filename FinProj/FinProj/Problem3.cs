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
    public partial class Problem3 : Form
    {
        public Problem3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            string ans="";
            for (int i = (int)Math.Sqrt(Math.Pow(10, N - 1)); i < (int)Math.Sqrt(Math.Pow(10, N)); i++)
                if ((i * i / Math.Pow(10, N - 1) == 5) || ((i * i % 10) == 5))
                {
                    ans += " " + Convert.ToString(i*i);
                    break;
                }
            label2.Text = ans;
        }
    }
}
