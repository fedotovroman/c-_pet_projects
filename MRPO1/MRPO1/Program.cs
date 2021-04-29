using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MPOlab1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, x2, x3, x4;
            Console.WriteLine("Введите x1, x2, x3, x4 : \n");
            x1 = Convert.ToSingle(Console.Read());
            x2 = Convert.ToSingle(Console.Read());
            x3 = Convert.ToSingle(Console.Read());
            x4 = Convert.ToSingle(Console.ReadLine());

            if (x1 > x2)
            {
                float temp = x1;
                x1 = x2;
                x2 = temp;
            }
            if (x3 > x4)
            {
                float temp = x3;
                x3 = x4;
                x4 = temp;
            }



            if ((x2 == x3) | (x1 == x4))
                Console.WriteLine(" Отрезки пересекаются ровно в одной точке");
            else
                Console.WriteLine(" Отрезки не пересекаются ровно в одной точке");



            Console.ReadKey();
        }
    }
}
