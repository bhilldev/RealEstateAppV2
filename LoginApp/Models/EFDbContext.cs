using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RealEstateApp2.Models
{
    public class EFDbContext : DbContext
    {
        public DbSet<House> Houses { get; set; }
        public DbSet<Realtor> Realtors { get; set; }
    }
}