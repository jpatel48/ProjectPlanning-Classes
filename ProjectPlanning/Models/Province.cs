using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class Province
    {
        public int ID { get; set; }

        [Display(Name = "Province")]
        [Required(ErrorMessage = "You must specify the province name.")]
        [StringLength(255, ErrorMessage = "Province Name should not be more than 255 letters")]
        public int ProvinceName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}