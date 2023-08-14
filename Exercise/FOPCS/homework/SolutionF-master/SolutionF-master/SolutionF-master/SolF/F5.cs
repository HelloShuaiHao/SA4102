using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F5
    {
        static void Main()
        {
            //The data
            string[] names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };

            //Part A
            int[] marksDesc = new int[] { 0, 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (marks[marksDesc[i]] < marks[marksDesc[j]])
                    {
                        //swap the order 
                        var temp = marksDesc[i];
                        marksDesc[i] = marksDesc[j];
                        marksDesc[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t{1}", names[marksDesc[i]], marks[marksDesc[i]]);
            }

            Console.WriteLine();

            //Part B
            int[] namesAsc = new int[] { 0, 1, 2, 3, 4 };
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (String.Compare(names[namesAsc[i]], names[namesAsc[j]], StringComparison.Ordinal) > 0)
                        //String.Compare:compare two sepcific string, 
                        //StringComparison.Ordinal:Compares substrings of two specified String objects 
                        //by evaluating the numeric values of the corresponding Char objects in each substring.
                    {
                        //swap the order 
                        var temp = namesAsc[i];
                        namesAsc[i] = namesAsc[j];
                        namesAsc[j] = temp;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t{1}", names[namesAsc[i]], marks[namesAsc[i]]);
            }
        }
    }
}
