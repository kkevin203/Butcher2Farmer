using Database.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace butcherApp.Pages
{
    public class butcherList : PageModel
    {
        private readonly Database.ButcherDatabase _context;

        public butcherList(Database.ButcherDatabase context)
        {
            _context = context;
        }

        public IList<Butcher> Butcher { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Butchers == null)
            {
                Butcher = await _context.Butchers.ToListAsync();
                Butcher = Butcher.OrderBy(x => x.Name).ToList();
            }
        }
    }
}
