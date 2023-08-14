using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F5_AlternativeSlu
    {
        static void SwapSwap(int j, String[,] arr)
        {
            //swapping method
            String tempName = arr[j, 0];
            String tempMarks = arr[j, 1];
            arr[j, 0] = arr[j + 1, 0];
            arr[j, 1] = arr[j + 1, 1];
            arr[j + 1, 0] = tempName;
            arr[j + 1, 1] = tempMarks;
        }

        static void Main(String[] args)
        {

            // Store values as 2 dimensional string array
            String[,] arr = new String[5, 2] { { "John", "63" }, { "Venkat", "29" }, { "Mary", "75" }, { "Victor", "82" }, { "Betty", "55" } };


            //descending order bubble sort
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (Convert.ToInt32(arr[j, 1]).CompareTo(Convert.ToInt32(arr[j + 1, 1])) == -1) // if CompareTo returns -1, means first value is smaller than next value
                    {
                        SwapSwap(j, arr);
                    }
                }
            }

            Console.WriteLine("Sorted by order of Marks descendingly\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i, 0] + " " + arr[i, 1] + "\n");
            }

            //ascending order bubble sort
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (arr[j, 0].CompareTo(arr[j + 1, 0]) == 1) // if CompareTo return 1 means first String should be after next String in a sequence
                    {
                        SwapSwap(j, arr);
                    }

                }
            }

            Console.WriteLine("\nSorted by student name alphabetically\n");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i, 0] + " " + arr[i, 1] + "\n");
            }

        }

    }
}
