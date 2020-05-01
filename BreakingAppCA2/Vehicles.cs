using System;
using System.Windows;
using System.Linq;

namespace BreakingAppCA2
{
    class Vehicles
    {


        // Properties
        public Vehicles vehicle;
        public string VehicleType { get; set; }
        public double speed { get; }


        // Constructors

        public Vehicles(string vechile)
        {

            VehicleType = vechile;

        }


        //Methods

        public override string ToString()
        {
            return $"{VehicleType}";
        }

        public double GetSpeedInMPH(int speed)
        {
            const double mphToKmph = 1.60934;
            return speed * mphToKmph;

        }

        public double GetBreakingDistanceInMPH(int speed)
        {
            // speed entered by the user and the muilplyer is determined by the switch
            double calulatedDistance;
            double breaking_distance = 0.0;

            // To do add a array to loop through all possiablities
            try
            {

                // switch to assign the muliplyer
                switch (speed)
                {
                    case 20:
                        breaking_distance = 2.0;

                        break;
                    case 30:
                        breaking_distance = 2.5;
                        break;
                    case 40:
                        breaking_distance = 3.0;
                        break;
                    case 50:
                        breaking_distance = 3.5;
                        break;
                    case 60:
                        breaking_distance = 4.0;
                        break;
                    case 70:
                        breaking_distance = 4.5;
                        break;
                    case 80:
                        breaking_distance = 5.0;
                        break;
                    case 90:
                        breaking_distance = 5.5;
                        break;
                    case 100:
                        breaking_distance = 6.0;
                        break;
                    case 110:
                        breaking_distance = 6.5;
                        break;
                    case 120:
                        breaking_distance = 7.0;
                        break;
                    default:
                        MessageBox.Show("an error has happened");
                        break;

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You must enter a number in MPH");
            }

            // calulation for the breaking distance

            calulatedDistance = (speed * breaking_distance);

            return calulatedDistance;
        }

        public double getDistances(double calulatedDistance, double speed)
        {
            // formula for reaction distance

            double thinkingDistance;
            const double reactionTime = 3.33;



            thinkingDistance = Math.Round(speed / reactionTime);


            return thinkingDistance;

        }

        public double getVanDistances(double caluatedDistance)
        {
            const double underLoad = 1.33;
            double underLoadDis = 0;

            underLoadDis = caluatedDistance * underLoad;

            return underLoadDis;
        }



        public double GetCarLength(double calulatedDistance)
        {
            const double carLength = 13.00;
            double totalCarLength = 0;


            totalCarLength = calulatedDistance / carLength;

            return totalCarLength;
        }

        public double GetLorryBreakingDistanceInMPH(int speed)
        {
            // speed entered by the user and the muilplyer is determined by the switch
            double calulatedDistance;
            double breaking_distance = 0.0;


            try
            {

                // switch to assign the muliplyer
                switch (speed)
                {
                    case 10:
                        breaking_distance = 3.0;

                        break;
                    case 20:
                        breaking_distance = 3.5;
                        break;
                    case 30:
                        breaking_distance = 4.0;
                        break;
                    case 40:
                        breaking_distance = 4.5;
                        break;
                    case 50:
                        breaking_distance = 5.0;
                        break;
                    case 60:
                        breaking_distance = 5.5;
                        break;
                    case 70:
                        breaking_distance = 6.0;
                        break;

                    default:
                        MessageBox.Show("an error has happened");
                        break;

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("You must enter a number in MPH");
            }

            // calulation for the breaking distance

            calulatedDistance = (speed * breaking_distance);

            return calulatedDistance;
        }


        //Notes:

        // thinking distance is approximately 1 foot for every mph you are travelling at.
        //Thinking distance + braking distance = overall stopping distance.
        // Calulation for breaking distances
        //Starting from 20mph you simply multiply the speed by intervals of 0.5,
        //beginning with 2, for example, 2, 2.5, 3, 3.5 etc., as follows:

        //20 mph x 2 = 40 feet((12 meters) or 3 car lengths)
        //30 mph x 2.5 = 75 feet((23 meters) or 6 car lengths)
        //40 mph x 3 = 120 feet((36.5 meters) or 9 car lengths)
        //50 mph x 3.5  = 175 feet((53 meters) or 13 car lengths)
        //60 mph x 4 = 240 feet((73 meters) or 18 car lengths)
        //70 mph x 4.5 = 315 feet((96 meters) or 24 car lengths)

        //(Average car length = 4 metres (13 feet)


        // d=vsquared / 2(coefficent of friction 0.60 dry)(g which is acceleration due to gravity or 9.80)

        // distance in meters is speed /3.33 then we change to feet
        // formula for reaction distance
        /* Formula: d = (s* r) / 3.6

         d = reaction distance in metres(to be calculated).
         s = speed in km/h.
         r = fixed a 2sec.
         3.6 = fixed figure for converting km / h to m / s.

         Example of calculation with a speed of 50 km / h and a reaction time of 2 second:

         (50 * 2) / 3.6 = 13.9 metres reaction distance

         (speed) ² ÷ 20 + thinking distance = overall stopping distance in feet

        For stopping distance formula in metres, multiply the result by 0.3
         The graph below illustrates a motorcycles stopping distances in ideal 
         dry conditions with speed in mph and km/h and distance in metres and feet. 
         Braking distances are considerably extended in wet and icy conditions. 
         The braking distance in green is doubled for wet conditions and is multiplied by 10 in icy conditions.

        lorry stopping distance
        speed 10mph = 14ft sec =3.0
        20 = 44 sec=3.5
        30 = 88 sec = 4.0
        40 =146 sec = 4.5
        50 = 220 sec = 5.0
        60 = 306 sec = 5.5
        70 = 409 sec = 6.0
         
         */
    }
}
