using System;

namespace ExerciseCDEF;

public class Solution
{
    internal static void Main()
    {
        // ExerciseC.homeworkC();
        // ExerciseD.homeworkD();
        ExerciseE.homeworkE();
        return;
    }
}

public class ExerciseC
{
    public static void homeworkC()
    {
        string name;
        string gender;
        int age;

        Console.WriteLine("Good morning,Mr/Ms ? Can I have your gender first? Enter your name followed by M represents for Male and F represents fo Female. Like: Venkat M");
        var line = Console.ReadLine();
        var data = line.Split(' ');

        name = data[0];
        gender = data[1];

        while(gender != "M" && gender != "F")
        {
            Console.WriteLine("Please enter the capital of F or M");
            gender = Console.ReadLine();    
        }
        if (gender == "M")
        {
            Console.WriteLine($"Good Morning Mr. {name}");

        }
        else Console.WriteLine($"Good Morning Ms. {name}");



        Console.WriteLine("\nLet's start again. Can I enter your name,gender,age like this:Sam,M,45");
        line = Console.ReadLine();
        data = line.Split(',');
        name = data[0];
        gender = data[1];
        age = Convert.ToInt32(data[2]);

        if (age >= 40)
        {
            if(gender == "M")
            {
                Console.WriteLine($"Good Morning Uncle {name}");
            }
            else
            {
                Console.WriteLine($"Good Morning Aunty {name}");
            }
        }
        else
        {
            if (gender == "M")
            {
                Console.WriteLine($"Good Morning Mr. {name}");
            }
            else
            {
                Console.WriteLine($"Good Morning Ms. {name}");
            }
        }



        Console.WriteLine("Fine, let's calculate your grade, please input your grade");
        int grade = Convert.ToInt32(Console.ReadLine());
        string level;
        if (grade < 0) level = "**Error**";
        else if (grade >= 0 && grade < 40) level = "F";
        else if (grade >= 40 && grade < 60) level = "C";
        else if (grade >= 60 && grade < 80) level = "B";
        else if (grade >= 80 && grade <= 100) level = "A";
        else level = "**Error**";
        Console.WriteLine($"Great job, your grade is {level}");


        Console.WriteLine("\nNow, you've called a taxi, please input your distance then we will calculate the fee for you");
        double dis = Convert.ToDouble(Console.ReadLine());
        dis = Math.Ceiling(dis * 10) / 10;
        Console.WriteLine($"Your distance is {dis}");
        double fees = 0;
        if(dis <= 0.5)
        {
            fees = 2.4;
        }else if(dis <= 9)
        {
            fees = 2.4 + (dis - 0.5) * 10 * 0.04;
        }
        else
        {
            fees = 2.4 + 8.5 * 10 * 0.04 + (dis - 9) * 10 * 0.05;
        }
        fees = Math.Ceiling(fees * 10)/10;
        Console.WriteLine($"Your fee is ${fees:#,###.0}");


        Console.WriteLine("\nPlease enter a number and we will check if it's a Armstrong number");
        int[] digits = new int[3];
        int checkNum = Convert.ToInt32(Console.ReadLine());
        int temp = checkNum;
        digits[2] = checkNum % 10;
        digits[1] = checkNum / 10 % 10;
        digits[0] = checkNum / 100 % 10;
        Console.WriteLine($"first digit: {digits[0]}, second digit:{digits[1]}, third digit:{digits[2]}");

        if (temp == Math.Pow(digits[0], 3) + Math.Pow(digits[1], 3) + Math.Pow(digits[2], 3))
        {
            Console.WriteLine($"{temp} is an Armstrong number");
        }
        else Console.WriteLine($"{temp} is not an Armstrong number");
    }
}


