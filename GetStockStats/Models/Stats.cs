﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GetStockStats.Models
{
  enum EQUITY_TYPE {
    STOCKS=1,
    ETF=2,
    MUTUAL_FUND=3
  }

  [DataContract]
  class Stats : BaseRepository
  {
    [DataMember]
    public EQUITY_TYPE equity_type { get; set; }

    [DataMember]
    public long db_ticker_id { get; set; }

    [DataMember]
    public DateTime db_updated { get; set; }

    [DataMember]
    public decimal? db_revenue { get; set; }

    [DataMember]
    public decimal? db_net_income { get; set; }

    [DataMember]
    public long? db_share_outstanding { get; set; }

    [DataMember]
    public decimal? db_current_price { get; set; }

    [DataMember]
    public decimal? db_ebitda { get; set; }

    [DataMember]
    public decimal? db_MA50 { get; set; }

    [DataMember]
    public decimal? db_MA200 { get; set; }

    [DataMember]
    public decimal? db_PEGRatio { get; set; }

    [DataMember]
    public decimal? db_DividendYield { get; set; }

    [DataMember]
    public decimal? db_EPS { get; set; }

    public List<Stats> Get(string sql)
    {
      //SQL DB Access
      using (IDbConnection connection = OpenConnection("StockDB"))
      {
        StringBuilder query = new StringBuilder();
        // Dapper maps by column names. So create class with identical member names as the columns in select
        query.Append(sql);

        //IEnumerable<Tickers> tickers =  connection.Query<Tickers>(query);
        var stats = connection.QueryMultiple(query.ToString());
        var Zstats = stats.Read<Stats>().ToList();
        return Zstats;
      }
    }

    public void Insert(Stats sData)
    {
      if (sData.equity_type == EQUITY_TYPE.STOCKS)
      {
        if (sData.db_net_income < 0) return;
        if (sData.db_revenue < 0) return;
        if (sData.db_share_outstanding < 0) return;
        if (sData.db_EPS < 0) return;
      }
      //SQL DB Access
      string query = "";
      using (IDbConnection connection = OpenConnection("StockDB"))
      {
        query = "INSERT INTO tbl_Stats(db_ticker_id, db_revenue, db_net_income, db_share_outstanding, db_current_price, db_ebitda, db_MA50, db_MA200, db_PEGRatio,db_DividendYield, db_EPS) " +
              "VALUES (@db_ticker_id, @db_revenue, @db_net_income,  @db_share_outstanding, @db_current_price, @db_ebitda, @db_MA50, @db_MA200, @db_PEGRatio,@db_DividendYield, @db_EPS)";

        connection.Execute(query, sData);
      }

    }
    public int Update(Stats sData)
    {
      if ( sData.equity_type == EQUITY_TYPE.STOCKS & (sData.db_net_income < 0 || sData.db_revenue < 0 || sData.db_share_outstanding < 0  || sData.db_EPS < 0))
      {
        // delete this ticker from Stats
        Delete(sData);
        return 0;
      }
      //SQL DB Access
      string query = "";
      using (IDbConnection connection = OpenConnection("StockDB"))
      {
        query = "Update tbl_Stats set db_revenue=@db_revenue, db_updated=@db_updated, db_net_income=@db_net_income, db_share_outstanding=@db_share_outstanding, db_current_price=@db_current_price, db_ebitda=@db_ebitda, db_MA50=@db_MA50, db_MA200=@db_MA200, db_PEGRatio=@db_PEGRatio, db_DividendYield=@db_DividendYield, db_EPS=@db_EPS where db_ticker_id = @db_ticker_id ";

        var count = connection.Execute(query, sData);
        return count;

      }
    }
    public int Delete(Stats sData)
    {
      //SQL DB Access
      string query = "";
      using (IDbConnection connection = OpenConnection("StockDB"))
      {
        query = "delete from tbl_Stats where db_ticker_id = @db_ticker_id ";

        var count = connection.Execute(query, sData);
        return count;

      }
    }
  }
}
