public abstract class Animal
{
    private string animalName;
    private string animalType;
    private double animalWeight;
    private int foodEaten;

    public Animal(string animalName, double animalWeight)
    {
        this.AnimalName = animalName;
        this.AnimalWeight = animalWeight;
    }

    public int FoodEaten
    {
        get { return foodEaten; }
        protected set { foodEaten = value; }
    }

    public string AnimalName
    {
        get
        {
            return this.animalName;
        }
        set
        {
            this.animalName = value;
        }
    }

    public string AnimalType
    {
        get
        {
            return this.animalType;
        }
        set
        {
            this.animalType = value;
        }
    }

    public double AnimalWeight
    {
        get
        {
            return this.animalWeight;
        }
        set
        {
            this.animalWeight = value;
        }
    }

    public virtual void MakeSound()
    {

    }

    public virtual void Eat(Food food)
    {
        this.FoodEaten += food.Quantity;
    }

    
}