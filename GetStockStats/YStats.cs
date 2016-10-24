using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GetStockStats
{

    [DataContract]
    public class EnterpriseValue
    {
        [DataMember(Name = "raw")]
        public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
        public string longFmt { get; set; }
    }

    [DataContract]
	public class ForwardPE
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class ProfitMargins
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class FloatShares
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
		public string longFmt { get; set; }
    }

    [DataContract]
	public class SharesOutstanding
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
		public string longFmt { get; set; }
    }

    [DataContract]
	public class SharesShort
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
		public string longFmt { get; set; }
    }

    [DataContract]
	public class SharesShortPriorMonth
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
		public string longFmt { get; set; }
    }

    [DataContract]
	public class HeldPercentInsiders
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class HeldPercentInstitutions
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class ShortRatio
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class ShortPercentOfFloat
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class Beta
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
    public class MorningStarOverallRating
    {
    }

    [DataContract]
    public class MorningStarRiskRating
    {
    }

    [DataContract]
	public class BookValue
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class PriceToBook
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }


     [DataContract]
	public class AnnualReportExpenseRatio
    {
    }

    [DataContract]
	public class YtdReturn
    {
    }

    [DataContract]
	public class Beta3Year
    {
    }

    [DataContract]
	public class TotalAssets
    {
    }

    [DataContract]
	public class Yield
    {
    }

    [DataContract]
	public class FundInceptionDate
    {
    }

    [DataContract]
	public class ThreeYearAverageReturn
    {
    }

    [DataContract]
	public class FiveYearAverageReturn
    {
    }

    [DataContract]
	public class PriceToSalesTrailing12Months
    {
    }

    [DataContract]
	public class LastFiscalYearEnd
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class NextFiscalYearEnd
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class MostRecentQuarter
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class EarningsQuarterlyGrowth
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class RevenueQuarterlyGrowth
    {
    }

    [DataContract]
	public class NetIncomeToCommon
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class TrailingEps
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class ForwardEps
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class PegRatio
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class LastSplitDate
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class EnterpriseToRevenue
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class EnterpriseToEbitda
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class __invalid_type__52WeekChange
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class SandP52WeekChange
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class LastDividendValue
    {
    }

    [DataContract]
	public class LastCapGain
    {
    }

    [DataContract]
	public class AnnualHoldingsTurnover
    {
    }

    [DataContract]
	public class DefaultKeyStatistics
    {
        [DataMember(Name = "maxAge")]
		public int maxAge { get; set; }
        [DataMember(Name = "enterpriseValue")]
		public EnterpriseValue enterpriseValue { get; set; }
        [DataMember(Name = "forwardPE")]
		public ForwardPE forwardPE { get; set; }
        [DataMember(Name = "profitMargins")]
		public ProfitMargins profitMargins { get; set; }
        [DataMember(Name = "floatShares")]
		public FloatShares floatShares { get; set; }
        [DataMember(Name = "sharesOutstanding")]
		public SharesOutstanding sharesOutstanding { get; set; }
        [DataMember(Name = "sharesShort")]
		public SharesShort sharesShort { get; set; }
        [DataMember(Name = "sharesShortPriorMonth")]
		public SharesShortPriorMonth sharesShortPriorMonth { get; set; }
        [DataMember(Name = "heldPercentInsiders")]
		public HeldPercentInsiders heldPercentInsiders { get; set; }
        [DataMember(Name = "heldPercentInstitutions")]
		public HeldPercentInstitutions heldPercentInstitutions { get; set; }
        [DataMember(Name = "shortRatio")]
		public ShortRatio shortRatio { get; set; }
        [DataMember(Name = "shortPercentOfFloat")]
		public ShortPercentOfFloat shortPercentOfFloat { get; set; }
        [DataMember(Name = "beta")]
		public Beta beta { get; set; }
        [DataMember(Name = "morningStarOverallRating")]
        public MorningStarOverallRating morningStarOverallRating { get; set; }
        [DataMember(Name = "morningStarRiskRating")]
        public MorningStarRiskRating morningStarRiskRating { get; set; }
        [DataMember(Name = "category")]
		public string category { get; set; }
        [DataMember(Name = "bookValue")]
		public BookValue bookValue { get; set; }
        [DataMember(Name = "priceToBook")]
		public PriceToBook priceToBook { get; set; }

        [DataMember(Name = "annualReportExpenseRatio")]
		public AnnualReportExpenseRatio annualReportExpenseRatio { get; set; }
        [DataMember(Name = "ytdReturn")]
		public YtdReturn ytdReturn { get; set; }
        [DataMember(Name = "beta3Year")]
		public Beta3Year beta3Year { get; set; }
        [DataMember(Name = "totalAssets")]
		public TotalAssets totalAssets { get; set; }
        [DataMember(Name = "yield")]
		public Yield yield { get; set; }
        [DataMember(Name = "fundFamily")]
		public string fundFamily { get; set; }
        [DataMember(Name = "fundInceptionDate")]
		public FundInceptionDate fundInceptionDate { get; set; }
        [DataMember(Name = "legalType")]
		public string legalType { get; set; }
        [DataMember(Name = "threeYearAverageReturn")]
		public ThreeYearAverageReturn threeYearAverageReturn { get; set; }
        [DataMember(Name = "fiveYearAverageReturn")]
		public FiveYearAverageReturn fiveYearAverageReturn { get; set; }
        [DataMember(Name = "priceToSalesTrailing12Months")]
		public PriceToSalesTrailing12Months priceToSalesTrailing12Months { get; set; }

        [DataMember(Name = "lastFiscalYearEnd")]
		public LastFiscalYearEnd lastFiscalYearEnd { get; set; }
        [DataMember(Name = "nextFiscalYearEnd")]
		public NextFiscalYearEnd nextFiscalYearEnd { get; set; }
        [DataMember(Name = "mostRecentQuarter")]
		public MostRecentQuarter mostRecentQuarter { get; set; }
        [DataMember(Name = "earningsQuarterlyGrowth")]
		public EarningsQuarterlyGrowth earningsQuarterlyGrowth { get; set; }
        [DataMember(Name = "revenueQuarterlyGrowth")]
		public RevenueQuarterlyGrowth revenueQuarterlyGrowth { get; set; }
        [DataMember(Name = "netIncomeToCommon")]
		public NetIncomeToCommon netIncomeToCommon { get; set; }
        [DataMember(Name = "trailingEps")]
		public TrailingEps trailingEps { get; set; }
        [DataMember(Name = "forwardEps")]
		public ForwardEps forwardEps { get; set; }
        [DataMember(Name = "pegRatio")]
		public PegRatio pegRatio { get; set; }
        [DataMember(Name = "lastSplitFactor")]
		public string lastSplitFactor { get; set; }
        [DataMember(Name = "lastSplitDate")]
		public LastSplitDate lastSplitDate { get; set; }
        [DataMember(Name = "enterpriseToRevenue")]
		public EnterpriseToRevenue enterpriseToRevenue { get; set; }
        [DataMember(Name = "enterpriseToEbitda")]
		public EnterpriseToEbitda enterpriseToEbitda { get; set; }
        [DataMember(Name = "__invalid_name__52WeekChange")]
		public __invalid_type__52WeekChange __invalid_name__52WeekChange { get; set; }
        [DataMember(Name = "SandP52WeekChange")]
		public SandP52WeekChange SandP52WeekChange { get; set; }
        [DataMember(Name = "lastDividendValue")]
		public LastDividendValue lastDividendValue { get; set; }
        [DataMember(Name = "lastCapGain")]
		public LastCapGain lastCapGain { get; set; }
        [DataMember(Name = "annualHoldingsTurnover")]
		public AnnualHoldingsTurnover annualHoldingsTurnover { get; set; }
    }

    [DataContract]
	public class EarningsDate
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class EarningsAverage
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class EarningsLow
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class EarningsHigh
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class RevenueAverage
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class RevenueLow
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class RevenueHigh
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class Earnings
    {
        [DataMember(Name = "earningsDate")]
		public List<EarningsDate> earningsDate { get; set; }
        [DataMember(Name = "earningsAverage")]
		public EarningsAverage earningsAverage { get; set; }
        [DataMember(Name = "earningsLow")]
		public EarningsLow earningsLow { get; set; }
        [DataMember(Name = "earningsHigh")]
		public EarningsHigh earningsHigh { get; set; }
        [DataMember(Name = "revenueAverage")]
		public RevenueAverage revenueAverage { get; set; }
        [DataMember(Name = "revenueLow")]
		public RevenueLow revenueLow { get; set; }
        [DataMember(Name = "revenueHigh")]
		public RevenueHigh revenueHigh { get; set; }
    }

    [DataContract]
	public class ExDividendDate
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class DividendDate
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class CalendarEvents
    {
        [DataMember(Name = "maxAge")]
		public int maxAge { get; set; }
        [DataMember(Name = "earnings")]
		public Earnings earnings { get; set; }
        [DataMember(Name = "exDividendDate")]
		public ExDividendDate exDividendDate { get; set; }
        [DataMember(Name = "dividendDate")]
		public DividendDate dividendDate { get; set; }
    }

    [DataContract]
	public class CurrentPrice
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class TargetHighPrice
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class TargetLowPrice
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class TargetMeanPrice
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class TargetMedianPrice
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class RecommendationMean
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class NumberOfAnalystOpinions
    {
        [DataMember(Name = "raw")]
		public int raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class TotalCash
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class TotalCashPerShare
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class Ebitda
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class TotalDebt
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class QuickRatio
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class CurrentRatio
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class TotalRevenue
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class DebtToEquity
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class RevenuePerShare
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class ReturnOnAssets
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class ReturnOnEquity
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class GrossProfits
    {
    }

    [DataContract]
	public class FreeCashflow
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class OperatingCashflow
    {
        [DataMember(Name = "raw")]
		public long raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
        [DataMember(Name = "longFmt")]
	public string longFmt { get; set; }
    }

    [DataContract]
	public class EarningsGrowth
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class RevenueGrowth
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class GrossMargins
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class EbitdaMargins
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class OperatingMargins
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class ProfitMargins2
    {
        [DataMember(Name = "raw")]
		public double raw { get; set; }
        [DataMember(Name = "fmt")]
        public string fmt { get; set; }
    }

    [DataContract]
	public class FinancialData
    {
        [DataMember(Name = "maxAge")]
		public int maxAge { get; set; }
        [DataMember(Name = "currentPrice")]
		public CurrentPrice currentPrice { get; set; }
        [DataMember(Name = "targetHighPrice")]
		public TargetHighPrice targetHighPrice { get; set; }
        [DataMember(Name = "targetLowPrice")]
		public TargetLowPrice targetLowPrice { get; set; }
        [DataMember(Name = "targetMeanPrice")]
		public TargetMeanPrice targetMeanPrice { get; set; }
        [DataMember(Name = "targetMedianPrice")]
		public TargetMedianPrice targetMedianPrice { get; set; }
        [DataMember(Name = "recommendationMean")]
		public RecommendationMean recommendationMean { get; set; }
        [DataMember(Name = "recommendationKey")]
		public string recommendationKey { get; set; }
        [DataMember(Name = "numberOfAnalystOpinions")]
		public NumberOfAnalystOpinions numberOfAnalystOpinions { get; set; }
        [DataMember(Name = "totalCash")]
		public TotalCash totalCash { get; set; }
        [DataMember(Name = "totalCashPerShare")]
		public TotalCashPerShare totalCashPerShare { get; set; }
        [DataMember(Name = "ebitda")]
		public Ebitda ebitda { get; set; }
        [DataMember(Name = "totalDebt")]
		public TotalDebt totalDebt { get; set; }
        [DataMember(Name = "quickRatio")]
		public QuickRatio quickRatio { get; set; }
        [DataMember(Name = "currentRatio")]
		public CurrentRatio currentRatio { get; set; }
        [DataMember(Name = "totalRevenue")]
		public TotalRevenue totalRevenue { get; set; }
        [DataMember(Name = "debtToEquity")]
		public DebtToEquity debtToEquity { get; set; }
        [DataMember(Name = "revenuePerShare")]
		public RevenuePerShare revenuePerShare { get; set; }
        [DataMember(Name = "returnOnAssets")]
		public ReturnOnAssets returnOnAssets { get; set; }
        [DataMember(Name = "returnOnEquity")]
		public ReturnOnEquity returnOnEquity { get; set; }
        [DataMember(Name = "grossProfits")]
		public GrossProfits grossProfits { get; set; }
        [DataMember(Name = "freeCashflow")]
		public FreeCashflow freeCashflow { get; set; }
        [DataMember(Name = "operatingCashflow")]
		public OperatingCashflow operatingCashflow { get; set; }
        [DataMember(Name = "earningsGrowth")]
		public EarningsGrowth earningsGrowth { get; set; }
        [DataMember(Name = "revenueGrowth")]
        public RevenueGrowth revenueGrowth { get; set; }
        [DataMember(Name = "grossMargins")]
        public GrossMargins grossMargins { get; set; }
        [DataMember(Name = "ebitdaMargins")]
		public EbitdaMargins ebitdaMargins { get; set; }
        [DataMember(Name = "operatingMargins")]
		public OperatingMargins operatingMargins { get; set; }
        [DataMember(Name = "profitMargins")]
		public ProfitMargins2 profitMargins { get; set; }
    }

    [DataContract]
	public class YStats
    {
        [DataMember(Name = "defaultKeyStatistics")]
		public DefaultKeyStatistics defaultKeyStatistics { get; set; }
        [DataMember(Name = "calendarEvents")]
		public CalendarEvents calendarEvents { get; set; }
        [DataMember(Name = "financialData")]
		public FinancialData financialData { get; set; }
    }

}