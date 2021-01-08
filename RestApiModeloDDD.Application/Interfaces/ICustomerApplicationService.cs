using RestApiModeloDDD.Application.DTOs;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface ICustomerApplicationService
    {
        IEnumerable<CustomerDTO> GetAll();

        CustomerDTO Get(int id);

        void Add(CustomerDTO customerDTO);

        void Update(CustomerDTO customerDTO);

        void Remove(CustomerDTO customerDTO);
    }
}