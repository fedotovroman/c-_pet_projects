using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace FileMngm
{
    class FileMngmES
    {
        string[] wfn = new string[4] { "f1.wrk", "f2.wrk", "f3.wrk", "f4.wrk" }; // файлы, хранящие порции
        int fswitch, fgswitch; // переключатели файлов и групп
        static int psize = 3; // делим по  три
        static CFileMngm.TbCars[] arCars = new CFileMngm.TbCars[psize];
        FileStream[] wf = new FileStream[4];
        CFileMngm.TbCars tmpCar;

        public void ExtSort(string _fn)
        {
            Divide(_fn);
        }

        public unsafe void Divide(string _fn)
        {
            int i, j, k, lena;             
            int flen;                      
            CFileMngm.TbCars* bCars = stackalloc CFileMngm.TbCars[1];
            byte[] bbCars = new byte[sizeof(CFileMngm.TbCars)];
            File.Delete(wfn[0]);
            File.Delete(wfn[1]);            
            wf[0] = File.OpenWrite(wfn[0]);
            wf[1] = File.OpenWrite(wfn[1]);
            FileStream fCars = File.OpenRead(_fn);
            flen = (Int32)fCars.Length / sizeof(CFileMngm.TbCars);            
            fswitch = 0;
            lena = 0;
            for (i = 0; i < flen; i++)
            {
                if ((i > (psize-1)) & (i % psize == 0))                
                {
                    InsSort(lena);
                        for (k = 0; k < lena; k++)
                        {
                            bCars[0] = arCars[k];
                            Marshal.Copy((IntPtr)bCars, bbCars, 0, bbCars.Length);
                            wf[fswitch].Write(bbCars, 0, bbCars.Length);                    
                        }
                    fswitch = (fswitch + 1) % 2;                  
                    fCars.Read(bbCars, 0, bbCars.Length);
                    Marshal.Copy(bbCars, 0, (IntPtr)bCars, bbCars.Length);
                    arCars[i % psize] = bCars[0];
                    lena = 1;
                }
                else
                { 
                    fCars.Read(bbCars, 0, bbCars.Length);
                    Marshal.Copy(bbCars, 0, (IntPtr)bCars, bbCars.Length);
                    arCars[i % psize] = bCars[0];
                    lena = lena + 1;
                }               
            }
            InsSort(lena);
            for (k = 0; k < lena; k++)
            {
                bCars[0] = arCars[k];
                Marshal.Copy((IntPtr)bCars, bbCars, 0, bbCars.Length);
                wf[fswitch].Write(bbCars, 0, bbCars.Length);
            }
            fCars.Close();
            wf[0].Close();
            wf[1].Close();
        }        

        private void InsSort(int _lena)
        {
            int k, j;
            string key_tmp, key_ar;
            bool eoc;  
            for (k = 1; k < _lena; k++)
            {
                tmpCar = arCars[k];
                key_tmp = tmpCar.S.ToString("D3") + tmpCar.V.ToString("0.0");
                j = k - 1;
                eoc = false;
                while (!eoc)
                {
                    key_ar = arCars[j].S.ToString("D3") + arCars[j].V.ToString("0.0");
                    if (String.Compare(key_ar, key_tmp) <= 0)
                        eoc = true;
                    else
                    {
                        arCars[j + 1] = arCars[j];
                        j = j - 1;
                        if (j < 0)
                            eoc = true;
                    }
                }
                arCars[j + 1] = tmpCar;
            }
        }

        public unsafe string Merge()
        {
            int[] flen = new int[2];
            CFileMngm.TbCars* bw0 = stackalloc CFileMngm.TbCars[1];
            byte[] bbw0 = new byte[sizeof(CFileMngm.TbCars)];
            CFileMngm.TbCars* bw1 = stackalloc CFileMngm.TbCars[1];
            byte[] bbw1 = new byte[sizeof(CFileMngm.TbCars)];
            int wpsize = psize;
            bool eopm, eom;
            string keyw0, keyw1, fres;
            int ip0, ip1;
            eom = false;
            fgswitch = 0;
            fres = "";
            while (!eom)
            {
                eopm = false;
                fswitch = 0;
                wf[0] = File.OpenRead(wfn[fgswitch]);
                flen[0] = (Int32)wf[0].Length / sizeof(CFileMngm.TbCars);
                wf[1] = File.OpenRead(wfn[fgswitch + 1]);
                flen[1] = (Int32)wf[1].Length / sizeof(CFileMngm.TbCars);
                File.Delete(wfn[(fgswitch + 2) % 4]);
                File.Delete(wfn[(fgswitch + 2) % 4 + 1]);
                wf[2] = File.OpenWrite(wfn[(fgswitch + 2) % 4]);
                wf[3] = File.OpenWrite(wfn[(fgswitch + 2) % 4 + 1]);                
                keyw0 = "";
                keyw1 = "";
                wf[0].Read(bbw0, 0, bbw0.Length);
                Marshal.Copy(bbw0, 0, (IntPtr)bw0, bbw0.Length);
                keyw0 = bw0->S.ToString("D3") + bw0->V.ToString("0.0");
                flen[0] = flen[0] - 1;
                ip0 = 1;
                wf[1].Read(bbw1, 0, bbw1.Length);
                Marshal.Copy(bbw1, 0, (IntPtr)bw1, bbw1.Length);
                keyw1 = bw1->S.ToString("D3") + bw1->V.ToString("0.0");
                flen[1] = flen[1] - 1;
                ip1 = 1;
                while (!eopm)
                {   
                    switch (keyw0.CompareTo(keyw1))
                    {
                        case -1:
                            Marshal.Copy((IntPtr)bw0, bbw0, 0, bbw0.Length);
                            wf[2 + fswitch].Write(bbw0, 0, bbw0.Length);
                            if ((ip0 < wpsize) & (flen[0] > 0))
                            {
                                wf[0].Read(bbw0, 0, bbw0.Length);
                                Marshal.Copy(bbw0, 0, (IntPtr)bw0, bbw0.Length);
                                keyw0 = bw0->S.ToString("D3") + bw0->V.ToString("0.0");
                                ip0 = ip0 + 1;
                                flen[0] = flen[0] - 1;
                            }
                            else
                                keyw0 = "9999";
                            break;
                        case 0:
                            Marshal.Copy((IntPtr)bw0, bbw0, 0, bbw0.Length);
                            wf[2 + fswitch].Write(bbw0, 0, bbw0.Length);
                            if ((ip0 < wpsize) & (flen[0] > 0))
                            {
                                wf[0].Read(bbw0, 0, bbw0.Length);
                                Marshal.Copy(bbw0, 0, (IntPtr)bw0, bbw0.Length);
                                keyw0 = bw0->S.ToString("D3") + bw0->V.ToString("0.0");
                                ip0 = ip0 + 1;
                                flen[0] = flen[0] - 1;
                            }
                            else
                                keyw0 = "9999";
                            Marshal.Copy((IntPtr)bw1, bbw1, 0, bbw1.Length);
                            wf[2 + fswitch].Write(bbw1, 0, bbw1.Length);
                            if ((ip1 < wpsize) & (flen[1] > 0))
                            {
                                wf[1].Read(bbw1, 0, bbw1.Length);
                                Marshal.Copy(bbw1, 0, (IntPtr)bw1, bbw1.Length);
                                keyw1 = bw1->S.ToString("D3") + bw1->V.ToString("0.0");
                                ip1 = ip1 + 1;
                                flen[1] = flen[1] - 1;
                            }
                            else
                                keyw1 = "9999";
                            break;
                        case 1:
                            Marshal.Copy((IntPtr)bw1, bbw1, 0, bbw1.Length);
                            wf[2 + fswitch].Write(bbw1, 0, bbw1.Length);
                            if ((ip1 < wpsize) & (flen[1] > 0))
                            {
                                wf[1].Read(bbw1, 0, bbw1.Length);
                                Marshal.Copy(bbw1, 0, (IntPtr)bw1, bbw1.Length);
                                keyw1 = bw1->S.ToString("D3") + bw1->V.ToString("0.0");
                                ip1 = ip1 + 1;
                                flen[1] = flen[1] - 1;
                            }
                            else
                                keyw1 = "9999";
                            break;
                    }  //switch                    
                    if ((keyw0.CompareTo("9999") == 0) & (keyw1.CompareTo("9999") == 0))
                    {
                        if ((flen[0] == 0) & (flen[1] == 0))
                            eopm=true;
                        else
                           if (!(flen[0] == 0))
                           {
                                keyw0 = "";
                                wf[0].Read(bbw0, 0, bbw0.Length);
                                Marshal.Copy(bbw0, 0, (IntPtr)bw0, bbw0.Length);
                                keyw0 = bw0->S.ToString("D3") + bw0->V.ToString("0.0");
                                flen[0] = flen[0] - 1;
                                ip0 = 1;
                            }
                            if (!(flen[1] == 0))
                            {
                                keyw1 = "";
                                wf[1].Read(bbw1, 0, bbw1.Length);
                                Marshal.Copy(bbw1, 0, (IntPtr)bw1, bbw1.Length);
                                keyw1 = bw1->S.ToString("D3") + bw1->V.ToString("0.0");
                                flen[1] = flen[1] - 1;
                                ip1 = 1;
                            }
                            fswitch=(fswitch +1 ) % 2;
                        }                            
                } // eopm
                if ((wf[2].Length > 0) & (wf[3].Length > 0))
                {
                    fgswitch = (fgswitch+2) % 4;
                    wpsize = wpsize * 2;
                }                    
                else
                {
                    if (wf[2].Length > 0)
                        fres = wfn[(fgswitch + 2) % 4];
                    else
                        fres = wfn[(fgswitch + 2) % 4 + 1];
                    eom = true;
                }
                wf[0].Close();
                wf[1].Close();
                wf[2].Close();
                wf[3].Close();
            } // eom
            return fres;
        }  // Merge
    }
}
