using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Domain.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}