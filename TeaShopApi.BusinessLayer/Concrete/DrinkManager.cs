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
    public class DrinkManager : IDrinkService
    {
        private readonly IDrinkDal _drinkDal;

        public DrinkManager(IDrinkDal drinkDal)
        {
            _drinkDal = drinkDal;
        }

        public void TAdd(Drink entity)
        {
            _drinkDal.Add(entity);
        }

        public List<Drink> TGetAll()
        {
            return _drinkDal.GetAll();
        }

        public Drink TGetById(int id)
        {
            return _drinkDal.GetById(id);
        }

        public void TRemove(Drink entity)
        {
            _drinkDal.Remove(entity);
        }

        public void TUpdate(Drink entity)
        {
            _drinkDal.Update(entity);
        }
    }
}
