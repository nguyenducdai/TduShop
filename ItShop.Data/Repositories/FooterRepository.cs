using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItShop.Data.Infrastrusture;
using ItShop.Models.Models;
namespace ItShop.Data.Repositories
{
    public interface IFooterRepository:IRepository<Footer>
    {

    }

    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        // base -> ke thua constructor
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }
    }
}
