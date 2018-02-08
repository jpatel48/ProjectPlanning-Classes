using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectPlanning.Models
{
    public class Location
    {
        public Location()
        {
            this.Postings = new HashSet<Posting>();
        }

        public int ID { get; set; }

        public int CityID { get; set; }

        public virtual City City { get; set; }

        public virtual ICollection<Posting> Postings { get; set; }
    }
}