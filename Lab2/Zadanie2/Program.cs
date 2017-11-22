using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            int A;
            A = int.Parse(a);
            if (A <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            int area;
            area = 6 * A * A;
            Console.Write(area);
           
            
        }
    }
}
