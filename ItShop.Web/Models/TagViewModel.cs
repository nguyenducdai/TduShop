using System.Collections.Generic;

namespace ItShop.Web.Models
{
    public class TagViewModel
    {
        public string ID { set; get; }

        public string Name { set; get; }

        public string Type { set; get; }

       // public virtual IEnumerable<ProductTag> ProductTag { set; get; }
        public virtual IEnumerable<PostTagViewModel> PostTag { set; get; }
    }
}