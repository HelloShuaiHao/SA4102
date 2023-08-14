using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolD
{
    class D3
    {
        static void Main()
        {
            Random r = new Random();
            int secret = r.Next(0, 10); //generate a random number between 0 and 9
            int guess = 0;
            int attempt = 0;
            do
            {
                Console.Write("Guess a number (0-9): ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempt++;
            } while (secret != guess);

            if (attempt <= 2)
            {
                Console.WriteLine("You are a Wizard!");
            }
            else if (attempt <= 5)
            {
                Console.WriteLine("You are a good guess");
            }
            else
            {
                Console.WriteLine("You are lousy");
            }
        }
    }
}
