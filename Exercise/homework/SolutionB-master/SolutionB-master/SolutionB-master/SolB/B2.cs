using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B2
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            Console.WriteLine("{0:0.000}", Math.Round(Math.Sqrt(x),3));
        }
    }
}
