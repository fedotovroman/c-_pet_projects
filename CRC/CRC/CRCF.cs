using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRC
{
    public partial class CRCF : Form
    {
        CRCC cs = new CRCC();
        public CRCF()
        {            
            InitializeComponent();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            cs.Init(tbN.Text, tbB.Text);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            cs.Show(dgCRC);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cs.Save(dgCRC);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            cs.CalcCRC();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblCRC.Text = cs.CheckCRC();
        }
    }
}
