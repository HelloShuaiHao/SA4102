using System;
namespace ColorChangingLamp
{
	public class Lamp
	{
		public bool isOn;
		public ColorEnum.Color color;


		public Lamp()
		{
			isOn = false;
			color = ColorEnum.Color.NoColor;
		}

		public void TurnOn()
		{
			if (!isOn)
			{
				isOn = true;
				if(color == ColorEnum.Color.NoColor)
				{
					// todo: haven't been opened yet
					color = ColorEnum.Color.RED;
				}
				else
				{
					// need to swich the color
					color = ColorEnum.NextColor(color);
				}
			}
			else
			{
				Console.WriteLine("The light is already on");
			}

		}
		public void TurnOff()
		{
			if (isOn) isOn = false;

			else Console.WriteLine("The light is already off");
        }
		public void ShowCurrentColor()
		{
			Console.WriteLine("color: {0}",this.color);
		}
		
	}
}

