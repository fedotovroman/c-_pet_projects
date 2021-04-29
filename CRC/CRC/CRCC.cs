using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CRC
{
    class CRCC
    {
        uint ics = 0xFFFFFFFF; // эталон контрольной суммы
        //NumberFormatInfo hex = NumberFormatInfo.CurrentInfo;
        private static int N, B;
        private static uint[] A;        
        public bool Init(string _N, string _B)
        {
            int i;
            if ((Int32.TryParse(_N, out N)) && (Int32.TryParse(_B, out B)))
            {
                A = new uint[N+1];
                Random Aval = new Random();
                for (i = 0; i < N; i++)
                    A[i] = (uint)Aval.Next(B);
                A[N] = 0;
                return true;
            }
            else
                return false;
        }
        public void Show(DataGridView _dgArr)
        {
            int i;
            _dgArr.RowCount = N + 2;
            for (i = 0; i <= N; i++)
                _dgArr.Rows[i].Cells[0].Value = String.Format("{0, 12:X}", A[i]); // вывод шестнадцатиричного числа
        }
        public bool Save(DataGridView _dgArr)
        {
            int i;
            bool tmp;
            tmp = true;
            for (i = 0; i < N; i++)                
                tmp = tmp & UInt32.TryParse(_dgArr.Rows[i].Cells[0].Value.ToString(), NumberStyles.HexNumber, null,  out A[i]);
            return tmp;
        }
        public void CalcCRC()
        {
            int i;
            A[N] = 0;
            for (i = 0; i < N; i++)
                A[N] = A[N] + A[i];
            A[N] = A[N] ^ ics; // сложение с переносом
        }
        public string CheckCRC()
        {
            int i;
            uint crc;
            crc = 0;
            for (i = 0; i <= N; i++)
                crc = crc + A[i];
            return String.Format("{0, 12:X}", crc);
        }
    }
}
