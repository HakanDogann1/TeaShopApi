using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly IStatisticService _statisticService;

        public StatisticController(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }
        [HttpGet]
        public IActionResult GetDrinkAveragePrice()
        {
            return Ok(_statisticService.TDrinkAveragePrice());
        }
        [HttpGet]
        public IActionResult GetDrinkMaxPrice()
        {
            return Ok(_statisticService.TMaxPriceDrink());
        }
        [HttpGet]
        public IActionResult GetDrinkCount()
        {
            return Ok(_statisticService.TDrinkCount());
        }
        [HttpGet]
        public IActionResult GetLastDrinkName()
        {
            return Ok(_statisticService.TLastDrinkName());
        }

    }
}
