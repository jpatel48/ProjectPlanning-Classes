﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class Application
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "You must specify the job posting applied for.")]
        [Index("IX_Unique_Application", Order = 1, IsUnique = true)]
        public int PostingID { get; set; }

        public virtual Posting Posting { get; set; }

        [Required(ErrorMessage = "You must specify the applicant applying to the job posting.")]
        [Index("IX_Unique_Application", Order = 2)]
        public int ApplicantID { get; set; }

        public virtual Applicant Applicant { get; set; }

        [Required(ErrorMessage = "You must specify the FileStore.")]
        [Index("IX_Unique_Application", Order = 3)]
        public int FileStoreID { get; set; }

        public virtual FileStore FileStore { get; set; }
    }
}