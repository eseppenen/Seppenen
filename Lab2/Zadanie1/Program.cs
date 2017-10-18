using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            str = Console.ReadLine();
            double X;
            X = double.Parse(str);
            double result;
            result = X + 7;
            Console.WriteLine("{0:F4}", result);




        }
    }
}
