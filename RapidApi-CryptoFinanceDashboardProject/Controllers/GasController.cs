using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi_CryptoFinanceDashboardProject.Models;
using System.Threading.Tasks;
using X.PagedList.Extensions;

namespace RapidApi_CryptoFinanceDashboardProject.Controllers
{
    public class GasController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GasController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            int pageSize = 6;
            int pageNumber = page;
            var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://gas-price.p.rapidapi.com/europeanCountries"),
                Headers =
    {
        { "x-rapidapi-key", "e71177d867mshfa37763bf5e2e10p1b4212jsn34b1dc08d068" },
        { "x-rapidapi-host", "gas-price.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<GasPrice>(body);
                var result = values.result;
                var pagedList = result.ToPagedList(pageNumber, pageSize);
                return View(pagedList);
            }
        }
    }
}
