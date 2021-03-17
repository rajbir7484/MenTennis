using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MenTennis.BusinessLayer;
using MenTennis.Data;

namespace MenTennis.Pages.GrandWinners
{
    public class DeleteModel : PageModel
    {
        private readonly MenTennis.Data.MenTennisDbContext _context;

        public DeleteModel(MenTennis.Data.MenTennisDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public GrandWinner GrandWinner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GrandWinner = await _context.GrandWinners.FirstOrDefaultAsync(m => m.Id == id);

            if (GrandWinner == null)
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

            GrandWinner = await _context.GrandWinners.FindAsync(id);

            if (GrandWinner != null)
            {
                _context.GrandWinners.Remove(GrandWinner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
