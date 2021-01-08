using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly StoreContext _storeContext;

        public BaseRepository(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        public void Add(TEntity entity)
        {
            try
            {
                _storeContext.Set<TEntity>().Add(entity);
                _storeContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TEntity Get(int id)
        {
            return _storeContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _storeContext.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            try
            {
                _storeContext.Set<TEntity>().Remove(entity);
                _storeContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _storeContext.Entry(entity).State = EntityState.Modified;
                _storeContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}