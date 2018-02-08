using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class Compensation
    {
        public int ID { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "You must specify the type.")]
        [StringLength(255, ErrorMessage = "type should not be more than 255 letters")]
        public int CompensationType { get; set; }

        public virtual ICollection<Occupation> Occupations { get; set; }
    }
}