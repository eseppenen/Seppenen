using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie25
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, cInGrad;
            a= double.Parse(Console.ReadLine());
            b= double.Parse(Console.ReadLine());
            cInGrad = Convert.ToDouble(Console.ReadLine());
            double cInRad = cInGrad * Math.PI / 180;
            double result = Math.Sqrt(a*a + b*b - 2*a*b*Math.Cos(cInRad));
            Console.WriteLine("{0:F4}", result);
            }
    }
}
