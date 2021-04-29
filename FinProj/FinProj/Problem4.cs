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
    public partial class Problem4 : Form
    {
        public Problem4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans="";
            Random rnd = new Random();
            int[] mass = new int[10];
            float aver = 0;

            for (int i = 0; i < 10; i++)
            {
                mass[i] = rnd.Next(10, 99);
                ans +=" " + Convert.ToString(mass[i]);
                aver = aver + mass[i];
            }
            
            aver = aver / 10;
            ans+="\nСреднее значение есть "+Convert.ToString( aver);
            for (int i = 1; i < 10; i++)
                if ((mass[i - 1] < aver) && (mass[i] > aver))
                {
                    ans += "\nСреднее значение лежит между "+ Convert.ToString(mass[i - 1])+ " и " + Convert.ToString(mass[i]);
                    break;
                }
            label1.Text = ans;
        }
    }
}
