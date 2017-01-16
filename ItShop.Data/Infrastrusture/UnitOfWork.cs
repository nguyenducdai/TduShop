using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ItShop.Data.Infrastrusture
{
    public class UnitOfWork : IUnitOfWork
    {
        private ItShopDBcontext dbContext;

        private readonly DbFactory dbFactory;

        public UnitOfWork(DbFactory dbFactory)
        {
            this.dbFactory = dbFactory;

        }

        public ItShopDBcontext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
