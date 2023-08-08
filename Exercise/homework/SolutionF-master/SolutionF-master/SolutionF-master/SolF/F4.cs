using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F4
    {
        static void Main()
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string[] words = phrase.Split(' ');//institute of systems science

            //now we uppercase all the first letter
            for (int i = 0; i < words.Length; i++)
            {
                int len = words[i].Length;

                if (len == 1)
                {
                    words[i] = words[i].Substring(0, 1).ToUpper();
                } else if (len > 1)
                {
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1, len-1);
                }
                //else word[i].length is < 1 in which case we don't need to do anything.
            }

            //now we reconstruct the phrase
            string newphrase = "";
            for (int i = 0; i < words.Length; i++)
            {
                newphrase = newphrase + words[i];
                if (i != words.Length) //if this is not the last word, we add space to newphrase
                {
                    newphrase = newphrase + " ";
                }
            }

            Console.WriteLine(newphrase);
        }
    }
}
