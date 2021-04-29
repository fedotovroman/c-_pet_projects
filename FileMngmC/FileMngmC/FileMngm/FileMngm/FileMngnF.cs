using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileMngm
{
    public partial class frmFileMngm : Form
    {
        CFileMngm FM = new CFileMngm();
        FileMngmSDS FMSDS = new FileMngmSDS();
        FileMngnHSH FMHSH = new FileMngnHSH();
        FileMngmES FMES = new FileMngmES();
        public frmFileMngm()
        {
            InitializeComponent();
            dgErr.Visible = false;            
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            FM.Convert("Cars.txt", dgErr);    
        }  
        
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (odCars.ShowDialog() == DialogResult.OK)
                FM.Load(odCars.FileName, dgCars);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            FMSDS.FileSort("Cars.dat");
        }

        private void btnDSearch_Click(object sender, EventArgs e)
        {
            //lblDS.Text = FMSDS.DSearch("Cars.dat", "220NISSAN ALMERA                 1,4").ToString();
            //lblDS.Text = FMSDS.DSearch("Cars.dat", "200KIA Sportage                  2,3").ToString();
            lblDS.Text = FMSDS.DSearch("Cars.dat", "220NISSAN ALMERA                 1,8").ToString();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            //lblHash.Text = FMHSH.Hash("Nissan Almera").ToString();
            //lblHash.Text = FMHSH.Hash("NISSAN ALMERA").ToString();
            //lblHash.Text = FMHSH.Hash("СмолГУ").ToString();
            //lblDS.Text = FMHSH.HSearch("Cars.hsh", "220Nissan Almera                 1,8");
            //lblDS.Text = FMHSH.HSearch("Cars.hsh", "200KIA Sportage                  2,3");

            /* create hash in data_errs, аналогично, как делали до этого*/
            FMHSH.CreHSH("Cars.dat", dgErr); 

            /* load hashed file to data_cars, -//-*/
            FM.Load("Cars.hsh", dgCars);

            /* find_hash, -//- */
            lblDS.Text = FMHSH.HSearch("Cars.hsh", "220Ford Focus                    1,8");
        }

        private void btnExtSort_Click(object sender, EventArgs e)
        {
            FMES.Divide("Cars.dat");
            lblDS.Text = FMES.Merge();
        }
    }
}