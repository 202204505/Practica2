using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice1;

namespace Practice1
{
    public class PoliceStation : IMessageWritter
    {
        private bool alarm;
        private List<PoliceCar> PoliceCarList;
        private List<Taxi> SpeedingTaxiList;
        private City? Ncity;
        private string NamePoliceStation;

        public PoliceStation(string namePoliceStation)
        {
            PoliceCarList = new List<PoliceCar>();
            SpeedingTaxiList = new List<Taxi>();
            alarm = false;
            NamePoliceStation = namePoliceStation;
        }
        internal void RegisterPoliceCar(PoliceCar policeCar)
        {
            PoliceCarList.Add(policeCar);
            Console.WriteLine($"Police car patrolling for {NamePoliceStation}");
            policeCar.setStation(this);  
        }
        internal void AddSpeedingTaxi(Taxi taxi)
        {
            SpeedingTaxiList.Add(taxi);
            alarm = true;
            Console.WriteLine($"Vehicle {taxi.GetPlate()} added to speeding list.");
        }
        public void SendChasing()
        {
            Console.WriteLine("Iligally speed detected. Sending all available units on a chase.");
            foreach (PoliceCar car in PoliceCarList)
            {
                if (car.IsPatrolling())
                {
                    car.StartChasing();
                }

            }
            
        }
        public void setCity(City city)
        {
            Ncity = city;
        }
        public void PrintSpeedingList()
        {
            Console.WriteLine("Speeding vehicles:");
            foreach (var vehicle in SpeedingTaxiList)
            {
                Console.WriteLine(vehicle.GetPlate());
            }
        }       
        public override string ToString()
        {
            return $"{GetName()}";
        }

        public string GetName()
        {
            return NamePoliceStation;
        }

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}







