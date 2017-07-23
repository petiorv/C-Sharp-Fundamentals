﻿using System.Text;

public abstract class Car
{
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsePower;
    private int acceleration;
    private int suspension;
    private int durability;

    protected Car(string brand, string model, int yearOfProduction, int horsePower, int acceleration, int suspension, int durability)
    {
        this.brand = brand;
        this.model = model;
        this.yearOfProduction = yearOfProduction;
        this.horsePower = horsePower;
        this.acceleration = acceleration;
        this.suspension = suspension;
        this.durability = durability;
    }

    public override string ToString()
    {
        StringBuilder sp = new StringBuilder();
        
        sp.AppendLine($"{brand} {model} {yearOfProduction}");
        sp.AppendLine($"{horsePower} HP, 100 m/h in {acceleration} s");
        sp.AppendLine($"{suspension} Suspension force, {durability} Durability");
        
        return sp.ToString();
    }
    //public string Brand
    //{
    //    get
    //    {
    //        return this.brand;
    //    }
    //    set
    //    {
    //        this.brand = value;
    //    }
    //}
    //public string Model
    //{
    //    get
    //    {
    //        return this.model;
    //    }
    //    set
    //    {
    //        this.model = value;
    //    }
    //}

    //public int YearOfProduction
    //{
    //    get
    //    {
    //        return this.yearOfProduction;
    //    }
    //    set
    //    {
    //        this.yearOfProduction = value;
    //    }
    //}

    //public int HorsePower
    //{
    //    get
    //    {
    //        return this.horsePower;
    //    }
    //    set
    //    {
    //        this.horsePower = value;
    //    }
    //}

    //public int Accelaration
    //{
    //    get
    //    {
    //        return this.acceleration;
    //    }
    //    set
    //    {
    //        this.acceleration = value;
    //    }
    //}

    //public int Suspension
    //{
    //    get
    //    {
    //        return this.suspension;
    //    }

    //    set
    //    {
    //        this.suspension = value;
    //    }
    //}

    //public int Durability
    //{
    //    get
    //    {
    //        return this.durability;
    //    }
    //    set
    //    {
    //        this.durability = value;
    //    }
    //}
}

