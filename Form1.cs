using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace z_weather_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string GEOAPIURL = "https://geocoding-api.open-meteo.com/v1/search?name=";
            string WEATHERAPIURL = "https://api.open-meteo.com/v1/forecast?";

            string[] geoLocationRequest;
            string sLatitude, sLongitude;

            decimal latitude, longitude;


            sLatitude = sLongitude = "";
            latitude = longitude = 0m;
            try
            {
                using (var client = new HttpClient())
                {
                    string city = txtCityName.Text;
                    validCity(ref city);
                    GEOAPIURL += city + "&count=1&language=en&format=json";

                    var endpoint = new Uri(GEOAPIURL);
                    var result = client.GetAsync(endpoint).Result;
                    var json = result.Content.ReadAsStringAsync().Result;

                    geoLocationRequest = json.Split([',']);
                    foreach(string s in geoLocationRequest)
                    {
                        if (s.Contains("latitude"))
                            sLatitude = s;
                        if (s.Contains("longitude"))
                            sLongitude = s;
                    }

                    latitude = Math.Round(decimal.Parse(sLatitude.Substring(sLatitude.IndexOf(":") + 1)), 2);
                    longitude = Math.Round(decimal.Parse(sLongitude.Substring(sLongitude.IndexOf(":") + 1)), 2);

                    WEATHERAPIURL += "latitude=" + latitude + "&";
                    WEATHERAPIURL += "longitude=" + longitude + "&";
                    WEATHERAPIURL += "current=temperature_2m&hourly=temperature_2m&";
                }

                buildURL(ref WEATHERAPIURL);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Has Occurred!");
                btnClear_Click(sender, e);
                txtCityName.Focus();
            }
        }

        private void buildURL(ref string url)
        {
            if (txtDegreeUnit.Text.ToUpper() == "F")
                url += "temperature_unit=fahrenheit&";
            else if (txtDegreeUnit.Text.ToUpper() == "C")
                url += "temperature_unit=celsius&";
            else
                throw new Exception("Please enter a valid degree unit! (C or F)");

            url += "timezone=auto&forecast_days=1";
        }

        private void validCity(ref string city)
        {
            if (city.Any(char.IsDigit))
                throw new Exception("Please enter a valid city name!");
            else
                city.Replace(" ", "+");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCityName.Clear();
            txtDegreeUnit.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
