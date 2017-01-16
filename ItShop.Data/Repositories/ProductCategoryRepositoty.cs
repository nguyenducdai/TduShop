using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItShop.Data.Infrastrusture;
using ItShop.Models.Models;

namespace ItShop.Data.Repositories
{
    public interface IProductCategoryRepositoty : IRepository<ProductCategory>
    {

    }
    public class ProductCategoryRepositoty : RepositoryBase<ProductCategory>, IProductCategoryRepositoty
    {
        public ProductCategoryRepositoty(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
