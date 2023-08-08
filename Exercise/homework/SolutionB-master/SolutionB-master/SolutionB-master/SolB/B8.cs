using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B8
    {
        static void Main()
        {
            Console.Write("Enter the distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());
            double fare = Math.Round(2.4 + 0.4 * distance,1);
            Console.WriteLine("{0:0.00}", fare);
        }
    }
}
