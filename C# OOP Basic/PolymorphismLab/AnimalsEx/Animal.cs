﻿public class Animal
{
    private string name;
    private string favouriteFood;

    public string FavouriteFood
    {
        get { return this.favouriteFood; }
        set
        {
            favouriteFood = value;
        }
    }
    public string Name
    {
        get { return this.name; }
        set
        {
            this.name = value;
        }
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}" ;
    }
}

