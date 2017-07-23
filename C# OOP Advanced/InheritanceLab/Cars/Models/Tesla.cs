using System;

public class Tesla : Car, IElectricCar
{
    private int battery;

    public Tesla(string model, string color, int battery) 
        : base(model, color)
    {
    }

    public int Battery
    {
        get => this.battery;
        set => this.battery = value;
    }

    public override string ToString()
    {
        return $"{base.ToString()} with {this.Battery} Batteries";
    }
}

