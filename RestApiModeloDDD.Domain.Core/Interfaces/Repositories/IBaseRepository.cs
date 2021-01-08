using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(int id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}