using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItShop.Data;

namespace ItShop.Data.Infrastrusture
{
    public interface IDbFactory:IDisposable
    {
        //giao tiep de khoi tao cac doi tuong entity 
        ItShopDBcontext Init();
    }
}
