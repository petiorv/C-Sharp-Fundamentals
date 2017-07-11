using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Gandalf gandalf = new Gandalf();
        var foodFactory = new FoodFactory();
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        foreach (var f in input)
        {
            var food = foodFactory.CreateFood(f);
            gandalf.Eat(food);

        }

        MoodFactory mood = new MoodFactory();
        Console.WriteLine(gandalf.TotalPoints);
        Console.WriteLine(mood.CreateMood(gandalf.TotalPoints).Name);
    }
}

