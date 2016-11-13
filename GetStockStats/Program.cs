using GetStockStats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GetStockStats
{
    class Program : BaseRepository
    {

  

        static void Main(string[] args)
        {
            // looking for args like P=IVV T=AAPL
            string pattern = @"^(\w+)[=](\w+)$";

            // default sql in case no args are provided
            string sql = "select* from tbl_Portfolios where db_portfolio_name = 'IVV' order by db_strTicker";
            foreach (var expression in args)
                foreach (Match m in Regex.Matches(expression, pattern))
                {
                    string key = m.Groups[1].Value;
                    string value = m.Groups[2].Value;
                    Console.WriteLine("{0}  {1}", key, value);
                    switch ( key.ToUpper())
                    {
                        case "P":
                            sql = string.Format("select * from tbl_Portfolios where db_portfolio_name = '{0}'  order by db_strTicker", value);
                            Console.WriteLine(sql);
                            break;
                        case "T":
                            sql = string.Format("select * from tbl_Ticker where db_strTicker = '{0}'", value);
                            Console.WriteLine(sql);
                            break;

                        default:
                            //Console.WriteLine("invalid arg");
                            break;
                    }
                }
            YQuoteAPI yqAPI = new YQuoteAPI();
            YahooQuote yq;

            YStatsAPI ysAPI = new YStatsAPI();

            YStats ys;
            List<Tickers> tickers;
            Tickers clsTicker = new Tickers();
            tickers = clsTicker.Get(sql);

            Stats clsStats = new Stats();
            List<Stats> stats = clsStats.Get("SELECT * from tbl_Stats");


            for (int i = 0; i < tickers.Count(); i++)
            {
                ys = ysAPI.GetData(tickers.ElementAt(i).db_strTicker);
                yq = yqAPI.GetData(tickers.ElementAt(i).db_strTicker);
                Stats s = new Stats();
                s.db_updated = DateTime.Today;
                try
                {
                    s.db_ticker_id = tickers.ElementAt(i).db_ticker_id;
                    s.db_net_income = ys.quoteSummary.result[0].defaultKeyStatistics.netIncomeToCommon.raw;
                    s.db_ebitda = ys.quoteSummary.result[0].financialData.ebitda.raw;
                    s.db_revenue = ys.quoteSummary.result[0].financialData.totalRevenue.raw;
                    s.db_share_outstanding = ys.quoteSummary.result[0].defaultKeyStatistics.sharesOutstanding.raw;
                    s.db_current_price = System.Convert.ToDecimal(ys.quoteSummary.result[0].financialData.currentPrice.raw);
                    s.db_MA50 = System.Convert.ToDecimal(yq.quote.FiftydayMovingAverage);
                    s.db_MA200 = System.Convert.ToDecimal(yq.quote.TwoHundreddayMovingAverage);
                    s.db_PEGRatio = System.Convert.ToDecimal(yq.quote.PEGRatio);

                }
                catch (Exception e)
                {
                    continue;
                }

                if (stats.Exists(x => x.db_ticker_id == tickers.ElementAt(i).db_ticker_id)) {
                    // update
                    try
                    {
                        clsStats.Update(s);
                    }
                    catch (Exception e) { }
                }
                else
                {
                    // insert
                    try
                    {
                        clsStats.Insert(s);
                    }
                    catch (Exception e) { }
                }
            }
            Console.WriteLine("Press any key to continue..");
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
