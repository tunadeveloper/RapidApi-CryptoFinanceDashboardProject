using Newtonsoft.Json;

namespace RapidApi_CryptoFinanceDashboardProject.Models
{
    public class ConvertResponse
    {
        public string code { get; set; }
        public string msg { get; set; }
        public Currency convert_result { get; set; }
    }
    public class Currency
    {

        [JsonProperty("base")]
        public string _base { get; set; }
        public string target { get; set; }
        public float rate { get; set; }
    }
}
