using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Sample
{
    class SampleC
    {   
        public unsafe struct TbfIn /* структура компонентов */
        {            
            public fixed byte Mark[30]; //Mark
            public double V;  //V
            public int S;     //S
        }
        public unsafe void QueSel(DataGridView _dgOut)
        {
            int i, k; 
            byte[] wStr; /* байт-массив */
            Encoding enc8 = Encoding.UTF8;               
            TbfIn* bfIn = stackalloc TbfIn[1]; /* ссылка на буфер динамической памяти */
            byte[] bbfIn = new byte[sizeof(TbfIn)]; /* байт-массив длиной в запись */
            FileStream ffIn = File.OpenRead("C:/Users/Karina/Desktop/2nd year/LnMP/Sample/Cars.dat"); // "C:/Users/Student/Desktop/All/Мунерман/Sample/Cars.dat"
            _dgOut.RowCount = 2; /* с запасом */
            i = 0; /* счётчик на 0. */
            while (ffIn.Read(bbfIn, 0, bbfIn.Length)==bbfIn.Length) /* пока размер файла равен длине записи */
            {        
                Marshal.Copy(bbfIn, 0, (IntPtr)bfIn, bbfIn.Length); /* копируем в динамическую память */
                _dgOut.RowCount = _dgOut.RowCount + 1;
                    wStr = new byte[30]; /* размер в "30 строк" */
                    for (k = 0; k < 30;k++ ) // пробегаем,
                    wStr[k] = bfIn->Mark[k]; // начиная с поля Mark
                    _dgOut.Rows[i].Cells[0].Value = enc8.GetString(wStr, 0, wStr.Length); /* "выводим" содержимое байт-массива */
                    _dgOut.Rows[i].Cells[1].Value = bfIn->V.ToString(); /* "выводим" содержимое V */
                _dgOut.Rows[i].Cells[2].Value = bfIn->S.ToString(); /* "выводим" содержимое S */
                i = i + 1;                                   
            }
            ffIn.Close(); /* закрыли файл */
        }
    }
}
