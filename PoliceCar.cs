namespace Practice1
{
    class PoliceCar : VehiclePlate
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car"; 
        private bool isPatrolling;
        private SpeedRadar? speedRadar;
        private PoliceStation? policeStation;
        private bool chasing;
        private float legalSpeed = 50.0f;

        public PoliceCar(string plate) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            //speedRadar = new SpeedRadar();
            chasing = false;   
        }

        public void setStation(PoliceStation polStation)
        {
            policeStation = polStation;
        }
        public void SetRadar(SpeedRadar speedRadar)
        {
            this.speedRadar = speedRadar;
            Console.WriteLine(WriteMessage("has radar"));
        }
        public void UseRadar(Vehicle vehicle)

        {
            if (!isPatrolling)
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
            else if (speedRadar == null)
            {
                Console.WriteLine(WriteMessage($"has no radar"));
            }
            else
            {
                speedRadar.TriggerRadar(vehicle);
                string meassurement = speedRadar.GetLastReading();
                Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));
                if (vehicle.GetSpeed() > legalSpeed)
                {
                    if (policeStation != null)
                    {
                        policeStation.SendChasing();
                        policeStation.AddSpeedingTaxi(vehicle);

                    }
                    else
                    {
                        Console.WriteLine("Police car has no police station assigned");
                    }
                }
            }

        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }

        public void PrintRadarHistory()
        {
            if (speedRadar == null)
            {
                Console.WriteLine(WriteMessage("has no radar"));
            }
            else
            {
                Console.WriteLine(WriteMessage("Report radar speed history:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
        }
        public void StartChasing()
        {
            chasing = true;
            Console.WriteLine(WriteMessage("is chasing a car"));
        }
    }
}