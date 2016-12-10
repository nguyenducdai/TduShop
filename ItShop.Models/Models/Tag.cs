using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItShop.Models.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }

        [MaxLength(50)]
        public string Name { set; get; }

        [MaxLength(50)]
        public string Type { set; get; }

        //public virtual IEnumerable<ProductTag> ProductTag { set; get; }
        //public virtual IEnumerable<PostTag> PostTag { set; get; }
    }
}