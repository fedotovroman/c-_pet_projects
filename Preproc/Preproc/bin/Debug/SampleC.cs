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
        public unsafe struct TbfIn
        {            
			public fixed byte Mark[30]; //Mark
            public double V;  //V
            public int S;     //S
        }
        public unsafe void QueSel(DataGridView _dgOut)
        {
            int i, k; 
            byte[] wStr; 
            Encoding enc8 = Encoding.UTF8;               
            TbfIn* bfIn = stackalloc TbfIn[1];
            byte[] bbfIn = new byte[sizeof(TbfIn)];
            FileStream ffIn = File.OpenRead("	C:/Users/Karina/Desktop/2nd year/LnMP/Sample/Cars.dat");
            _dgOut.RowCount = 2;
            i = 0;
            while (ffIn.Read(bbfIn, 0, bbfIn.Length)==bbfIn.Length)
            {        
                Marshal.Copy(bbfIn, 0, (IntPtr)bfIn, bbfIn.Length);
                _dgOut.RowCount = _dgOut.RowCount + 1;
wStr = new byte[30];
for (k = 0; k < 30;k++ )
wStr[k] = bfIn->Mark[k];
_dgOut.Rows[i].Cells[0].Value = enc8.GetString(wStr, 0, wStr.Length);
_dgOut.Rows[i].Cells[1].Value = bfIn->V.ToString();
_dgOut.Rows[i].Cells[2].Value = bfIn->S.ToString();
                i = i + 1;                                   
            }
            ffIn.Close();
        }
    }
}
