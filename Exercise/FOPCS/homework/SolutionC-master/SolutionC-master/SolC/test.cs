using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolC
{
    class test
    {
        static void Main()
        {
            Console.Write("Please input your distance Kilometer :  ");
            double distance = Convert.ToDouble(Console.ReadLine());

            if (distance >= 0.5)
            {
                if (distance >= 9)
                {
                    double sum = 5.8 + ((Math.Round(distance * 10) - 90) * 0.05);
                    Console.WriteLine($"{sum:0.#}");
                }

                else
                {
                    double sum = ((Math.Round(distance * 10) - 5) * 0.04) + 2.4;
                    Console.WriteLine($"{sum:0.#}");
                }
            }
            else
            {
                Console.WriteLine("2.4");
            }

        }
    }
}
