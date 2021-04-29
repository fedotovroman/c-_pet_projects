using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace NonStrC
{
    class NonStrCCnv
    {
        SqlConnection conProbBook;

        SqlCommand cmdProbBook;

        string csProbBook = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\VICTOR MUNERMAN\DOCUMENTS\PROGRAMMING\C#_PRO\NONSTRC\PROBBOOK.MDF;Integrated Security=True;Connect Timeout=30";

        public void ConvTXTSQL()
        {
            int c, l; 
            string[] rPB;
            System.IO.StreamReader fProbBookTXT = new System.IO.StreamReader("PBS.txt");
            string bProbBookTXT;
            conProbBook = new SqlConnection(csProbBook);
            conProbBook.Open();
            cmdProbBook = new SqlCommand();
            cmdProbBook.Connection = conProbBook;
            cmdProbBook.CommandText = "DELETE FROM PBS";
            cmdProbBook.ExecuteNonQuery();
            cmdProbBook.CommandType = CommandType.StoredProcedure;
            cmdProbBook.CommandText = "InsProbBook";
            cmdProbBook.Parameters.Add("@Class", SqlDbType.Int);
            cmdProbBook.Parameters.Add("@Subject", SqlDbType.NChar);
            cmdProbBook.Parameters.Add("@Theme", SqlDbType.NChar);
            cmdProbBook.Parameters.Add("@Number", SqlDbType.NChar);
            cmdProbBook.Parameters.Add("@Level", SqlDbType.Int);
            while ((bProbBookTXT = fProbBookTXT.ReadLine()) != null)
            {
                rPB = bProbBookTXT.Split(new Char[] { ';' });
                if ((rPB.Length == 5) & 
                    (Int32.TryParse(rPB[0], out c)) & 
                    (Int32.TryParse(rPB[4], out l)))
                        {
                            cmdProbBook.Parameters["@Class"].Value = c;
                            cmdProbBook.Parameters["@Level"].Value = l;
                            cmdProbBook.Parameters["@Subject"].Value = rPB[1];
                            cmdProbBook.Parameters["@Theme"].Value = rPB[2];
                            cmdProbBook.Parameters["@Number"].Value = rPB[3];
                            cmdProbBook.ExecuteNonQuery();
                        }
            }
            fProbBookTXT.Close();
            fProbBookTXT = new System.IO.StreamReader("StudS.txt");
            conProbBook = new SqlConnection(csProbBook);
            conProbBook.Open();
            cmdProbBook = new SqlCommand();
            cmdProbBook.Connection = conProbBook;
            cmdProbBook.CommandText = "DELETE FROM StudS";
            cmdProbBook.ExecuteNonQuery();
            cmdProbBook.CommandType = CommandType.StoredProcedure;
            cmdProbBook.CommandText = "InsStud";
            cmdProbBook.Parameters.Add("@Class", SqlDbType.Int);
            cmdProbBook.Parameters.Add("@Theme", SqlDbType.NChar);
            cmdProbBook.Parameters.Add("@Level", SqlDbType.Int);
            cmdProbBook.Parameters.Add("@Student", SqlDbType.NChar);
            while ((bProbBookTXT = fProbBookTXT.ReadLine()) != null)
            {
                rPB = bProbBookTXT.Split(new Char[] { ';' });
                if ((rPB.Length == 4) &
                    (Int32.TryParse(rPB[0], out c)) &
                    (Int32.TryParse(rPB[2], out l)))
                {
                    cmdProbBook.Parameters["@Class"].Value = c;
                    cmdProbBook.Parameters["@Level"].Value = l;
                    cmdProbBook.Parameters["@Theme"].Value = rPB[1];
                    cmdProbBook.Parameters["@Student"].Value = rPB[3];
                    cmdProbBook.ExecuteNonQuery();
                }
            }
            fProbBookTXT.Close();
            conProbBook.Close();
        }
    }
}
