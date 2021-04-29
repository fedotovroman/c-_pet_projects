using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonStrC
{
    public partial class NonStrCF : Form
    {
        NonStrCCnv cnv = new NonStrCCnv();
        NonStrCMrg mrg = new NonStrCMrg();
        public NonStrCF()
        {
            InitializeComponent();
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            cnv.ConvTXTSQL();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            mrg.Init();
            mrg.Merge();
        }
    }
}
