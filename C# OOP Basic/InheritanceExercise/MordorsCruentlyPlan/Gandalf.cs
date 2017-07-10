using System.Collections.Generic;

public class Gandalf
{
    private string gandalfMood;
    private int happines;

    public void AddFood(string food)
    {
        food = food.ToLower();
        switch (food)
        {
            case "cram":
                happines += 2;
                break;
            case "lembas":
                happines += 3;
                break;
            case "apple":
                happines += 1;
                break;
            case "melon":
                happines += 1;
                break;
            case "honeycake":
                happines += 5;
                break;
            case "mushrooms":
                happines -= 10;
                break;
            default:
                happines -= 1;
                break;
        }
    }

    public void Mood(int happines)
    {
        this.gandalfMood = "kurec";
    }

    public override string ToString()
    {
        return $"{this.happines} {this.gandalfMood}";
    }



}

