using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            double yInGrad;
            yInGrad = Convert.ToDouble(Console.ReadLine());
            double yInRad;
            yInRad = yInGrad * Math.PI/180;
            double R;
                R = 5 * Math.Cos(yInRad);
                Console.WriteLine("{0:F4}", R);
    }
    }
}
