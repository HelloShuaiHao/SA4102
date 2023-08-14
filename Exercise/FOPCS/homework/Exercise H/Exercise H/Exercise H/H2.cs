using System;
namespace HClass
{
	public class H2
	{
		public static void PrintArray(int[] arr)
		{
			string line = "";
			for(int i = 0; i < arr.Length; i++)
			{
				line += i;
				if (i != arr.Length - 1) line += "**";
			}
			Console.WriteLine(line);
		}
	}
}

