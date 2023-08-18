// See https://aka.ms/new-console-template for more information
using System;
using ARandomList;

RandomList myRandomList = new RandomList();

myRandomList.SeedValue = 5;

int arrNum, low, high;
Console.Write("Please input arrNum: ");
arrNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input low value: ");
low = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input high value: ");
high = Convert.ToInt32(Console.ReadLine());

myRandomList.Generate(arrNum, low, high);
myRandomList.Show();
Console.WriteLine("mean value: {0}",myRandomList.Mean());




myRandomList.SeedValue = 8;

Console.Write("Please input arrNum: ");
arrNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input low value: ");
low = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input high value: ");
high = Convert.ToInt32(Console.ReadLine());

myRandomList.Generate(arrNum, low, high);
myRandomList.Show();
Console.WriteLine("mean value: {0}", myRandomList.Mean());

Console.WriteLine("cur seed value: {0}",myRandomList.SeedValue);

Console.ReadKey();