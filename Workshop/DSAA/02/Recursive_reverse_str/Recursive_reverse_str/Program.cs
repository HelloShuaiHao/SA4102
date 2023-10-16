namespace Recursive_reverse_str;
using System.Text;

public static class ReverseString
{
    public static void Main()
    {
        string str = "Hello World!";
        Console.WriteLine(Reverse(str,"iterative"));

        Console.ReadKey();
    }

    public static string Reverse(string str, string impl)
    {
        if(impl != "recursive" && impl != "iterative")
        {
            throw new Exception("Unknown implementation type");
        }
        if (str.Length == 0) return "";

        return impl == "recursive" ? RReverse(str) : IReverse(str);
    }

    public static string IReverse(string str)
    {
        StringBuilder sb = new StringBuilder();
        for(int i = str.Length-1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        return sb.ToString();
    }

    /// <summary>
    /// Return the reversed str.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string RReverse(string str)
    {
        if (str.Length == 1)
        {
            return str[0].ToString();
        }

        char c = str[0];

        return RReverse(str.Substring(1)) + c;
    }
}