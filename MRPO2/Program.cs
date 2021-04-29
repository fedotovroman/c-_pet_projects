using System;

namespace MRPO2
{
    class Program
    {
        static bool IsPrime(uint inp)
        {
            for (int i = 2; i < inp; i++)
                if (inp % i == 0) return false;
            return true;        
        }
        static void Main(string[] args)
        {
            
            uint N;
            uint MaxN=1;
            N =Convert.ToUInt32( Console.ReadLine());
            Console.Write("Простые множители {0} : ", N);

            for (int i = 2; i <= N; i++)            
                if ((N % i == 0) & (IsPrime((uint)i)))
                {
                    if (MaxN < i) MaxN = (uint)i;
                    Console.Write(" {0}",i);
                }
            Console.WriteLine();
            Console.WriteLine("Наибольший множитель произведения есть {0}", MaxN);
            Console.ReadKey();
        }
    }
}
