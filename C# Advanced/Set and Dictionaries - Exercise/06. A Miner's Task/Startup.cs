namespace _06.A_Miner_s_Task
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main(string[] args)
        {
            string resource = "";
            int quantity;
            int cnt = 0;
            var dictionary = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (!input.ToLower().Equals("stop"))
            {
                if (cnt % 2 == 0)
                {
                    resource = input;
                    
                }
                else
                {
                    quantity = int.Parse(input);
                    if (dictionary.ContainsKey(resource))
                        dictionary[resource] += quantity;                    
                    else
                        dictionary[resource] = quantity;
                }
                cnt++;
                input = Console.ReadLine();

            }
            foreach (var r in dictionary)
            {
                Console.WriteLine($"{r.Key} -> {r.Value}");
            }
        }
    }
}
