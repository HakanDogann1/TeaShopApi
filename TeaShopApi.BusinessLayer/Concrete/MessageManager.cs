using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.CommonLayer;
using TeaShopApi.CommonLayer.Enums;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public async Task<Response<Message>> TAdd(Message entity)
        {
            await _messageDal.Add(entity);
            return Response<Message>.Success(ResponseType.Success);
        }

        public async Task<Response<List<Message>>> TGetAll()
        {
            var value = await _messageDal.GetAll();
            return Response<List<Message>>.Success(value,ResponseType.Success);
        }

        public async Task<Response<Message>> TGetById(int id)
        {
            var value = await _messageDal.GetById(id);
            return Response<Message>.Success(value,ResponseType.Success);
        }

        public async Task<Response<NoContent>> TRemove(int id)
        {
            var value = await _messageDal.GetById(id);
            _messageDal.Remove(value);
            return Response<NoContent>.Success(ResponseType.Success);
        }

        public Response<NoContent> TUpdate(Message entity)
        {
            _messageDal.Update(entity);
            return Response<NoContent>.Success(ResponseType.Success);
        }
    }
}
