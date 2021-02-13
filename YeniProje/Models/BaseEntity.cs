using System;

namespace YeniProje.Models
{
    public abstract class BaseEntity
    {
        // classlarda aynı şeyi kullanıcaksak abstract da yapmamız gerekir kod tekrarından kaçınılmalı
        //abstact yaptığımızın için şimdi baseEntity classlarımızda tanımlayalım
        //burdaki özellikleri her classda kullanabilirim.

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
