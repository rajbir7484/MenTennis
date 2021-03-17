using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MenTennis.BusinessLayer;
using MenTennis.Data;

namespace MenTennis.Pages.Schedules
{
    public class CreateModel : PageModel
    {
        private readonly MenTennis.Data.MenTennisDbContext _context;

        public CreateModel(MenTennis.Data.MenTennisDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "CountryName");
            return Page();
        }

        [BindProperty]
        public Schedule Schedule { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Schedules.Add(Schedule);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
