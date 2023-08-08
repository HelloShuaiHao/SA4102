using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F1
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            //string version
            int count = 0;
            string[] vowels = { "a", "e", "i", "o", "u" };
            int[] vowelCount = new int[5];
            for (int i=0;i<phrase.Length;i++)
            {
                string c = phrase.Substring(i,1).ToLower();
                if (vowels.Contains(c))
                {
                    count++;
                }
                for (int j = 0; j < 5; j++)
                {
                    if (c == vowels[j])
                    {
                        vowelCount[j]++;
                    }
                }
            }

            //char version
            //int count = 0;
            //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //int[] vowelCount = new int[5];
            //foreach (char ch in phrase)
            //{
            //    char c = Char.ToLower(ch);
            //    if (vowels.Contains(c))
            //    {
            //        count++;
            //    }
            //    for (int i = 0; i < 5; i++)
            //    {
            //        if (c == vowels[i])
            //        {
            //            vowelCount[i]++;
            //        }
            //    }
            //}

            Console.WriteLine("Total number of vowels: " + count);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number of {0}: {1}", vowels[i], vowelCount[i]);
            }
        }
    }
}
