using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumptionPerKm;
    private double tankCapacity;

    public Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        this.TankCapacity = tankCapacity;

    }

    public double TankCapacity
    {
        get
        {
            return this.tankCapacity;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.tankCapacity = value;
        }
    }

    public virtual double FuelQuantity
    {
        get
        {
            return this.fuelQuantity;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.fuelQuantity = value;
        }
    }

    public virtual double FuelConsumptionPerKm
    {
        get
        {
            return this.fuelConsumptionPerKm;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Consumption must be more than 0");
            }
            this.fuelConsumptionPerKm = value;
        }
    }

    public virtual string Drive(double km)
    {
        double currentQuantity = FuelQuantity;
        currentQuantity -= km * this.FuelConsumptionPerKm;
        string result;
        if (currentQuantity > 0)
        {
            result = $"{this.GetType().Name} travelled {km} km";
            FuelQuantity = currentQuantity;
        }
        else
        {
            result = $"{this.GetType().Name} needs refueling";
        }
        return result;
    }

    public string DriveEmpty(double km)
    {
        double currentQuantity = FuelQuantity;
        currentQuantity -= km * (this.FuelConsumptionPerKm - 1.4);
        string result;
        if (currentQuantity > 0 && currentQuantity < fuelQuantity)
        {
            result = $"{this.GetType().Name} travelled {km} km";
            FuelQuantity = currentQuantity;
        }
        else
        {
            result = $"{this.GetType().Name} needs refueling";
        }
        return result;

    }

    public virtual void Refuel(double fuel)
    {
        if (fuel > this.TankCapacity)
        {
            throw new ArgumentException("Cannot fit fuel in tank");
        }
        if (fuel <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        this.FuelQuantity += fuel;
    }
}

