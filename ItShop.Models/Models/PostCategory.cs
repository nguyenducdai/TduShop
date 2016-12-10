using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItShop.Models.Models
{
    [Table("PostCategories")]
    public class PostCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Descaption { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { get; set; }

        public int? ParentId { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<Post> Post { set; get; }
    }
}