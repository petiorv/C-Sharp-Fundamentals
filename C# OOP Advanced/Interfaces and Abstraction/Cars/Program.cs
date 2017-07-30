﻿using System;

public class Program
{
    static void Main(string[] args)
    {
        string driverName = Console.ReadLine();
        ICar ferrari = new Ferrari(driverName);
        Console.WriteLine(ferrari);

        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }
    }
}

