using System;

namespace ItShop.Models.Abstract
{
    public abstract class Audiable : IAudiable
    {
        public string MetaKeyword { set; get; }
        public string MetaDescaption { set; get; }
        public DateTime CreateAt { set; get; }
        public DateTime? UpdateAt { set; get; }
        public bool Status { set; get; }
    }
}