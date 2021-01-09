using Microsoft.AspNetCore.Mvc;
using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiModeloDDD.API.Controllers
{
    [Route("v1/product")]
    public class ProductController : Controller
    {
        private readonly IProductApplicationService _productApplicationService;

        public ProductController(IProductApplicationService productApplicationService)
        {
            _productApplicationService = productApplicationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> Get()
        {
            return Ok(_productApplicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDTO> Get(int id)
        {
            return Ok(_productApplicationService.Get(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDTO product)
        {
            try
            {
                if (product == null)
                    return NotFound();

                _productApplicationService.Add(product);
                return Ok("Product successfully registered!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProductDTO product)
        {
            try
            {
                if (product == null)
                    return NotFound();

                _productApplicationService.Update(product);
                return Ok("Product updated successfully!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ProductDTO product)
        {
            try
            {
                if (product == null)
                    return NotFound();

                _productApplicationService.Remove(product);
                return Ok("Product successfully removed!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
