using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie20
{
    class Program
    {
        static void Main(string[] args)
        {
            double mass, velocity, height;
            mass = double.Parse(Console.ReadLine());
            velocity = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            if (mass <= 0)
            {
                Console.WriteLine("Значение mass должно быть положительным");
                return;
            }
            if (velocity <= 0)
            {
                Console.WriteLine("Значение velocity должно быть положительным");
                return;
            }
            if (height <= 0)
            {
                Console.WriteLine("Значение height должно быть неотрицательным");
                return;
            }
            double g = 9.8067;
            double kineticEnergy = (mass * velocity * velocity) / 2;
            double potentialEnergy = mass * g * height;      
            Console.WriteLine("Кинетическая энергия составляет:{kineticEnergy}(Дж)");
            Console.WriteLine("Потенциальная энергия составляет:{potentialEnergy}(Дж)");
        }
    }
}
