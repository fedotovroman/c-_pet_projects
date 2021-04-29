using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDate
{
    public partial class FormOpenDeposit : Form
    {
        public FormOpenDeposit()
        {
            InitializeComponent();
        }

        private void OtmenaButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocCreator dc = new DocCreator();
            
        }
    }
}
