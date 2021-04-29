﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CshCpp
{
    internal class CshCppWrp
    {
        public float Sum(float[] arr)
        {
                return ArrSum(arr, arr.Length);
        }

        [DllImport("CppAP.dll", EntryPoint = "Sum", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern float ArrSum(float[] array, int length);
    }
}
