using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;

namespace RestApiModeloDDD.Domain.Services
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
            : base(repository)
        {
            _repository = repository;
        }
    }
}