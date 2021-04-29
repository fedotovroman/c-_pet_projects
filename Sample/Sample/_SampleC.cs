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
        public unsafe struct TbCars
        {
            public fixed byte Mark[30];
            public double V;
            public int S;
        }
        public unsafe void QueSel(string _fn, DataGridView _dgCars)
        {
            int i, k;
            byte[] wMark;
            Encoding enc8 = Encoding.UTF8;               
            TbCars* bCars = stackalloc TbCars[1];
            byte[] bbCars = new byte[sizeof(TbCars)];
            FileStream fCars = File.OpenRead(_fn);
            _dgCars.RowCount = 3;
            i = 0;
            while (fCars.Read(bbCars, 0, bbCars.Length)==bbCars.Length)
            {        
                Marshal.Copy(bbCars, 0, (IntPtr)bCars, bbCars.Length);
                wMark = new byte[30];
                for (k = 0; k < 30;k++ )
                    wMark[k] = bCars->Mark[k];            
                _dgCars.Rows[i].Cells[0].Value =enc8.GetString(wMark,0,wMark.Length);             
               _dgCars.Rows[i].Cells[1].Value = bCars->V.ToString();
                _dgCars.Rows[i].Cells[2].Value = bCars->S.ToString();
                i = i + 1;
            }
            fCars.Close();
        }       
    }
}
