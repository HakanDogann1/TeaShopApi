using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        Task Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
