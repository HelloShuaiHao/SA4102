using System;
namespace GoUpstairs
{
	public class Solution
	{
		// 1,2,3
		public static void Main()
		{
			int stairs = 4;
			int[] dp = new int[stairs + 1];
			// dp[i] indicates how many ways to get to i th stairs
			// dp[0] = 1
			// dp[i] = dp[i-1] + dp[i-2] + dp[i-3]
			dp[0] = 1;
			for(int i=1;i <= stairs; i++)
			{
				if (i - 1 >= 0) dp[i] += dp[i - 1];
                if (i - 2 >= 0) dp[i] += dp[i - 2];
                if (i - 3 >= 0) dp[i] += dp[i - 3];
            }

			Console.WriteLine("Ways: " + dp[stairs]);

			Console.ReadKey();
			return;
        }

	}
}

