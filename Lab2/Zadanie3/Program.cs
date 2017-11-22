using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            String a;
            a = Console.ReadLine();
            int V;
            V = int.Parse(a);
            if (V <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            int volume;
            volume = V * V * V;
            Console.Write(volume);


        }
    }
}
