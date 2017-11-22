using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie19
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialVelocity, time, acceleration;
            initialVelocity = Convert.ToDouble(Console.ReadLine());
            time = Convert.ToDouble(Console.ReadLine());
            acceleration = Convert.ToDouble(Console.ReadLine());
            if (time <= 0)
            {
                Console.WriteLine("Время должно быть положительным");
                return;
            }
            if (initialVelocity <= 0)
            {
                Console.WriteLine("Начальная скорость должно быть неотрицательна");
                return;
            }
            double distance;
            distance = initialVelocity * time + ((acceleration * time * time) / 2);
            Console.WriteLine("{0:F4}", distance);

        }
    }
}
