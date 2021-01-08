using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces.Mapper;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mapper
{
    public class CustomerMapper : ICustomerMapper
    {
        public Customer MapDtoToEntity(CustomerDTO customerDTO)
        {
            return new Customer()
            {
                Id = customerDTO.Id,
                Name = customerDTO.Name,
                LastName = customerDTO.LastName,
                Email = customerDTO.Email
            };
        }

        public IEnumerable<CustomerDTO> MapEntityListToDtoList(IEnumerable<Customer> customers)
        {
            return customers.Select(c =>
                new CustomerDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    LastName = c.LastName,
                    Email = c.Email
                }
            );
        }

        public CustomerDTO MapEntityToDto(Customer customer)
        {
            return new CustomerDTO()
            {
                Id = customer.Id,
                Name = customer.Name,
                LastName = customer.LastName,
                Email = customer.Email
            };
        }
    }
}