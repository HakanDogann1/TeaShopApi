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
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService TestimonialService)
        {
            _testimonialService = TestimonialService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var value = await _testimonialService.TGetAll();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = await _testimonialService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddTestimonial(CreateTestimonialDto testimonial)
        {
            await _testimonialService.TAdd(CreateMapper.mapper.Map<Testimonial>(testimonial));
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto testimonial)
        {
            _testimonialService.TUpdate(CreateMapper.mapper.Map<Testimonial>(testimonial));
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonial(int id)
        {
            await _testimonialService.TRemove(id);
            return Ok("İçerik silindi");
        }
    }
}
