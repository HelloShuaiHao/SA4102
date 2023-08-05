using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1
{
    class PlaceholderExample
    {
        static void Main(string[] args)
        {
            double a = 5.2;
            double b = 2.3;
            double c = 1.2;          
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("{{{0}}}", a);
            Console.WriteLine("a = {" + a + "}");
            Console.WriteLine(" My values are {{{0}}}", a);           
            Console.WriteLine("a = {1}, str = {2}", a,b, "Hello");
           
            



        }
    }
}
