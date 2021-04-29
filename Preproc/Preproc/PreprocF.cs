using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preproc
{
    public partial class PreprocF : Form
    {
        PreprocC PP = new PreprocC();
        public PreprocF()
        {
            InitializeComponent();
        }

        private void btnPreproc_Click(object sender, EventArgs e)
        {
            if (ofdMD.ShowDialog() == DialogResult.OK)
                PP.Constr(ofdMD.FileName);

        }
    }
}
