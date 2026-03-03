namespace RapidApi_CryptoFinanceDashboardProject.Models
{
    public class TrendingCoinsApiResponse
    {
        public string status { get; set; }
        public TrendingCoinsData data { get; set; }
    }

    public class TrendingCoinsData
    {
        public TrendingCoinsList coins { get; set; }
    }
    public class TrendingCoinsList
    {
        public List<TrendingCoin> coins { get; set; }
    }
}
