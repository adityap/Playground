using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using Newtonsoft.Json;
namespace JsonAsync
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Run();
        }

        public string _address = "http://api.worldbank.org/countries?format=json";

        public async void Run()
        {
            // Create an HttpClient instance
            HttpClient client = new HttpClient();

            // Send a request asynchronously continue when complete
            HttpResponseMessage response = await client.GetAsync(_address);

            // Check that response was successful or throw exception
            response.EnsureSuccessStatusCode();

            // Read response asynchronously as JsonValue and write out top facts for each country
            string content = await response.Content.ReadAsStringAsync();
            Response.Write(content);
            //Console.WriteLine("First 50 countries listed by The World Bank...");
            //foreach (var country in content[1])
            //{
            //    Console.WriteLine("   {0}, Country Code: {1}, Capital: {2}, Latitude: {3}, Longitude: {4}",
            //        country.Value["name"],
            //        country.Value["iso2Code"],
            //        country.Value["capitalCity"],
            //        country.Value["latitude"],
            //        country.Value["longitude"]);
            //}
        }
    }
}