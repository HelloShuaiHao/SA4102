using System;
namespace HClass
{
	public class H6
	{
		public static bool isPrimte(int n)
		{
			if (n < 2) return false;

			for(int i = 2; i * i <= n; i++)
			{
				if (n % i == 0) return false;
			}

			return true;
		}
	}
}

