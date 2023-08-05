using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello ShuaiHao");
            StringBuilder sb = new StringBuilder();
            OperatorExamples();
        }

        private static void OperatorExamples()
        {
            int height = 10;
            int weight = 10;
            Console.WriteLine(height * weight);

            Class2.SayHi();

            double b = 6543.213;
            Console.WriteLine($"{b:0,0.000}");
            Console.WriteLine($"{b:0.0}");
            Console.WriteLine($"{b:#,#.000}");
            Console.WriteLine($"{b:###.#}");
            Console.WriteLine($"{b:###.##}");
            Console.WriteLine($"{b:#.###}");
            Console.WriteLine($"{b:00000}");

            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine(name + " " + b);

            Console.WriteLine("Please a number, we will convert it to number ");
            int number = int.Parse( Console.ReadLine() );
            Console.WriteLine($"{number}+1 = {number+1}");

        }
    }
}
