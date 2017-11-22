using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            if (x<0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            double y;
            y = Convert.ToDouble(Console.ReadLine());
            if (y < 0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }
            double R;
            R = -5 * (Math.Sqrt(x) + Math.Sqrt(y));
            Console.WriteLine("{0:F4}", R);
        }
    }
}
