using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace GetStockStats
{
    class YQuoteAPI
    {
        string _baseURL = "http://localhost:3000/stocks/yq/";

        public YQuoteAPI()
        {
        }

        public YahooQuote GetData(string ticker)
        { 
            try
            {
                string locationsRequest = CreateRequest(ticker);
                Task<YahooQuote> tYQ = MakeRequest(locationsRequest);
                YahooQuote yq = tYQ.Result;

                return yq;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                return null;
            }
        }

        public void DumpData(YahooQuote yq)
        {
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

        //Create the request URL
        public string CreateRequest(string queryString)
        {
            string UrlRequest = _baseURL + queryString;
            return (UrlRequest);
        }

        private async Task<YahooQuote> MakeRequest(string requestUrl)
        {
            YahooQuote result;
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(requestUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync(requestUrl);
                var data = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<YahooQuote>(data);

            }
            return result;
        }
    }

}
