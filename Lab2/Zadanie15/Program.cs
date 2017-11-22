using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatureInC;
            temperatureInC = Convert.ToDouble(Console.ReadLine());
            double temperatureInF;
            temperatureInF = temperatureInC * 1.8 + 32;
            if (temperatureInF <0)
                {
                Console.WriteLine("Температура должна быть выше абсолютного нуля");
                return;
            }
            Console.WriteLine("{0:F4}", temperatureInF);

        }
    }
}
