using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Arrs
{
    class ArrsC
    {
        private static int N, B;
        private static int[] A;
        private static int sumL, sumH;
        public bool Init(string _N, string _B)
        {
            int i;
            if ((Int32.TryParse(_N, out N))&&(Int32.TryParse(_B, out B)))
            {
                A = new int[N];                
                Random Aval = new Random();
                for (i = 0; i < N; i++)
                    A[i] = Aval.Next(B);               
                return true;
            }
            else
                return false;
        }
        public void Show( DataGridView _dgArr)
        {
            int i;
            _dgArr.RowCount = N + 1;
            for (i = 0; i < N; i++)
               _dgArr.Rows[i].Cells[0].Value = A[i].ToString();
        }
        public bool Save( DataGridView _dgArr)
        {
            int i;
            bool tmp;         
            tmp = true;
            for (i = 0; i < N; i++)
                tmp = tmp & Int32.TryParse(_dgArr.Rows[i].Cells[0].Value.ToString(), out A[i]);
            return tmp;
        }
        public void InsertSort()
        {
            int i, j;
            int tmp;
            bool eoc;
            for (i=1;i<N;i++)
            {
                tmp=A[i];
                j=i-1;
                eoc=false; 
                while (!eoc)
                {
                    if (j < 0)
                        eoc = true;
                    else
                        if (A[j] < tmp)
                            eoc = true;
                        else
                        { 
                            A[j+1]=A[j];
                            j=j-1;
                        }
                }
                A[j+1]=tmp;
            }
        }
        public void BubbleSort(int h)
        {
            int i, j, Margin;
            int tmp;
            bool Finish;
            Margin = N - h-1;
            j = Margin;
            do
            {                
                Finish=true;
                for (i = 0; i <= Margin; i++)
                {
                    if (A[i] > A[i + h])
                    {
                        tmp = A[i];
                        A[i] = A[i + h];
                        A[i + h] = tmp;
                        j = i;
                        Finish = false;
                    }
                }
                Margin = j - h;
            } 
            while (!Finish);
        }
        public void Shell()
        {
            int h;
            h = N / 2;
            while (h>0)
            {
                BubbleSort(h);
                h = h / 2;
            }
        }
        public int FindFirst(string _SI)
        {
            int SI,i,P;
            P=-1;
            i=0;
            if (Int32.TryParse(_SI,out SI))
              while ((i<N)&&(P==-1)) 
                  if (A[i]==SI)
                    P=i;
                  else
                    i=i+1;
            return P;
        }
        public int DSearch(string _SI)
        {
            int left, middle,right;
            int SI;
            if (Int32.TryParse(_SI,out SI))
            {
                left = 0;
                right = N - 1;                
                while (left<right)
                {
                    middle = (left + right) / 2;
                    if (A[middle] < SI)
                        left = middle + 1;
                    else
                        right = middle;
                }
                if (A[right] == SI)
                    return right;
                else
                    return -1;
            }
            return -1;
        }
        public void SeqSum(out string _s, out string _dt)
        {
            int i, sum;
            long dt;
            DateTime ts;
            DateTime te;
            ts = DateTime.Now;
            sum = 0;
            for (i = 0; i < N; i++)
                sum = sum + A[i];
            te = DateTime.Now;
            _s = sum.ToString();
            dt = te.Ticks-ts.Ticks;            
            _dt = dt.ToString();
        }
        public void ParSum(out string _s, out string _dt)
        {
            int i, sum; 
            long dt;
            DateTime ts;
            DateTime te;
            ts = DateTime.Now;
            Thread thrL = new Thread(sL);
            Thread thrH = new Thread(sH);            
            thrL.Start();
            thrH.Start();
            while (thrL.IsAlive | thrH.IsAlive);
            te = DateTime.Now;
            sum = sumL + sumH;
            _s = sum.ToString();
            dt = te.Ticks - ts.Ticks;
            _dt = dt.ToString();            
        }
        static void sL()
        {
            int i;
            sumL=0;
            for (i = 0; i < N / 2; i++)
                sumL = sumL + A[i];
        }
        static void sH()
        {
            int i;
            sumH = 0;
            for (i = N / 2; i < N; i++)
                sumH = sumH + A[i];
        }
    }
}
