using System;
namespace Exercise_G
{
	public class G1
	{

		public static int[] salesRecord = new int[12] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

		public static void G1_work()
		{
			int maxSalesMonth = 0;
			for (int i = 0; i < salesRecord.Length; i++) maxSalesMonth = salesRecord[maxSalesMonth] < salesRecord[i] ? i : maxSalesMonth;
			Console.WriteLine($"The max sales month is {maxSalesMonth}");

			int totalSales = 0;
			for (int i = 0; i < salesRecord.Length; i++) totalSales += salesRecord[i];
			Console.WriteLine($"The average sales is {(totalSales / 12):0}");

		}
	}
}

