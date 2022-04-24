using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class TeamLeague
    {
        public int Id { get; set; }
        public int SeasonId { get; set; }
        public Season Season { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int LeagueId { get; set; }
        public League League  { get; set; }
        public byte Points { get; set; }
      

    }
}
