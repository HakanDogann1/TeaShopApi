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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal TestimonialDal)
        {
            _testimonialDal = TestimonialDal;
        }

        public async Task<Response<Testimonial>> TAdd(Testimonial entity)
        {
            await _testimonialDal.Add(entity);
            return Response<Testimonial>.Success(ResponseType.Success);
        }

        public async Task<Response<List<Testimonial>>> TGetAll()
        {
            var value = await _testimonialDal.GetAll();
            return Response<List<Testimonial>>.Success(value, ResponseType.Success);
        }

        public async Task<Response<Testimonial>> TGetById(int id)
        {
            var value = await _testimonialDal.GetById(id);
            return Response<Testimonial>.Success(value, ResponseType.Success);
        }

        public async Task<Response<NoContent>> TRemove(int id)
        {
            var value = await _testimonialDal.GetById(id);
            _testimonialDal.Remove(value);
            return Response<NoContent>.Success(ResponseType.Success);
        }

        public Response<NoContent> TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
            return Response<NoContent>.Success(ResponseType.Success);
        }
    }
}
