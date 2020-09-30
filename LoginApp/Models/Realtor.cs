using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstateApp2.Models
{
    public class Realtor
    {
        public int RealtorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public virtual ICollection<House> Houses { get; set; }
    }
}