using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolD
{
    class D1
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                Console.Write("Enter a number (1-100): ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num != 88);
            //
            while (num != 88)
            {
                Console.Write("Enter a number (1-100): ");
                num = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Lucky you");
        }
    }
}
