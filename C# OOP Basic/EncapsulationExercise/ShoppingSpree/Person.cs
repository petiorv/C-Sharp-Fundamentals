namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    class Person
    {
        private string name;
        private decimal money;

        public List<Product> Bag { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        
        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }

        public void BuyProduct(Product prod)
        {
            if (this.money >= prod.Coast)
            {
                this.money -= prod.Coast;
                this.Bag.Add(prod);
            }
            else
            {
                throw new ArgumentException($"{this.name} can't afford {prod.Name}");
            }
        }
    }
}
