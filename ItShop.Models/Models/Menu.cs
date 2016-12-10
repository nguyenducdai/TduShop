using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItShop.Models.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public string Url { set; get; }

        public int DisplayOrder { set; get; }

        [Required]
        public int GroupID { set; get; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }

        [Required]
        public int Taget { set; get; }

        [Required]
        public int Status { set; get; }
    }
}