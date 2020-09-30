using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstateApp2.Models
{
    public class House
    {
        public int HouseID { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int SquareFeet { get; set; }
        public int NumBedrooms { get; set; }
        public int NumBaths { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public int RealtorID { get; set; }
        public virtual Realtor Realtor { get; set; }
    }
}