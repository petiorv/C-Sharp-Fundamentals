namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

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
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
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
                    throw new ArgumentException($"{nameof(Money)} cannot be negative");
                }
                this.money = value;
            }
        }

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public void BuyProduct(Product prod)
        {
            if (this.Money < prod.Price)
            {
                throw new InvalidOperationException($"{this.name} can't afford {prod.Name}");
            }
            this.bag.Add(prod);
            this.Money -= prod.Price;
        }

        public IList<Product> GetProducts()
        {
            return this.bag.AsReadOnly();
        }
       
    }
}
