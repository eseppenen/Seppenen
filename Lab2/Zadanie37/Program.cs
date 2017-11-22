using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie37
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume1, volume2, temperature1, temperature2;
            volume1 = double.Parse(Console.ReadLine());
            if (volume1 <= 0)

            {
                Console.WriteLine("Объем должен быть неотрицательным");
                return;
            }
            volume2 = double.Parse(Console.ReadLine());
            if (volume2 <= 0)

            {
                Console.WriteLine("Объем должен быть неотрицательным");
                return;
            }
            temperature1 = Convert.ToDouble(Console.ReadLine());
            temperature2 = Convert.ToDouble(Console.ReadLine());
            double volume = volume1 + volume2;
            double temperature = ((temperature1 * volume1) + (temperature2 * volume2)) / (volume1 + volume2);
            Console.WriteLine("{0:F4}", volume);
            Console.WriteLine("{0:F4}", temperature);
        }
    }
}
