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
            string ticker = "AAPL";
            if ( args.Length > 0)
            {
                ticker = args[0];
            }
            //YQuoteAPI yqAPI = new YQuoteAPI();
            //YahooQuote yq = yqAPI.GetData("AAPL");
            //yqAPI.DumpData(yq);

            YStatsAPI ysAPI = new YStatsAPI();
            YStats ys = ysAPI.GetData(ticker);
            //ysAPI.DumpData(ys);
            doCalc(ys.quoteSummary.result[0].defaultKeyStatistics.netIncomeToCommon.raw,
                ys.quoteSummary.result[0].financialData.totalRevenue.raw,
                ys.quoteSummary.result[0].defaultKeyStatistics.sharesOutstanding.raw);
            Console.ReadKey();
        }


        static void doCalc(long ni, long rev, long shares)
        {
            Console.WriteLine("NI: {0}", ni);
            Console.WriteLine("Revenue: {0}", rev);
            Console.WriteLine("Shares: {0}", shares);



        }
    }
}
