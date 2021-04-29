using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Preproc
{
    class PreprocC
    {
        string bSmp, bCS; 
        string[]  bMD;        
        StreamReader fSmp;        
        StreamWriter fCS;
        string[] cmdOut ={"wStr = new byte[#l];",
                          "for (k = 0; k < #l;k++ )",
                          "wStr[k] = bfIn->#f[k];",
                          "_dgOut.Rows[i].Cells[#nf].Value = enc8.GetString(wStr, 0, wStr.Length);",                         
                          "_dgOut.Rows[i].Cells[#nf].Value = bfIn->#f.ToString();"};
        public void Constr(string _fMD)
        {
            int i, pLow, pHi;
            bMD = System.IO.File.ReadAllLines(_fMD);
            fSmp = new StreamReader("SampleC.smp");
            fCS = new StreamWriter("SampleC.cs");
            while ((bSmp=fSmp.ReadLine())!=null)
            {
                bCS = bSmp;
                if (bSmp.IndexOf("struct")>0)
                {
                    fCS.WriteLine(bSmp);
                    if ((bSmp = fSmp.ReadLine()) != null)
                    {
                        fCS.WriteLine(bSmp);
                        for (i = 1; i < bMD.Length; i++)
                            fCS.WriteLine(bMD[i]);
                    }                    
                }
                else
                    if (bSmp.IndexOf("#fn") > 0)
                    {
                        bCS = bSmp.Replace("#fn", "\"" + bMD[0] + "\"");
                        fCS.WriteLine(bCS);
                    }
                    else
                        if (bSmp.IndexOf("#out") > 0)
                        {
                            for (i=1; i < bMD.Length; i++)
                            {
                                if (bMD[i].IndexOf("[")>0)
                                {
                                    bCS = cmdOut[0];
                                    pHi=bMD[i].IndexOf("]");
                                    pLow=bMD[i].IndexOf("[");
                                    bCS = bCS.Replace("#l", bMD[i].Substring(pLow+1, pHi - pLow-1));
                                    fCS.WriteLine(bCS);
                                    bCS = cmdOut[1];
                                    bCS = bCS.Replace("#l", bMD[i].Substring(pLow + 1, pHi - pLow - 1));
                                    fCS.WriteLine(bCS);
                                    pLow = bMD[i].IndexOf("//");
                                    pHi = bMD[i].Length;
                                    bCS = cmdOut[2];
                                    bCS = bCS.Replace("#f", bMD[i].Substring(pLow + 2, pHi - pLow - 2));
                                    fCS.WriteLine(bCS);
                                    bCS = cmdOut[3];
                                    bCS = bCS.Replace("#nf", (i-1).ToString());
                                    fCS.WriteLine(bCS);
                                }
                                else
                                    if ((bMD[i].IndexOf("double") > 0) | (bMD[i].IndexOf("int") > 0))
                                    {
                                        pLow = bMD[i].IndexOf("//");
                                        pHi = bMD[i].Length;
                                        bCS = cmdOut[4];
                                        bCS = bCS.Replace("#f", bMD[i].Substring(pLow + 2, pHi - pLow - 2));
                                        bCS = bCS.Replace("#nf", (i - 1).ToString());
                                        fCS.WriteLine(bCS);
                                    }
                            }
                        }
                        else
                            fCS.WriteLine(bSmp);
            }
            fCS.Close();
            fSmp.Close();
        }
    }
}
