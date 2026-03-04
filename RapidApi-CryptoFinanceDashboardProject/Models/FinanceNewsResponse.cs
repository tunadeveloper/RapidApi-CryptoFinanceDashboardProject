using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;
namespace RapidApi_CryptoFinanceDashboardProject.Models
{
    public class FinanceNewsResponse
    {
        public string status { get; set; }
        public string request_id { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string article_id { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string snippet { get; set; }
        public string photo_url { get; set; }
        public string thumbnail_url { get; set; }
        public DateTime published_datetime_utc { get; set; }
        public string[] authors { get; set; }
        public string source_url { get; set; }
        public string source_name { get; set; }
        public string source_logo_url { get; set; }
        public string source_favicon_url { get; set; }
        public string source_publication_id { get; set; }
        public Related_Topics[] related_topics { get; set; }
    }

    public class Related_Topics
    {
        public string topic_id { get; set; }
        public string topic_name { get; set; }
    }

}
