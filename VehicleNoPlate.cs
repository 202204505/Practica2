using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice1;

namespace Practice1
{
    abstract class VehicleNoPlate : Vehicle
    {
        protected VehicleNoPlate(string typeOfVehicle) : base(typeOfVehicle) { }
        public override string GetPlate()
        {
            return "Vehicle has no plate";
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with no plate";
        }
    }
}

    