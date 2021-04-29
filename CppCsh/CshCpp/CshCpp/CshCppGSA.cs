using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using System.Diagnostics;

namespace CshCpp
{
    class CshCppGSA
    {
        CshCppWrp ap = new CshCppWrp();
        CshCppASMWRP asmp = new CshCppASMWRP();

        private float[] A;
        float res;

        public void Gen(int _l)
        {
            A = new float[_l];
            Random rnd = new Random();
            for (var i = 0; i < A.LongLength; i++)
            {
                A[i] = (float)rnd.Next(0, 10);
            }
        }

        public string SumCsh()
        {
            int i;
            
            if (null == A)
            {
                return @"Array not generated!";
            }
            else
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                res = 0;
                for (i = 0; i < A.LongLength; ++i)
                {
                    res = res + A[i];
                }
                timer.Stop();
                return string.Format(@"Sum:{0}; Time:{1}", res, timer.Elapsed);
            }
            
        }

       public string SumCppDLL()
        {
            if (A == null)
            {
                 return @"Array not generated!";
            }
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                res = ap.Sum(A);
                timer.Stop();
                return string.Format(@"Sum:{0}; Time:{1}", res, timer.Elapsed);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string SumCppDLLasm()
        {
            if (A == null)
            {
                return @"Array not generated!";
            }
            try
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                res = asmp.Sum(A);
                timer.Stop();
                return string.Format(@"Sum:{0}; Time:{1}", res, timer.Elapsed);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
