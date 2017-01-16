using ItShop.Models.Models;
using System.Collections.Generic;
using System;
using ItShop.Data.Repositories;
using ItShop.Data.Infrastrusture;

namespace ItShop.Services
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        Post GetById(int id);

        IEnumerable<Post> GetPaging(int page,int pageSize , out int total);

        IEnumerable<Post> getAll();

        IEnumerable<Post> GetPagingByTag(string tag , int pageIndex, int pageSize, out int total);

        void Save();


    }

    public class PostService : IPostService
    {
        private PostRepository _postRepository;
        private IUnitOfWork _iunitOfWork;

        public PostService(PostRepository postRepository, IUnitOfWork iunitOfWork)
        {
            this._postRepository = postRepository;
            this._iunitOfWork = iunitOfWork;
        }

        public void Add(Post post)
        {
            this._postRepository.Add(post);
        }

        public void Delete(int id)
        {
            this._postRepository.Delete(id);
        }

        public IEnumerable<Post> getAll()
        {
            return this._postRepository.GetAll();
        }

        public Post GetById(int id)
        {
            return this._postRepository.GetById(id);
        }

        public IEnumerable<Post> GetPaging(int page, int pageSize, out int total)
        {
            return _postRepository.GetMutiPaging(x=>x.Status ,out total,page,pageSize);
        }

        public IEnumerable<Post> GetPagingByTag(string tag, int pageIndex, int pageSize, out int total)
        {
            return this._postRepository.GetPaging(tag , pageIndex,pageSize,out total);
        }

        public void Save()
        {
            this._iunitOfWork.Commit();
        }

        public void Update(Post post)
        {
            this._postRepository.Update(post);
        }
    }
}