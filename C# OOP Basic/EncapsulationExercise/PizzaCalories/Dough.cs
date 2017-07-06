namespace PizzaCalories
{
    using System;

    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private const double BaseModifier = 2;

        public string FlourType
        {
            get
            {
                return this.flourType;     
            }
            set
            {
                string input = value.ToLower();
                if (input != "white" && input!="wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = $"{char.ToUpper(input[0])}{input.Substring(1, input.Length-1)}";
            }
        }

        public string BakingTechnique
        {
            get
            {
                return this.bakingTechnique;
            }
            set
            {
                string input = value.ToLower();
                if (input != "crispy" && input != "chewy" && input!="homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = $"{char.ToUpper(input[0])}{input.Substring(1, input.Length - 1)}";
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public double FlourTypeModifier
        {
            get
            {
                double flourTypeModifier = 0;
                switch (this.FlourType)
                {
                    case "White":
                        flourTypeModifier = 1.5;
                        break;
                    case "Wholegrain":
                        flourTypeModifier = 1.0;
                        break;                    
                }

                return flourTypeModifier;
            }
        }
        
        public double BakingTechniqueModifier
        {
            get
            {
                double bakingTechModifier = 0;

                switch (this.BakingTechnique)
                {
                    case "Crispy":
                        bakingTechModifier = 0.9;
                        break;
                    case "Chewy":
                        bakingTechModifier = 1.1;
                        break;
                    case "Homemade":
                        bakingTechModifier = 1.0;
                        break;
                }
                return bakingTechModifier;
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                return this.Calories / this.Weight;
            }
        }

        public double Calories
        {
            get
            {
                return (this.Weight * BaseModifier) * this.FlourTypeModifier * this.BakingTechniqueModifier;
            }
        }

        


        //White – 1.5;
        //Wholegrain – 1.0;
        //Crispy – 0.9;
        //Chewy – 1.1;
        //Homemade – 1.0; 



    }
}
