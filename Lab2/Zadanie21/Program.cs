﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie21
{
    class Program
    {
        static void Main(string[] args)
        {
            double R1, R2;
            R1 = double.Parse(Console.ReadLine());
            R2 = double.Parse(Console.ReadLine());
            if (R1 <= 0)
            {
                Console.WriteLine("Значение r1 должно быть не равно нулю");
                return;
            }
            if (R2 <= 0)
            {
                Console.WriteLine("Значение r2 должно быть не равно нулю");
                return;
            }
            double result;
            result = (1 / R1) + (1 / R2);
            Console.WriteLine("{0:F4}",result);
        }
    }
}
