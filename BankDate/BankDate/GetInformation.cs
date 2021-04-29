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
    public partial class GetInformation : Form
    {
        DBEditor db = new DBEditor("Data Source=ZVER-ПК;Initial Catalog=BankDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public GetInformation()
        {
            InitializeComponent();
        }

        private void findinfob_Click(object sender, EventArgs e)
        {
            string ans = db.GetClientInfo(tb.Text);
            if (ans != "NO")
            {
                label6.Text = ans.Split(' ')[0];
                label7.Text = ans.Split(' ')[1];
                label8.Text = ans.Split(' ')[2];
            }
            else
            {
                label6.Text = "Клиент не найден";
            }

        }
    }
}
