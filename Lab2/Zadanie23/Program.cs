using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie23
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
                return;
            }
            b= double.Parse(Console.ReadLine());
            c= double.Parse(Console.ReadLine());
            double discriminant = b * b - (4 * a * c);
            Console.WriteLine("{0:F4}", discriminant);
        }
    }
}
