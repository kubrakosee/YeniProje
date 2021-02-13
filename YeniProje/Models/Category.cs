using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YeniProje.Models
{
    public class Category:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        //bir categoryde birden fazla todo olabilir diyoruz.
        public List<Todo> Todos { get; set; }
    }
    public class Todo: BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
      
        //kategorin otomatik olarak idsini tutmak istiyoruz
        public int CategoryId { get; set; }
        //burdaysa bir todo da sadece bir category var
        public Category category { get; set; }

    }

    // classlarda aynı şeyi kullanıcaksak abstract da yapmamız gerekir kod tekrarından kaçınılmalı
    //abstact yaptığımızın için şimdi baseEntity classlarımızda tanımlayalım
    //burdaki özellikleri her classda kullanabilirim.
    public abstract class BaseEntity
    {
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
