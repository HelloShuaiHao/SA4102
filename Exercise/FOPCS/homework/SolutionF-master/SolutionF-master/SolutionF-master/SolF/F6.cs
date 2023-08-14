using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolF
{
    class F6
    {
        static void Main()
        {
            //ask for input
            Console.Write("Enter a matriculation number: ");
            string input = Console.ReadLine();

            //if (not 7 characters)
            if (input.Length != 7)
            {
                //invalid
                Console.WriteLine("Invalid");
            }
            else
            {
                //else
                //convert input into uppercase
                input = input.ToUpper();

                //calculate checksum
                int sum = 0;
                //take 1st digit and multiply with 6
                int d1 = Convert.ToInt32(input.Substring(1, 1));
                sum = sum + (d1 * 6);
                //take 2nd digit and multiply with 5
                int d2 = Convert.ToInt32(input.Substring(2, 1));
                sum = sum + (d2 * 5);
                //take 3rd digit and multiply with 4
                int d3 = Convert.ToInt32(input.Substring(3, 1));
                sum = sum + (d3 * 4);
                //take 4th digit and multiply with 3
                int d4 = Convert.ToInt32(input.Substring(4, 1));
                sum = sum + (d4 * 3);
                //take 5th digit and multiply with 2
                int d5 = Convert.ToInt32(input.Substring(5, 1));
                sum = sum + (d5 * 2);
                //calculate the sum - calculated in variable sum
                //divide by 5 and get the remainder
                int remainder = sum % 5;

                //int remainder = ((d1*6) + (d2*5) + (d3*4) .. ) % 5;

                //map the remainder to the checksum
                string checksum = "";
                switch (remainder)
                {
                    case 0:
                        checksum = "O";
                        break;
                    case 1:
                        checksum = "P";
                        break;
                    case 2:
                        checksum = "Q";
                        break;
                    case 3:
                        checksum = "R";
                        break;
                    case 4:
                        checksum = "S";
                        break;
                }

                //if last char matches checksum then
                string lastChar = input.Substring(6, 1);
                if (lastChar == checksum)
                {
                    //valid
                    Console.WriteLine("Valid");
                }
                else
                {
                    //else
                    //invalid
                    Console.WriteLine("Invalid");

                }
            }
        }
    }
}
