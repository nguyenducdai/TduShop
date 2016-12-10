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

        [MaxLength(256)]
        [Required]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string Descaption { get; set; }

        public int? ParentId { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<Product> Product { set; get; }
    }
}