using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolE
{
    class E5
    {
        static void Main()
        {
            for (int n = 5; n < 10000; n++)
            {
                bool isPrime = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
