using System;
namespace SumOfTwoIntegers
{
	public class Solution
	{
	
		public static int[] SumOfTwo(int[] nums, int target)
		{
			QuickSort(nums, 0, nums.Length - 1);
			// assume that nums is already sorted.
			int l = 0, r = nums.Length - 1;
			while (l < r)
			{
				int sum = nums[l] + nums[r];

				if (sum < target) l++;
				else if (sum > target) r--;
				else return new int[] { nums[l], nums[r] };
			}

			return new int[] { };
		}

		// quick sort
		public static void QuickSort(int[] nums, int l, int r)
		{
			if (l >= r) return;

			int partition = Partition(nums, l, r);
			QuickSort(nums, l, partition - 1);
			QuickSort(nums, partition + 1, r);
		}

		public static int Partition(int[] nums, int l, int r)
		{
			int pivot = l - 1;
			for(int i=l;i<=r;i++)
			{
				if (nums[i] < nums[r])
				{
					Swap(nums, ++pivot, i);
				}
			}
			Swap(nums,++pivot, r);
			return pivot;
		}

		public static void Swap(int[] nums, int i, int j)
		{
			int t = nums[i];
			nums[i] = nums[j];
			nums[j] = t;
		}


	}
}

