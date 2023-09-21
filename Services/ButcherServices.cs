using Database;
using Database.Entities;
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

        public List<Butcher> GetAll()
        {
            return new List<Butcher>() { new Butcher() { Name = "Kevin", Email = "exemple@gmail.com" } };
            var butchers = _butcherDatabase.Butchers.ToList();
            return butchers;
        }
    }
}
