using System;

namespace HClass
{
	public class H1
	{
		public static int ReadInteger()
		{
			// Console.Write("Please enter a string");
			string message = "";

			int ans = 0;
			while(!int.TryParse(message, out ans))
			{
				Console.Write("Please enter a valid number");
				message = Console.ReadLine();
			}
			Console.WriteLine($"The number is {ans}");
			return ans;
		}
	}
}

