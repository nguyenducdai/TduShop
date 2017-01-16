using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItShop.Data.Infrastrusture;
using ItShop.Models.Models;

namespace ItShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetPaging(string tag , int pageIndex , int pageZize , out int totalRow);
    }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetPaging(string tag, int pageIndex, int pageZize, out int totalRow)
        {
            var query = from p in DBContext.Posts join t in DBContext.PostTags 
                        on p.ID equals t.PostID where t.TagID == tag select p;
            totalRow = query.Count();
            //1-1 = 0 * 20 = 0 , 2-1=1*20 take 20 ban nghi tieps theo
            query = query.Skip((pageIndex - 1 )* pageZize).Take(pageZize);
            return query;
        }
    }
}
