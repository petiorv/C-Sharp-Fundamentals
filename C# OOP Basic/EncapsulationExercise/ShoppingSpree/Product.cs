using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Product
    {
        private string name;
        private decimal coast;

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
        public decimal Coast
        {
            get
            {
                return this.coast;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.coast = value;
            }
        }

        public Product(string name, decimal coast)
        {
            this.Name = name;
            this.Coast = coast;
        }
    }
}
