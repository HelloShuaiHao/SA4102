namespace Recursive_str_len;

using System;
using System.Text;



public static class ReverseString
{
    public static void Main()
    {
        string str = "Hello World!";

        Console.WriteLine("The length of " + str + " is " + RCount(str));
        Console.ReadKey();
    }

    public static int Count(string str, string impl)
    {
        if (impl != "recursive" && impl != "iterative")
        {
            throw new Exception("Unknown implementation type");
        }
        

        return impl == "recursive" ? RCount(str) : ICount(str);
    }

    public static int ICount(string str)
    {
        int res = 0;
        for(int i = 0; i < str.Length; i++)
        {
            res++;
        }
        return res;
    }

    /// <summary>
    /// Return the length of the str.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static int RCount(string str)
    {
        if (str.Length == 1) return 1;


        return 1 + RCount(str.Substring(1));
    }
}