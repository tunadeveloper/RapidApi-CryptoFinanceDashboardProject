namespace RapidApi_CryptoFinanceDashboardProject.Models
{
    public class NasdaqDataResponse
    {
        public NasdaqData data { get; set; }
        public string message { get; set; }
        public Status status { get; set; }
    }

    public class NasdaqData
    {
        public string symbol { get; set; }
        public SummaryData summaryData { get; set; }
        public string assetClass { get; set; }
    }

    public class SummaryData
    {
        public Field Exchange { get; set; }
        public Field Sector { get; set; }
        public Field Industry { get; set; }
        public Field OneYrTarget { get; set; }
        public Field PreviousClose { get; set; }
        public Field FiftTwoWeekHighLow { get; set; }
        public Field MarketCap { get; set; }
        public Field AnnualizedDividend { get; set; }
        public Field Yield { get; set; }
    }

    public class Field
    {
        public string label { get; set; }
        public string value { get; set; }
    }

    public class Status
    {
        public int rCode { get; set; }
        public object bCodeMessage { get; set; }
        public string developerMessage { get; set; }
    }
}