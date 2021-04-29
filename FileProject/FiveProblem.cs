using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProject
{
    class FiveProblem
    {
        public string alph;
        public int N;
        public int[] arr;

        public string GetWord()
        {
            string ans="";
            for (int i = 0; i < N; i++)
            {
                ans = ans + alph[arr[i]%9];
            }
            return ans;
        }
    }
}
