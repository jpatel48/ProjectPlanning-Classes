using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class JobCode
    {
        public int ID { get; set; }

        [Display(Name = "Code")]
        [Required(ErrorMessage = "You must specify the code.")]
        [StringLength(255, ErrorMessage = "code should not be more than 255 letters")]
        public int Code { get; set; }

        public virtual ICollection<Occupation> Occupations { get; set; }
    }
}