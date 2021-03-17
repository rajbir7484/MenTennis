using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MenTennis.BusinessLayer;
using MenTennis.Data;

namespace MenTennis.Pages.MensRankings
{
    public class DeleteModel : PageModel
    {
        private readonly MenTennis.Data.MenTennisDbContext _context;

        public DeleteModel(MenTennis.Data.MenTennisDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public MensRanking MensRanking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MensRanking = await _context.MensRankings
                .Include(m => m.Country).FirstOrDefaultAsync(m => m.Id == id);

            if (MensRanking == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MensRanking = await _context.MensRankings.FindAsync(id);

            if (MensRanking != null)
            {
                _context.MensRankings.Remove(MensRanking);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
