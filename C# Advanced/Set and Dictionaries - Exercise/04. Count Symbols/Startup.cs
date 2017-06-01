namespace _04.Count_Symbols
{
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var result = new SortedDictionary<char, int>();

            foreach (char c in input)
            {
                if (!result.ContainsKey(c))
                {
                    result.Add(c, 1);
                }
                else
                {
                    result[c]++;
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
