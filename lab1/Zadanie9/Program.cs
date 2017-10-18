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
           String id;
           id = Console.ReadLine();
           Console.WriteLine("SELECT first_name,last_name,grop FROM students WHERE student_id ='"+id+ "'");
            


        }
    }
}
