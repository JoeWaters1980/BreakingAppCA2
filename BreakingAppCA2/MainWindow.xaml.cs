using System;
using System.Windows;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BreakingAppCA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Vehicles vehicle;

        WeatherConDataEntities db = new WeatherConDataEntities();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddCar(object sender, RoutedEventArgs e)
        {
            try
            {
                
                vehicle = new Vehicles("car");
            }
            catch
            {

            }
        }

        private void BtnSpeedEnter_Click_1(object sender, RoutedEventArgs e)
        {
            // declare vairables
            int speed;
            double breaking_distance = 0.0;
            double totalThinkingDis = 0;
            string weather;
            string outputThink = "thinking distance in meters :";
            string outputtotalDis = "Total braking distance Feet :";
            double speedInKph;
            double totalCarLenght;

            try
            {
                // speed entered by the user
                speed = int.Parse(Tbx_Speed_Input.Text);

                Tbx_Speed_OutPut.Text = speed.ToString();

                //    // adds the number from the text box calulates the breaking distance
                //    //and displays it in the breaking distance textblock in feet

                Console.WriteLine(vehicle);
                // speed sent to the vechicle class to get the speed in kph
                speedInKph = vehicle.GetSpeedInMPH(speed);
                Console.WriteLine(speed);

                // breaking disatance is calulated from the vechicle class
                breaking_distance = vehicle.GetBreakingDistanceInMPH(speed);

                totalThinkingDis = vehicle.getDistances(breaking_distance, speed);
                Console.WriteLine(totalThinkingDis);

                GetWeather();

            }
            catch
            {

            }

        }
        public void GetWeather()
        {
            //Looking for weather id where some conditions..
            var query1 = from c in db.VecicleTypes
                         //where c.TypeOfVechicle == "Car" 
                        select c.Weather_Id;

            int weatherId = query1.First();

            var query2 = from w in db.Weathers
                         where w.Id == weatherId
                         select w.Condition;

            string weatherCondition = query2.First();


            //var query = from c in db.VecicleTypes
            //            from w in db.Weathers
            //            join
            //            where c.TypeOfVechicle == "Car"
            //            select c;



            //                where w.Condition == "dry"
            //                select w;





            //            var categoryQuery =
            //from cat in categories
            //join prod in products on cat equals prod.Category
            //select new { Category = cat, Name = prod.Name };





            DataTest.ItemsSource = query1.ToList();
        }

        
    }


}
