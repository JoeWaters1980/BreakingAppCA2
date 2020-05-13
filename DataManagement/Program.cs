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
                Weather w1 = new Weather() { WeatherID = 5, TypeOfWeatherDry = "Dry", TypeOfWeatherIcy = "Icy", TypeOfWeatherWet = "Wet" };
                Weather w2 = new Weather() { WeatherID = 6, TypeOfWeatherDry = "Dry", TypeOfWeatherIcy = "Icy", TypeOfWeatherWet = "Wet" };
                Weather w3 = new Weather() { WeatherID = 7, TypeOfWeatherDry = "Dry", TypeOfWeatherIcy = "Icy", TypeOfWeatherWet = "Wet" };
                Weather w4 = new Weather() { WeatherID = 8, TypeOfWeatherDry = "Dry", TypeOfWeatherIcy = "Icy", TypeOfWeatherWet = "Wet" };


                Vehicles v1 = new Vehicles() { VechicleID = 1, VehicleType= "Car", WeatherID = 5};
                Vehicles v2 = new Vehicles() { VechicleID = 2, VehicleType = "Van", WeatherID = 6};
                Vehicles v3 = new Vehicles() { VechicleID = 3, VehicleType = "Bike", WeatherID = 7 };
                Vehicles v4 = new Vehicles() { VechicleID = 4, VehicleType = "Lorry", WeatherID = 8 };


                db.WeatherTBL.Add(w1);
                db.WeatherTBL.Add(w2);
                db.WeatherTBL.Add(w3);
                db.WeatherTBL.Add(w4);


                db.VehiclesTBL.Add(v1);
                db.VehiclesTBL.Add(v2);
                db.VehiclesTBL.Add(v3);
                db.VehiclesTBL.Add(v4);

                Console.WriteLine("vehicles added to database");

                

                Console.WriteLine("Weather added to database");

                // always remember to save changes
                db.SaveChanges();

                // confirm save 
                Console.WriteLine("saved changes to database");

            }
        }
    }
}
