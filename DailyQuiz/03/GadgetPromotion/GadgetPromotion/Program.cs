using System;

namespace dailyQuiz03
{
    public class Solution
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.WriteLine("Number of items to purchase: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int sum = num * 500;
            double ans = 0;
            if (sum <= 2000) ans = sum;
            else if (sum > 2000 && sum <= 3000) ans = sum * 0.97;
            else if (sum > 3000 && sum <= 6000) ans = sum * 0.95;
            else ans = sum * 0.92;

            ans = Math.Round(ans, 0);

            Console.WriteLine($"Please pay: ${ans:#,###.00}");


            // 和Math的区别是，Math是static Random是非static
            // 所以需要使用前先 new Random()

            // Generating Random Integer
            System.Random rnd = new Random();
            Console.WriteLine(rnd.Next(6)); // generate 0<=random number <6
            Console.WriteLine(rnd.Next(10, 20)); // generate 10<=random number <20

            // generate a double number
            Console.WriteLine(100 + rnd.NextDouble() * (150 - 100));
        }
    }
}