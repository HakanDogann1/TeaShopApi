using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.DataAccessLayer.Extensions;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.DataAccessLayer.Context
{
    public class TeaShopContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-40E27NS\\SQLEXPRESS;initial catalog=TeaShopDb;integrated security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
       
    }
}
