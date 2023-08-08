using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B9
    {
        static void Main()
        {
            Console.Write("Enter the distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double fare = 2.4 + 0.4 * distance;
            fare = fare * 10;
            fare = Math.Ceiling(fare);
            fare = fare / 10;
            Console.WriteLine("{0:0.0}", fare);
        }
    }
}
