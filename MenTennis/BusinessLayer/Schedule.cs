using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenTennis.BusinessLayer
{
    public class Schedule
    {
        public int Id { get; set; }

        public string Tournament { get; set; }

        public string Dates { get; set; }

        public string Host { get; set; }

        public string DefendingChampion { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }
    }
}
