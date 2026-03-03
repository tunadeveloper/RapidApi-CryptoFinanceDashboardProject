namespace RapidApi_CryptoFinanceDashboardProject.Models
{
    public class CoinListItem
    {
        public string Uuid { get; set; }
        public string IconUrl { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Price { get; set; }
        public string Change { get; set; }
        public string MarketCap { get; set; }
        public string[] Sparkline { get; set; }
    }

    public class CoinListResponse
    {
        public CoinListData Data { get; set; }
    }

    public class CoinListData
    {
        public CoinListItem[] Coins { get; set; }
    }
}
