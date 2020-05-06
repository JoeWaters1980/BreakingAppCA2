using System;
using System.Linq;
using System.Media;
using System.Windows;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BreakingAppCA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer _soundPlayer;

        private Vehicles vehicle;

        WeatherConDataEntities db = new WeatherConDataEntities();


        public MainWindow()
        {
            InitializeComponent();
        }


        private void BtnSpeedEnter_Click(object sender, RoutedEventArgs e)
        {
            // declare vairables
            int speed;
            double breaking_distance = 0.0;
            double totalThinkingDis = 0;
            string condition = "";
            string outputThink = "thinking distance in meters :";
            string outputtotalDis = "Total braking distance Feet :";
            double speedInKph;

            double totalCarLenght;

            _soundPlayer = new SoundPlayer("D:/Collage Work/Second Year/Programming Year 2/Sem 2/OOP/BreakingAppCA2/BreakingAppCA2/Sounds/car.wav");
            _soundPlayer.Play();

            try
            {
                // speed entered by the user
                speed = int.Parse(Tbx_Speed_Input.Text);

                Tbx_Speed_OutPut.Text = speed.ToString();




                //    // adds the number from the text box calulates the breaking distance
                //    //and displays it in the breaking distance textblock in feet

                //Console.WriteLine(vehicle);
                //// speed sent to the vechicle class to get the speed in kph
                speedInKph = vehicle.GetSpeedInMPH(speed);


                // breaking disatance is calulated from the vechicle class
                breaking_distance = vehicle.GetBreakingDistanceInMPH(speed);
                TbxOutputBreak.Text = breaking_distance.ToString();

                totalThinkingDis = vehicle.getDistances(breaking_distance, speed);
                Console.WriteLine(totalThinkingDis);



            }
            catch
            {

            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnICY_Click(object sender, RoutedEventArgs e)
        {
            var weatherQuery = from c in db.Weathers
                               where c.Condition == "Icy"
                               select c.Condition;


            string weatherCon = weatherQuery.First();

            foreach (string var in weatherQuery)
            {
                Weath_Display.Text = var;
            }
            GetWeather(weatherCon);

        }



        private void BtnDry_Click(object sender, RoutedEventArgs e)
        {
            var weatherQuery = from c in db.Weathers
                               where c.Condition == "Dry"
                               select c.Condition;


            string weatherCon = weatherQuery.First();


            foreach (string var in weatherQuery)
            {
                Weath_Display.Text = var;
            }
            GetWeather(weatherCon);


        }

        public string GetWeather(string weatherCon)
        {
            string condition = weatherCon;

            return condition;

        }


        private void BtnWet_Click(object sender, RoutedEventArgs e)
        {
            var weatherQuery = from c in db.Weathers
                               where c.Condition == "Wet"
                               select c.Condition;


            string weatherCon = weatherQuery.First();


            foreach (string var in weatherQuery)
            {
                Weath_Display.Text = var;
            }
            GetWeather(weatherCon);

        }

        private void Btn_Add_Lorry_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                vehicle = new Vehicles("Lorry");

            }
            catch
            {

            }

        }

        private void Btn_Add_Bike_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                vehicle = new Vehicles("Bike");

            }
            catch
            {

            }

        }

        private void Btn_Add_Van_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                vehicle = new Vehicles("Van");

            }
            catch
            {

            }
        }

        private void BtnCarAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                vehicle = new Vehicles("Car");

            }
            catch
            {

            }

        }

       
    }


}
