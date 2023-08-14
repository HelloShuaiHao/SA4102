using System;
namespace ColorChangingLamp
{
	public class ColorEnum
	{
		public enum Color
		{
			NoColor,
			RED,
			GREEN,
			BLUE
		}

		public static Color NextColor(Color color)
		{
			Color nextColor;

			switch (color)
			{
				case Color.RED:
					nextColor = Color.GREEN;
					break;
				case Color.GREEN:
					nextColor = Color.BLUE;
					break;
				case Color.BLUE:
					nextColor = Color.RED;
					break;
				default:
					nextColor = Color.NoColor;
					break;
			}

			return nextColor;
		}
	}
}

