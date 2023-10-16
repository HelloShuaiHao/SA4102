namespace ListAndLinkedList;

public class Solution
{
    public static void Main()
    {
        MyList myList = new MyList();

        Console.WriteLine("Add: 1");
        myList.Add("1");
        Console.WriteLine("Add: 2");
        myList.Add("2");
        Console.WriteLine("Add: 3");
        myList.Add("3");
        Console.WriteLine(myList.ToString());
        Console.WriteLine("If contains 3: " + myList.Contains("3"));

        
        Console.WriteLine("Remove the element at 0");
        myList.RemoveAt(0);
        Console.WriteLine(myList.ToString());

        
        Console.WriteLine("Remove the element at 1");
        myList.RemoveAt(1);
        Console.WriteLine(myList.ToString());
        Console.WriteLine("Remove the element at 0");
        myList.RemoveAt(0);
        Console.WriteLine(myList.ToString());

        
        Console.WriteLine("Add: 5");
        myList.Add("5");

        if(myList.GetAt(0) != null) Console.WriteLine("Get at index 0: " + myList.GetAt(0).Val);

        Console.WriteLine("Insert 4 at index of 1");
        myList.Insert(1, "4");
        Console.WriteLine(myList.ToString());

        
        Console.WriteLine("Replace the element of index of 1 by 8");
        myList.Replace(1, "8");
        Console.WriteLine(myList.ToString());

        Console.WriteLine("Add: 1");
        myList.Add("1");
        Console.WriteLine("Add: 2");
        myList.Add("2");
        Console.WriteLine("Add: 3");
        myList.Add("3");
        Console.WriteLine(myList.ToString());

        Console.ReadKey();
    }
}
