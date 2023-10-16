using System;
namespace SmartHome;

public class MainTest
{
    public static void Main()
    {
        List<Machine> machineList = new List<Machine>();

        Random rnd = new Random();
        int attempt = rnd.Next(5, 12 );

        Lamp newLamp = new Lamp("Living room lamp");
        Fridge newFridge = new Fridge("Kitchen fridge");


        for(int i = 0; i < attempt; i++)
        {
            newLamp.On();
            newLamp.Off();
            newFridge.On();
            newFridge.Off();
        }

        HealthChecker newHealthChecker1 = new HealthChecker(newLamp);
        HealthChecker newHealthChecker2 = new HealthChecker(newFridge);


        Console.ReadKey();

        return;
    }
}

