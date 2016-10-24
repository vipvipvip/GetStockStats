using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace GetStockStats
{
    class YStatsAPI
    {
        string _baseURL = "http://localhost:3000/stocks/yqs/";

        public YStatsAPI()
        {
        }

        public YStats GetData(string ticker)
        {
            try
            {
                string locationsRequest = CreateRequest(ticker);
                Task<YStats> tYQ = MakeRequest(locationsRequest);
                YStats yq = tYQ.Result;

                return yq;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                return null;
            }
        }

        public void DumpData(YStats yq)
        {
            // Optionally Access data as a raw object
            string yqDes = JsonConvert.SerializeObject(yq);
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

        private async Task<YStats> MakeRequest(string requestUrl)
        {
            YStats result;
            List<string> errors = new List<string>();
            using (var client = new System.Net.Http.HttpClient())
            {
                client.BaseAddress = new Uri(requestUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.GetAsync(requestUrl);
                var data = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<YStats>(data,
                            new JsonSerializerSettings
                            {
                                Error = delegate (object sender, ErrorEventArgs args)
                                {
                                    Console.WriteLine(args.ErrorContext.Error.Message);
                                    errors.Add(args.ErrorContext.Error.Message);
                                    args.ErrorContext.Handled = true;
                                },
                                Converters = { new IsoDateTimeConverter() }
                            });

            }
            return result;
        }
    }

}
