// To practice LINQ with C# Collections and Models

namespace LINQ;

public class Test
{

    public static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student("John", 13),
            new Student("Joey", 15),
            new Student("Bill", 18)
        };

        // Write a single LINQ statement to get
        // all the names of students with age between 12 and 20.

        // <>里就是最后要iterate的类型
        
        IEnumerable<string> iter = from student in students
                                  where student.Age >= 12 && student.Age <= 20
                                  select student.Name;

        // 也可以用var替代类型
        /*
        var iter = from student in students
                   where student.Age >= 12 && student.Age <= 18
                   select student.Name;*/
        Console.Write("all the names of students with age between 12 and 20: ");
        foreach(var name in iter)
        {
            Console.Write(name + ", ");
        }
        Console.WriteLine();







        // Write a single LINQ statement sort the array ascendingly. 
        int[] arr = new int[] { 20, 12, 6, 10, 0, 3, 1 };
        IEnumerable<int> iter3 = from num in arr
                                orderby num ascending
                                select num;
        Console.WriteLine("Ascending order: ");
        foreach (var item in iter3) Console.Write(item + ", ");
        Console.WriteLine();






        // Use a LINQ statement to retrieve the names of students, sorted by their ExamMark1 in descending order.
        List<Student> students2 = new List<Student>()
        {
            new Student("John", 75, 80),
            new Student("Joey", 95, 50),
            new Student("Bill", 40, 50),
            new Student("Alex", 20, 75),
            new Student("Ron", 70, 80)
        };
        IEnumerable<string> iter2 = from stu in students2
                                   orderby stu.ExamMark1 descending
                                   select stu.Name;
        Console.WriteLine("Ordered by exammark 1: ");
        foreach (var item in iter2) Console.Write(item + ", ");
        Console.WriteLine();


        // Modify the LINQ statement in b. to also include the respective average score for each student name.
        IEnumerable<string> iter4 = from stu in students2
                                    orderby stu.ExamMark1 + stu.ExamMark2 descending
                                    select stu.Name;
        Console.Write("Ordered by average score: ");
        foreach (var item in iter4) Console.Write(item + ", ");
        Console.WriteLine();


        // multiple queries

        // Write a single LINQ statement that generate pairs
        // such that the multiplication of the two elements
        // in a pair is greater than 20. The first element
        // of a pair must come from numbers1, while the
        // second from numbers2. Your results should look like this:

        int[] nums1 = new int[] { 0, 1, 2, 3, 4 };
        int[] nums2 = new int[] { 5, 6, 7, 8, 9 };
        var iter5 =
            from n1 in nums1
            from n2 in nums2
            where n1 * n2 >= 20
            select new { n1, n2 };
        Console.WriteLine("The multiplication of the two elements in a pair is greater than 20.");
        foreach(var pair in iter5)
        {
            Console.WriteLine("(" + pair.n1 + ", " + pair.n2 + ")");
        }





        // Write a C# program using LINQ Order and Group
        // to display the category for students’ average
        // marks (0x, 1x, 2x, 3x…) and the respective
        // students in each category.

        // The result for the sample above input should be:
        var iter6 = from stu in students2
                    orderby (stu.ExamMark1 + stu.ExamMark2)/20 descending
                    group stu by (stu.ExamMark1 + stu.ExamMark2) / 20
                    into gradeGroup
                    
                    select gradeGroup;

        foreach(var grp in iter6)
        {
            bool flag = false;
            // Console.WriteLine("({0}x): {1}", );
            foreach(var item in grp)
            {
                if(flag == false)
                {
                    Console.WriteLine("({0}x): {1}", (item.ExamMark1+item.ExamMark2)/20, grp.Count());
                    flag = true;
                }
                Console.WriteLine("    {0}, average {1:#.#}", item.Name, (double)(item.ExamMark1 + item.ExamMark2)/2);
            }
        }










        Console.ReadKey();
                                         
                                         
                                     

    }
}


