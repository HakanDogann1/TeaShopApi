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
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessageController(IMessageService MessageService)
        {
            _messageService = MessageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var value = await _messageService.TGetAll();
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessage(int id)
        {
            var value = await _messageService.TGetById(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddMessage(CreateMessageDto message)
        {
            await _messageService.TAdd(CreateMapper.mapper.Map<Message>(message));
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto message)
        {
            _messageService.TUpdate(CreateMapper.mapper.Map<Message>(message));
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _messageService.TRemove(id);
            return Ok("İçerik silindi");
        }
    }
}
