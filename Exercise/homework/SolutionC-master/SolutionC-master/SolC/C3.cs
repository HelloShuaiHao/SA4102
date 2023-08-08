using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolC
{
    class C3
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 80 && grade <= 100)
            {
                Console.WriteLine("You scored {0} marks which is A grade.", grade);
            }
            else if (grade >= 60 && grade < 80)
            {
                Console.WriteLine("You scored {0} marks which is B grade.", grade);
            }
            else if (grade >= 40 && grade < 60)
            {
                Console.WriteLine("You scored {0} marks which is C grade.", grade);
            }
            else if (grade >= 0 && grade < 40)
            {
                Console.WriteLine("You scored {0} marks which is F grade.", grade);
            }
            else
            {
                Console.WriteLine("**Error**");
            }
        }
    }
}
