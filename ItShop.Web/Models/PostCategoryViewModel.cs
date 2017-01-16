using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItShop.Web.Models
{
    public class PostCategoryViewModel
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Descaption { get; set; }

        public string Image { get; set; }

        public string Alias { get; set; }

        public int? ParentId { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? HomeFlag { get; set; }

        public virtual IEnumerable<PostViewModel> Post { set; get; }
    }
}