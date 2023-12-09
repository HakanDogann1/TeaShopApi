using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.CommonLayer;

namespace TeaShopApi.BusinessLayer.Abstract
{
    public interface IStatisticService
    {
        Response<int> TDrinkCount();
        Response<decimal> TDrinkAveragePrice();
        Task<Response<string>> TLastDrinkName();
        Task<Response<string>> TMaxPriceDrink();
    }
}
