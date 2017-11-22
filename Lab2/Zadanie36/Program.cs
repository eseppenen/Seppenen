using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie36
{
    class Program
    {
        static void Main(string[] args)
        {
            double xa, xb,ya,yb;
            xa = double.Parse(Console.ReadLine());
            xb = double.Parse(Console.ReadLine());
            ya = double.Parse(Console.ReadLine());
            yb = double.Parse(Console.ReadLine());
            double AB = Math.Sqrt(((xb - xa)*Math.Exp(2)) + (yb - ya) * Math.Exp(2));
            Console.WriteLine("{0:F4}", AB);
        }
    }
}
