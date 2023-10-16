namespace SumOfTwoIntegers;

public class Test
{
    public static void Main()
    {
        int[] arrs = new int[] { 9, 7, 4, 2, 11, 17, 14, 13 };
        int[] ans = SumOfTwoIntegers.Solution.SumOfTwo(arrs, 20);

        Console.Write("The sum of 20: ");
        Console.Write(ans[0] + " " + ans[1]);

        Console.ReadKey();
    }
}