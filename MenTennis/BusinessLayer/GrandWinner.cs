using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MenTennis.BusinessLayer
{
    public class GrandWinner
    {
        public int Id { get; set; }

        public string Tournament { get; set; }

        public string WinnerName { get; set; }

        public string RunnerUp { get; set; }

        public int Year { get; set; }


    }
}
