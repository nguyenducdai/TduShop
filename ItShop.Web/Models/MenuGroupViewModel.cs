using System.Collections.Generic;

namespace ItShop.Web.Models
{
    public class MenuGroupViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }

        public virtual IEnumerable<MenuViewModel> Menus { set; get; }
    }
}