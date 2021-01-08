using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Application.Interfaces.Mapper;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Application.Mapper
{
    public class ProductMapper : IProductMapper
    {
        public Product MapDtoToEntity(ProductDTO productDTO)
        {
            return new Product
            {
                Id = productDTO.Id,
                Name = productDTO.Name,
                Price = productDTO.Price
            };
        }

        public IEnumerable<ProductDTO> MapEntityListToDtoList(IEnumerable<Product> products)
        {
            return products.Select(p =>
                new ProductDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                }
            );
        }

        public ProductDTO MapEntityToDto(Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }
    }
}