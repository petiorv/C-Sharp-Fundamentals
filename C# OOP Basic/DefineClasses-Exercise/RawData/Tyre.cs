using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Tyre
    {
       
        public double TyrePresure { get; set; }
        public int TyreAge { get; set; }

        public Tyre(double tyrePresure, int tyreAge)
        {
            this.TyrePresure = tyrePresure;
            this.TyreAge = tyreAge;
        }

    }
}
