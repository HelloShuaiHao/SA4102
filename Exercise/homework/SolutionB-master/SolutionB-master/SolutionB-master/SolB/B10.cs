using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B10
    {
        static void Main()
        {
            Console.Write("Please enter a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double s = (a + b + c) / 2;
         
            if (s == 0)
            {
                Console.WriteLine(s);
            }
            else if ((a+b)>c && (b+c)>a && (a+c)>b)
            {
                Console.WriteLine(Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
            } 
            else 
            {
                Console.WriteLine("NaN");
            }
         
        }
    }
}
