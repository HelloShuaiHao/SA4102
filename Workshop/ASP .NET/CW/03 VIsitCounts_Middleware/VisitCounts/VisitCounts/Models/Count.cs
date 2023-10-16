using System;
namespace VisitCounts.Models
{
	public class Count
	{
		public int CountHome { get; set; }
		public int CountGallery { get; set; }

		public Count(int a, int b)
		{
			this.CountHome = a;
			this.CountHome = b;
		}
	}
}

