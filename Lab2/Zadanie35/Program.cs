using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie35
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2;
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            double result = Math.Sqrt((x2 * x2) + (x1 * x1));
            Console.WriteLine("{0:F4}", result);
        }
    }
}
