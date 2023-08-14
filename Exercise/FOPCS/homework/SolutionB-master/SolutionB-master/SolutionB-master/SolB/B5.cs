using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B5
    {
        static void Main()
        {
            Console.Write("Enter x:");
            string input = Console.ReadLine();
            double x = Convert.ToDouble(input);
            Console.WriteLine((5 * x * x) - (4 * x) + 3);
        }
    }
}
