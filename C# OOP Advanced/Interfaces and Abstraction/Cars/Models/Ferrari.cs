using System;

public class Ferrari : ICar
{
    private const string FerrariModel = "488-Spider";

    private string driver;

    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public string Model => FerrariModel;

    public string Driver
    {
        get { return this.driver; }
        set { this.driver = value; }
    }

    public string Brake()
    {
        return "Brakes!";
    }

    public string Gas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.Brake()}/{this.Gas()}/{this.Driver}";
    }
}

