using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Weathher
{
    public partial class Form1 : Form
    { 
        //Global variable with server's address 
        readonly string BaseUrl = "http://weather-csharp.herokuapp.com/";

        string[] States = {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado",
            "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Hawaii",
            "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine",
            "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri",
            "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York",
            "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania",
            "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah",
            "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming" };


        public Form1()
        {
            InitializeComponent();
        }

        private bool GetWeatherText(string city, string state, out string weatherText, out string errorMessage)
        {
            //Use the format method to make a string in the format
            //http://weather-csharp.herokuapp.com/text?city=Edina&state=mn

            string weatherTextUrl = string.Format("{0}text?city={1}&state={2}", BaseUrl, city, state);
            Debug.WriteLine(weatherTextUrl);

            errorMessage = null;
            weatherText = null;
            try
            {
                using (WebClient client = new WebClient())
                {
                    weatherText = client.DownloadString(weatherTextUrl);
                }
                Debug.WriteLine(weatherText);
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
                errorMessage = e.Message;
                return false;
            }

        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            btnGetWeather.Enabled = false;

            //read data from textBoxes
            string city = txtCity.Text;
            string state = cbxState.Text;

            if (LocationDataValid(city, state))
            {

                    //Fetch current weather and display
                if (GetWeatherText(city, state, out string weather, out string textErrorMessage))
                {
                    lblWeather.Text = weather;
                }
                else
                {
                   MessageBox.Show(textErrorMessage, "Error");
                }
                if (picWeather.Image !=null)
                    {
                        picWeather.Image.Dispose();
                    }
                if (GetWeatherImage(city, state, out Image image, out string imageErrorMessage))
                    {
                        picWeather.Image = image;
                    }
            }
            else
            {
                MessageBox.Show("Enter both city and state", "Error");
            }
            // Enable button so user can get weather for somewhere else
            btnGetWeather.Enabled = true;
        }
        private bool LocationDataValid(string city, string state)
        {
            // Make checks on data, return false if any fail
          if(string.IsNullOrWhiteSpace(city))
          {
            return false;
          }
        if (string.IsNullOrWhiteSpace(state))
        {
            return false;
        }
           // All checks passed? Data looks good, return true
            return true;
        }
        private bool GetWeatherImage(string city, string state, out Image weatherImage, out string errorMessage)
        {
            weatherImage = null;
            errorMessage = null;

            try
            {
                using(WebClient client = new WebClient())
                {
                    //http://weather-csharp.herokuapp.com/text?city=Edina&state=mn
                    string weatherPhotoUrl = string.Format("{0}photo?city={1}&state={2}", BaseUrl, city, state);
                    string tempFileDirectory = Path.GetTempPath().ToString(); //Directory to save image
                    string weatherFilePath = Path.Combine(tempFileDirectory, "weather.jpg"); //filename to make completed path
                    Debug.WriteLine(weatherFilePath);
                    client.DownloadFile(weatherPhotoUrl, weatherFilePath); //Download from URL
                    weatherImage = Image.FromFile(weatherFilePath);      // setting the out parameters

                }
                return true;  //request was made, file was saved
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace); //this will help troubleshoot
                errorMessage = e.Message; // setting the out parameter
                return false; //to infrom the caller that there was an error
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxState.Items.AddRange(States);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
