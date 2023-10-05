using Database.Entities;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FarmerService
    {
        ButcherDatabase _butcherDatabase;

        public FarmerService(ButcherDatabase butcherDatabase)
        {
            _butcherDatabase = butcherDatabase;
        }

        public List<Farmer> GetAll()
        {
            return new List<Farmer>() { new Farmer() { Name = "Pauline", Email = "exemple2@gmail.com" } };
            var farmer = _butcherDatabase.Farmers.ToList();
            return farmer;
        }
    }
}
