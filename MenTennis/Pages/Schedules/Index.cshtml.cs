using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MenTennis.BusinessLayer;
using MenTennis.Data;

namespace MenTennis.Pages.Schedules
{
    public class IndexModel : PageModel
    {
        private readonly MenTennis.Data.MenTennisDbContext _context;

        public IndexModel(MenTennis.Data.MenTennisDbContext context)
        {
            _context = context;
        }

        public IList<Schedule> Schedule { get;set; }

        public async Task OnGetAsync()
        {
            Schedule = await _context.Schedules
                .Include(s => s.Country).ToListAsync();
        }
    }
}
