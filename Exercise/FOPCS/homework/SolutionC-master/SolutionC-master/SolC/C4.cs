using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolC
{
    class C4
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            double cost = 2.4;
            distance -= 0.5; //distance = distance - 0.5; first 0.5km no additional charges apply

            if (distance > 0)
            {
                if (distance <= 8.5)
                {
                    cost += Math.Ceiling(distance * 10) * 0.04;
                    //cost = cost + Math.Ceiling(distance * 10) * 0.04
                }
                else if (distance > 8.5)
                {
                    distance -= 8.5; 
                    cost += 3.4; // next 8.5 km is 8.5*0.4=3.4
                    cost += Math.Ceiling(distance * 10) * 0.05;
                }
            }
            Console.WriteLine(cost);

        }
    }
}
