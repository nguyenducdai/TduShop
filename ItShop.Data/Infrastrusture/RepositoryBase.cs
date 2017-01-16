﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ItShop.Data.Infrastrusture
{
    public abstract class RepositoryBase<T>  :IRepository<T> where T : class
    {
        private ItShopDBcontext dbContext;
        private readonly DbSet<T> dbSet;

        protected IDbFactory DBFactory
        {
            private set;
            get;
        }

        protected ItShopDBcontext DBContext
        {
            get { return dbContext ?? (dbContext = DBFactory.Init()); }
        }


        public RepositoryBase(IDbFactory dbFactory)
        {
            DBFactory = dbFactory;
            dbSet = DBContext.Set<T>();

        }

        public virtual T Add(T entity)
        {
            return dbSet.Add(entity);
        }

        public virtual void Delete(T entity) {
            dbSet.Remove(entity);
        }

        public virtual void Update(T entity) {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void DeleteMuti(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (var obj in objects)
            {
                dbSet.Remove(obj);

            }
        }


        public virtual T GetById(int id)
        {
           return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T,bool>> where ,string includes )
        {
            return dbSet.Where(where).ToList();
        }

        public virtual int Count(Expression<Func<T,bool>> where)
        {
            return dbSet.Count(where);
        }

        public IEnumerable<T> GetAll(string[] include = null) {
           if(include != null && include.Count()> 0)
            {
                var query = dbContext.Set<T>().Include(include.First());
                foreach (var inc in include.Skip(1))
                
                  query =  query.Include(inc);

                return query.AsQueryable();
            }
            return dbContext.Set<T>().AsQueryable();
        }


        public IEnumerable<T> GetMuti(Expression<Func<T,bool>> where, string[] include = null)
        {
            if (include != null && include.Count() > 0)
            {
                var query = dbContext.Set<T>().Include(include.First());
                foreach (var inc in include.Skip(1))

                    query = query.Include(inc);

                return query.Where<T>(where).AsQueryable<T>();
            }
            return dbContext.Set<T>().Where<T>(where).AsQueryable<T>();
        }



        public bool CheckContain(Expression<Func<T, bool>> where)
        {
            return dbContext.Set<T>().Count<T>() > 0;
        }

    
        public T GetByConditon(Expression<Func<T, bool>> express, string[] includes = null)
        {
            if (includes != null && includes.Count() > 0)
            {
                var query = dbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.FirstOrDefault(express);
            }
            return dbContext.Set<T>().FirstOrDefault(express);
        }

        public IEnumerable<T> GetMutiPaging(Expression<Func<T, bool>> where,out int total, int index = 0, int size = 20, string[] include = null)
        {
            int skipCount = index * size;
            IQueryable<T> _resetSet;

            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (include != null && include.Count() > 0)
            {
                var query = dbContext.Set<T>().Include(include.First());
                foreach (var inc in include.Skip(1))
                    query = query.Include(inc);
                _resetSet = where != null ? query.Where<T>(where).AsQueryable() : query.AsQueryable();
            }
            else
            {
                _resetSet = where != null ? dbContext.Set<T>().Where<T>(where).AsQueryable() : dbContext.Set<T>().AsQueryable();
            }

            _resetSet = skipCount == 0 ? _resetSet.Take(size) : _resetSet.Skip(skipCount).Take(size);
            total = _resetSet.Count();
            return _resetSet.AsQueryable();
        }

        T IRepository<T>.Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Delete(int id)
        {
            var data=  dbSet.Find(id);
            return dbSet.Remove(data);
        }
    }
}
