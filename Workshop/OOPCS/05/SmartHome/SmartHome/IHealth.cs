using System;
namespace SmartHome
{
	// 接口相当于向子类里潜入一些函数 可以直接通过类似于调用子类的函数 传递一些数据
	public interface IHealth
	{
		MachineType GetMType();
		int GetCount();
		string GetName();
	}
}

