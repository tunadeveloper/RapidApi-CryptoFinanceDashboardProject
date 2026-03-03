namespace RapidApi_CryptoFinanceDashboardProject.Models
{
    public class CryptoArticle
    {
        public string Title { get; set; }
        public string Summary { get; set; }
        public List<string> Media { get; set; }
        public string Link { get; set; }
        public List<Author> Authors { get; set; }
        public DateTime Published { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Language { get; set; }
        public string TimeZone { get; set; }
        public Sentiment Sentiment { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }

    public class Sentiment
    {
        public string Label { get; set; }
        public double Score { get; set; }
    }
}