using System;
namespace Exercise_G
{
	public class G2
	{
        public static int[] nums = new int[] { 2, 5, 3, 8, 6, 3, 7, 9 };

        public static void G2_work()
		{
			int n = nums.Length;
			// selection sort, print out the progress after every round
            for(int i = 0; i < n-1; i++)
            {
                int maxIndex = i;
                for(int j = i + 1; j < n; j++)
                {
                    if (nums[j] > nums[maxIndex]) maxIndex = j;
                }
                swap(ref nums,i, maxIndex);
                printNums(nums);
            }
		}

        public static void printNums(int[] nums)
        {
            string line = "";
            for (int i = 0; i < nums.Length; i++)
            {
                line += nums[i];
                if (i != nums.Length - 1) line += " ";
            }
            Console.WriteLine(line);
        }

        public static void swap(ref int[] nums, int i, int j)
        {
            int t = nums[i];
            nums[i] = nums[j];
            nums[j] = t;
        }
    }

	
}

