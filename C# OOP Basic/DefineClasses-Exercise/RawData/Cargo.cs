using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Cargo
    {
        private int cargoWeight;
        private string cargoType;

        public int CargoWeight { get; set; }
        public string CartgoType { get; set; }

        public Cargo(int cargoWeight, string cargoType)
        {
            this.CargoWeight = cargoWeight;
            this.CartgoType = cargoType;
        }
    }
}
