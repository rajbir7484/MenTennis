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
    public class IndexModel : PageModel
    {
        private readonly MenTennis.Data.MenTennisDbContext _context;

        public IndexModel(MenTennis.Data.MenTennisDbContext context)
        {
            _context = context;
        }

        public IList<MensRanking> MensRanking { get;set; }

        public async Task OnGetAsync()
        {
            MensRanking = await _context.MensRankings
                .Include(m => m.Country).OrderByDescending(o => o.Points).ToListAsync();
        }
    }
}
