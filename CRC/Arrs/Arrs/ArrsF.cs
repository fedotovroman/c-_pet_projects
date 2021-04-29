using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arrs
{
    public partial class frmArrs : Form
    {
        ArrsC ExArr;
        public frmArrs()
        {
            InitializeComponent();
        }

        private void frmArrs_Load(object sender, EventArgs e)
        {
            ExArr = new ArrsC();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            if (!ExArr.Init(tbN.Text, tbB.Text))
                lblRes.Text = "Ошибка данных";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int P;
            P=ExArr.FindFirst(tbSI.Text);
            if (P >= 0)
                lblRes.Text = Convert.ToString(P);
            else
                lblRes.Text = "не найден";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ExArr.Show(dgArr);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ExArr.Save(dgArr))
                MessageBox.Show("Ошибка данных");
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            ExArr.InsertSort();
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            ExArr.BubbleSort(1);
        }

        private void btnShell_Click(object sender, EventArgs e)
        {
            ExArr.Shell();
        }

        private void btnDSearch_Click(object sender, EventArgs e)
        {
            int P;
            P=ExArr.DSearch(tbSI.Text);
            if (P >= 0)
                lblRes.Text = Convert.ToString(P);
            else
                lblRes.Text = "не найден";
            ;
        }

        private void btnPS_Click(object sender, EventArgs e)
        {
            string s, dt;
            s = "";
            ExArr.ParSum(out s, out dt);
            lblRes.Text = s + " " + dt;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            string s, dt;
            s = "";
            ExArr.SeqSum(out s, out dt);
            lblRes.Text = s + " " + dt;
        }
    }
}
