using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolE
{
    class E6
    {
        static void Main()
        {
            for (int n = 1; n < 1000; n++)
            {
                int sum = 0;

                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == n)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
