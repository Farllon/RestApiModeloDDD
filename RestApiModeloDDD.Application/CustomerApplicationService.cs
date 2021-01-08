using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mapper;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class CustomerApplicationService : ICustomerApplicationService
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerMapper _customerMapper;

        public CustomerApplicationService(ICustomerService customerService, ICustomerMapper customerMapper)
        {
            _customerService = customerService;
            _customerMapper = customerMapper;
        }

        public void Add(CustomerDTO customerDTO)
        {
            var customer = _customerMapper.MapDtoToEntity(customerDTO);
            _customerService.Add(customer);
        }

        public void Remove(CustomerDTO customerDTO)
        {
            var customer = _customerMapper.MapDtoToEntity(customerDTO);
            _customerService.Remove(customer);
        }

        public CustomerDTO Get(int id)
        {
            var customer = _customerService.Get(id);
            return _customerMapper.MapEntityToDto(customer);
        }

        public IEnumerable<CustomerDTO> GetAll()
        {
            var customers = _customerService.GetAll();
            return _customerMapper.MapEntityListToDtoList(customers);
        }

        public void Update(CustomerDTO customerDTO)
        {
            var customer = _customerMapper.MapDtoToEntity(customerDTO);
            _customerService.Update(customer);
        }
    }
}