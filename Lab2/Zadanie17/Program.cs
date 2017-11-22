using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie17
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance;
            distance = double.Parse(Console.ReadLine());
            double velocity1;
            velocity1 = double.Parse(Console.ReadLine());
            if (velocity1 < 0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }
            double timevelocity1;
            timevelocity1= double.Parse(Console.ReadLine());
            timevelocity1 = distance / velocity1;
            double velocity2;
            velocity2 = double.Parse(Console.ReadLine());
            if (velocity2 < 0)
            {
                Console.WriteLine("Скорость должна быть неотрицательна");
                return;
            }
            double timevelocity2;
            timevelocity2 = double.Parse(Console.ReadLine());
            timevelocity2 = distance / velocity2;
            double time = timevelocity1 + timevelocity2;
            Console.WriteLine("{0:F4} (час), time");
        }
    }
}
