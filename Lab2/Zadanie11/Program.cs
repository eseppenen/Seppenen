using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x =double.Parse(Console.ReadLine());
            double R;
            if(x<0)
            {
            Console.WriteLine("Значение x должно быть неотрицательным");
                return;
            }
            R = Math.Sqrt(x);
            Console.WriteLine("{0:F4}", R);
    }
    }
}
