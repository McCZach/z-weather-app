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

        // https://open-meteo.com/en/docs#temperature_unit=fahrenheit&wind_speed_unit=mph&precipitation_unit=inch&forecast_days=1
        // https://open-meteo.com/en/docs/geocoding-api#name=St.+Louis
        // https://www.newtonsoft.com/json/help/html/DeserializeObject.htm

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const string GEOAPIURL = "https://geocoding-api.open-meteo.com/v1/search?name=";
            const string GEOAPPENDURL = "&count=1&language=en&format=json";

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

                    var endpoint = new Uri(GEOAPIURL + city + GEOAPPENDURL);
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

                    latitude = decimal.Parse(sLatitude.Substring(sLatitude.IndexOf(":") + 1));
                    longitude = decimal.Parse(sLongitude.Substring(sLongitude.IndexOf(":") + 1));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Has Occurred!");
                btnClear_Click(sender, e);
                txtCityName.Focus();
            }
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
            txtWindUnit.Clear();
            txtPrecipitationUnit.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
