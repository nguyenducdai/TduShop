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

        public int Quality { get; set; }

        [ForeignKey("OderId")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }
    }
}