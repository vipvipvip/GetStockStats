using Dapper;
using GetStockStats.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace GetStockStats
{
    class Program : BaseRepository
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

            Tickers clsTicker = new Tickers();
            List<Tickers> tickers = clsTicker.Get("SELECT db_strTicker, db_addition_dt from tbl_Ticker where db_strTicker like 'Z%'");
            for (int i = 0; i < tickers.Count(); i++)
            {
                Console.Write("\r\n" + tickers.ElementAt<Tickers>(i).db_strTicker);
            }

            Stats clsStats = new Stats();
            List<Stats> stats = clsStats.Get("SELECT * from tbl_Stats");
            for (int i = 0; i < stats.Count(); i++)
            {
                Console.Write("\r\n" + stats.ElementAt(i).db_ticker_id);
            }

            Console.ReadKey();
        }


        static void doCalc(long ni, long rev, long shares)
        {
            Console.WriteLine("NI: {0}", ni);
            Console.WriteLine("Revenue: {0}", rev);
            Console.WriteLine("Shares: {0}", shares);
        }

        static void InsertStats()
        {
            //SQL DB Access
            int n = 0;
            using (IDbConnection connection = OpenConnection("StockDB"))
            {
                StringBuilder query = new StringBuilder();
                // Dapper maps by column names. So create class with identical member names as the columns in select
                query.Append("SELECT db_strTicker, db_addition_dt from tbl_Ticker where db_strTicker like 'Z%'");

                //IEnumerable<Tickers> tickers =  connection.Query<Tickers>(query);
                var tickers = connection.QueryMultiple(query.ToString());
                var ZTickers = tickers.Read<Tickers>().ToList();

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("\r\n" + ZTickers.ElementAt<Tickers>(i).db_strTicker);
                }

                foreach (Tickers tick in ZTickers)
                {
                    n++;
                    Console.Write("\r\n" + tick.GetJson());
                }
            }

            Console.Write("\r\nTick Count: " + n);

        }
    }
}
