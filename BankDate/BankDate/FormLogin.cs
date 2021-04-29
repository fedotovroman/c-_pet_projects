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
    public partial class FormLogin : Form
    {
        DBEditor db = new DBEditor("Data Source=ZVER-ПК;Initial Catalog=BankDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public FormLogin()
        {
            InitializeComponent();

            picbox_key.Image = Image.FromFile("keys.png");
        }
        public FormMainAdmin formMainManager;
        public FormMain formMain;


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (db.CheckManager(logdatebox.Text, passdatebox.Text))
            {
                formMainManager = new FormMainAdmin();
                formMainManager.Show();
                this.Hide();
                
            }
            else if (db.CheckClient(logdatebox.Text, passdatebox.Text))
            {
                formMain = new FormMain();
                formMain.Show();
                this.Hide();
                
            }
            else MessageBox.Show("Идентификатор или пароль пользователя введен неверно ","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);

            
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
