﻿using G1KnowledgeTest.DataAccess.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace G1KnowledgeTest.DataAccess.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        internal DbSet<T> dbSet;

        public Repository (DbContext context)
        {
            Context= context;
            this.dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public T Get(int id)
        {
         return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includeProperties = null)
        {
            IQueryable<T> query=dbSet;
            if(filter!=null)
            {
                query = query.Where(filter);
            }
            //inculde properties are comma saperated
            if(includeProperties!=null)
            {
                foreach(var includeProperty in includeProperties.Split(new char[] { ','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query=query.Include(includeProperty);
                }
            }
            if(orderby!=null)
            {
                return orderby(query).ToList();

            }
            return query.ToList();
        }

        public T GetFirstorDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            //inculde properties are comma saperated
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(int id)
        {
          T entitytoRemove=dbSet.Find(id);
            Remove(entitytoRemove);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
    }
}
