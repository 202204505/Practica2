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

            Console.WriteLine("Police 1 and 3 will have radar, but 2 wont");
            Console.WriteLine(" ");

            PoliceCar policeCar1 = new PoliceCar("0001 CNP");
            Console.WriteLine(policeCar1.WriteMessage("Created"));
            policeStation.RegisterPoliceCar(policeCar1);
            SpeedRadar radar1 = new SpeedRadar();
            policeCar1.SetRadar(radar1);
            policeCar1.setStation(policeStation);
            policeCar1.StartPatrolling();
            Console.WriteLine(" ");

            PoliceCar policeCar2 = new PoliceCar("0002 CNP");
            Console.WriteLine(policeCar2.WriteMessage("Created"));
            policeStation.RegisterPoliceCar(policeCar2);
            SpeedRadar radar2 = new SpeedRadar();
            policeCar2.setStation(policeStation);
            policeCar2.StartPatrolling();
            Console.WriteLine(" ");

            PoliceCar policeCar3 = new PoliceCar("0003 CNP");
            Console.WriteLine(policeCar3.WriteMessage("Created"));
            policeStation.RegisterPoliceCar(policeCar3);
            SpeedRadar radar3 = new SpeedRadar();
            policeCar3.SetRadar(radar3);
            policeCar3.setStation(policeStation);
            policeCar3.StartPatrolling();
            Console.WriteLine(" ");

            //aunque no hace falta
            Scooter scooter1 = new Scooter();
            Console.WriteLine(scooter1.WriteMessage("Created"));
            Console.WriteLine("     ");


            //Coche con radar utiliza el radar
            policeCar1.UseRadar(taxi1);
            Console.WriteLine("     ");


            taxi2.StartRide();
            policeCar2.UseRadar(taxi2);


            //Extra: Verificamos que se pueda usar el radar de forma individual
            radar2.TriggerRadar(taxi2);
            string measurement2 = radar2.GetLastReading();
            Console.WriteLine($"Triggered individual radar. Result: {measurement2}");
            Console.WriteLine("     ");

            

            //Comprobamos que el police car 3 funciona bien con radar
            policeCar3.UseRadar(taxi3);
            Console.WriteLine("     ");

            
            taxi1.StartRide();
            policeCar1.UseRadar(taxi1);
            Console.WriteLine("     ");


            Madrid.RemoveTaxiLicence(taxi1);
            Console.WriteLine("     ");

            policeCar1.EndPatrolling();
            policeCar2.EndPatrolling();
            policeCar3.EndPatrolling(); 
            Console.WriteLine("     ");

            //El coche de policía no tendrá este historial ya que no tenía radar
            policeCar1.PrintRadarHistory();
            policeCar2.PrintRadarHistory();
            policeCar3.PrintRadarHistory();

            //policeCar2.StartPatrolling();
            //policeCar3.StartPatrolling();
            //Console.WriteLine(" ");

            //taxi2.StartRide();
            //policeCar2.UseRadar(taxi2);
            //policeCar2.StartPatrolling();
            //policeCar2.UseRadar(taxi2);
            //taxi2.StopRide();
            //policeCar2.EndPatrolling();

            //taxi1.StartRide();
            //taxi1.StartRide();
            //policeCar1.StartPatrolling();
            //policeCar1.UseRadar(taxi1);
            //taxi1.StopRide();
            //taxi1.StopRide();
            //policeCar1.EndPatrolling();

            //policeCar1.PrintRadarHistory();
            //policeCar2.PrintRadarHistory();

        }
    }
}
    

