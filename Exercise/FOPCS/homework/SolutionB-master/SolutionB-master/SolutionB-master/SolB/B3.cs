using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B3
    {
        static void Main()
        {
            Console.Write("Enter your salary:");
            string input = Console.ReadLine();
            double salary = Convert.ToDouble(input);
            Console.WriteLine("${0:0,0.00}", salary * 1.13);
        }
    }
}
