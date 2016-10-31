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
            string ticker = "";
            if ( args.Length > 0)
            {
                ticker = args[0];
            }
            YQuoteAPI yqAPI = new YQuoteAPI();
            YahooQuote yq;

            YStatsAPI ysAPI = new YStatsAPI();

            YStats ys;
            List<Tickers> tickers;
            Tickers clsTicker = new Tickers();
            if (ticker == "")
            {
                tickers = clsTicker.Get("SELECT db_ticker_id, db_strTicker, db_addition_dt from tbl_Ticker where db_ticker_id in (select db_ticker_id from tbl_Portfolios where db_portfolio_name = 'IVV')");
            } else
            {
                tickers = clsTicker.Get("SELECT db_ticker_id, db_strTicker, db_addition_dt from tbl_Ticker where db_strTicker = '" + ticker + "'");
            }
            Stats clsStats = new Stats();
            List<Stats> stats = clsStats.Get("SELECT * from tbl_Stats");


            for (int i = 0; i < tickers.Count(); i++)
            {
                ys = ysAPI.GetData(tickers.ElementAt(i).db_strTicker);
                if (stats.Exists(x => x.db_ticker_id == tickers.ElementAt(i).db_ticker_id)) {
                    // update
                    try
                    {
                        Stats s = new Stats();
                        s.db_ticker_id = tickers.ElementAt(i).db_ticker_id;
                        s.db_net_income = ys.quoteSummary.result[0].defaultKeyStatistics.netIncomeToCommon.raw;
                        s.db_ebitda = ys.quoteSummary.result[0].financialData.ebitda.raw;
                        s.db_revenue = ys.quoteSummary.result[0].financialData.totalRevenue.raw;
                        s.db_share_outstanding = ys.quoteSummary.result[0].defaultKeyStatistics.sharesOutstanding.raw;
                        s.db_current_price = ys.quoteSummary.result[0].financialData.currentPrice.raw;
                        clsStats.Update(s);
                    }
                    catch(Exception e)
                    {

                    }
                }
                else
                {
                    // insert
                    try
                    {
                        Stats s = new Stats();
                        s.db_ticker_id = tickers.ElementAt(i).db_ticker_id;
                        s.db_net_income = ys.quoteSummary.result[0].defaultKeyStatistics.netIncomeToCommon.raw;
                        s.db_ebitda = ys.quoteSummary.result[0].financialData.ebitda.raw;
                        s.db_revenue = ys.quoteSummary.result[0].financialData.totalRevenue.raw;
                        s.db_share_outstanding = ys.quoteSummary.result[0].defaultKeyStatistics.sharesOutstanding.raw;
                        s.db_current_price = ys.quoteSummary.result[0].financialData.currentPrice.raw;

                        clsStats.Insert(s);
                    }
                    catch (Exception e)
                    {

                    }
                }

//                Console.Write("\r\n" + tickers.ElementAt<Tickers>(i).db_strTicker);
            }

            Console.WriteLine("Apple Exists? {0}",  tickers.Exists(x => x.db_strTicker == "AAPL"));

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
    }
}
