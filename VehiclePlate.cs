using Practice1;

namespace Practice1
{
    abstract class VehiclePlate : Vehicle
    {
        private string plate;
        protected VehiclePlate(string typeOfVehicle, string plate) : base(typeOfVehicle)
        {
            this.plate = plate;
        }

        //Override ToString() method with class information
        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }
        public override string GetPlate()
        {
            return plate;
        }
    }
}
