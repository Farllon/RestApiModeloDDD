using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces;
using RestApiModeloDDD.Application.Interfaces.Mapper;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductService _productService;
        private readonly IProductMapper _productMapper;

        public ProductApplicationService(IProductService productService, IProductMapper productMapper)
        {
            _productService = productService;
            _productMapper = productMapper;
        }

        public void Add(ProductDTO productDTO)
        {
            var product = _productMapper.MapDtoToEntity(productDTO);
            _productService.Add(product);
        }

        public ProductDTO Get(int id)
        {
            var product = _productService.Get(id);
            return _productMapper.MapEntityToDto(product);
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var products = _productService.GetAll();
            return _productMapper.MapEntityListToDtoList(products);
        }

        public void Remove(ProductDTO productDTO)
        {
            var product = _productMapper.MapDtoToEntity(productDTO);
            _productService.Remove(product);
        }

        public void Update(ProductDTO productDTO)
        {
            var product = _productMapper.MapDtoToEntity(productDTO);
            _productService.Update(product);
        }
    }
}