using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi_CryptoFinanceDashboardProject.Models;

namespace RapidApi_CryptoFinanceDashboardProject.ViewComponents
{
    public class _DashboardTrendingCoingListComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardTrendingCoingListComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://coinranking1.p.rapidapi.com/coins/trending?referenceCurrencyUuid=yhjMzLPhuIDl&timePeriod=24h&limit=50&offset=0"),
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
                var apiResponse = JsonConvert.DeserializeObject<TrendingCoinsApiResponse>(body);
                var values = apiResponse?.data?.coins?.coins ?? new List<TrendingCoin>();
                return View(values);
            }
        }
    }
}
