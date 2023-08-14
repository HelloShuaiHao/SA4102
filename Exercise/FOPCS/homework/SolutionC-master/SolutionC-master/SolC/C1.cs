using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolC
{
    class C1
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();
            switch (gender.ToUpper())
            {
                case "M":
                    Console.Write("Good Morning Mr. " + name);
                    break;
                case "F":
                    Console.Write("Good Morning Ms. " + name);
                    break;
                default:
                    Console.WriteLine("Wrong gender");
                    break;
            }
        }
    }
}
