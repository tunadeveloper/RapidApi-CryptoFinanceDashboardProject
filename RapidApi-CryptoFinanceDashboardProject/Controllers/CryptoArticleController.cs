using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi_CryptoFinanceDashboardProject.Models;
using System.Threading.Tasks;

namespace RapidApi_CryptoFinanceDashboardProject.Controllers
{
    public class CryptoArticleController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CryptoArticleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://crypto-news51.p.rapidapi.com/api/v1/crypto/articles?page=1&limit=10&time_frame=24h&format=json"),
                Headers =
    {
       { "x-rapidapi-key", "cdb47aa04cmsh29c897da07c93f7p193945jsn7a061eae88f6" },
        { "x-rapidapi-host", "crypto-news51.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CryptoArticle>>(body);
                return View(values);
            }
        }
    }
}
