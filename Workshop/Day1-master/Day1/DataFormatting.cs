using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class DataFormatting
    {
        static void Main(string[] args)
        {
            // a = 6543.21
            Console.WriteLine("Please enter a number: ");
            string num = Console.ReadLine();
            double a = double.Parse(num);
            Console.WriteLine($"{a}");
            Console.WriteLine($"{a:#.#}");
            Console.WriteLine($"{a:#.###}");
            Console.WriteLine($"{a:0.0}");
            Console.WriteLine($"{a:0.000}");
            Console.WriteLine($"{a:0,0.00}");
        }
    }
}
