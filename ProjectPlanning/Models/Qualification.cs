using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class Qualification
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "You cannot leave the name blank.")]
        [StringLength(255, ErrorMessage = "First name cannot be more than 255 characters long.")]
        public string Name { get; set; }
    }
}