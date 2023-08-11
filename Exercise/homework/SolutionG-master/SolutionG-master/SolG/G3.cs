using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolG
{
    class G3
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[,]
            {
                {56,84,68,29},
                {94,73,31,96},
                {41,63,36,90},
                {99,9,18,17},
                {62,3,65,75},
                {40,96,53,23},
                {81,15,27,30},
                {21,70,100,22},
                {88,50,13,12},
                {48,54,52,78},
                {64,71,67,25},
                {16,93,46,72}
            };

            int[] total = new int[12];
            int[] sumPerSubject = new int[4];

            for (int row = 0; row < 12; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    total[row] += marks[row, col];
                    sumPerSubject[col] += marks[row, col];
                }
            }

            for (int row = 0; row < 12; row++)
            {
                Console.WriteLine("Total marks for student {0}: {1}", row, total[row]);
            }

            double totalAvg = 0;

            for (int col = 0; col < 4; col++)
            {
                Console.WriteLine("Avg marks for subject {0}: {1}", col, sumPerSubject[col] / 12.0);
                totalAvg += sumPerSubject[col] / 12.0;
            }

            Console.WriteLine("Overall average: " + totalAvg / 4.0); //Overall average for all subjects
        }
    }
}
