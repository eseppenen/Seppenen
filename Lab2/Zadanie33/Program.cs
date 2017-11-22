using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie33
{
    class Program
    {
        static void Main(string[] args)
        {
            double h;
            h= double.Parse(Console.ReadLine());
            if (h <= 0)
            {
                Console.WriteLine("Высота над уровнем Земли должна быть неотрицательна");
                return;
            }
            double R = 6350;
            double S=(((R+h)*(R+h))- (R*R))*Math.Exp(1/2);
            Console.WriteLine("{0:F4}", S);

        }
    }
}
