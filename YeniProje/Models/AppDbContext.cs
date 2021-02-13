using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YeniProje.Models
{
    public class AppDbContext:DbContext
    {
        //dbcontext oluşturuyoruz.
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base()
        {

        }
        //buraya da oluşturduğumuz classları veri tabanında oluşması
        //istediğimiz sınıfları belirtiyoruz.
        //şimdi startup da bunu kullanacağımızı belli edeceğiz
        public DbSet<Category> Categories { get; set; }
        public DbSet<Todo>Todos { get; set; }
    }
}
