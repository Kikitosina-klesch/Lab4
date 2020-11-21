using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("}{ola Amouuur...!");


            Console.WriteLine("Вводи число А ");
            double A = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Вводи число B ");
            double B = Convert.ToDouble(Console.ReadLine());


            double res2 = A - B;
            Console.WriteLine("Результат вычитания А и В - " + Convert.ToString(res2));

        }
    }
}
