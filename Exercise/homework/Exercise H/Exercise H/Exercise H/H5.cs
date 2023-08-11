using System;
namespace HClass
{
	public class H5
	{
		public static int[] ResizeArray(int[] arr, int newSize)
		{
			int[] ans = new int[newSize];
			if(newSize < arr.Length)
			{
				Console.WriteLine("The new size is smaller than the original one");
				return ans;
			}

			for (int i = 0; i < arr.Length; i++) ans[i] = arr[i];

			return ans;
		}
	}
}

