using System;
namespace MyException
{
	public class Triangle
	{
		private double side1;
		private double side2;
		private double side3;

		public Triangle(double s1, double s2, double s3)
		{
			if (s1 + s2 < s3 || s1 + s3 < s2 || s2 + s3 < s1) BadTriangleException.Report();

			this.side1 = s1;
			this.side2 = s2;
			this.side3 = s3;

		}

		/// <summary>
		/// return the perimeter
		/// </summary>
		/// <returns></returns>
		public double Perimeter()
		{
			return this.side1 + this.side2 + this.side3;
		}

		/// <summary>
		/// return the area
		/// </summary>
		/// <returns></returns>
		public double Area()
		{
			double p = (side1 + side2 + side3) / 2;
			return Math.Sqrt(p * (p - this.side1) * (p - this.side2) * (p - this.side3));
		}
	}
}

