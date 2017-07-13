public class Bus : Vehicle
{
    private const double acOn = 1.4;
    public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionPerKm+acOn, tankCapacity)
    {

    }     
}
