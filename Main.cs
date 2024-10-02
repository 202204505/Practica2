namespace Practice1
{
    internal class Program
    {

        static void Main()
        {
            City Madrid = new City("Madrid");
            Console.WriteLine(Madrid.WriteMessage("Created"));

            PoliceStation policeStation = new PoliceStation("Central Station");
            Console.WriteLine(policeStation.WriteMessage("Created"));
            
            Madrid.RegisterPoliceStation(policeStation);
            Console.WriteLine(" ");

            Taxi taxi1 = new Taxi("0001 AAA");
            Console.WriteLine(taxi1.WriteMessage("Created"));
            Madrid.RegisterTaxiLicence(taxi1);
            Madrid.RegisterTaxiLicence(taxi1);
            Console.WriteLine(" ");

            Taxi taxi2 = new Taxi("0002 BBB");
            Console.WriteLine(taxi2.WriteMessage("Created"));
            Madrid.RegisterTaxiLicence(taxi2);
            Console.WriteLine(" ");

            Taxi taxi3 = new Taxi("0003 CCC");
            Console.WriteLine(taxi3.WriteMessage("Created"));
            Madrid.RegisterTaxiLicence(taxi3);
            Console.WriteLine(" ");


            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            policeStation.RegisterPoliceCar(policeCar1);
            Console.WriteLine(" ");

            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            policeStation.RegisterPoliceCar(policeCar2);
            Console.WriteLine(" ");

            PoliceCar policeCar3 = new PoliceCar("0003 CNP");
            Console.WriteLine(policeCar3.WriteMessage("Created"));
            policeStation.RegisterPoliceCar(policeCar3);
            Console.WriteLine(" ");


            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            Console.WriteLine(" ");

            policeCar2.StartPatrolling();
            policeCar3.StartPatrolling();
            Console.WriteLine(" ");

            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);
            policeCar2.StartPatrolling();
            policeCar2.UseRadar(taxi2);
            taxi2.StopRide();
            policeCar2.EndPatrolling();

            taxi1.StartRide();
            taxi1.StartRide();
            policeCar1.StartPatrolling();
            policeCar1.UseRadar(taxi1);
            taxi1.StopRide();
            taxi1.StopRide();
            policeCar1.EndPatrolling();

            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();

        }
    }
}
    

