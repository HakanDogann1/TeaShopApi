using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using TeaShopApi.WebUI.Dtos.DrinkDtos;

namespace TeaShopApi.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();


            var response1 = await client.GetAsync("https://localhost:7241/api/Statistic/GetDrinkAveragePrice");
            var jsonData1 = await response1.Content.ReadAsStringAsync();
            ViewBag.average = jsonData1;

            var response2 = await client.GetAsync("https://localhost:7241/api/Statistic/GetDrinkMaxPrice");
            var jsonData2 = await response2.Content.ReadAsStringAsync();
            ViewBag.max = jsonData2;

            var response3 = await client.GetAsync("https://localhost:7241/api/Statistic/GetDrinkCount");
            var jsonData3 = await response3.Content.ReadAsStringAsync();
            ViewBag.count = jsonData3;

            var response4 = await client.GetAsync("https://localhost:7241/api/Statistic/GetLastDrinkName");
            var jsonData4 = await response4.Content.ReadAsStringAsync();
            ViewBag.last = jsonData4;

            return View();
        }
    }
}
