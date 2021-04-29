using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExExcel
{
    public partial class ExExcelF : Form
    {
        ExExcelW WB = new ExExcelW();
        public ExExcelF()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (odWB.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                WB.OpenFEx(odWB.FileName);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            WB.ChangeCells(tbSqr.Text);
        }
    }
}
