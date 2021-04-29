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
    public partial class FormMain : Form
    {
        Timer timer;
        public FormMain()
        {
            InitializeComponent();

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            MainStatusPanelL2.Text = DateTime.Now.ToLongDateString();
            LabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void BDepositOpen_Click(object sender, EventArgs e)
        {
            FormOpenDeposit openDeposit = new FormOpenDeposit();
            openDeposit.Show();
        }

        private void BDepositClose_Click(object sender, EventArgs e)
        {
            FormCloseDeposit formClose = new FormCloseDeposit();
            formClose.Show();
        }

        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
