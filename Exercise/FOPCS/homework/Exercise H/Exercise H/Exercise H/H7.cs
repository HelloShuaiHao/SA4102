using System;
namespace HClass
{
	public class H7
	{
		public static int[,] MatricMultiply(int[,] A, int[,] B)
		{
			if (A.GetLength(1) != B.GetLength(0)) return null;

			int m = A.GetLength(0);
			int n0 = A.GetLength(1);
			int m1 = B.GetLength(0);
			int n =B.GetLength(1);
			

			int[,] ans = new int[m, n];

			for(int i = 0; i < m; i++)
			{
				for(int j = 0; j < n; j++)
				{
					int t = 0;
					for(int k = 0; k < n0; k++)
					{
						t += A[i, k] * B[k, j];
					}
					ans[i, j] = t;
				}
			}

			return ans;
		}
	}
}

