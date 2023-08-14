using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F3
    {
        static void Main()
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            phrase = phrase.ToLower();
            string newphrase = "";
            string reversephrase = "";
            string listOfPunctuations = ".;!?, ";
            //Remove all the punctuations
            for (int i =0; i<phrase.Length;i++)
            {
                char ch = phrase[i];
                if (listOfPunctuations.Contains(ch) == false)
                    newphrase = newphrase + ch;
            }
            //Generate reverse phrase
            int len = newphrase.Length - 1;
            while (len >= 0)
            {
                reversephrase = reversephrase + newphrase[len];
                len--;
            }
           
            if (newphrase == reversephrase)
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
