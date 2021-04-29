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
    public partial class FormRegistration : Form
    {
        DBEditor db = new DBEditor("Data Source=ZVER-ПК;Initial Catalog=BankDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void b_reg_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            try
            {
                string ch=DataChecker.ClientRegCheck(lastnlab.Text.Replace(" ", ""), namelab.Text.Replace(" ", ""), thnamelab.Text.Replace(" ", ""), passwordlab.Text.Replace(" ", ""), mobphlab.Text.Replace(" ", ""), passserlab.Text.Replace(" ", ""), passnumlab.Text.Replace(" ", ""));
                if ((passserlab.Text + " " + passnumlab.Text).Replace(" ","")!="" && (mobphlab.Text).Replace(" ", "") != "" && passwordlab.Text.Replace(" ", "") != "" && ch=="YES" ) {
                    db.CreateNewClient(dtpicker.Value, lastnlab.Text.Replace(" ", "") + " " + namelab.Text.Replace(" ", "") + " " + thnamelab.Text.Replace(" ", ""), passserlab.Text.Replace(" ", "") + " " + passnumlab.Text.Replace(" ", ""), mobphlab.Text.Replace(" ", ""), passwordlab.Text.Replace(" ", ""));
                    MessageBox.Show("Новый клиент был успешно зарегистрирован", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else MessageBox.Show("Одно из значений персональных данных было введено неверно или пропущено. " + ch, "Сообщение об ошибке", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                
            }
           
        }


    }
}
