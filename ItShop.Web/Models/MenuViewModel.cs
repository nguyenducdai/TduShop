using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItShop.Web.Models
{
    public class MenuViewModel
    {

        public int ID { set; get; }


        public string Name { set; get; }

        public string Url { set; get; }

        public int DisplayOrder { set; get; }

        public int GroupID { set; get; }


        public virtual MenuGroupViewModel MenuGroup { set; get; }

        public int Taget { set; get; }

        public int Status { set; get; }
    }
}