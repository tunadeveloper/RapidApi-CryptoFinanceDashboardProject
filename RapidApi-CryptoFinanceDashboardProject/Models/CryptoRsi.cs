namespace RapidApi_CryptoFinanceDashboardProject.Models
{
    public class CryptoRsi
    {
        public long requestTime { get; set; }
        public Rsi[] rsi { get; set; }
    }

    public class Rsi
    {
        public long time { get; set; }
        public float close { get; set; }
        public float rsi { get; set; }
    }

}