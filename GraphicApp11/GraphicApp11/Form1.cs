using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphicApp11
{
    public partial class Form1 : Form
    {
        string[] s = new string[5];
        int[] ch = new int[5];

        string[] Months ={"Январь","Февраль","Март","Апрель","Май","Июнь","Июль","Август","Сентябрь","Октябрь","Ноябрь","Декабрь"};
        int[] Sales = {1123,5123,9123,8124,2145,7634,4343,2315,9234,3353,9245,3002 };
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Март",122);
            dataGridView1.Rows.Add("Апрель", 413);
            dataGridView1.Rows.Add("Май", 521);
            dataGridView1.Rows.Add("Июнь", 411);
            dataGridView1.Rows.Add("Июль", 221);

            chart2.Series[0].Points.DataBindXY(Months, Sales);
            chart2.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart2.ChartAreas[0].AxisX.Interval = 1;

        }

        
       
        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            Graphics gr = chart1.CreateGraphics();
            Update(gr);

        }

        

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Graphics gr = chart1.CreateGraphics();
            Update(gr);

        }
        public void Update(Graphics gr)
        {
            for (int i = 0; i < 5; i++)
            {
                s[i] = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value);
                ch[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }

            chart1.Series[0].Points.DataBindXY(s, ch);


        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            //Update(e.Graphics);
        }
        int sw = 0;
        private void chart1_Click(object sender, EventArgs e)
        {
            
            switch (sw){
                case 0:
                    chart1.Series[0].BackGradientStyle = GradientStyle.LeftRight;
                    break;
                case 1:
                    chart1.Series[0].BackGradientStyle = GradientStyle.HorizontalCenter;
                    break;
                case 2:
                    chart1.Series[0].BackGradientStyle = GradientStyle.TopBottom;
                    break;
                    
            }
            if (sw > 3) sw = 0;
            sw++;


        }
    }
}
