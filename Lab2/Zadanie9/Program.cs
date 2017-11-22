using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            int aInitial;
            aInitial = Convert.ToInt32(Console.ReadLine());
            int aRemainder = aInitial % 360;
            Console.WriteLine("Остаток от деления {0}" , aRemainder);



        }
    }
}
