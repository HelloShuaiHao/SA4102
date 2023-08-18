using System;
namespace ARandomList
{
	public class RandomList
	{
		private int arrayNum;
		private int low, high;
		private int[] arr;
		private int seedValue;
		Random rnd;

		public RandomList()
		{
		}

        /// <summary>
        /// The Seed attribute should be implemented as a
		/// C# Property, and can be read and updated from outside the class.
        /// </summary>
        public int SeedValue
		{
			get { return seedValue; }
			set
			{
				if (value > 10) seedValue = 10;
				else if (value < -10) seedValue = 10;
				else seedValue = value;
			}
		}

		/// <summary>
		/// 生成n个-10 ～ 10随机数种子的随机数，范围在[low,high) 填满arr
		/// </summary>
		/// <param name="n"> 数组长度</param>
		/// <param name="low">最小值</param>
		/// <param name="high">最大值</param>
		public void Generate(int n, int low, int high)
		{
			this.arrayNum = n;
			this.low = low;
			this.high = high;

			if (low > high)
			{
				int t = low;
				low = high;
				high = t;
			}

			arr = new int[this.arrayNum];
			/*rnd = new Random();
			seedValue = rnd.Next(-10, 10);*/
			rnd = new Random(this.seedValue);
			
			
			for(int i = 0; i < arrayNum; i++)
			{
				arr[i] = rnd.Next(low, high);
			}
		}

		public void Show()
		{
			for(int i = 0; i < arrayNum; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}

		public float Mean()
		{
			float avg = 0;
			for (int i = 0; i < arrayNum; i++) avg += arr[i];
			return (float)avg/arrayNum;
		}



	}
}

