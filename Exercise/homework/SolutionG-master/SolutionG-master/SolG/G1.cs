using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolG
{
    class G1
    {
        static void Main(string[] args)
        {
            int[] sales = new int[12];
            string[] monthNames = new string[]
                {"January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"};
            for (int n = 0; n < 12; n++)
            {
                Console.Write("Enter sales for month {0} ({1}): ", n, monthNames[n]);
                sales[n] = Convert.ToInt32(Console.ReadLine());
            }
            
            int max = 0;
            int min = 0;
            int sum = sales[0];
            for (int i = 1; i < 12; i++)
            {
                if (sales[i] > sales[max])
                {
                    max = i;
                }
                if (sales[i] < sales[min])
                {
                    min = i;
                }
                sum += sales[i];
            }
            Console.WriteLine("Maximum Sales: {0} ({1})", max, monthNames[max]);
            Console.WriteLine("Minimum Sales: {0} ({1})", min, monthNames[min]);
            Console.WriteLine("Average Sales: " + sum / 12.0);
        }
    }
}
