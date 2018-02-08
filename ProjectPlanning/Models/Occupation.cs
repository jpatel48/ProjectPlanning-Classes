using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class Occupation
    {
        public Occupation()
        {
            this.Positions = new HashSet<Position>();
        }

        public int ID { get; set; }

        [Display(Name = "Occupation")]
        [Required(ErrorMessage = "Occupation name is required.")]
        [StringLength(255, ErrorMessage = "Occupation name cannot be more than 255 characters long.")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Occupation description is required.")]
        [StringLength(700, ErrorMessage = "Occupation description cannot be more than 700 characters long.")]
        public string Description { get; set; }

        public int CompensationID { get; set; }
        public int JobCodeID { get; set; }

        public virtual Compensation Compensation { get; set; }
        public virtual JobCode JobCode { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}