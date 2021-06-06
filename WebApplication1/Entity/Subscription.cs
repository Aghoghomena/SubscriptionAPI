﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entity
{
    public class Subscription
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(500, ErrorMessage = "name email can only be 100 characters long")]
        public string email { get; set; }

        public DateTime dateAdded { get; set; }
    }
}
