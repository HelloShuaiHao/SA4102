using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B4
    {
        static void Main()
        {
            Console.Write("Please enter the temperature in Centigrade: ");
            string input = Console.ReadLine();
            double c = Convert.ToDouble(input);
            double f = 1.8 * c + 32;
            Console.WriteLine(f);
        }
    }
}
