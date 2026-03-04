using Microsoft.AspNetCore.Mvc;
using RapidApi_CryptoFinanceDashboardProject.Models;
using System.Text.Json;
using X.PagedList.Extensions;
namespace RapidApi_CryptoFinanceDashboardProject.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 10;
            int pageNumber = page;

            var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://coinranking1.p.rapidapi.com/coins?referenceCurrencyUuid=yhjMzLPhuIDl&timePeriod=24h&orderBy=marketCap&orderDirection=desc&limit=50&offset=0"),
                Headers =
    {
        { "x-rapidapi-key", "e71177d867mshfa37763bf5e2e10p1b4212jsn34b1dc08d068" },
        { "x-rapidapi-host", "coinranking1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var coinResponse = JsonSerializer.Deserialize<CoinListResponse>(body, options);
                var coins = coinResponse.Data.Coins;
                var pagedCoins = coins.ToPagedList(pageNumber, pageSize);
                return View(pagedCoins);
            }
        }
    }
}
