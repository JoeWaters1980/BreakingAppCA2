using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakingAppCA2;
using System.ComponentModel.DataAnnotations;


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

                Vehicles v1 = new Vehicles() { VechicleID = 1, VehicleType = "Car"};
                Vehicles v2 = new Vehicles() { VechicleID = 2, VehicleType = "Van"};
                Vehicles v3 = new Vehicles() { VechicleID = 3, VehicleType = "Bike"};
                Vehicles v4 = new Vehicles() { VechicleID = 4, VehicleType = "Lorry" };

                Weather w1 = new Weather() { WeatherID = 5, TypeOfWeatherDry = "Dry", TypeOfWeatherIcy = "Icy", TypeOfWeatherWet = "Wet", VechicleID = 1 , Vehicles = v1 };
                Weather w2 = new Weather() { WeatherID = 6, TypeOfWeatherDry = "Dry", TypeOfWeatherIcy = "Icy", TypeOfWeatherWet = "Wet", VechicleID = 2, Vehicles = v2 };
                Weather w3 = new Weather() { WeatherID = 7, TypeOfWeatherDry = "Dry", TypeOfWeatherIcy = "Icy", TypeOfWeatherWet = "Wet", VechicleID = 3, Vehicles = v3 };
                Weather w4 = new Weather() { WeatherID = 8, TypeOfWeatherDry = "Dry", TypeOfWeatherIcy = "Icy", TypeOfWeatherWet = "Wet", VechicleID = 4, Vehicles = v4 };
                
                db.VehiclesTBL.Add(v1);
                db.VehiclesTBL.Add(v2);
                db.VehiclesTBL.Add(v3);
                db.VehiclesTBL.Add(v4);

                Console.WriteLine("vehicles added to database");

                db.WeatherTBL.Add(w1);
                db.WeatherTBL.Add(w2);
                db.WeatherTBL.Add(w3);
                db.WeatherTBL.Add(w4);

                Console.WriteLine("Weather added to database");

                // always remember to save changes
                db.SaveChanges();

                // confirm save 
                Console.WriteLine("saved changes to database");

            }
        }
    }
}
