namespace _10.Population_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string city;
            string country;
            int population;

            var cities = new Dictionary<string, Dictionary<string, long>>();
            var countries = new Dictionary<string, long>();

            while (true)
            {
                if (input.Equals("report"))
                {
                    break;
                }

                string[] info = input.Split('|');
                city = info[0];
                country = info[1];
                population = int.Parse(info[2]);

                if (!cities.ContainsKey(country))
                {
                    cities.Add(country, new Dictionary<string, long>());
                    countries.Add(country, 0);
                }
                if (!cities[country].ContainsKey(city))
                {
                    cities[country].Add(city, 0);
                }
                cities[country][city] += population;
                countries[country] += population;
                input = Console.ReadLine();   
            }
            foreach (var c in countries.OrderByDescending(kv => kv.Value))
            {
                Console.WriteLine($"{c.Key} (total population: {c.Value})");
                foreach (var ci in cities[c.Key].OrderByDescending(kv => kv.Value))
                {
                    
                        Console.WriteLine($"=>{ci.Key}: {ci.Value}");
                    
                }
            }
        }
    }
}
