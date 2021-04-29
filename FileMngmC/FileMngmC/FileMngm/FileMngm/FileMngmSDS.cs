    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;

namespace FileMngm
{
    class FileMngmSDS
    {        
        public unsafe void FileSort(string _fn)
        {            
            int i, j, k;            /* + */
            int flen;
            string key_tmp, key_ar; /* + */
            bool eoc;               /* + */
            string s; // is not used.
            CFileMngm.TbCars* bCars = stackalloc CFileMngm.TbCars[1];
            byte[] bbCars = new byte[sizeof(CFileMngm.TbCars)];
            CFileMngm.TbCars tmpCar;
            //Load file to array            
            FileStream fCars = File.OpenRead(_fn);
            flen=(Int32)fCars.Length/sizeof(CFileMngm.TbCars);
            CFileMngm.TbCars[] arCars = new CFileMngm.TbCars[flen];
            for (i = 0; i < flen; i++)
            {
                fCars.Read(bbCars, 0, bbCars.Length);
                Marshal.Copy(bbCars, 0, (IntPtr)bCars, bbCars.Length);
                arCars[i] = bCars[0];                
            }
            
            //Sort array
            for (i = 1; i < flen; i++) /* + */ // begin with the second one
            {
                tmpCar = arCars[i];    /* + */ // chose it
                key_tmp = tmpCar.S.ToString("D3"); // key field Speed
                for (k = 0; k < 30; k++)
                    key_tmp = key_tmp + tmpCar.Mark[k].ToString();
                key_tmp = key_tmp + tmpCar.V.ToString("0.0");
                j = i - 1;             /* + */ // artificially generated an index of the previous one
                eoc = false;           /* + */ // falsed end of circle
                while (!eoc)           /* + */ // check
                {
                    key_ar = arCars[j].S.ToString("D3"); // next
                    bCars[0] = arCars[j]; // removed to the buffer
                    for (k = 0; k < 30; k++)
                        key_ar = key_ar + bCars->Mark[k].ToString(); // chose the record with field and the key field
                    key_ar = key_ar + arCars[j].V.ToString("0.0"); // and added it the next key field   
                    if (String.Compare(key_ar, key_tmp)<=0) /* + */ // аналог A[j] < tmp
                        eoc = true;      /* + */
                    else                 /* + */
                    {
                        arCars[j + 1] = arCars[j]; /* + */
                        j = j - 1;                 /* + */
                        if (j < 0)
                           eoc = true;
                    }                   
                }
                arCars[j + 1] = tmpCar;            /* + */
            }
            fCars.Close();
            fCars = File.OpenWrite(_fn);
            for (i = 0; i < flen; i++)
            {
                bCars[0] = arCars[i];
                Marshal.Copy((IntPtr)bCars, bbCars, 0, bbCars.Length);
                fCars.Write(bbCars, 0, bbCars.Length);                
            }
            fCars.Close();
        }
        public unsafe int DSearch(string _fn, string _SI)
        {
            int left, middle, right;       
            int k, flen;
            string key;
            object SI;
            //object SI;
            CFileMngm.TbCars* bCars = stackalloc CFileMngm.TbCars[1];
            byte[] bbCars = new byte[sizeof(CFileMngm.TbCars)];
            FileStream fCars = File.OpenRead(_fn);
            flen=(Int32)fCars.Length/sizeof(CFileMngm.TbCars); // number of records
            left = 0; // initialized
            right = flen-1; // the last element before the last one
            key = ""; // initialized
            while (left < right)
            {
                middle = (left + right) / 2;
                fCars.Seek(middle * sizeof(CFileMngm.TbCars), SeekOrigin.Begin);
                fCars.Read(bbCars, 0, bbCars.Length);
                Marshal.Copy(bbCars, 0, (IntPtr)bCars, bbCars.Length);
                key = bCars->S.ToString("D3");                
                for (k = 0; k < 30; k++)
                       key = key + Convert.ToChar(bCars->Mark[k]);
                key = key + bCars->V.ToString("0.0");   
                if (String.Compare(key, _SI, true)<0)
                   left = middle + 1;
                else
                   right = middle;
            }
            fCars.Seek(right * sizeof(CFileMngm.TbCars), SeekOrigin.Begin);
            fCars.Read(bbCars, 0, bbCars.Length);
            Marshal.Copy(bbCars, 0, (IntPtr)bCars, bbCars.Length);
            key = bCars->S.ToString("D3");
            for (k = 0; k < 30; k++)
                key = key + Convert.ToChar(bCars->Mark[k]);
            key = key + bCars->V.ToString("0.0");
            if (String.Compare(key, _SI, true) == 0)
                return right;
            else
                return -1;
            
        }
        
    }
}
