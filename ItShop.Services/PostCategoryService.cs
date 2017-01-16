using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItShop.Data.Repositories;
using ItShop.Data.Infrastrusture;
using ItShop.Models.Models;

namespace ItShop.Services
{

    public interface IPostCategoryService
    {

        PostCategory Add(PostCategory postCategory);

        void Delete(int id);

        void Update(PostCategory postCategory);

        IEnumerable<PostCategory> GetAllByParentId(int parentID);

        PostCategory GetById(int id);

        IEnumerable<PostCategory> GetAll();

        void Save();

    }
    public class PostCategoryService: IPostCategoryService
    {
        private PostCategoryRepository __postCategoryRepository;

        private IUnitOfWork __iUnitOfWork;

        public PostCategoryService(PostCategoryRepository postCategoryRepository , IUnitOfWork iUnitOfWork)
        {
            this.__postCategoryRepository = postCategoryRepository;
            this.__iUnitOfWork = iUnitOfWork;
        }

        public PostCategory Add(PostCategory postCategory)
        {
            return this.__postCategoryRepository.Add(postCategory);        }

        public void Delete(int id)
        {
            this.__postCategoryRepository.Delete(id);
        }

        public void Update(PostCategory postCategory)
        {
              this.__postCategoryRepository.Update(postCategory);
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentID)
        {
            return __postCategoryRepository.GetMuti(x=>x.ParentId == parentID);
        }

        public PostCategory GetById(int id)
        {
            return this.__postCategoryRepository.GetById(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return this.__postCategoryRepository.GetAll();
        }
        public void Save()
        {
            this.__iUnitOfWork.Commit();
        }
    }
}
