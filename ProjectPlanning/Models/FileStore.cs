using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class FileStore
    {
        public int ID { get; set; }

        [Display(Name = "File Content")]
        [Required(ErrorMessage = "You cannot leave the first name blank.")]
        [StringLength(255)]
        public string FileContent { get; set; }

        [Display(Name = "File Meme Type")]
        [StringLength(255)]
        public string FileMemeType { get; set; }

        [Display(Name = "File Name")]
        [StringLength(255)]
        public Int64 FileName { get; set; }
        
        public ICollection<Application> Applications { get; set; }
    }
}