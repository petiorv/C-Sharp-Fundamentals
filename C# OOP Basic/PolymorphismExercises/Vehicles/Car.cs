public class Car : Vehicle
{
    private const double acOn = 0.9;

    public Car(double fuelQuatity, double fuelConsumptioPerKm)
        :base(fuelQuatity, fuelConsumptioPerKm + acOn)
    {

    }

    public Car(double fuelQuatity, double fuelConsumptioPerKm, double tankCapacity)
      : base(fuelQuatity, fuelConsumptioPerKm + acOn, tankCapacity)
    {

    }
}

