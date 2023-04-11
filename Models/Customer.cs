using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Functionality.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter valid input")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter valid input")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter valid input")]
        public string Department { get; set; }
        [Required(ErrorMessage = "Please enter valid input")]
        public int Age { get; set; }

    }
}