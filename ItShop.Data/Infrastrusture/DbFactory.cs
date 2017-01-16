using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItShop.Data.Infrastrusture
{
    public class DbFactory : Dispostable, IDbFactory
    {
        private ItShopDBcontext dbContext;

        public ItShopDBcontext Init()
        {
            return dbContext ?? (dbContext = new ItShopDBcontext());
          
        }

        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
       
        }
    }
}
