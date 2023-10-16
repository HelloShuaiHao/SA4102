namespace MyException;

public class MainTest
{
    public static void Main()
    {
        try
        {
            Triangle t1 = new Triangle(3, 4, 5);
            

            Triangle t2 = new Triangle(3, 3, 7);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("CLean up");
        }


        Console.ReadKey();
    }
}