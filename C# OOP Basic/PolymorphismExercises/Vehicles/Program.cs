using System;

public class Program
{
    static void Main()
    {
        string[] carArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Vehicle car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]));

        string[] truckArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Vehicle truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]));

        int n = int.Parse(Console.ReadLine());
        try
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string toDo = input[0];
                string type = input[1];
                double km = double.Parse(input[2]);
                double tankCapacity = double.Parse(input[3]);

                if (toDo.ToLower() == "refuel")
                {
                    if (type.ToLower() == "car")
                    {
                        car.Refuel(km);
                    }

                    if (type.ToLower() == "truck")
                    {
                        truck.Refuel(km*0.95);
                    }
                }

                if (toDo.ToLower() == "drive")
                {
                    if (type.ToLower() == "car")
                    {
                        Console.WriteLine(car.Drive(km));
                    }

                    if (type.ToLower() == "truck")
                    {
                        Console.WriteLine(truck.Drive(km));
                    }
                }
               
            }
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
          
    }
}
