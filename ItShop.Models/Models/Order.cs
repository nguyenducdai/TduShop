using System;
using System.Collections.Generic;
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
        [MaxLength(256)]
        public string CustommerName { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerAdress { get; set; }

        [Required]
        public int CustomerPhone { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { get; set; }

        [MaxLength(256)]
        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }

        public string CreateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public bool Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }
    }
}