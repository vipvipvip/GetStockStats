using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GetStockStats
{
    class Program
    {
        static void Main(string[] args)
        {
            YQuoteAPI yqAPI = new YQuoteAPI();
            YahooQuote yq = yqAPI.GetData("AAPL");
            yqAPI.DumpData(yq);
            Console.ReadKey();
        }
    }
}
