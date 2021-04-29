using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonleave_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void buttonleave_MouseEnter_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            Random c = new Random();
            int randx= rand.Next(55,Width-50);
            int randy = rand.Next(55, Height - 50);
            buttonleave.Location = new Point(randx, randy);
            buttonleave.BackColor = Color.FromArgb(c.Next());
            buttonleave.Text = "Не нажал!";
            
        }
    }
}
