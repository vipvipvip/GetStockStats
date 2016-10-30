using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace GetStockStats.Models
{
    [DataContract]
    class Tickers
    {
        [DataMember]
        public int db_ticker_id;

        [DataMember]
        public string db_strTicker = "";

        [DataMember]
        public int db_type;

        [DataMember]
        public DateTime db_inactive_dt = DateTime.Today;

        [DataMember]
        public DateTime db_addition_dt = DateTime.Today;

        public string GetJson()
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Tickers));
            MemoryStream ms = new MemoryStream();
            js.WriteObject(ms, this);
            ms.Position = 0;
            StreamReader sr = new StreamReader(ms);
            return sr.ReadToEnd();
        }
    };

}
