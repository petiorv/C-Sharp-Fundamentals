using System.Collections.Generic;

public class Gandalf
{
    public int Happines { get; set; }

    public void AddFood(string food)
    {
        food = food.ToLower();
        switch (food)
        {
            case "cram": Happines += 2;
                break;
            case "lembas": Happines += 3;
                break;
            case "apple": Happines += 1;
                break;
            case "melon":
                Happines += 1;
                break;
            case "honeycake":
                Happines += 1;
                break;
            case "mushrooms":
                Happines -= 10;
                break;
            default: Happines -= 1;
                break;
        }
    }

}

