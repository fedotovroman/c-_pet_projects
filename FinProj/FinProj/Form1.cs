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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textbox.Text = "Модель «Делать, пока не будет сделано».\nДаны попарно координаты концов двух отрезков x1, x2 и x3, x4. \nВерно ли, что" +
                " отрезки имеют единственную общую точку (не имеют единственной точки пересечения)?";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textbox.Text = "Разложите натуральное число N на простые множители и определите наибольший множитель произведения.";
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textbox.Text = "Среди трёхзначных (N-значных) полных квадратов найти первый, у которого какая то крайняя цифра равна 5.";
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textbox.Text = "Сформировать случайным образом целочисленный массив из 10 натуральных двузначных чисел. Найти среднее значение S и два соседних элемента, между которыми находится S.";
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textbox.Text = "Каждого третьего по списку ученика направляют на уборку территории, а каждого девятого из списка делают звеньевым соответствующей уборочной бригады. Сколько учеников списка не будут участвовать в уборке, когда назначат N-го звеньевого?";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Problem1 newForm = new Problem1();
            newForm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Problem2 newForm = new Problem2();
            newForm.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Problem3 newForm = new Problem3();
            newForm.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Problem4 newForm = new Problem4();
            newForm.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Problem5 newForm = new Problem5();
            newForm.Show();
        }
    }
}
