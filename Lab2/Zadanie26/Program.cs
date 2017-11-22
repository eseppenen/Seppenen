using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d;
            a = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Значение a должно быть не равно нулю");
                return;
            }
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            if (d < 0)
            {
                Console.WriteLine("Значение d должно быть не равно нулю");
                return;
            }
            double R = (a * d + b * c) / (a * d);
            Console.WriteLine("{0:F4}", R);



        }
    }
}
