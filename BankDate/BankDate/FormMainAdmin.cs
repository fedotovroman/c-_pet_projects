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
    public partial class FormMainAdmin : Form
    {
        DBEditor db = new DBEditor("Data Source=ZVER-ПК;Initial Catalog=BankDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public FormMainAdmin()
        {

            InitializeComponent();
            UpdateMainForm();





        }

        public void UpdateMainForm()
        {   
           MainDataGreed.AutoGenerateColumns = true;
           MainDataGreed.DataSource = db.GetMainTable(); // dataset
            MainDataGreed.Columns[0].HeaderText = "Идентификатор";
            MainDataGreed.Columns[1].HeaderText = "ФИО клиента";
            MainDataGreed.Columns[2].HeaderText = "Вид вклада";
            MainDataGreed.Columns[3].HeaderText = "Процентная ставка";
            MainDataGreed.Columns[4].HeaderText = "Сумма вклада";
            MainDataGreed.Columns[5].HeaderText = "Дата создания";
        }

        private void BDepositOpen_Click(object sender, EventArgs e)
        {
            OpenDepositFormAdmin openDepositFormAdmin = new OpenDepositFormAdmin();
            openDepositFormAdmin.Show();
        }

        private void BDepositClose_Click(object sender, EventArgs e)
        {
            FormCloseDepositAdmin formCloseDepositAdmin = new FormCloseDepositAdmin();
            formCloseDepositAdmin.Show();
        }

        private void BCreateClient_Click(object sender, EventArgs e)
        {
            
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
            formRegistration.FormClosed +=new FormClosedEventHandler(Updater);
        }
        void Updater(object sender, FormClosedEventArgs e)
        {
            UpdateMainForm();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetInformation formGet = new GetInformation();
            formGet.Show();
            
        }
    }
}
