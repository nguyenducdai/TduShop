using ItShop.Models.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItShop.Models.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Alias { get; set; }
        public int? ParentId { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<Product> Product { set; get; }
         
    }
}