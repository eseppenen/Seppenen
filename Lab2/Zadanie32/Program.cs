﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie32
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = double.Parse(Console.ReadLine());
            double b = (12 * a * a +7*a-16);
            Console.WriteLine("{0:F4}", b);
        }
    }
}
