using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FileMngm
{
    class CFileMngm
    {
        public unsafe struct TbCars
        {
            public fixed byte Mark[30];
            public double V;
            public int S;
        }
        public unsafe void Convert(string _fn, DataGridView _dgErr)
        {
             
            int i, j, Res; 
            string tmp;
            TbCars* bCars = stackalloc TbCars[1];

            byte[] bbCars = new byte[sizeof(TbCars)];
            
            string bCarsTXT;
            string[] rCar;
            System.IO.StreamReader fCatsTXT = new System.IO.StreamReader(_fn);
            tmp = "";
            for (i = 0; i <= _fn.IndexOf("."); i++)
                tmp = tmp + _fn[i];
            tmp = tmp + "dat";
            Console.WriteLine(tmp,_fn);
            FileStream fCars = File.OpenWrite(tmp);
            j = 0;
            while ((bCarsTXT = fCatsTXT.ReadLine()) != null)
            {
                rCar=bCarsTXT.Split(new Char[] {'/'});
                Console.Write("{0}", string.Join(" ", rCar));
                Console.WriteLine();
                if (rCar.Length == 3)
                    {
                        for (i = 0; i < 30; i++)
                            bCars->Mark[i] = 32;
                        for (i = 0; i < rCar[0].Length; i++)
                            bCars->Mark[i] = System.Convert.ToByte(rCar[0][i]);
                        if (Double.TryParse(rCar[1], out bCars->V))
                        {                        
                            if (Int32.TryParse(rCar[2], out bCars->S))
                                Res = 0;
                            else
                                Res = 2; // ошибка 2 типа.
                        }
                        else
                            Res = 1; // ошибка 1 типа.
                    }  //then
                    else
                        Res = 3; // ошибка 3 типа.

                if (Res !=0)
                {
                    _dgErr.Visible = true;
                    _dgErr.RowCount = _dgErr.RowCount + 1;
                    _dgErr.Rows[j].Cells[0].Value = Res.ToString() + " - " + bCarsTXT;
                    j = j + 1;
                }
                else
                { 
                    Marshal.Copy((IntPtr)bCars, bbCars, 0, bbCars.Length);
                    fCars.Write(bbCars, 0, bbCars.Length);
                }
                Console.Write("{0}", string.Join(" ", bbCars));

            }
            fCars.Close();           
        }
        public unsafe void Load(string _fn, DataGridView _dgCars)
        {
            int i, j, k;
            int flen;
            string s;
            CFileMngm.TbCars* bCars = stackalloc CFileMngm.TbCars[1];
            byte[] bbCars = new byte[sizeof(CFileMngm.TbCars)];
            FileStream fCars = File.OpenRead(_fn);
            flen = (Int32)fCars.Length / sizeof(CFileMngm.TbCars);
            _dgCars.RowCount = flen + 1;
            for (i = 0; i < flen; i++)
            {
                fCars.Read(bbCars, 0, bbCars.Length);
                Marshal.Copy(bbCars, 0, (IntPtr)bCars, bbCars.Length);
                s = Encoding.UTF8.GetString(bbCars, 0, 30);
                _dgCars.Rows[i].Cells[0].Value = s;
                _dgCars.Rows[i].Cells[1].Value = bCars->V.ToString();
                _dgCars.Rows[i].Cells[2].Value = bCars->S.ToString();
            }
            fCars.Close();
        }
    }   
}
