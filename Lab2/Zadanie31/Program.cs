using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie31
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x= double.Parse(Console.ReadLine());
            double y = (7 * x * x - 3 * x + 6);
            Console.WriteLine("{0:F4}", y);
        }
    }
}
