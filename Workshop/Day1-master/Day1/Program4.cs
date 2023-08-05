using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program4
    {
        static void Main()
        
        {

            Console.Write("Enter your salary: ");
            string input = Console.ReadLine();
            double salary = Convert.ToDouble(input);

            double tax = 0.05 * salary;
            Console.WriteLine("Your salary is ${0:0,000.00}, your tax is ${1:0,0.00}"
                , salary, tax);
            Console.WriteLine("Your salary is ${0:0,000.##}, your tax is ${1:0,0.##}"
                , salary, tax);
            Console.WriteLine("Your salary is ${0:#,###.00}, your tax is ${1:#,###.00}"
                , salary, tax);
            Console.WriteLine("Your salary is ${0:c}, your tax is ${1:c}" //convert the value to a currency value
                , salary, tax);
            Console.WriteLine("{{0}} {0}, your tax is ${1:c}"
                , salary, tax);

            //Custom Numeric Format
            //"0" Specifier
            double value;
            value = 123;
            Console.WriteLine("{0:00000}", value); //Displays 00123

            value = 1.234;
            Console.WriteLine("{0:0.00}", value); //Displays 1.23

            value = 1.345;
            Console.WriteLine("{0:0.00}", value); //Displays 1.35

            value = -1.234;
            Console.WriteLine("{0:0.00}", value); //Displays -1.23

            value = -1.345;
            Console.WriteLine("{0:0.00}", value); //Displays -1.35

            //"#" Specifier
            
            value = 1.2;
            Console.WriteLine("{0:#.##}", value); //Display 1.2

            value = 1.234;
            Console.WriteLine("{0:#.##}", value); //Displays 1.23

            value = 1.345;
            Console.WriteLine("{0:#.##}", value); //Displays 1.35

            value = -1.234;
            Console.WriteLine("{0:#.##}", value); //Displays -1.23

            value = -1.345;
            Console.WriteLine("{0:#.##}", value); //Displays -1.35

            //Standard Date and Time Format, String format
            string FormatString1 = String.Format("{0:dddd MMMM}", DateTime.Now);
            string FormatString2 = DateTime.Now.ToString("dddd MMMM");
            Console.WriteLine(FormatString1);
            Console.WriteLine(FormatString2);

           

        
        }
    }
}
