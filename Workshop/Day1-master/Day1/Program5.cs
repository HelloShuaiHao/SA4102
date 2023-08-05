using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    /*
    Bubble sort Algorithm: 
    Step 1. Begin with the first element.
    Step 2. Look at the element just to the right of it
    Step 3. If the element to the right should come before the element on the left, swap them so that they are in order
    Step 4. Compare the next element in line, and repeat step 3. Do this until you run out of the array.
    Step 5. Then repeat the process for n-1 passes when n is the number of elements in the array
     */
    class Program5
    {
        static void Main()
        {
            int[] array = {8,5,7,3,1};
            BubbleSort(array); 
        }
        static void BubbleSort(int[] array)  
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j]> array[j+1]) 
                    {
                        var temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
                Console.WriteLine("The {0}th pass", i+1);
                foreach (var item in array) //print result for each pass
                {
                    Console.WriteLine(item.ToString());
                }

            }
            Console.WriteLine("Sorting result");
            foreach (var item in array) //print final result to console
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
