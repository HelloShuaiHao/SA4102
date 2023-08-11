using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolG
{
    class G2
    {
        public static void Main()
        {
            int[] list = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[i] < list[j])
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;

                        for (int k = 0; k < list.Length; k++)
                        {
                            Console.Write(list[k] + " ");
                        }
                        Console.WriteLine();

                    }
                }
            }
        }
    }
}
