using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi_CryptoFinanceDashboardProject.Models;
using System.Threading.Tasks;

namespace RapidApi_CryptoFinanceDashboardProject.Controllers
{
    public class NasdaqController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public NasdaqController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(string symbol = "NVDA")
        {
            var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://nasdaq-stock-summary.p.rapidapi.com/api/quote/{symbol}/summary?assetclass=stocks"),
                Headers =
    {
        { "x-rapidapi-key", "e71177d867mshfa37763bf5e2e10p1b4212jsn34b1dc08d068" },
        { "x-rapidapi-host", "nasdaq-stock-summary.p.rapidapi.com" }
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<NasdaqDataResponse>(body);
                return View(values.data);
            }
        }
    }
}
