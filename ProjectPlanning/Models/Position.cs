using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class Position
    {
        public Position()
        {
            this.Postings = new HashSet<Posting>();
        }

        public int ID { get; set; }

        [Required(ErrorMessage = "You must specify the occupation for the job position.")]
        public int OccupationID { get; set; }
        public int FTEID { get; set; }

        public virtual Occupation Occupation { get; set; }
        public virtual FTE FTE { get; set; }

        public virtual ICollection<Posting> Postings { get; set; }

    }
}