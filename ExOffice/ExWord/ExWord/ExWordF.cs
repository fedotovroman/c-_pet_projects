using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExWord
{
    public partial class frmWord : Form
    {
        WordSrv WS;
        public frmWord()
        {
            InitializeComponent();
            WS = new WordSrv();
        }
                /// create button click event 
        private void btnRead_Click(object sender, EventArgs e)
        {
            // call the method to create ms word document file
            WS.CreateMsWord();
        }

    }
}
