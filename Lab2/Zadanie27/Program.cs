using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie27
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = double.Parse(Console.ReadLine());
            double result = Math.Sqrt(1 - Math.Sin(x)* Math.Sin(x));
            Console.WriteLine("{0:F4}", result);
        }
    }
}
