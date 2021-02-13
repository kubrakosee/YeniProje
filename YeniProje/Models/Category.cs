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
}
