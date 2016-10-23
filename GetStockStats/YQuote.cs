using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Collections;

namespace GetStockStats
{
    [DataContract]
    public class YQuote
    {
        [DataMember(Name = "symbol")]
        public string symbol { get; set; }

        [DataMember(Name = "Ask")]
        public string Ask { get; set; }

        [DataMember(Name = "AverageDailyVolume")]
        public string AverageDailyVolume { get; set; }

        [DataMember(Name = "Bid")]
        public string Bid { get; set; }

        [DataMember(Name = "AskRealtime")]
        public object AskRealtime { get; set; }

        [DataMember(Name = "BidRealtime")]
        public object BidRealtime { get; set; }

        [DataMember(Name = "BookValue")]
        public string BookValue { get; set; }

        [DataMember(Name = "Change_PercentChange")]
        public string Change_PercentChange { get; set; }

        [DataMember(Name = "Change")]
        public string Change { get; set; }

        [DataMember(Name = "Commission")]
        public object Commission { get; set; }

        [DataMember(Name = "Currency")]
        public string Currency { get; set; }

        [DataMember(Name = "ChangeRealtime")]
        public object ChangeRealtime { get; set; }

        [DataMember(Name = "AfterHoursChangeRealtime")]
        public object AfterHoursChangeRealtime { get; set; }

        [DataMember(Name = "DividendShare")]
        public string DividendShare { get; set; }

        [DataMember(Name = "LastTradeDate")]
        public string LastTradeDate { get; set; }

        [DataMember(Name = "TradeDate")]
        public object TradeDate { get; set; }

        [DataMember(Name = "EarningsShare")]
        public string EarningsShare { get; set; }

        [DataMember(Name = "ErrorIndicationreturnedforsymbolchangedinvalid")]
        public object ErrorIndicationreturnedforsymbolchangedinvalid { get; set; }

        [DataMember(Name = "EPSEstimateCurrentYear")]
        public string EPSEstimateCurrentYear { get; set; }

        [DataMember(Name = "EPSEstimateNextYear")]
        public string EPSEstimateNextYear { get; set; }

        [DataMember(Name = "EPSEstimateNextQuarter")]
        public string EPSEstimateNextQuarter { get; set; }

        [DataMember(Name = "DaysLow")]
        public string DaysLow { get; set; }

        [DataMember(Name = "DaysHigh")]
        public string DaysHigh { get; set; }

        [DataMember(Name = "YearLow")]
        public string YearLow { get; set; }

        [DataMember(Name = "YearHigh")]
        public string YearHigh { get; set; }

        [DataMember(Name = "HoldingsGainPercent")]
        public object HoldingsGainPercent { get; set; }

        [DataMember(Name = "AnnualizedGain")]
        public object AnnualizedGain { get; set; }

        [DataMember(Name = "HoldingsGain")]
        public object HoldingsGain { get; set; }

        [DataMember(Name = "HoldingsGainPercentRealtime")]
        public object HoldingsGainPercentRealtime { get; set; }

        [DataMember(Name = "HoldingsGainRealtime")]
        public object HoldingsGainRealtime { get; set; }

        [DataMember(Name = "MoreInfo")]
        public object MoreInfo { get; set; }

        [DataMember(Name = "OrderBookRealtime")]
        public object OrderBookRealtime { get; set; }

        [DataMember(Name = "MarketCapitalization")]
        public string MarketCapitalization { get; set; }

        [DataMember(Name = "MarketCapRealtime")]
        public object MarketCapRealtime { get; set; }

        [DataMember(Name = "EBITDA")]
        public string EBITDA { get; set; }

        [DataMember(Name = "ChangeFromYearLow")]
        public string ChangeFromYearLow { get; set; }

        [DataMember(Name = "PercentChangeFromYearLow")]
        public string PercentChangeFromYearLow { get; set; }

        [DataMember(Name = "LastTradeRealtimeWithTime")]
        public object LastTradeRealtimeWithTime { get; set; }

        [DataMember(Name = "ChangePercentRealtime")]
        public object ChangePercentRealtime { get; set; }

        [DataMember(Name = "ChangeFromYearHigh")]
        public string ChangeFromYearHigh { get; set; }

        [DataMember(Name = "PercebtChangeFromYearHigh")]
        public string PercebtChangeFromYearHigh { get; set; }

