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
    public partial class Problem5 : Form
    {
        public Problem5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            int N = Convert.ToInt32(textBox1.Text);

            label1.Text = Convert.ToString(N * 3);
        }
    }
}
