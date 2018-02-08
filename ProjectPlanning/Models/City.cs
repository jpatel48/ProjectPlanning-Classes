using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class City
    {
        public int ID { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "You must specify the city name.")]
        [StringLength(255, ErrorMessage = "city name should not be more than 255 letters")]
        public int CityName { get; set; }

        public int ProvinceID { get; set; }

        public virtual Province Province { get; set; }
    }
}