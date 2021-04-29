using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FileProject
{
    class Divide7
    {

        
        public string GetRemainder(string inp)
        {
            return BigInteger.Remainder(BigInteger.Parse(inp),7).ToString();
        }

    }
}
