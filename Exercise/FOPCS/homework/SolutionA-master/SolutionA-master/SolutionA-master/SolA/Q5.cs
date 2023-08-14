using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolA
{
    class Q5
    {
        static void Main()
        {
            Console.Write("Please enter an double: ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            Console.WriteLine($"{x:0.00}", x);
        }
    }
}
