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
    public partial class Problem2 : Form
    {
        static bool IsPrime(uint inp)
        {
            for (int i = 2; i < inp; i++)
                if (inp % i == 0) return false;
            return true;
        }

        public Problem2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint N;
            uint MaxN = 1;
            N = Convert.ToUInt32(labn.Text);
            string ans="";

            for (int i = 2; i <= N; i++)
                if ((N % i == 0) & (IsPrime((uint)i)))
                {
                    if (MaxN < i) MaxN = (uint)i;
                    ans +=" "+ Convert.ToString(i);
                }
            ans += "\nНаибольший множитель произведения есть " + Convert.ToString(MaxN);

            label3.Text = ans;
        }
    }
}
