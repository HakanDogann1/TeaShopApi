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
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService AboutService)
        {
            _aboutService = AboutService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var value = await _aboutService.TGetAll();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value = await _aboutService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddAbout(CreateAboutDto about)
        {
            await _aboutService.TAdd(CreateMapper.mapper.Map<About>(about));
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto about)
        {
            _aboutService.TUpdate(CreateMapper.mapper.Map<About>(about));
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _aboutService.TRemove(id);
            return Ok("İçerik silindi");
        }
    }
}
