public abstract class Mammal : Animal
{
    public Mammal(string animalName, double animalWeight, string livingRegion)
        :base(animalName, animalWeight)
    {
        this.LivingRegion = livingRegion;
    }
    private string livingRegion;
    public string LivingRegion
    {
        get
        {
            return this.livingRegion;
        }
        set
        {
            this.livingRegion = value;
        }
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
