using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingAppCA2;


namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            // the new database
            WeatherData db = new WeatherData();
            
            using (db)
            {
                Vehicles car = new Vehicles() { VechicleID = 1, VehicleType= "Car" };
                Vehicles van = new Vehicles() { VechicleID = 2, VehicleType = "Van" };
                Vehicles bike = new Vehicles() { VechicleID = 3, VehicleType = "Bike" };
                Vehicles Lorry = new Vehicles() { VechicleID = 4, VehicleType = "Lorry" };

                Weather dry = new Weather() { WeatherID = 5, TypeOfWeather = "Dry" };
                Weather wet = new Weather() { WeatherID = 6, TypeOfWeather = "Wet" };
                Weather icy = new Weather() { WeatherID = 7, TypeOfWeather = "Icy" };
            }
        }
    }
}
