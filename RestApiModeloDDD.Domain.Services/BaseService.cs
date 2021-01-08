using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}