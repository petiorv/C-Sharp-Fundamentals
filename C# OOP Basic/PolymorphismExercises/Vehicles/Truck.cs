public class Truck : Vehicle
{
    private const double acOn = 1.6;
    public Truck(double fuelQuantity, double fuelConsumptionPerKm)
        :base(fuelQuantity, fuelConsumptionPerKm + acOn)
    {

    }

}

