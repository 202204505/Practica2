using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Scooter : VehicleNoPlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances.
        private static string typeOfVehicle = "Scooter";
        private bool riding;
        //private bool isCarryingPassengers;

        public Scooter() : base(typeOfVehicle)
        {
            //Values of atributes are set just when the instance is done if not needed before.
            //isCarryingPassengers = false;
            SetSpeed(45.0f);
            riding = true;
        }
        public void StopRide()
        {
            if (riding)
            {
                riding = false;
                SetSpeed(0f);
                Console.WriteLine(WriteMessage("stops riding."));
            }
            else
            {
                Console.WriteLine(WriteMessage("already stop."));
            }
        }
    }
}