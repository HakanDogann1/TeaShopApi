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
    public class DrinkManager : IDrinkService
    {
        private readonly IDrinkDal _drinkDal;

        public DrinkManager(IDrinkDal drinkDal)
        {
            _drinkDal = drinkDal;
        }

        public async Task<Response<Drink>> TAdd(Drink entity)
        {
            await _drinkDal.Add(entity);
            return Response<Drink>.Success(entity,ResponseType.Success);

        }

        public async Task<Response<List<Drink>>> TGetAll()
        {
            var value = await _drinkDal.GetAll();
            return Response<List<Drink>>.Success(value,ResponseType.Success);
        }

        public async Task<Response<Drink>> TGetById(int id)
        {
            var value = await _drinkDal.GetById(id);
            return Response<Drink>.Success(value,ResponseType.Success);
        }

        public async Task<Response<NoContent>> TRemove(int id)
        {
            var value = await _drinkDal.GetById(id);
            _drinkDal.Remove(value);
            return Response<NoContent>.Success(ResponseType.Success);
        }

        public Response<NoContent> TUpdate(Drink entity)
        {
            _drinkDal.Update(entity);
            return Response<NoContent>.Success(ResponseType.Success);

        }
    }
}
