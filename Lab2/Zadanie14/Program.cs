using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            A = Convert.ToDouble(Console.ReadLine());
            double B;
            B = Convert.ToDouble(Console.ReadLine());
            double R;
            if (B < 0)
            {
                Console.WriteLine("Значение B должно быть не положительным");
                return;
            }
            R = A * Math.Sqrt(-7*B);
            Console.WriteLine("{0:F4}", R);
        }
    }
}
