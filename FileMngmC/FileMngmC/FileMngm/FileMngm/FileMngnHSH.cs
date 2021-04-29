using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FileMngm
{
    class FileMngnHSH
    {        
        int b=2; // основание системы счисления
        int h=101; // база хеширования
        public int Hash(string _key)
        {

           // char k = 'a';

            long e, code; // степень основания системы счисления и код
            int i; // счётчик
            e = 1; // инициализация основания сис. с.
            code = 0; // инициализация кода хеш-функции
            for (i=0; i<_key.Length; i++)
            {
               // code = Convert.ToChar(code) + k;
                code = code + Convert.ToInt32(_key[i]) * e; // 50???
                e = e * b;
            }
            return (int)(code % h);
        }
        public unsafe void CreHSH(string _fn, DataGridView _dgHCodes)
        {
            int i, j, k;
            int flen;
            int hcode;
            string tmp, fnh;
            CFileMngm.TbCars* bCars = stackalloc CFileMngm.TbCars[1];
            byte[] bbCars = new byte[sizeof(CFileMngm.TbCars)];
            CFileMngm.TbCars tmpCar;
            //Load file to array
            fnh = "";
            for (i = 0; i <= _fn.IndexOf("."); i++)
                fnh = fnh + _fn[i];
            fnh = fnh + "hsh";
            FileStream fCarsH = File.OpenWrite(fnh);
            tmpCar.S = 0;
            tmpCar.V = 0;
            for (i = 0; i < 30; i++)
                bCars->Mark[i] = 32;
            flen = h;
            _dgHCodes.Visible = true;
            _dgHCodes.RowCount = 1;
            j = 0;
            for (i = 0; i < flen; i++)
            {
                Marshal.Copy((IntPtr)bCars, bbCars, 0, bbCars.Length);
                fCarsH.Write(bbCars, 0, bbCars.Length);
            }
            FileStream fCars = File.OpenRead(_fn);
            flen = (Int32)fCars.Length / sizeof(CFileMngm.TbCars);  // длина файла в байтах делим на количество байт в записи          
            for (i = 0; i < flen; i++)
            {
                fCars.Read(bbCars, 0, bbCars.Length);
                Marshal.Copy(bbCars, 0, (IntPtr)bCars, bbCars.Length);
                tmpCar = bCars[0];
                tmp = tmpCar.S.ToString("D3");
                for (k = 0; k < 30; k++)
                    tmp = tmp + Convert.ToChar(tmpCar.Mark[k]);
                tmp = tmp + tmpCar.V.ToString("0.0");
                hcode = Hash(tmp);
                fCarsH.Seek(hcode * sizeof(CFileMngm.TbCars), SeekOrigin.Begin);
                fCarsH.Write(bbCars, 0, bbCars.Length);
                _dgHCodes.RowCount = _dgHCodes.RowCount + 1;
                _dgHCodes.Rows[j].Cells[0].Value = hcode.ToString("D2") + " - " + tmp;
                j = j + 1;
            }
            fCars.Close();
            fCarsH.Close();
        }
        public unsafe string HSearch(string _fn, string _SI)
        {
            int hcode, k;
            string tmp;
            CFileMngm.TbCars* bCars = stackalloc CFileMngm.TbCars[1];
            byte[] bbCars = new byte[sizeof(CFileMngm.TbCars)];
            FileStream fCarsH = File.OpenRead(_fn);            
            hcode = Hash(_SI);
            fCarsH.Seek(hcode * sizeof(CFileMngm.TbCars), SeekOrigin.Begin);
            fCarsH.Read(bbCars, 0, bbCars.Length);
            Marshal.Copy(bbCars, 0, (IntPtr)bCars, bbCars.Length);
            tmp = bCars->S.ToString("D3");
            for (k = 0; k < 30; k++)
                tmp = tmp + Convert.ToChar(bCars->Mark[k]);
            tmp = tmp + bCars->V.ToString("0.0");
            if (String.Compare(tmp, _SI) == 0)
                return "Yes! "+ hcode.ToString();
            else 
                return "No!";
        }
        
    }
}