        [DataMember(Name = "LastTradeWithTime")]
        public string LastTradeWithTime { get; set; }

        [DataMember(Name = "LastTradePriceOnly")]
        public string LastTradePriceOnly { get; set; }

        [DataMember(Name = "HighLimit")]
        public object HighLimit { get; set; }

        [DataMember(Name = "LowLimit")]
        public object LowLimit { get; set; }

        [DataMember(Name = "DaysRange")]
        public string DaysRange { get; set; }

        [DataMember(Name = "DaysRangeRealtime")]
        public object DaysRangeRealtime { get; set; }

        [DataMember(Name = "FiftydayMovingAverage")]
        public string FiftydayMovingAverage { get; set; }

        [DataMember(Name = "TwoHundreddayMovingAverage")]
        public string TwoHundreddayMovingAverage { get; set; }

        [DataMember(Name = "ChangeFromTwoHundreddayMovingAverage")]
        public string ChangeFromTwoHundreddayMovingAverage { get; set; }

        [DataMember(Name = "PercentChangeFromTwoHundreddayMovingAverage")]
        public string PercentChangeFromTwoHundreddayMovingAverage { get; set; }

        [DataMember(Name = "ChangeFromFiftydayMovingAverage")]
        public string ChangeFromFiftydayMovingAverage { get; set; }

        [DataMember(Name = "PercentChangeFromFiftydayMovingAverage")]
        public string PercentChangeFromFiftydayMovingAverage { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Notes")]
        public object Notes { get; set; }

        [DataMember(Name = "Open")]
        public string Open { get; set; }

        [DataMember(Name = "PreviousClose")]
        public string PreviousClose { get; set; }

        [DataMember(Name = "PricePaid")]
        public object PricePaid { get; set; }

        [DataMember(Name = "ChangeinPercent")]
        public string ChangeinPercent { get; set; }

        [DataMember(Name = "PriceSales")]
        public string PriceSales { get; set; }

        [DataMember(Name = "PriceBook")]
        public string PriceBook { get; set; }

        [DataMember(Name = "ExDividendDate")]
        public string ExDividendDate { get; set; }

        [DataMember(Name = "PERatio")]
        public string PERatio { get; set; }

        [DataMember(Name = "DividendPayDate")]
        public string DividendPayDate { get; set; }

        [DataMember(Name = "PERatioRealtime")]
        public object PERatioRealtime { get; set; }

        [DataMember(Name = "PEGRatio")]
        public string PEGRatio { get; set; }

        [DataMember(Name = "PriceEPSEstimateCurrentYear")]
        public string PriceEPSEstimateCurrentYear { get; set; }

        [DataMember(Name = "PriceEPSEstimateNextYear")]
        public string PriceEPSEstimateNextYear { get; set; }

        [DataMember(Name = "Symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "SharesOwned")]
        public object SharesOwned { get; set; }

        [DataMember(Name = "ShortRatio")]
        public string ShortRatio { get; set; }

        [DataMember(Name = "LastTradeTime")]
        public string LastTradeTime { get; set; }

        [DataMember(Name = "TickerTrend")]
        public object TickerTrend { get; set; }

        [DataMember(Name = "OneyrTargetPrice")]
        public string OneyrTargetPrice { get; set; }

        [DataMember(Name = "Volume")]
        public string Volume { get; set; }

        [DataMember(Name = "HoldingsValue")]
        public object HoldingsValue { get; set; }

        [DataMember(Name = "HoldingsValueRealtime")]
        public object HoldingsValueRealtime { get; set; }

        [DataMember(Name = "YearRange")]
        public string YearRange { get; set; }

        [DataMember(Name = "DaysValueChange")]
        public object DaysValueChange { get; set; }

        [DataMember(Name = "DaysValueChangeRealtime")]
        public object DaysValueChangeRealtime { get; set; }

        [DataMember(Name = "StockExchange")]
        public string StockExchange { get; set; }

        [DataMember(Name = "DividendYield")]
        public string DividendYield { get; set; }

        [DataMember(Name = "PercentChange")]
        public string PercentChange { get; set; }

    }

    [DataContract]
    public class YahooQuote
    {
        [DataMember(Name = "quote")]
        public YQuote quote { get; set; }

    }

}