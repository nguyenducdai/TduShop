using System;

namespace ItShop.Web.Models
{
    public class OrderViewModel
    {
        public int ID { get; set; }

        public string CustommerName { get; set; }

        public string CustomerAdress { get; set; }

        public int CustomerPhone { get; set; }

        public string CustomerMessage { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }

        public string CreateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public bool Status { get; set; }

        //  public virtual IEnumerable<OrderDetail> OrderDetail { set; get; }
    }
}