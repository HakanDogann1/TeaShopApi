using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.BusinessLayer.Mapping.AutoMapper
{
    public static class CreateMapper
    {
        public static Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(opt =>
            {
                opt.AddProfile<TeaShopMapping>();
            });

            return config.CreateMapper();
        });

        public static IMapper mapper => lazy.Value;
    }
}
