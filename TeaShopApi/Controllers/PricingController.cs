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
    public class PricingController : ControllerBase
    {
        private readonly IPricingService _pricingService;

        public PricingController(IPricingService PricingService)
        {
            _pricingService = PricingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var value = await _pricingService.TGetAll();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPricing(int id)
        {
            var value = await _pricingService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddPricing(CreatePricingDto pricing)
        {
            await _pricingService.TAdd(CreateMapper.mapper.Map<Pricing>(pricing));
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdatePricing(UpdatePricingDto pricing)
        {
            _pricingService.TUpdate(CreateMapper.mapper.Map<Pricing>(pricing));
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePricing(int id)
        {
            await _pricingService.TRemove(id);
            return Ok("İçerik silindi");
        }
    }
}
