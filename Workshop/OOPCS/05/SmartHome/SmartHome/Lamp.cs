using System;
namespace SmartHome
{
	public class Lamp:Machine
	{
		public Lamp(string equipmentName):base(equipmentName)
		{
            mType = MachineType.Lamp;
            count = 0;
		}

        public override void On()
        {
            if (!isOn)
            {
                isOn = true;
                base.count++;
                Console.WriteLine("The lamp is on");
            }
            else
            {
                Console.WriteLine("The lamp in already on");
            }
        }

        public override void Off()
        {
            if (!isOn)
            {
                Console.WriteLine("The lamp is already on");
            }
            else
            {
                isOn = false;
                base.count++;
                Console.WriteLine("The lamp is off");
            }
        }

        
    }
}

