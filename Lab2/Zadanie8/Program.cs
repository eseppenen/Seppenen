using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalInM;
            totalInM = Convert.ToInt16(Console.ReadLine());
            if (totalInM <= 0)
            {
            Console.WriteLine("Значение totalInM должно быть положительным");
                return;
            }
            int partInCm;
            partInCm = Convert.ToInt16(Console.ReadLine());
            if (partInCm <= 0)
            {
            Console.WriteLine("Значение partInCm должно быть положительным");
                return;
            }
            int quantity = totalInM * 100 / partInCm;
            int deficit = totalInM * 100 % partInCm;               
            Console.WriteLine("количество {0} шт, остаток {1} см", quantity, deficit);
            
        }


    }
}
