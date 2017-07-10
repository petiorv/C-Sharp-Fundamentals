using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Gandalf gandalf = new Gandalf();

        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        foreach (var food in input)
        {
            gandalf.AddFood(food);
        }

        gandalf.Mood(1);
        Console.WriteLine(gandalf);
    }
}

