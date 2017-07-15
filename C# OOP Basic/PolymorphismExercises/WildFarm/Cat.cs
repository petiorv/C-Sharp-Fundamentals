public class Cat : Felime
{
    private string breed;

    public Cat(string animalName, double animalWeight, string livingRegion, string breed)
        :base(animalName, animalWeight, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed
    {
        get
        {
            return this.breed;
        }
        set
        {
            this.breed = value;
        }
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }

    public override void MakeSound()
    {
        System.Console.WriteLine("Meowwww");
    }
}

