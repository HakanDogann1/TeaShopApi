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
        public async Task<IActionResult> GetAll()
        {
            var value =await _drinkService.TGetAll();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDrink(int id)
        {
            var value =await _drinkService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddDrink(CreateDrinkDto drink)
        {
            await _drinkService.TAdd(CreateMapper.mapper.Map<Drink>(drink));
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateDrink(UpdateDrinkDto drink)
        {
            _drinkService.TUpdate(CreateMapper.mapper.Map<Drink>(drink));
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDrink(int id)
        {
            await _drinkService.TRemove(id);
            return Ok("İçerik silindi");
        }
       
    }
}
