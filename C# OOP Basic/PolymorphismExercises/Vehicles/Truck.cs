using System;

public class Truck : Vehicle
{
    private const double acOn = 1.6;
    public Truck(double fuelQuantity, double fuelConsumptionPerKm)
        :base(fuelQuantity, fuelConsumptionPerKm + acOn)
    {

    }

    public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionPerKm + acOn, tankCapacity)
    {

    }

    public override void Refuel(double fuel)
    {
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        this.FuelQuantity += fuel;
    }

}

