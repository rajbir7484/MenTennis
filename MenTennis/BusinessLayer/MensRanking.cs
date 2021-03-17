using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenTennis.BusinessLayer
{
    public class MensRanking
    {
        public int Id { get; set; }

        public string PlayerName { get; set; }

        public int Points { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
