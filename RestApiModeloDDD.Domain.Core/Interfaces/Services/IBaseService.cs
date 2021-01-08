using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(int id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}