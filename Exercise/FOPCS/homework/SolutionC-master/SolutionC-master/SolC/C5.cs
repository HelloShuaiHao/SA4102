using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolC
{
    class C5
    {
        static void Main()
        {
            Console.Write("Please enter a 3-digits number: ");
            int n = Int32.Parse(Console.ReadLine());

            int digit1 = n / 100; 
            int digit2 = n % 100 / 10;
            int digit3 = n % 10;
            int sum = (int) Math.Round(Math.Pow(digit1, 3) + Math.Pow(digit2, 3) + Math.Pow(digit3, 3));

            if (sum == n)
            {
                Console.WriteLine("True");
            } else
            {
                Console.WriteLine("False");
            }

        }
    }
}
