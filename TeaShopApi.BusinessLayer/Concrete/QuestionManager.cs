using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.BusinessLayer.Concrete
{
    public class QuestionManager : IQuestionService
    {
        private readonly IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public void TAdd(Question entity)
        {
            _questionDal.Add(entity);
        }

        public List<Question> TGetAll()
        {
            return _questionDal.GetAll();
        }

        public Question TGetById(int id)
        {
            return _questionDal.GetById(id);
        }

        public void TRemove(Question entity)
        {
            _questionDal.Remove(entity);
        }

        public void TUpdate(Question entity)
        {
            _questionDal.Update(entity);
        }
    }
}
