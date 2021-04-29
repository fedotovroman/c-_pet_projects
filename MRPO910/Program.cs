using System;

namespace MRPO910
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число звеньевых N ");
            
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Число выбывших учеников есть {0} ", N*3);
        }
    }
}
