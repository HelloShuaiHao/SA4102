// See https://aka.ms/new-console-template for more information

using System;
using ColorChangingLamp;

Lamp colorchangingLamp = new Lamp();

string info;
do
{
    Console.Write("Please enter command~ on/off/showcolor/quit: ");
    info = Console.ReadLine();
    info = info.ToLower();
    if(info == "on")
    {
        colorchangingLamp.TurnOn();
        colorchangingLamp.ShowCurrentColor();
    }else if(info == "off")
    {
        colorchangingLamp.TurnOff();
    }else if(info == "quit")
    {
        break;
    }
} while (info != "quit");