using System;
namespace SmartHome;

public class SmartLamp : SmartAppliance, IHealth
{
    private bool isOn;

    public SmartLamp(string name): base(name) 
    {
        isOn = false;
    }

    public bool TurnOn()
    {
        if (! isOn) {
            isOn = true;
            return true;
        } 

        return false;
    }

    public bool TurnOff()
    {
        if (isOn) {
			nUsed++;
			isOn = false;

			return true;
        }

        return false;
    }

    public uint GetUsageCount()
    {
        return nUsed;
    }

    public string GetApplType()
    {
        return "Lamp";
    }

    public string GetName()
    {
        return name;
    } 
}


