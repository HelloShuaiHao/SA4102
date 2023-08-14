using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolH
{
    class H8
    {
        //declare a delegate
        delegate double DoubleOps(double x); 

        static double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] newArray = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = ops(arr[i]);
            }

            return newArray;
        }

        static void Main()
        {
            double[] A = new double[] { 1.0, 2.0, 3.0, 4.0 };
            DoubleOps myOp = Square_root;
            double[] B = ProcessArray(A, myOp);

            PrintArray(B);
        }

        static double Square_root(double x)
        {
            return Math.Sqrt(x);
        }
        static double add10(double x)
        {
            return x + 10.0;
        }

        public static void PrintArray(double[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine("]");
        }
    }
}
