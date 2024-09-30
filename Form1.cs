using System;
using System.Net.Http;

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
        //                                                      SPACES IN CITY NAME BECOME +'s!!!!!!!!!!!

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const string apiUrl = "https://geocoding-api.open-meteo.com/v1/search?name=";
            const string appendUrl = "&count=1&language=en&format=json";

            try
            {
                using (var client = new HttpClient())
                {
                    string city = txtCityName.Text;
                    validCity(ref city);

                    var endpoint = new Uri(apiUrl + city + appendUrl);
                    var result = client.GetAsync(endpoint).Result;
                    var json = result.Content.ReadAsStringAsync().Result;

                    string location = getLocation(json.ToString());



                    MessageBox.Show(json.ToString());
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
            {
                throw new Exception("Please enter a valid city name!");
            }
            else
            {
                city.Replace(" ", "+");
            }
        }

        private string getLocation(string request)
        {
            float latitude, longitude;
            string geolocation = "";

            return geolocation;
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
