using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.BusinessLayer.Concrete;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Context;
using TeaShopApi.DataAccessLayer.EntityFramework;

namespace TeaShopApi.BusinessLayer.Extensions
{
    public static class ProgramExtensions
    {
        public static void Extansion(this IServiceCollection services)
        {
            services.AddDbContext<TeaShopContext>();
            services.AddScoped<IDrinkService, DrinkManager>();
            services.AddScoped<IDrinkDal, EfDrinkDal>();
            services.AddScoped<IQuestionService, QuestionManager>();
            services.AddScoped<IQuestionDal, EfQuestionDal>();

            services.AddScoped<IStatisticDal, EfStatisticDal>();
            services.AddScoped<IStatisticService, StatisticManager>();

        }
    }
}
