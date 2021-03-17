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
    public class DetailsModel : PageModel
    {
        private readonly MenTennis.Data.MenTennisDbContext _context;

        public DetailsModel(MenTennis.Data.MenTennisDbContext context)
        {
            _context = context;
        }

        public Schedule Schedule { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Schedule = await _context.Schedules
                .Include(s => s.Country).FirstOrDefaultAsync(m => m.Id == id);

            if (Schedule == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