public class ExerciseD
{
    public static void homeworkD()
    {
        Console.WriteLine("Guess what, now we are gonna to play a guessing game, enter a number and we will check it");
        int guessNum = Convert.ToInt32(Console.ReadLine());
        while(guessNum != 88)
        {
            Console.WriteLine("Sorry, you need to enter again");
            guessNum = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Lucky you...");

        Console.WriteLine("\nNow we are gonna to use Ecuclid's Algorithm to calculate LCM and HCF ");
        Console.WriteLine("Please input two numbers seperated by a space like:8 4");
        var line = Console.ReadLine();
        var data = line.Split(' ');
        int minNum = Convert.ToInt32(data[0]);
        int maxNum = Convert.ToInt32(data[1]);
        if (minNum > maxNum)
        {
            int t = minNum;
            minNum = maxNum;
            maxNum = t;
        }

        int HCF,LCM;
        int tmin = minNum, tmax = maxNum;
        while (tmax > tmin)
        {
            tmax = tmax - tmin;
            if (tmax < tmin)
            {
                int t = tmax;
                tmax = tmin;
                tmin = t;
            }
        }
        HCF = tmin;
        Console.WriteLine($"The highest common factor of {minNum} and {maxNum} is {HCF}");
        Console.WriteLine($"The lowest common multiply of {minNum} and {maxNum} is {minNum*maxNum/HCF}");


        Console.WriteLine("\n");

        Console.WriteLine("Alright, we are gonna to guess the number again, the number is between 0 and 9");
        Random rnd = new Random();
        int guessNumber = rnd.Next(0, 9);
        Console.WriteLine(guessNum);
        int youGuess = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        while(youGuess != guessNum)
        {
            Console.WriteLine("I am sorry, please try again");
            youGuess = Convert.ToInt32(Console.ReadLine());
            count++;
            if (count == 3) break;
        }
        if(count == 1)
        {
            Console.WriteLine("You are a Wizard!");
        }else if(count == 2)
        {
            Console.WriteLine("You are a good guess");
        }else if (count >= 3)
        {
            Console.WriteLine("You are lousy");
        }
    }
}

public class ExerciseE
{
    
    public static void homeworkE()
    {
        Console.WriteLine("In this program, we will calculate the factorial of a number");
        int facNum = Convert.ToInt32(Console.ReadLine());
        if(facNum < 0)
        {
            Console.WriteLine("Program terminated, please enter a valid number");
            return;
        }
        int factorial = 1;
        // Using increment counter
        // i从1开始默认了0!=1
        for(int i = 1; i <= facNum; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine($"The increment method: {factorial}");

        factorial = 1;
        // Using decrement counter
        for(int i = facNum; i >= 1; i--)
        {
            factorial = factorial * i;
        }
        Console.WriteLine($"The decrement method: {factorial}");





        Console.WriteLine("\nOh guys, great job, next I am gonna to print 1 and 10 with the value of some calculation");
        Console.WriteLine("  NO      INVERSE      SQUARE ROOT    SQUARE ");
        Console.WriteLine("_____________________________________________");
        for(double i = 1; i <= 10; i++)
        {
            Console.WriteLine($"  {i:#.0}      {(1/i):0.0##}           {(Math.Sqrt(i)):#.0##}             {(Math.Pow(i,2)):#.0}     ");
        }



        Console.WriteLine("\n");
        Console.WriteLine("Next we are gonna to check if a number is prime");
        int ifIsPrime = Convert.ToInt32(Console.ReadLine());
        if (ifIsPrime < 2)
        {
            Console.WriteLine("A prime number can't be less then 2, please enter another valid number");
            return;
        }
        bool isPrime = true;
        for(int i = 2; i * i <= ifIsPrime; i++)
        {
            if(ifIsPrime % i ==0 && ifIsPrime != i)
            {
                isPrime = false;
            }
        }
        if (isPrime) Console.WriteLine("Prime\n");
        else Console.WriteLine("Not Prime\n");


        Console.WriteLine("Guys Great Job, we are gonna to check if a number is perfect, please enter a number");
        int ifIsPerfect = Convert.ToInt32(Console.ReadLine());
        int checkSum = 1;
        for(int i = 2; i * i <= ifIsPerfect; i++)
        {
            if(ifIsPerfect%i == 0)
            {
                checkSum = checkSum + i + ifIsPerfect / i;
            }
        }
        if (checkSum == ifIsPerfect) Console.WriteLine($"{ifIsPerfect} is a perfect number\n");
        else Console.WriteLine($"{ifIsPerfect} is not a perfect number\n");

        Console.WriteLine("\nNext we are gonna to print all the perfect numbers from 1 to 1000");

        for(int i = 1; i <= 1000; i++)
        {
            if (checkIfIsPerfectNumber(i)) Console.WriteLine(i);
        }
        return;
    }

    public static bool checkIfIsPerfectNumber(int num)
    {
        int checkSum = 1;
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                checkSum = checkSum + i + num / i;
            }
        }
        if (checkSum == num) return true;
        else return false;
    }
}