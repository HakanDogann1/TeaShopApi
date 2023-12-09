using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.CommonLayer.Enums;
using TeaShopApi.CommonLayer;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.BusinessLayer.Concrete
{
    public class QuestionManager : IQuestionService
    {
        private readonly IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal QuestionDal)
        {
            _questionDal = QuestionDal;
        }

        public async Task<Response<Question>> TAdd(Question entity)
        {
            await _questionDal.Add(entity);
            return Response<Question>.Success(ResponseType.Success);
        }

        public async Task<Response<List<Question>>> TGetAll()
        {
            var value = await _questionDal.GetAll();
            return Response<List<Question>>.Success(value, ResponseType.Success);
        }

        public async Task<Response<Question>> TGetById(int id)
        {
            var value = await _questionDal.GetById(id);
            return Response<Question>.Success(value, ResponseType.Success);
        }

        public async Task<Response<NoContent>> TRemove(int id)
        {
            var value = await _questionDal.GetById(id);
            _questionDal.Remove(value);
            return Response<NoContent>.Success(ResponseType.Success);
        }

        public Response<NoContent> TUpdate(Question entity)
        {
            _questionDal.Update(entity);
            return Response<NoContent>.Success(ResponseType.Success);
        }
    }
}
