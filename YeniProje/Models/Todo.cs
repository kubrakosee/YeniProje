using System.ComponentModel.DataAnnotations;

namespace YeniProje.Models
{
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
}
