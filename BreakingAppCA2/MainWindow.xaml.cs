using System;
using System.Linq;
using System.Media;
using System.Windows;

namespace BreakingAppCA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // sound player for the sounds used in the app
        SoundPlayer _soundPlayer;

        // class used
        //private Vehicles vehicle;



        public MainWindow()
        {
            InitializeComponent();


        }

        //Methods

        private void BtnSpeedEnter_Click(object sender, RoutedEventArgs e)
        {
            // declare vairables
            int speed;
            double breaking_distance = 0.0;
            double totalThinkingDis = 0;
            string outputThink = "thinking distance in meters :";
            string outputtotalDis = "Total braking distance Feet :";
            double speedInKph;
            double weatherMulit = 0.00;



            double totalCarLenght;

            //_soundPlayer = new SoundPlayer("D:/Collage Work/Second Year/Programming Year 2/Sem 2/OOP/BreakingAppCA2/BreakingAppCA2/Sounds/car.wav");
            _soundPlayer.Play();

        //    //try
        //    //{
        //    //    // speed entered by the user
        //    //    speed = int.Parse(Tbx_Speed_Input.Text);

        //    //    Tbx_Speed_OutPut.Text = speed.ToString();

        //    //    speedInKph = vehicle.GetSpeedInMPH(speed);


        //    //    // vehicle.GetWeatherMulitiplyer(weatherMulit);

        //    //    // breaking disatance is calulated from the vechicle class
        //    //    breaking_distance = vehicle.GetBreakingDistanceInMPH(speed, weatherMulit);
        //    //    TbxOutputBreak.Text = breaking_distance.ToString();

        //    //    totalThinkingDis = vehicle.GetDistances(breaking_distance, speed);
        //    //    Console.WriteLine(totalThinkingDis);



        //    //}
        //    //catch
        //    //{

        //    }



        }


        /*
         * Method for Exiting the program
         */

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // end Exiting Method

        /*
         * Method for Minimizing the program
         */

        private void BtnMin(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // end Minimizing Method

        /*
         * Method for Controls for adding weather condition
         * which is controlled via the user pressing 
         * one of the weather conditions buttons
         * this will run a query on the data base
         * looking for the type of weather selected
         * it also returns a mulitiplyer for the breaking distances
         */

        private void BtnICY_Click(object sender, RoutedEventArgs e)
        {
            //double mulitplyer = 10.00;

            //var weatherQuery = from c in db.Weathers
            //                   where c.Condition == "Icy"
            //                   select c.Condition;


            //string weatherCon = weatherQuery.First();

            //foreach (string var in weatherQuery)
            //{
            //    Weath_Display.Text = var;
            //}

            //GetWeather(weatherCon);

            //GetMuliplyer(mulitplyer);
        }

        private void BtnDry_Click(object sender, RoutedEventArgs e)
        {
            //double mulitplyer = 0;

            //var weatherQuery = from c in db.Weathers
            //                   where c.Condition == "Dry"
            //                   select c.Condition;


            //string weatherCon = weatherQuery.First();


            //foreach (string var in weatherQuery)
            //{
            //    Weath_Display.Text = var;
            //}

            //GetWeather(weatherCon);

            //GetMuliplyer(mulitplyer);
        }


        private void BtnWet_Click(object sender, RoutedEventArgs e)
        {
            //double mulitplyer = 2.00;

            //var weatherQuery = from c in db.Weathers
            //                   where c.Condition == "Wet"
            //                   select c.Condition;


            //string weatherCon = weatherQuery.First();


            //foreach (string var in weatherQuery)
            //{
            //    Weath_Display.Text = var;
            //}
            //GetWeather(weatherCon);

            //GetMuliplyer(mulitplyer);

        }

        // End of Weather Control Methods


        /* Method for getting the type of weather
         * after the query has completed
         * so we can add it to our calulations
         */

        public string GetWeather(string weatherCon)
        {
            string condition = weatherCon;

            return condition;

        }
        //End Method for getting weather

        /*Method for Getting the mulitplyer
         * called once the weather condition
         * has been selected and will return
         * a number for use in the breaking distance
         * calulation
         */

        private double GetMuliplyer(double mulitplyer)
        {



            return mulitplyer;

        }
        // End Method for getting Multiplyer

        /*Method for adding a type of Vehicle
         * to the calulation for the breaking distance
         * here we use a query to get the vehicle type
         * this is then returned via another method
         */

        private void Btn_Add_Lorry_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    var VechicleQuery = from c in db.VecicleTypes
            //                        where c.TypeOfVechicle == "Car"
            //                        select c.TypeOfVechicle;


            //    string TypeOfVechicle = VechicleQuery.First();

            //    foreach (string var in VechicleQuery)
            //    {
            //        Tbx_Dis_vech.Text = var;
            //    }

            //    GetVechicleType(TypeOfVechicle);

            //}
            //catch
            //{

            //}

            _soundPlayer = new SoundPlayer("D:/Collage Work/Second Year/Programming Year 2/Sem 2/OOP/BreakingAppCA2/BreakingAppCA2/Sounds/lorry.wav");

        }

        //private string GetVechicleType(string typeOfVechicle)
        //{

        //    //vehicle = new Vehicles(typeOfVechicle);

        //    //return vehicle.ToString();
        //}

        private void Btn_Add_Bike_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{

            //    var VechicleQuery = from c in db.VecicleTypes
            //                        where c.TypeOfVechicle == "Car"
            //                        select c.TypeOfVechicle;


            //    string TypeOfVechicle = VechicleQuery.First();

            //    foreach (string var in VechicleQuery)
            //    {
            //        Tbx_Dis_vech.Text = var;
            //    }
            //    GetVechicleType(TypeOfVechicle);

            //}
            //catch
            //{

            //}
            _soundPlayer = new SoundPlayer("D:/Collage Work/Second Year/Programming Year 2/Sem 2/OOP/BreakingAppCA2/BreakingAppCA2/Sounds/bike.wav");
        }

        private void Btn_Add_Van_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{

            //    var VechicleQuery = from c in db.VecicleTypes
            //                        where c.TypeOfVechicle == "Car"
            //                        select c.TypeOfVechicle;


            //    string TypeOfVechicle = VechicleQuery.First();

            //    foreach (string var in VechicleQuery)
            //    {
            //        Tbx_Dis_vech.Text = var;
            //    }
            //    GetVechicleType(TypeOfVechicle);


            //}
            //catch
            //{

            //}
            _soundPlayer = new SoundPlayer("D:/Collage Work/Second Year/Programming Year 2/Sem 2/OOP/BreakingAppCA2/BreakingAppCA2/Sounds/car.wav");
        }

        private void BtnCarAdd_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{

            //    var VechicleQuery = from c in db.VecicleTypes
            //                        where c.TypeOfVechicle == "Car"
            //                        select c.TypeOfVechicle;


            //    string TypeOfVechicle = VechicleQuery.First();

            //    foreach (string var in VechicleQuery)
            //    {
            //        Tbx_Dis_vech.Text = var;
            //    }
            //    GetVechicleType(TypeOfVechicle);

            //}
            //catch
            //{

            //}


            _soundPlayer = new SoundPlayer("D:/Collage Work/Second Year/Programming Year 2/Sem 2/OOP/BreakingAppCA2/BreakingAppCA2/Sounds/car.wav");


            // End of Method for Adding a Vehicle
        }


        // End of Methods
    }


}
