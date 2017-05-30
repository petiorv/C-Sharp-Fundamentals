
namespace _04.Academy_Graduation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, double>();
            int counter = int.Parse(Console.ReadLine());
            for (int i = 0; i < counter; i++)
            {
                string name = Console.ReadLine();
                string inputScores = Console.ReadLine();
                double[] scoreArr = inputScores.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

                dictionary.Add(name, scoreArr.Average());

            }
            foreach (var student in dictionary)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value}");
            }
        }
    }
}
