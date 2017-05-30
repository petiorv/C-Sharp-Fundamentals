namespace _03.CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main(string[] args)
        {
            string inputArr = Console.ReadLine();
            var arr = inputArr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();
            var dictionary = new SortedDictionary<double, int>();
            foreach (var num in arr)
            {
                if (!dictionary.ContainsKey(num))
                    dictionary.Add(num, 1);
                else
                    dictionary[num]++;                   
            }
            foreach (var num in dictionary)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
