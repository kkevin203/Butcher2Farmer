using Database.Entities;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class FarmerService
    {
        private ButcherDatabase _butcherDatabase;
        private List<Farmer> farmers = new List<Farmer>();

        public FarmerService(ButcherDatabase butcherDatabase)
        {
            _butcherDatabase = butcherDatabase;
        }

        public async Task<List<Farmer>> GetAllAsync()
        {
            return new List<Farmer>() { new Farmer() { Name = "Pauline", Email = "exemple1@gmail.com" },
           { new Farmer() { Name = "kevin", Email = "exemple2@gmail.com" }
            }};

            var farmers = await _butcherDatabase.Farmers.ToListAsync();
            return farmers;
        }
        public Farmer GetFarmerById(int farmerId)
        {
            var farmer = farmers.FirstOrDefault(f => f.Id == farmerId);
            return farmer;
        }
        public List<Farmer> GetFarmers()
        {
            return farmers;
        }

        public void AddFarmer(Farmer farmer)
        {
            farmer.Id = farmers.Count + 1;
            farmers.Add(farmer);
        }
        public async Task<List<Farmer>> GetFarmersAsync()
        {
            try
            {
                var farmers = await _butcherDatabase.Farmers.ToListAsync();
                return farmers;
            }
            catch (Exception ex)
            {
              
                throw;
            }
        }

    }
}
