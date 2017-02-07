using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WikiPages.Models
{
    [Table("Categories")]
    public class Category
    {   
        public Category()
        {
            this.Restaurants = new HashSet<Restaurant>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
