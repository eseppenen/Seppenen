using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie30
{
    class Program
    {
        static void Main(string[] args)
        {
            double aInGrad, bInGrad;
            aInGrad = Convert.ToDouble(Console.ReadLine());
            bInGrad = Convert.ToDouble(Console.ReadLine());
            double aInRad= aInGrad * Math.PI / 180;
            double bInRad = bInGrad * Math.PI / 180;
            double R;
            {
                R = Math.Sin(aInRad) * Math.Cos(bInGrad) + Math.Cos(aInRad) * Math.Sin(bInGrad);
            }
                Console.WriteLine("{0:F4}", R);
            }
    }
}
