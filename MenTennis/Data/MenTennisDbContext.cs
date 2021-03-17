using MenTennis.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenTennis.Data
{
    public class MenTennisDbContext:DbContext
    {
        public MenTennisDbContext(DbContextOptions<MenTennisDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<MensRanking> MensRankings { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<GrandWinner> GrandWinners { get; set; }
    }
}
