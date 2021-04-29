using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExExcel
{   //http://wladm.narod.ru/C_Sharp/comexcel.html 
    //http://csharp.net-informations.com/excel/csharp-open-excel.htm
    class ExExcelW
    {
        Excel.Application exapp;
        Excel.Workbook exwb;
        Excel.Worksheet exsht;
        Excel.Range excls;
        Random rv;
        object miss = System.Reflection.Missing.Value;

        public void OpenFEx(string _fn)
        {
            exapp = new Excel.Application();
            exwb = exapp.Workbooks.Open(@_fn); 
            exapp.Visible = true;
        }

        public void ChangeCells(string _x)
        {
            int i;
            string s;
            double x;
            exsht = exwb.ActiveSheet;
            excls = (Excel.Range)exsht.Cells[10, 1];
            rv = new Random();
            for (i = 1; i <= 10; i++)
            {
                s = "A" + i.ToString();
                excls = exsht.get_Range(s, miss);
                excls.Value2 = rv.Next(10);
            }
            if (Double.TryParse(_x, out x))
            {
                s = "B1";
                excls = exsht.get_Range(s, miss);
                excls.Value2 = x;
            }
            else
                MessageBox.Show("error data");
            s = "F5";
            excls = exsht.get_Range(s, miss);
            excls.Formula = "=(A5+B5)*C5";
        }
    }
}
