using System;

namespace ItShop.Web.Models
{
    public class PostViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int CategoryID { get; set; }

        public string Alias { get; set; }

        public string Content { get; set; }

        public string Descaption { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        public string MetaKeyword { set; get; }

        public string MetaDescaption { set; get; }

        public DateTime CreateAt { set; get; }

        public DateTime? UpdateAt { set; get; }

        public bool Status { set; get; }

        public virtual PostCategoryViewModel PostCategory { set; get; }
    }
}