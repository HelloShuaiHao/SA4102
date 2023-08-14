using System;
namespace HClass
{
	public class H4
	{
		public static void SetArray(ref int[] nums, int value)
		{
			for (int i = 0; i < nums.Length; i++) nums[i] = value;
		}
	}
}

