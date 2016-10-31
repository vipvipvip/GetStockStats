using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GetStockStats.Models
{
    [DataContract]
    class Stats : BaseRepository
    {

        [DataMember]
        public int db_ticker_id;

        [DataMember]
        public DateTime db_updated;

        [DataMember]
        public Decimal? db_revenue;

        [DataMember]
        public Decimal? db_net_income;

        [DataMember]
        public int? db_share_outstanding;

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
    }
}
