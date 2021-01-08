using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        private readonly StoreContext _storeContext;

        public CustomerRepository(StoreContext storeContext)
            : base(storeContext)
        {
            _storeContext = storeContext;
        }
    }
}