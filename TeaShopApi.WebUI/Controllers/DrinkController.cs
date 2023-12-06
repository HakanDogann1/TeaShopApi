using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DrinkController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {

            var client = _httpClientFactory.CreateClient();
            return View();
        }
    }
}
