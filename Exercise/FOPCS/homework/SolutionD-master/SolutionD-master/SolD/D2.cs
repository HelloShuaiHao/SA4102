using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolD
{
    class D2
    {
        static void Main()
        {
            Console.Write("Enter A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int big = Math.Max(a, b);
            int small = Math.Min(a, b);

            while (big != small)
            {
                big = big - small;

                if (big < small)
                {
                    var temp = small;
                    small = big;
                    big = temp;
                }
            }

            int hcf = big; 
            int lcm = (a * b) / hcf;

            Console.WriteLine("HCF:" + hcf);
            Console.WriteLine("LCM:" + lcm);
        }
    }
}
