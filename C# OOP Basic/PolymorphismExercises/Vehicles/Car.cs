public class Car : Vehicle
{
    private const double acOn = 0.9;

    public Car(double fuelQuatity, double fuelConsumptioPerKm)
        :base(fuelQuatity, fuelConsumptioPerKm + acOn)
    {

    }
}

