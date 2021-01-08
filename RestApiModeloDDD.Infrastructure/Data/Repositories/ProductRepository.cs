using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly StoreContext _storeContext;

        public ProductRepository(StoreContext storeContext)
            : base(storeContext)
        {
            _storeContext = storeContext;
        }
    }
}