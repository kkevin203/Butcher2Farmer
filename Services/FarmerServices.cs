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
        public FarmerService(ButcherDatabase butcherDatabase)
        {
            _butcherDatabase = butcherDatabase;
        }

        public async Task<List<Farmer>> GetAllAsync()
        {
            try
            {
               return await _butcherDatabase.Farmers.ToListAsync();
               
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Farmer GetFarmerById(int farmerId)
        {
            var farmer = _butcherDatabase.Farmers.FirstOrDefault(f => f.Id == farmerId);
            return farmer;
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
        public async Task CreateFarmerAsync(Farmer newFarmer)
        {
            try
            {
                _butcherDatabase.Farmers.Add(newFarmer);
                await _butcherDatabase.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
