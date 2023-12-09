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
    public class PricingManager:IPricingService
    {
        private readonly IPricingDal _pricingDal;

        public PricingManager(IPricingDal PricingDal)
        {
            _pricingDal = PricingDal;
        }

        public async Task<Response<Pricing>> TAdd(Pricing entity)
        {
            await _pricingDal.Add(entity);
            return Response<Pricing>.Success(entity, ResponseType.Success);

        }

        public async Task<Response<List<Pricing>>> TGetAll()
        {
            var value = await _pricingDal.GetAll();
            return Response<List<Pricing>>.Success(value, ResponseType.Success);
        }

        public async Task<Response<Pricing>> TGetById(int id)
        {
            var value = await _pricingDal.GetById(id);
            return Response<Pricing>.Success(value, ResponseType.Success);
        }

        public async Task<Response<NoContent>> TRemove(int id)
        {
            var value = await _pricingDal.GetById(id);
            _pricingDal.Remove(value);
            return Response<NoContent>.Success(ResponseType.Success);
        }

        public Response<NoContent> TUpdate(Pricing entity)
        {
            _pricingDal.Update(entity);
            return Response<NoContent>.Success(ResponseType.Success);

        }
    }
}
