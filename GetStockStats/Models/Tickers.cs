using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace GetStockStats.Models
{
    [DataContract]
    class Tickers : BaseRepository
    {
        [DataMember]
        public int db_ticker_id;

        [DataMember]
        public string db_strTicker = "";

        [DataMember]
        public int? db_type;

        [DataMember]
        public DateTime? db_inactive_dt;

        [DataMember]
        public DateTime? db_addition_dt;

        public string GetJson()
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Tickers));
            MemoryStream ms = new MemoryStream();
            js.WriteObject(ms, this);
            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            return sr.ReadToEnd();
        }

        public List<Tickers> Get(string sql)
        {
            //SQL DB Access
            using (IDbConnection connection = OpenConnection("StockDB"))
            {
                StringBuilder query = new StringBuilder();
                // Dapper maps by column names. So create class with identical member names as the columns in select
                query.Append(sql);

                //IEnumerable<Tickers> tickers =  connection.Query<Tickers>(query);
                var tickers = connection.QueryMultiple(query.ToString());
                var ZTickers = tickers.Read<Tickers>().ToList();
                return ZTickers;
            }
        }
    };

}
