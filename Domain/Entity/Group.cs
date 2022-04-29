using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
   public class Group
    {
        public int Id { get; set; }
        public char Letter { get; set; }
        public int OuterLeagueId { get; set; }
        public OuterLeague OuterLeague { get; set; }
        public ICollection<GroupTeam> Teams { get; set; }

    }
}
