using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie34
{
    class Program
    {
        static void Main(string[] args)
        {
            double aInGrad, bInGrad;
            aInGrad = Convert.ToDouble(Console.ReadLine());
            bInGrad = Convert.ToDouble(Console.ReadLine());
            double aInRad = aInGrad * Math.PI / 180;
            double R;
            {
                R = 3*Math.Sin(2*aInRad) * Math.Cos(3*bInGrad);
            }
            Console.WriteLine("{0:F4}", R);
    }
    }
}
