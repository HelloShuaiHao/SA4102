using System;
namespace SmartHome
{
	public class HealthChecker
	{
		Dictionary<MachineType, int> dict = new Dictionary<MachineType, int>();

		public HealthChecker(IHealth healthInfo)
		{
			dict.Add(MachineType.Fridge,15);
			dict.Add(MachineType.Lamp, 20);

			int limit = dict[healthInfo.GetMType()];
			string name = healthInfo.GetName();
			int count = healthInfo.GetCount();

			if (count > limit)
			{
				Console.WriteLine("{0} needs servicing after {1} uses.", name, count);
			}
			else
			{
				Console.WriteLine("{0} is health after {1} uses.", name,count);
			}
		}
	}
}

