using System;
namespace SmartHome
{
    public class Fridge : Machine
    {
        public Fridge(string equipmentName) : base(equipmentName)
        {
            mType = MachineType.Fridge;
            count = 0;
            isOn = false;
        }

        public override void On()
        {
            if (!isOn)
            {
                isOn = true;
                base.count++;
                Console.WriteLine("The fridge is on");
            }
            else
            {
                Console.WriteLine("The fridge is already on");
            }
        }

        public override void Off()
        {
            if (!isOn)
            {
                Console.WriteLine("The fridge is already on");
            }
            else
            {
                isOn = false;
                base.count++;
                Console.WriteLine("The fridge is off");
            }
        }
    }
}

