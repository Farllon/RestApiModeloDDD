using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Customer : Base
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsActive { get; set; }
    }
}