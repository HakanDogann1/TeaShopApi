using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Context;

namespace TeaShopApi.DataAccessLayer.EntityFramework
{
    public class EfStatisticDal : IStatisticDal
    {
        private readonly TeaShopContext _context;

        public EfStatisticDal(TeaShopContext context)
        {
            _context = context;
        }

        public decimal DrinkAveragePrice()
        {
            return _context.Drinks.Average(x => x.DrinkPrice);
        }

        public int DrinkCount()
        {
            return _context.Drinks.Count();
        }

        public string LastDrinkName()
        {
            return _context.Drinks.OrderByDescending(x => x.DrinkId).Take(1).Select(x=>x.DrinkName).FirstOrDefault()!;
        }

        public string MaxPriceDrink()
        {
            decimal price = _context.Drinks.Max(x => x.DrinkPrice);
            string value = _context.Drinks.Where(x=>x.DrinkPrice==price).Select(y=>y.DrinkName).FirstOrDefault()!;
            return value;
        }
    }
}
