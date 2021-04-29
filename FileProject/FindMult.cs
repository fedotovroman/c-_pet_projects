using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FileProject
{
    class FindMult
    {

        public int GetMult(string inp)
        {
            int m=1,k=0;
            string curs="0";
            inp ="1"+ inp + "a";
            for (int i = 0; i < inp.Length; i++)
            {
                if (new char[] {'0','1','2','3','4','5','6','7','8','9'}.Contains(inp[i]))
                {

                    curs = curs + Convert.ToString(inp[i]);
                    
                   
                }
                else
                {
                    if (curs != "")
                    {
                        m = m * Convert.ToInt32(curs);
                        
                        curs = "";
                    }
                    
                }

            }
            return m;
        }
    }
}
