using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            double xInGrad;
            xInGrad = Convert.ToDouble(Console.ReadLine());
            double xInRad;
            xInRad = xInGrad* Math.PI/180;
            double R;
            {
                R = Math.Sin(xInRad);
                Console.WriteLine("{0:F4}", R);
            }
        }
    }
}
