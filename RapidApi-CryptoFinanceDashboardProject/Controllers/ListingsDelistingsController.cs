using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi_CryptoFinanceDashboardProject.Models;
using System.Threading.Tasks;

namespace RapidApi_CryptoFinanceDashboardProject.Controllers
{
    public class ListingsDelistingsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ListingsDelistingsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int? page)
        {
            var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://crypto-news51.p.rapidapi.com/api/v1/crypto/listing_delisting?sort_by=published"),
                Headers =
    {
        { "x-rapidapi-key", "e71177d867mshfa37763bf5e2e10p1b4212jsn34b1dc08d068" },
        { "x-rapidapi-host", "crypto-news51.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ListingDelistingItem>>(body);
                return View(values);
            }
        }
    }
}
