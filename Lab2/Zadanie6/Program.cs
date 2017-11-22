using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
           double b;
            b = double.Parse(Console.ReadLine());
            double h;
            h = double.Parse(Console.ReadLine());
            double area;
            if (b > 0)
            if (h > 0)
            {
                area = b * h / 2;
                Console.WriteLine("{0:F4}", area);
            }
            else
            {
                Console.WriteLine("Значение height должно быть положительным");
            }
            else
            {
                Console.WriteLine("Значение base должно быть положительным");
            }


        }
    }
}
