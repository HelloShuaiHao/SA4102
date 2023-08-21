using System;
namespace SmartHome
{
	public class Machine:IHealth
	{
        protected int count;
        protected MachineType mType;
        protected string equipmentName;
        protected bool isOn;

        public  Machine(string equipmentName)
        {
            this.equipmentName = equipmentName;
        }

        public virtual void On()
        {
            Console.WriteLine("It's a virtual method");
        }

        public virtual void Off()
        {
            Console.WriteLine("It's a virtual method");
        }

        // 实现接口
        public MachineType GetMType()
        {
            return mType;
        }
        public int GetCount()
        {
            return count;
        }
        public string GetName()
        {
            return equipmentName;
        }

    }
}

