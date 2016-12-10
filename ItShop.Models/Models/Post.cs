using ItShop.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItShop.Models.Models
{
    [Table("Posts")]
    public class Post : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public string Alias { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Descaption { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }
    }
}