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
    public class AboutManager:IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal AboutDal)
        {
            _aboutDal = AboutDal;
        }

        public async Task<Response<About>> TAdd(About entity)
        {
            await _aboutDal.Add(entity);
            return Response<About>.Success(entity, ResponseType.Success);

        }

        public async Task<Response<List<About>>> TGetAll()
        {
            var value = await _aboutDal.GetAll();
            return Response<List<About>>.Success(value, ResponseType.Success);
        }

        public async Task<Response<About>> TGetById(int id)
        {
            var value = await _aboutDal.GetById(id);
            return Response<About>.Success(value, ResponseType.Success);
        }

        public async Task<Response<NoContent>> TRemove(int id)
        {
            var value = await _aboutDal.GetById(id);
            _aboutDal.Remove(value);
            return Response<NoContent>.Success(ResponseType.Success);
        }

        public Response<NoContent> TUpdate(About entity)
        {
            _aboutDal.Update(entity);
            return Response<NoContent>.Success(ResponseType.Success);

        }
    }
}
