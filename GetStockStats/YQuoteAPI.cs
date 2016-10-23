using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GetStockStats
{
    class YQuoteAPI
    {

        public YQuoteAPI()
        {
            try
            {
                string locationsRequest = CreateRequest("AAPL");
                YahooQuote yq = MakeRequest(locationsRequest);

                // Optionally Access data as a raw object
                string yqDes = JsonConvert.SerializeObject(yq.quote);
                var jObj = JToken.Parse(yqDes);
                foreach (JProperty property in jObj.Children())
                {
                    if (property.Value.ToString().Length > 0)
                    {
                        Console.WriteLine(property.Name);
                        Console.WriteLine(property.Value);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }

        //Create the request URL
        public string CreateRequest(string queryString)
        {
            string UrlRequest = "http://localhost:3000/stocks/yq/" + queryString;
            return (UrlRequest);
        }

        public YahooQuote MakeRequest(string requestUrl)
        {
            YahooQuote result;
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(requestUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(requestUrl).Result;
                var data = response.Content.ReadAsStringAsync().Result;
                result = JsonConvert.DeserializeObject<YahooQuote>(data);
            }
            return result;
        }
    }

}
