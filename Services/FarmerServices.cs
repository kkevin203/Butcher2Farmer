using Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class FarmerService
    {
        public FarmerService()
        {
        }

        public List<Farmer> GetAll()
        {
            return new List<Farmer>() { new Farmer() { Name = "Pauline", Email = "exemple2@gmail.com" } };
        }
    }
}
