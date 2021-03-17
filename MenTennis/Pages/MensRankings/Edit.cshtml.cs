using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MenTennis.BusinessLayer;
using MenTennis.Data;

namespace MenTennis.Pages.MensRankings
{
    public class EditModel : PageModel
    {
        private readonly MenTennis.Data.MenTennisDbContext _context;

        public EditModel(MenTennis.Data.MenTennisDbContext context)
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
           ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "CountryName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(MensRanking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MensRankingExists(MensRanking.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MensRankingExists(int id)
        {
            return _context.MensRankings.Any(e => e.Id == id);
        }
    }
}
