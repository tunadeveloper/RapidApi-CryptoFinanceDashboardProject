using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi_CryptoFinanceDashboardProject.Models;
using System.Threading.Tasks;

namespace RapidApi_CryptoFinanceDashboardProject.Controllers
{
    public class IndicatorController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public IndicatorController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(string symbol = "BTCUSDT", long time = 15)
        {
            var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://crypto-technical-analysis-indicator-apis-for-trading.p.rapidapi.com/rsi?length=14&timeframe={time}m&symbol={symbol}"),
                Headers =
    {
        { "x-rapidapi-key", "e71177d867mshfa37763bf5e2e10p1b4212jsn34b1dc08d068" },
        { "x-rapidapi-host", "crypto-technical-analysis-indicator-apis-for-trading.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<CryptoRsi>(body);
                return View(values?.rsi);
            }
        }
    }
}
