using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x;
            a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            b = double.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");
                return;
            }
            c = double.Parse(Console.ReadLine());
            x= double.Parse(Console.ReadLine());
            double R = 1 / Math.Sqrt(a * x * x + b * x + c);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
