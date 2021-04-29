using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BankDate
{
    class DBEditor
    {
        public int ClCount()
        {
            string counter = String.Format("SELECT COUNT(*) as ct FROM [BankDataBase].[dbo].[ClientsList]");
            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(counter, connection);
                SqlDataReader  sq= command.ExecuteReader();
                sq.Read();
                return sq.GetInt32(0);
            }

        }
        private string connectstring;
        public DBEditor(string connectstring)
        {
            this.connectstring = connectstring;
        }
        public void CreateNewClient(DateTime birthday,string fullname,string passport,string phonenumb,string password) 
        {
            string insertion = String.Format("INSERT INTO dbo.ClientsList  VALUES ( \'{0}\', \'{1}\',\'{2}\',\'{3}\',\'{4}\')",  birthday.Year+" - "+ birthday.Month+"-"+birthday.Day,fullname,passport,phonenumb,password);
            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(insertion, connection);
                command.ExecuteNonQuery();
            }
        }
        public bool CheckManager(string passport,string password)
        {
            string findmanager = String.Format("SELECT * FROM dbo.ManagersList WHERE ( PassportNumb=\'{0}\' AND ManPassword=\'{1}\')",passport,password);

            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(findmanager, connection);
                if (command.ExecuteReader().HasRows) return true; else return false;
            }
        }
        public bool CheckClient(string passport, string password)
        {
            string findclient = String.Format("SELECT * FROM dbo.ClientsList WHERE ( PassportNumb=\'{0}\' AND ClPassword=\'{1}\')", passport, password);
            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(findclient, connection);
                if (command.ExecuteReader().HasRows) return true; else return false;
            }
        }
        public bool CheckClient(string passport)
        {
            string findclient = String.Format("SELECT * FROM dbo.ClientsList WHERE ( PassportNumb=\'{0}\')", passport);
            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(findclient, connection);
                if (command.ExecuteReader().HasRows) return true; else return false;
            }
        }

        public DataTable GetMainTable()
        {
            string gettable = "SELECT  ClientsList.Id, ClientsList.FullName, DepositsTypesList.DepName, DepositsTypesList.DepInterRate, UsersDepositsList.ClientMoney,UsersDepositsList.CreatedAt FROM ClientsList LEFT JOIN UsersDepositsList ON UsersDepositsList.IdClients = ClientsList.Id LEFT JOIN DepositsTypesList ON DepositsTypesList.Id = UsersDepositsList.IdDepos";

            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(gettable, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable Table = ds.Tables[0];
                return Table;

            }
        }


        public string GetClientInfo(string passport)
        {
            string ans;
            string findclient = String.Format("SELECT FullName,BirthDate,Phone FROM dbo.ClientsList WHERE ( PassportNumb=\'{0}\')", passport);
            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(findclient, connection);
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows) {
                    ans = (string)dr["FullName"] + " " + dr.GetDateTime(1).ToShortDateString()+" "+ (string)dr["Phone"];
                    return ans;
                }
                else
                {
                    return "NO";
                }



            }
        }
    }
}
