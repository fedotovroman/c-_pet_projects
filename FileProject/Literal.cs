using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileProject
{
    class Literal
    {
        string input="";
        public Literal(string inp)
        {
            input = inp;
        }

        public string GetStr()
        {
            Stack<char> st = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '#' && st.Count!=0)
                {
                    st.Pop();
                }
                else
                {
                    if (input[i] == '#' && st.Count != 0)
                    {
                        st.Pop();
                    }
                    else
                    {
                        if (input[i] != '#') st.Push(input[i]);
                    }
                }
                
            }
            char[] outp= st.ToArray();
            Array.Reverse(outp);
            input = new String(outp);
            return input;
            
        }
    }
}
