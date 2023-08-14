using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B6
    {
        static void Main()
        {
            Console.Write("Enter x1:");
            string input = Console.ReadLine();
            double x1 = Convert.ToDouble(input);
            Console.Write("Enter y1:");
            input = Console.ReadLine();
            double y1 = Convert.ToDouble(input);
            Console.Write("Enter x2:");
            input = Console.ReadLine();
            double x2 = Convert.ToDouble(input);
            Console.Write("Enter y2:");
            input = Console.ReadLine();
            double y2 = Convert.ToDouble(input);
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(distance);        
        }
    }
}
