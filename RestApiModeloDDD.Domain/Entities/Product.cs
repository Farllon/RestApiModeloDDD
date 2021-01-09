using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Product
    {
        [Required(ErrorMessage = "The id field is required!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name field is required!")]
        [MinLength(2, ErrorMessage = "The name field must be at least 2 characters!")]
        [MaxLength(150, ErrorMessage = "The name field must be a maximum of 150 characters!")]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The price field is required!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The quantity field is required!")]
        [Range(0, 150, ErrorMessage = "The quantity field can contain 0 to 150 products")]
        public int Quantity { get; set; }

        public bool IsAvaible { get; set; }
    }
}