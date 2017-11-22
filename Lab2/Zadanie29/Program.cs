using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie29
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = double.Parse(Console.ReadLine());
            if (x <= 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double R = (Math.Sqrt(x + 5) + Math.Sqrt(x - 5)) / 2 * Math.Sqrt(x);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
