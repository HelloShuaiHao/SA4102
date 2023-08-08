using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F2
    {
        static void Main()
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string reversephrase = "";
            
            //Generate reverse phase
            int len = phrase.Length - 1;
            while (len >= 0)
            {
                reversephrase = reversephrase + phrase[len];
                len--;
            }
            if (phrase == reversephrase)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
