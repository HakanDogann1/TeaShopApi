using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.CommonLayer;
using TeaShopApi.CommonLayer.Enums;
using TeaShopApi.DataAccessLayer.Abstract;

namespace TeaShopApi.BusinessLayer.Concrete
{
    public class StatisticManager : IStatisticService
    {
        private readonly IStatisticDal _statisticDal;

        public StatisticManager(IStatisticDal statisticDal)
        {
            _statisticDal = statisticDal;
        }

        public Response<decimal> TDrinkAveragePrice()
        {
            var value = _statisticDal.DrinkAveragePrice();
            return Response<decimal>.Success(value,ResponseType.Success);
        }

        public Response<int> TDrinkCount()
        {
            var value = _statisticDal.DrinkCount();
            return Response<int>.Success(value, ResponseType.Success);
        }

        public async Task<Response<string>> TLastDrinkName()
        {
            var value =await _statisticDal.LastDrinkName();
            return Response<string>.Success(value, ResponseType.Success);
        }

        public async Task<Response<string>> TMaxPriceDrink()
        {
            var value =await _statisticDal.MaxPriceDrink();
            return Response<string>.Success(value, ResponseType.Success);
        }
    }
}
