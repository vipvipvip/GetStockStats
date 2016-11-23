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

      EQUITY_TYPE et;

      // default sql in case no args are provided
      string sql = "select * from tbl_Portfolios where db_portfolio_name = 'IVV' order by db_strTicker";
      foreach (var expression in args)
        foreach (Match m in Regex.Matches(expression, pattern))
        {
          string key = m.Groups[1].Value;
          string value = m.Groups[2].Value;
          Console.WriteLine("{0}  {1}", key, value);
          switch (key.ToUpper())
          {
            case "P":
              sql = string.Format("select P.*, T.db_type from tbl_Portfolios P, tbl_Ticker T where P.db_portfolio_name = '{0}' and P.db_ticker_id = T.db_ticker_id order by db_strTicker", value);
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
      YStats ys = null;

      List<Tickers> tickers;
      Tickers clsTicker = new Tickers();
      tickers = clsTicker.Get(sql);

      Stats clsStats = new Stats();
      List<Stats> stats = clsStats.Get("SELECT * from tbl_Stats");


      for (int i = 0; i < tickers.Count(); i++)
      {
        Console.WriteLine("Processing {0}", tickers.ElementAt(i).db_strTicker);
        ys = ysAPI.GetData(tickers.ElementAt(i).db_strTicker);
        yq = yqAPI.GetData(tickers.ElementAt(i).db_strTicker);
        Stats s = new Stats();
        s.db_updated = DateTime.Today;
        try
        {
          s.equity_type = (EQUITY_TYPE)Enum.ToObject(typeof(EQUITY_TYPE), tickers.ElementAt(i).db_type);
          s.db_ticker_id = tickers.ElementAt(i).db_ticker_id;
          s.db_current_price = Convert.ToDecimal(yq.quote.LastTradePriceOnly);
          s.db_MA50 = Convert.ToDecimal(yq.quote.FiftydayMovingAverage);
          s.db_MA200 = Convert.ToDecimal(yq.quote.TwoHundreddayMovingAverage);

          if (tickers.ElementAt(i).db_type == Convert.ToInt16(EQUITY_TYPE.STOCKS))
          {
            s.db_net_income = ys.quoteSummary.result[0].defaultKeyStatistics.netIncomeToCommon.raw;
            s.db_ebitda = ys.quoteSummary.result[0].financialData.ebitda.raw;
            s.db_revenue = ys.quoteSummary.result[0].financialData.totalRevenue.raw;
            s.db_share_outstanding = ys.quoteSummary.result[0].defaultKeyStatistics.sharesOutstanding.raw;
            s.db_PEGRatio = Convert.ToDecimal(yq.quote.PEGRatio);
            s.db_DividendYield = Convert.ToDecimal(yq.quote.DividendYield);
          }

        }
        catch (Exception e)
        {
          continue;
        }

        if (stats.Exists(x => x.db_ticker_id == tickers.ElementAt(i).db_ticker_id))
        {
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
  }
}
