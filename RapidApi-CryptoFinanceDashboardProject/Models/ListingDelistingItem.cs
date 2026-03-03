namespace RapidApi_CryptoFinanceDashboardProject.Models
{
    public class ListingDelistingItem
    {
        public string title { get; set; }
        public string source { get; set; }
        public string symbol { get; set; }
        public string content { get; set; }
        public string category { get; set; }
        public DateTime date { get; set; }
        public DateTime published_date { get; set; }
    }
}
