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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string GEOAPIURL = "https://geocoding-api.open-meteo.com/v1/search?name=";
            string WEATHERAPIURL = "https://api.open-meteo.com/v1/forecast?";

            string[] geoLocationRequest;
            string[] weatherTimeRequest;
            string[] weatherTempRequest;

            decimal latitude, longitude;
            latitude = longitude = 0m;

            DateTime curTime = DateTime.Now;
            if (curTime.Minute >= 30)
            {
                curTime = curTime.AddHours(1);
            }
            curTime = curTime.AddMinutes(-curTime.Minute);
            string currentTime = curTime.ToString("yyyy-MM-ddTHH:mm");

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
                            latitude = Math.Round(decimal.Parse(s.Substring(s.IndexOf(":") + 1)), 2);

                        if (s.Contains("longitude"))
                            longitude = Math.Round(decimal.Parse(s.Substring(s.IndexOf(":") + 1)), 2);
                    }

                    WEATHERAPIURL += "latitude=" + latitude + "&";
                    WEATHERAPIURL += "longitude=" + longitude + "&";
                    WEATHERAPIURL += "current=temperature_2m&hourly=temperature_2m&";
                }

                buildURL(ref WEATHERAPIURL);

                using (var client = new HttpClient())
                {
                    var endpoint = new Uri(WEATHERAPIURL);
                    var result = client.GetAsync(endpoint).Result;
                    var json = result.Content.ReadAsStringAsync().Result;
                    json = json.Substring(json.LastIndexOf("time") + 7);

                    weatherTimeRequest = json.Substring(0, json.IndexOf("temperature_2m") - 3).Replace("\"","").Trim(['"', ')', ']', '}']).Split([',']);

                    weatherTempRequest = json.Substring(json.LastIndexOf("temperature_2m") + 17).Trim(['"', ')', ']', '}']).Split([',']);
                }

                for (int i = 0; i < weatherTimeRequest.Length; i++)
                {
                    if (currentTime == weatherTimeRequest[i])
                    {
                        MessageBox.Show("Current temperature: " + weatherTempRequest[i], "Temperature!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        break;
                    }
                }
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