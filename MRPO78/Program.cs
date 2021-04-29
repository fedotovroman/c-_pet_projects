using System;
using System.Linq.Expressions;

namespace MRPO78
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mass = new int[10];
            float aver=0;
            
            for (int i = 0; i < 10; i++)
            {
                mass[i] = rnd.Next(10,99);
                Console.Write(" {0}",mass[i]);
                aver =aver +mass[i];
            }
            Console.WriteLine();
            aver = aver/10;
            Console.WriteLine("Среднее значение есть {0} ",aver);
            for (int i = 1; i < 10; i++)
                if ((mass[i - 1] < aver) && (mass[i] > aver))
                {
                    Console.WriteLine("Среднее значение лежит между {0} и {1}", mass[i - 1], mass[i]);
                    break;
                }
            
        }
    }
}
