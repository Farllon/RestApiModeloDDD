using RestApiModeloDDD.Application.DTOs;
using RestApiModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces.Mapper
{
    public interface IProductMapper
    {
        Product MapDtoToEntity(ProductDTO productDTO);

        ProductDTO MapEntityToDto(Product product);

        IEnumerable<ProductDTO> MapEntityListToDtoList(IEnumerable<Product> products);
    }
}