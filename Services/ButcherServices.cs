using Database;
using Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ButcherService
    {
        ButcherDatabase _butcherDatabase;

        public ButcherService(ButcherDatabase butcherDatabase)
        {
            _butcherDatabase = butcherDatabase;
        }

        public async Task<List<Butcher>> GetAllAsync()
        {
            try
            {
                return await _butcherDatabase.Butchers.ToListAsync();

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public Butcher GetButcheryId(int butcherId)
        {
            var butcher = _butcherDatabase.Butchers.FirstOrDefault(f => f.Id == butcherId);
            return butcher;
        }
        public async Task<List<Butcher>> GetButcherAsync()
        {
            try
            {
                var butchers = await _butcherDatabase.Butchers.ToListAsync();
                return butchers;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task CreateButcherAsync(Butcher newButcher)
        {
            try
            {


                _butcherDatabase.Butchers.Add(newButcher);
                await _butcherDatabase.SaveChangesAsync();
            }
            catch (Exception ex)
            {
               
                throw;
            }
        }

    }
}
