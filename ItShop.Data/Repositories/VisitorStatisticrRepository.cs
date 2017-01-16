using ItShop.Data.Infrastrusture;
using ItShop.Models.Models;

namespace ItShop.Data.Repositories
{
    public interface IVisitorStatisticrRepository : IRepository<VisitorStatistic>
    {
    }

    public class VisitorStatisticrRepository : RepositoryBase<VisitorStatistic>, IVisitorStatisticrRepository
    {
        public VisitorStatisticrRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}