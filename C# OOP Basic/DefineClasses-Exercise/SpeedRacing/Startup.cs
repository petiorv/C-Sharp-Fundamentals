using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                if (!cars.ContainsKey(input[0]))
                {
                    cars.Add(input[0], new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
                }
            }

            string command = Console.ReadLine();
            while (command!="End")
            {
                var parameters = command.Split(' ');
                string tartgelModel = parameters[1];
                double km = double.Parse(parameters[2]);

                cars[tartgelModel].Drive(km);
                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Value);
            }
        }
    }
}
