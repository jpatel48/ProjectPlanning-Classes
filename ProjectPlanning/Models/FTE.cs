using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class FTE
    {
        public int ID { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "You must specify the type.")]
        [StringLength(255, ErrorMessage = "Type should not be more than 255 letters")]
        public int FTEType { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}