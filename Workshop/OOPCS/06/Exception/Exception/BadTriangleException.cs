using System;
namespace MyException
{
	/// <summary>
	/// 
	/// </summary>
	public class BadTriangleException
	{
		public BadTriangleException()
		{
			
		}
		public static void Report()
		{
			throw new System.Exception("Invalid triangle");
		}
	}
}

