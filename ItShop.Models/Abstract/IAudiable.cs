using System;
using System.ComponentModel.DataAnnotations;

namespace ItShop.Models.Abstract
{
    public interface IAudiable
    {
        [MaxLength(256)]
        string MetaKeyword { set; get; }

        [MaxLength(256)]
        string MetaDescaption { set; get; }

        [MaxLength(256)]
        DateTime CreateAt { set; get; }

        [MaxLength(256)]
        DateTime? UpdateAt { set; get; }

        bool Status { set; get; }

    }
}