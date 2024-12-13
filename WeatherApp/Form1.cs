using Newtonsoft.Json.Linq;

namespace WeatherApp
{
    public partial class Form1 : Form
    {

        private const string apikey = "6ab2dceeed1e34d1dd4e44b59978b2ee\r\n";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCityName.Text;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("please enter a city name");
                return;
            }

            try
            {
                string weatherData = await GetWeatherData(city);

                JObject json = JObject.Parse(weatherData);
                double temp = (double)json["main"]["temp"] - 273.15;
                string condition = (string)json["weather"][0]["description"];

                lblTemprature.Text = $"{temp:F1}°C";
                lblCondition.Text = $" {condition}";

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private async Task<string> GetWeatherData(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apikey}";
                HttpResponseMessage responce = await client.GetAsync(url);
                responce.EnsureSuccessStatusCode();
                return await responce.Content.ReadAsStringAsync();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblCondition_Click(object sender, EventArgs e)
        {

        }
    }
}
