using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entity
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="name length can only be 50 characters long")]
        public string name { get; set; }
    }
}
