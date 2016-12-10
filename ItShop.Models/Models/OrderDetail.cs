using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItShop.Models.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int ProductId { get; set; }

        [Key]
        public int OderId { get; set; }

        [Required]
        public int Quality { get; set; }
    }
}