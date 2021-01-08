using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces.Mapper
{
    public interface ICustomerMapper
    {
        Customer MapDtoToEntity(CustomerDTO customerDTO);

        CustomerDTO MapEntityToDto(Customer customer);

        IEnumerable<CustomerDTO> MapEntityListToDtoList(IEnumerable<Customer> customers);
    }
}