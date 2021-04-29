using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollTheDice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dice D;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = textBox.Text.Split('\n');
            int[,] inp = new int[4, 4]; 
            for (int i = 0; i < 4; i++)       
                for (int j = 0; j < 4; j++)
                    inp[i,j] = Convert.ToInt32(lines[i].Split(' ')[j]);
            D = new Dice(inp);
            label1.Text = Convert.ToString(D.Solve(inp));    
        }
    }
}
