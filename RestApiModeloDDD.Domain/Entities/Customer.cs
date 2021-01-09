using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Customer
    {
        [Required(ErrorMessage = "The id field is required!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name field is required!")]
        [MinLength(2, ErrorMessage = "The name field must be at least 2 characters!")]
        [MaxLength(15, ErrorMessage = "The name field must be a maximum of 15 characters!")]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The last name field is required!")]
        [MinLength(2, ErrorMessage = "The last name field must be at least 2 characters!")]
        [MaxLength(15, ErrorMessage = "The name last field must be a maximum of 15 characters!")]
        [Column(TypeName = "VARCHAR")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The email field is required!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Enter a valid email!")]
        [MaxLength(255, ErrorMessage = "The email field must be a maximum of 255 characters!")]
        [Column(TypeName = "VARCHAR")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The registration date field is required")]
        public DateTime RegistrationDate { get; set; }

        public bool IsActive { get; set; }
    }
}