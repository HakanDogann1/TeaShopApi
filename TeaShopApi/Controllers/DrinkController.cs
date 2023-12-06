using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.BusinessLayer.Mapping.AutoMapper;
using TeaShopApi.DtoLayer.DTOs;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private readonly IDrinkService _drinkService;

        public DrinkController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var value = _drinkService.TGetAll();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public IActionResult GetDrink(int id)
        {
            var value = _drinkService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public IActionResult AddDrink(CreateDrinkDto drink)
        {
            _drinkService.TAdd(CreateMapper.mapper.Map<Drink>(drink));
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateDrink(UpdateDrinkDto drink)
        {
            _drinkService.TUpdate(CreateMapper.mapper.Map<Drink>(drink));
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDrink(int id)
        {
            var value = _drinkService.TGetById(id);
            _drinkService.TRemove(value);
            return Ok("İçerik silindi");
        }
       
    }
}
