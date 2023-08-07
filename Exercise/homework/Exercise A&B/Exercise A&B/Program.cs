using System;
namespace Exercise_A_B
{

    public class ExerciseAB
    {
        public static void Main()
        {
            // new ExerciseA().homeworkA();
            // ExerciseA.homeworkA();

            ExerciseB.homeworkB();
            return;
        }
    }

    public class ExerciseA
    {
        // 如果没有static，则需要在Main方法里用 new ExerciseA.homeworkA()
        public static void homeworkA()
        {
            Console.WriteLine("SHUAI HAO \ne1221805@u.nus.edu");

            Console.WriteLine("Hello, what's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"OK,Good Morning {name}");

            Console.WriteLine("Please input a number");
            string s = Console.ReadLine();
            int num;
            while(!int.TryParse(s,out num)){
                Console.WriteLine("Please enter a valid number");
                s = Console.ReadLine();
            }
            Console.WriteLine($"The sqaure of {num} = {Math.Pow(num, 2)}");

            Console.WriteLine("Alright, next we are gonna to enter 4 double precision number as input and prints the number with 2 decimal points in the output");
            for(int i=0;i<4; i++)
            {
                Console.WriteLine($"Please input the {i+1} number");
                s = Console.ReadLine();
                double dNum;
                while(!double.TryParse(s, out dNum))
                {
                    Console.WriteLine("Please enter a valid number");
                    s = Console.ReadLine();
                }
                Console.WriteLine($"input: {dNum}, the 2 decimal points output: {dNum:#.00}");
            }
        }
    }

    public class ExerciseB
    {
        public static void homeworkB()
        {
            Console.WriteLine("\n\nGreat job! Here comes the exercise B");

            Console.WriteLine("Please input a double precision number and we will output the square root of it");

            string s = Console.ReadLine();
            double dNum;
            while (!double.TryParse(s, out dNum))
            {
                Console.WriteLine("Please input a valid number");
                s = Console.ReadLine();
            }
            Console.WriteLine($"The sqrt of it is {Math.Sqrt(dNum):#.000}");

            Console.WriteLine("\nCool, we are goona to calculate your salary");
            Console.WriteLine("Please enter your basic salary, we will add your allowance to it");
            s = Console.ReadLine();
            while(!double.TryParse(s,out dNum))
            {
                Console.WriteLine("Please input a valid number");
                s = Console.ReadLine();
            }

            Console.WriteLine("**input****output**");
            Console.WriteLine($"  {dNum:0.00}      {dNum*1.13:0.00}               ");
            Console.WriteLine("*******************");

            Console.WriteLine("\nNext we are gonna to convert temperature in Centigrade to Fahrenheit");
            s = Console.ReadLine();
            while(!double.TryParse(s, out dNum))
            {
                Console.WriteLine("please enter a valid number");
                s = Console.ReadLine();
            }
            Console.WriteLine($"input:{dNum:0.} output:{(dNum * 1.8 + 32):0.}");

            Console.WriteLine("\nprogram that would take as input the value of x and calculate & output the value of y using the formula: y = 5*x^2 – 4*x + 3");
            s = Console.ReadLine();
            while (!double.TryParse(s, out dNum))
            {
                Console.WriteLine("please enter a valid number");
                s = Console.ReadLine();
            }
            Console.WriteLine($"input:{dNum:0.} output:{(5*dNum*dNum - 4*dNum + 3):0.}");


            Console.WriteLine("\nNext please input x1 y1 x2 y2 , please enter it at once in sequence, seperated by space");
            double[] x = new double[2] , y = new double[2];
            var line = Console.ReadLine();
            var data = line.Split(' ');
            x[0] = double.Parse(data[0]);
            y[0] = double.Parse(data[1]);
            x[1] = double.Parse(data[2]);
            y[1] = double.Parse(data[3]);
            Console.WriteLine("Distance: {0}", Math.Sqrt(Math.Pow((x[0] - x[1]), 2) + Math.Pow((y[0] - y[1]),2)));


            Console.WriteLine("\n\nWell done, next check the fare of taxi");
            Console.WriteLine("Please input the distance");
            s = Console.ReadLine();
            while (!double.TryParse(s, out dNum))
            {
                Console.WriteLine("please enter a valid number");
                s = Console.ReadLine();
            }
            double roundedNearest = Math.Round(2.40 + dNum * 0.4, 1);
            double roundedCeiling = Math.Ceiling((2.40 + dNum * 0.4)*10)/10;
            Console.WriteLine($"the original:{(2.40 + dNum * 0.4):#.###}, the rounded{roundedNearest:#.00}, the ceiling: {roundedCeiling:#.0}");

            Console.WriteLine("\n");
            /*
             * (a+b+c)/2 * (b+c-a)/2 * (a+b-c)/2 * (a+c-b)/2
             * which means any of the sum of two sides needs to be greater than the third one
             * or we wll get a negative number
             */

            Console.WriteLine("Please input a b c in a line by sequence seperated by a space");
            line = Console.ReadLine();
            data = line.Split(' ');
            double[] side = new double[3];
            for(int i = 0; i < 3; i++)
            {
                side[i] = double.Parse(data[i]);
            }

            if ((side[0] + side[1] < side[2]) || (side[0] + side[2] < side[1]) || (side[2] + side[1] < side[0]))
            {
                Console.WriteLine("Your input is invalid, the sum of any 2 sides have to be greated than the third one");
            }
            else
            {

                double stemp = (side[0] + side[1] + side[2]) / 2;
                Console.WriteLine("The area is:{0}", Math.Sqrt(stemp * (stemp - side[0]) * (stemp - side[1]) * (stemp - side[2])));
            }
            
            /// <summary>
            /// 
            /// </summary>
        }
    }



}