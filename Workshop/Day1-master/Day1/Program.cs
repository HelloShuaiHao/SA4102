using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Console.WriteLine("***********");
            Console.WriteLine("*         *");
            Console.WriteLine("***********");
            Console.Write("Please enter a number: ");
            Console.WriteLine("Welcome to ISS");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number}+1 = {number + 1}");

        }
    }

}
