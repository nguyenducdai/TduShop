using ItShop.Models.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ItShop.Models.Models
{
    [Table("Products")]
    public class Product : Audiable
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

        public int Warranty { get; set; }

        [Required]
        public string Content { get; set; }

        public string Image { get; set; }

        [Required]
        public string Descaption { get; set; }

        public XElement MoreImage { get; set; }

        [Required]
        public Decimal Price { get; set; }

        public Decimal? PromotionPrice { get; set; }

        public bool HomeFlag { get; set; }
        public bool HotFlag { get; set; }
        public int ViewCount { get; set; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}