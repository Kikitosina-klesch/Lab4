﻿using System;

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


            double res3 = A * B;

            Console.WriteLine("Результат умножения А и В - " + Convert.ToString(res3));


            double res4 = A / B;
            Console.WriteLine("Результат деления А на В - "+ Convert.ToString(res4));

        }
    }
}
