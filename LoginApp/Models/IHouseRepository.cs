using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp2.Models
{
    public interface IHouseRepository
    {
        IEnumerable<House> Houses { get; }
        IEnumerable<Realtor> Realtors { get; }
        void SaveHouse(House house);
        House DeleteHouse(int HouseID);
    }
}
