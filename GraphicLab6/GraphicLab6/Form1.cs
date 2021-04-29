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
namespace GraphicLab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.ImageLocation = "wallpaper.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            Font font = new Font("Tahoma", 60f, FontStyle.Bold);
            LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.Red, Color.Black, LinearGradientMode.Horizontal);
            e.Graphics.DrawString("Welcome, GDI+ !", font, brush, 60,150);

            
        }
    }
}
