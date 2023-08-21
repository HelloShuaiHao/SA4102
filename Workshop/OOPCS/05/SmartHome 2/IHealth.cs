using System;
namespace SmartHome;

public interface IHealth
{
    public uint GetUsageCount();
    public string GetApplType();
    public string GetName();
}


