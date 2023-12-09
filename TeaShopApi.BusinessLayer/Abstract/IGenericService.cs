using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.CommonLayer;

namespace TeaShopApi.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        Task<Response<T>> TAdd(T entity);
        Response<NoContent> TUpdate(T entity);
        Task<Response<NoContent>> TRemove(int id);
        Task<Response<List<T>>> TGetAll();
        Task<Response<T>> TGetById(int id);
    }
}
