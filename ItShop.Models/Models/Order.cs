using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItShop.Models.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string CustommerName { get; set; }

        [Required]
        public string CustomerAdress { get; set; }

        [Required]
        public int CustomerPhone { get; set; }

        public string CustomerMessage { get; set; }
        public string PaymentMethod { get; set; }
        public bool? PaymentStatus { get; set; }
        public bool? Status { get; set; }
    }
}