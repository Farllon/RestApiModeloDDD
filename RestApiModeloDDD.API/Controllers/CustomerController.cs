using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("v1/customer")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerApplicationService _customerApplicationService;

        public CustomerController(ICustomerApplicationService customerApplicationService)
        {
            _customerApplicationService = customerApplicationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerDTO>> Get()
        {
            return Ok(_customerApplicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<CustomerDTO> Get(int id)
        {
            return Ok(_customerApplicationService.Get(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] CustomerDTO customer)
        {
            try
            {
                if (customer == null)
                    return NotFound();

                _customerApplicationService.Add(customer);
                return Ok("Customer successfully registered!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] CustomerDTO customer)
        {
            try
            {
                if (customer == null)
                    return NotFound();

                _customerApplicationService.Update(customer);
                return Ok("Customer updated successfully!");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] CustomerDTO customer)
        {
            try
            {
                if (customer == null)
                    return NotFound();

                _customerApplicationService.Remove(customer);
                return Ok("Customer successfully removed!");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}