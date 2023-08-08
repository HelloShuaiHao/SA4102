using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolC
{
    class C2
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender (M/F): ");
            string gender = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            switch (gender)
            {
                case "M":
                    if (age >= 40)
                    {
                        Console.WriteLine("Good Morning Uncle " + name);
                    }
                    else
                    {
                        Console.WriteLine("Good Morning Mr. " + name);
                    }
                    break;
                case "F":
                    if (age >= 40)
                    {
                        Console.WriteLine("Good Morning Aunty " + name);
                    }
                    else
                    {
                        Console.WriteLine("Good Morning Ms. " + name);
                    }
                    break;
                default:
                    Console.WriteLine("Wrong gender");
                    break;
            }
        }
    }
}
