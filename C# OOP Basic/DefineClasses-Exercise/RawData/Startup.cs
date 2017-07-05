using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string model = input[0];

                
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                var engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                var cargo = new Cargo(cargoWeight, cargoType);

                var tyres = new List<Tyre>();
                
                double typerP1 = double.Parse(input[5]);
                int tyreAge1 = int.Parse(input[6]);
                var tyre1 = new Tyre(typerP1, tyreAge1);
                tyres.Add(tyre1);

                double typerP2 = double.Parse(input[5]);
                int tyreAge2 = int.Parse(input[6]);
                var tyre2 = new Tyre(typerP2, tyreAge2);
                tyres.Add(tyre2);

                double typerP3 = double.Parse(input[5]);
                int tyreAge3 = int.Parse(input[6]);
                var tyre3 = new Tyre(typerP3, tyreAge3);
                tyres.Add(tyre3);

                double typerP4 = double.Parse(input[5]);
                int tyreAge4 = int.Parse(input[6]);
                var tyre4 = new Tyre(typerP4, tyreAge4);
                tyres.Add(tyre4);

                Car car = new Car(model, engine, cargo, tyres);
                cars.Add(car);
            }

            string type = Console.ReadLine();

            if (type == "fragile")
            {
                foreach (var car  in cars.Where(c => c.Cargo.CartgoType == "fragile").Where(c => c.Tyres.Any(t => t.TyrePresure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (var car in cars.Where(c => c.Cargo.CartgoType == "flamable").Where(c => c.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
