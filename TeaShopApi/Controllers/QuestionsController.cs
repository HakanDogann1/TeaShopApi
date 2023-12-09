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
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionService _questionService;

        public QuestionsController(IQuestionService questionService)
        {
            _questionService = questionService;
        }
        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values =await _questionService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateQuestion(CreateQuestionDto createQuestionDto)
        {
            await _questionService.TAdd(CreateMapper.mapper.Map<Question>(createQuestionDto));
            return Ok("Soru başarılı bir şekilde eklendi.");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuestion(int id)
        {
           await _questionService.TRemove(id);
            return Ok("Soru başarıyla silindi.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetQuestion(int id)
        {
            var value =await _questionService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateQuestion(UpdateQuestionDto updateQuestionDto)
        {
            _questionService.TUpdate(CreateMapper.mapper.Map<Question>(updateQuestionDto));
            return Ok("Güncelleme işlemi başarılı");
        }
    }
}
