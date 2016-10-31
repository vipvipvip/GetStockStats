using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GetStockStats.Models
{
    [DataContract]
    class Stats : BaseRepository
    {

        [DataMember]
        public int db_ticker_id { get; set; }

        [DataMember]
        public DateTime db_updated { get; set; }

        [DataMember]
        public Decimal? db_revenue { get; set; }

        [DataMember]
        public Decimal? db_net_income { get; set; }

        [DataMember]
        public long? db_share_outstanding { get; set; }


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
            if (sData.db_net_income <= 0) return;
            if (sData.db_revenue <= 0) return;

            //SQL DB Access
            string query = "";
            using (IDbConnection connection = OpenConnection("StockDB"))
            { 
                    query ="INSERT INTO tbl_Stats(db_ticker_id, db_revenue, db_net_income, db_share_outstanding) " +
                          "VALUES (@db_ticker_id, @db_revenue, @db_net_income,  @db_share_outstanding)";

                connection.Execute(query, sData);
            //using (IDbCommand command = IDbCommand(
            //    "INSERT INTO tbl_Stats VALUES(@tickID, @NetIncome, @Revenue, @Shares)", connection))
            //{
            //    command.Parameters.Add(new SqlParameter("tickID", db_ticker_id));
            //    command.Parameters.Add(new SqlParameter("NetIncome", netIncomeToCommon));
            //    command.Parameters.Add(new SqlParameter("Revenue", totalRevenue));
            //    command.Parameters.Add(new SqlParameter("Shares", sharesOutstanding));
            //    command.ExecuteNonQuery();
            //};
            }

        }
    }
}
