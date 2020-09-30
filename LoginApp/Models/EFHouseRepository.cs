using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealEstateApp2.Models
{
    public class EFHouseRepository : IHouseRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<House> Houses
        {
            get { return context.Houses.Include("Realtor"); }
        }
        public IEnumerable<Realtor> Realtors
        {
            get { return context.Realtors; }
        }
        public void SaveHouse(House house)
        {
            if (house.HouseID == 0)
            {
                context.Houses.Add(house);
            }
            else
            {
                House dbEntry = context.Houses.Find(house.HouseID);
                if (dbEntry != null)
                {
                    dbEntry.Street = house.Street;
                    dbEntry.City = house.City;
                    dbEntry.State = house.State;
                    dbEntry.Zip = house.Zip;
                    dbEntry.RealtorID = house.RealtorID;
                    dbEntry.Price = house.Price;
                }
            }
            context.SaveChanges();
        }

        public House DeleteHouse(int houseID)
        {
            House dbEntry = context.Houses.Find(houseID);
            if (dbEntry != null)
            {
                context.Houses.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }


    }
}