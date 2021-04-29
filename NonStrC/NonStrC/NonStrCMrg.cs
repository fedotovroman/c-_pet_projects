using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using NonStrC.ProbBookDataSetTableAdapters;

namespace NonStrC
{
    class NonStrCMrg
    {
        string csProbBook = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\VICTOR MUNERMAN\DOCUMENTS\PROGRAMMING\C#_PRO\NONSTRC\PROBBOOK.MDF;Integrated Security=True;Connect Timeout=30";
        struct tBucket
        {
            public int Grade;
            public string Theme;
            public int ComplexityLevel;
            public ArrayList Studs;
        }
        struct tTask
        {
            public string Stud;
            public int Grade;
            public string Theme;
            public int ComplexityLevel;
            public string NumProb;
        }

        tBucket Bucket;
        tTask Task;

        SqlConnection conStud;
        SqlConnection conProbBook;
        SqlCommand queStud, queBook;
        SqlDataReader readStud, readBook;
        ProbBookDataSet wPB = new ProbBookDataSet();
        ProbBookDataSet.TasksRow rTask;
        TasksTableAdapter taTastks = new TasksTableAdapter();
        //taTastks.Fill(wPB.Tasks); 

        public void Init()
        {
            Bucket = new tBucket();
            Bucket.Studs = new ArrayList();
            conStud = new SqlConnection(csProbBook);
            conStud.Open();
            conProbBook = new SqlConnection(csProbBook);
            conProbBook.Open();
            queStud = new SqlCommand();
            queStud.Connection = conStud;
            queStud.CommandText = "DELETE FROM Tasks";
            queStud.ExecuteNonQuery();
            queStud.CommandText = "SELECT * FROM StudS ORDER BY Class, Theme, Level;";
            readStud = queStud.ExecuteReader();
            queBook = new SqlCommand();
            queBook.Connection = conProbBook;
            queBook.CommandText = "SELECT * FROM PBS ORDER BY Class, Theme, Level;";
            readBook = queBook.ExecuteReader();
        }

        public int KeyComp(int _grade, string _theme, int _level)
        {
            int i;
            string key_Bucket, key_File;
            key_Bucket = Bucket.Grade.ToString("D2");
            key_Bucket = key_Bucket + Bucket.Theme;
            for (i = Bucket.Theme.Length + 1; i <= 50; i++)
                key_Bucket = key_Bucket + ' ';
            key_Bucket = key_Bucket + Bucket.ComplexityLevel.ToString("D2");
            key_File = _grade.ToString("D2");
            key_File = key_File + _theme;
            for (i = _theme.Length + 1; i <= 50; i++)
                key_File = key_File + ' ';
            key_File = key_File + _level.ToString("D2");
            return key_Bucket.CompareTo(key_File);
        }

        public bool Scoop()
        {
            bool eofSt, eos;
            Bucket.Grade = readStud.GetInt32(0);
            Bucket.Theme = readStud.GetString(1);
            Bucket.ComplexityLevel = readStud.GetInt32(2);
            Bucket.Studs.Clear();
            Bucket.Studs.Add(readStud.GetString(3));
            eofSt = false;
            eos = false;
            while (!eofSt & !eos)
            {
                if (readStud.Read())
                    if (KeyComp(readStud.GetInt32(0), readStud.GetString(1), readStud.GetInt32(2)) == 0)
                        Bucket.Studs.Add(readStud.GetString(3));
                    else
                        eos = true;
                else
                    eofSt = true;
            }
            if (eofSt)
            {
                return false;
            }
            else
                return true;
        }

        public void Merge()  //DataGridView _dgTasks
        {
            bool nonexhaust;
            int i, j, cmp;
            nonexhaust = false;
            nonexhaust = readStud.Read();
            nonexhaust = Scoop();
            nonexhaust = readBook.Read();
            //_dgTasks.RowCount = 200;
            j = 0;
            while (nonexhaust)
            {
                cmp = KeyComp(readBook.GetInt32(0), readBook.GetString(2), readBook.GetInt32(4));
                if (cmp < 0)
                    nonexhaust = Scoop();
                else
                    if (cmp == 0)
                {
                    for (i = 0; i < Bucket.Studs.Count; i++)
                    {
                        Task.Stud = Bucket.Studs[i].ToString();
                        Task.Grade = Bucket.Grade;
                        Task.Theme = Bucket.Theme;
                        Task.ComplexityLevel = Bucket.ComplexityLevel;
                        Task.NumProb = readBook.GetString(3);
                       /* _dgTasks.Rows[j].Cells[0].Value = Task.Stud;
                        _dgTasks.Rows[j].Cells[1].Value = Task.Grade.ToString();
                        _dgTasks.Rows[j].Cells[2].Value = Task.Theme;
                        _dgTasks.Rows[j].Cells[3].Value = Task.ComplexityLevel.ToString();
                        _dgTasks.Rows[j].Cells[4].Value = Task.NumProb;*/
                        rTask = wPB.Tasks.NewTasksRow();
                        rTask.Student = Task.Stud;
                        rTask.Grade = (short)Task.Grade;
                        rTask.Theme = Task.Theme;
                        rTask.Level = (byte)Task.ComplexityLevel;
                        rTask.Number = Task.NumProb;
                        wPB.Tasks.Rows.Add(rTask);
                        j = j + 1;
                    }
                    nonexhaust = readBook.Read();
                }
                else
                    nonexhaust = readBook.Read();
            }
            taTastks.Update(wPB.Tasks);
            readBook.Close();
            readStud.Close();
            conProbBook.Close();
        }
    }
}
