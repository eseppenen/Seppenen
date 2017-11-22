using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double volumeforaball;
            radius = double. Parse(Console.ReadLine());
            if (radius > 0)
            {
                volumeforaball = 4 * Math.PI * radius * radius * radius / 3;
                Console.WriteLine("{0:F4}", volumeforaball);
            }
            else
            {
                Console.WriteLine("Радиус должн быть положительным");
            }

        }
    }
}
