using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Entity
{
    public class Setting
    {
        [Key]
        public int Id { get; private set; }


        [MaxLength(200, ErrorMessage = "name type can only be 100 characters long")]
        public string type { get; set; }

        [MaxLength(200, ErrorMessage = "name value can only be 100 characters long")]
        public string value { get; set; }

        public DateTime dateAdded { get; private set; }
    }
}
