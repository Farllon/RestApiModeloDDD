using RestApiModeloDDD.Application.DTOs;
using System.Collections.Generic;

namespace RestApiModeloDDD.Application.Interfaces
{
    public interface IProductApplicationService
    {
        IEnumerable<ProductDTO> GetAll();

        ProductDTO Get(int id);

        void Add(ProductDTO productDTO);

        void Update(ProductDTO productDTO);

        void Remove(ProductDTO productDTO);
    }
}