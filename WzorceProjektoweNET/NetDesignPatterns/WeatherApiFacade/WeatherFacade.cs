using Newtonsoft.Json;
using System.Globalization;

namespace WeatherApiFacade
{
    public struct Coords 
    {
        public string lat { get; set; }
        public string lon { get; set; }
    }
    public class WeatherFacade
    {
        private static string APIkey => "5b2965ceb7056ac1cb87a3f4581e90b4";
        private string baseURL = "https://api.openweathermap.org";
        private static readonly HttpClient client = new HttpClient();
        private Coords coords;

        private async Task sendRequest(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        private async Task sendRequestForCords(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                coords = new Coords();
                dynamic jsonDe = JsonConvert.DeserializeObject(responseBody);
                coords.lon = jsonDe[0].lon;
                coords.lat = jsonDe[0].lat;

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        public async Task getWeatherByCordinats(double lat, double lon)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            string currentUrl = $"{baseURL}/data/2.5/weather?lat={lat.ToString(nfi)}&lon={lon.ToString(nfi)}&appid={APIkey}";
            await sendRequest(currentUrl);
        }
        public async Task getWeatherByCity(string city)
        {
            string cityUrl = $"{baseURL}/geo/1.0/direct?q={city}&limit=5&appid={APIkey}";
            await sendRequestForCords(cityUrl);
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            string weatherUrl = $"{baseURL}/data/2.5/weather?lat={coords.lat.ToString(nfi)}&lon={coords.lon.ToString(nfi)}&appid={APIkey}";
            await sendRequest(weatherUrl);
        }


    }
}
