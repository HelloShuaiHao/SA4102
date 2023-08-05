using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentimeterToInch
{
    internal class Program
    {

        // Declarations: the main function will invoke the CentimeterToinch.CentimeterToInch.ConvertCalculate
        static void Main(string[] args)
        {

            // Exception handling
            Console.Write("Please enter the length in cm: ");
            string str = Console.ReadLine();
            double centiMeter=0.0;
            while(!double.TryParse(str, out centiMeter))
            {
                Console.Write("Please enter the length in cm: ");
                str = Console.ReadLine();
            };
            
            double inchNum = CentimeterToInch.ConvertCalculate(centiMeter);
            Console.WriteLine($"{inchNum:#.000}");
        }
    }
}
