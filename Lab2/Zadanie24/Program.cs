using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie24
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass1, mass2, distance;
            mass1 = double.Parse(Console.ReadLine());
            if (mass1 <= 0)
                
                {
                Console.WriteLine("Масса должна быть неотрицательной");
                return;
            }
            mass2 = double.Parse(Console.ReadLine());
            if (mass2 <= 0)
            {
                Console.WriteLine("Масса должна быть неотрицательной");
                return;
            }
                distance = double.Parse(Console.ReadLine());
            if (distance <= 0)
            {
                Console.WriteLine("Дистанция должна быть неотрицательной");
                return;
            }
            double g = 9.8067;
            double force = g * ((mass1 * mass2) / (distance * distance));
            Console.WriteLine("{0:F4}", force);


        }
    }
}
