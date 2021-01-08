using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public bool IsAvaible { get; set; }
    }
}