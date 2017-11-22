using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie22
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass, aInGrad;
            mass = double.Parse(Console.ReadLine());
            if (mass <= 0) 
            {
                Console.WriteLine(" Масса должна быть положительной");
                return;
            }
            aInGrad = Convert.ToDouble(Console.ReadLine());
            double aInRad, result;
            aInRad = aInGrad * Math.PI / 180;
            double g = 9.8067;
            result = mass * g * Math.Cos(aInRad);
            Console.WriteLine("{0:F4}", result);
        }
    }
}
