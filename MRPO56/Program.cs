using System;

namespace MRPO56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = (int)Math.Sqrt(Math.Pow(10, N - 1)); i < (int)Math.Sqrt(Math.Pow(10, N)); i++)
                if ((i * i / Math.Pow(10, N - 1)==5)||((i * i % 10) == 5)){
                    Console.WriteLine(i * i);
                    break;
                }
                
            
        }
    }
}
