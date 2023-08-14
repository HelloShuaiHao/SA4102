using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolE
{
    class E2
    {
        static void Main()
        {
            Console.WriteLine("NO\t\tINVERSE\t\tSQUARE ROOT\tSQUARE");
            for (int i = 1; i <= 10; i++)
            {
                double d = i;
                Console.WriteLine("{0:0.0##}\t\t{1:0.0##}\t\t{2:0.0##}\t\t{3:0.0##}", 
                    d, 1 / d, Math.Sqrt(d), Math.Pow(d, 2));
            }
        }
    }
}
