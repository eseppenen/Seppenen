using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double circumference;
            radius = double.Parse(Console.ReadLine());
            if (radius > 0)
            {
                circumference = 2 * Math.PI * radius;
                Console.WriteLine("{0:F4}", circumference);
            }
            else
            {
                Console.WriteLine("Радиус должн быть положительным");
            }

        }
    }
}
