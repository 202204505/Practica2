using System;
using System.Xml.Linq;
using Practice1;

public class City : IMessageWritter
{
    private List<Taxi> licenceRegister;
    private string cityName;
    public City(string CityName)
	{
        licenceRegister = new List<Taxi>();
        cityName = CityName;
	}
    internal void RegisterPoliceStation(PoliceStation policeStation)
    {
        policeStation.setCity(this);
        Console.WriteLine($"The {cityName} police station is known as {policeStation.GetName()}");
    }
    internal void RegisterTaxiLicence(Taxi taxi)
    {
        if (licenceRegister.Contains(taxi))
        {
            Console.WriteLine("This taxi already has a licence");
        }
        else
        {
            licenceRegister.Add(taxi);
            Console.WriteLine("Licence created successfully");
        }
    }
    internal void RemoveTaxiLicence(Taxi taxi)
    {
        if (taxi != null)
        {
            licenceRegister.Remove(taxi);
            Console.WriteLine("Taxi licence removed correctly");
        }
        else
        { 
            Console.WriteLine("Taxi already removed"); 
        }

    }
    public override string ToString()
    {
        return $"{GetName()}";
    }

    public string GetName()
    {
        return cityName;
    }

    public string WriteMessage(string message)
    {
        return $"{this}: {message}";
    }

}
