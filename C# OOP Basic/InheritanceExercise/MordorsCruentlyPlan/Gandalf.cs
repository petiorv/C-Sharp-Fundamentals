public class Gandalf
{
    public int TotalPoints { get; set; }

    public void Eat(Food food)
    {
        this.TotalPoints += food.Happines;
    }
}

